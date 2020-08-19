using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDV4Sharp
{
    class FindTmpMarker
    {

        FolderBrowserDialog fbd;


        //static Dictionary<string, string> dPathFileAndNumberTmpMarker;

        static List<MarkerSrc> lMarkersInSrc;
        public FindTmpMarker(FolderBrowserDialog fbd)
        {
            this.fbd = fbd;
        }

        public void findTmpMarkerWithSrc()
        {
            List<string[]> lParentFilters = new List<string[]>();

            //dPathFileAndNumberTmpMarker = new Dictionary<string, string>();

            lMarkersInSrc = new List<MarkerSrc>();


            lParentFilters.Add(Directory.GetFiles(fbd.SelectedPath, "*.cs", SearchOption.AllDirectories));

            try
            {
                foreach (var filter in lParentFilters)
                {
                    foreach (var path in filter)
                    {
                        string[] allLinesInFile = File.ReadAllLines(path);

                        foreach (var line in allLinesInFile)
                        {
                            string paternFindTmpMarker = "tmp[0-9]{8}";

                            Regex regex = new Regex(paternFindTmpMarker);
                            Match match = regex.Match(line);

                            if(match.Success)
                            {
                                MarkerSrc markerSrc = new MarkerSrc();
                                markerSrc.Number = match.Value;
                                markerSrc.Path = path;
                                //dPathFileAndNumberTmpMarker.Add(match.Value, path);
                                lMarkersInSrc.Add(markerSrc);
                                break;
                            }
                            
                        }
                        
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Can't open file.\nOriginal error: " + e.Message);
            }

            
        }

        public void findTmpMarkerWithBin()
        {
            List<string[]> lParentFilters = new List<string[]>(); // список фильтров
            
            

            //Dictionary<string, List<string>> dPathBinFileAndListNumberTmpMarker = new Dictionary<string, List<string>>();
            
            List<MarkerBin> lBinWithMarkers = new List<MarkerBin>();

            lParentFilters.Add(Directory.GetFiles(fbd.SelectedPath, "*", SearchOption.AllDirectories));

            try
            {
                foreach (var filter in lParentFilters)
                {
                    foreach (var path in filter)
                    {
                        string[] allLinesInFile = File.ReadAllLines(path);
                        MarkerBin markerBin = new MarkerBin();
                        List<string> lNumbersMarkerBin = new List<string>();

                        foreach (var line in allLinesInFile)
                        {
                            string paternFindTmpMarker = "tmp[0-9]{8}";

                            Regex regex = new Regex(paternFindTmpMarker);
                            Match match = regex.Match(line);

                            while (match.Success)
                            {
                                // Проверка на дублирование маркеров в бинарниках

                                if(lNumbersMarkerBin.Count == 0) // если список пустой то добавляем
                                {
                                    lNumbersMarkerBin.Add(match.Value);                                  
                                }
                                else if(!lNumbersMarkerBin.Exists(x => x.Equals(match.Value))) //если такого маркера нет, то добавляем, если есть то ничего не делаем
                                {
                                    lNumbersMarkerBin.Add(match.Value);
                                }
                                // так как у нас может быть несколько маркеров в одной строке
                                match = match.NextMatch(); // ищем следующее совпадение в текущей строке                       
                            }
                            
                        }
                        //dPathBinFileAndListNumberTmpMarker.Add(path, lTmpMarkerBin);
                        markerBin.Path = path;
                        markerBin.ListNumberMarker = lNumbersMarkerBin;
                        lBinWithMarkers.Add(markerBin);
                    }
                }

                ComparisonTmpMarkers comparisonTmpMarkers = new ComparisonTmpMarkers();
                comparisonTmpMarkers.comparisonTmpMarkersFindSrcAndBin(lMarkersInSrc, lBinWithMarkers);
            }
            catch (Exception e)
            {
                MessageBox.Show("Can't open file.\nOriginal error: " + e.Message);
            }

            
        }
    }
}
