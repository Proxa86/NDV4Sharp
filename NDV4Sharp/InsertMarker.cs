using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDV4Sharp
{
    class InsertMarker
    {
        FolderBrowserDialog fbd;

        public InsertMarker(FolderBrowserDialog fbd)
        {
            this.fbd = fbd;
        }

        public async void insertMarker()
        {
            List<string[]> lParentFilters = new List<string[]>();

            lParentFilters.Add(Directory.GetFiles(fbd.SelectedPath, "*.cs", SearchOption.AllDirectories));

            string baseDirectoryBin = AppDomain.CurrentDomain.BaseDirectory;
            string writePathAndMarkerInLog = String.Concat(baseDirectoryBin,"logInsertMarker.txt");

            try
            {
                if (File.Exists("logInsertMarker.txt"))
                {
                    DialogResult resultButton = MessageBox.Show("File logInsertMarker.txt exists!\nDelete this file?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    if (resultButton == DialogResult.Yes)
                        File.Delete("logInsertMarker.txt");
                }

                int i = 1;
                foreach (var filter in lParentFilters)
                {
                    foreach (var path in filter)
                    {
                        using (StreamWriter sw = new StreamWriter(new FileStream(path, FileMode.Append)))
                        {
                            await sw.WriteLineAsync(String.Format(
                                @"
#if !NUM_MARKER{0}
class tmp{1}{{}}
#endif", i.ToString("00000000"), i.ToString("00000000")));

                        }
                        //sw.Close();

                        // Запись в Log.txt находящегося возле бинарника

                        if (!System.IO.File.Exists("logInsertMarker.txt"))
                        {
                            using (StreamWriter sw = new StreamWriter(writePathAndMarkerInLog, false, System.Text.Encoding.Default))
                            {
                                await sw.WriteLineAsync(String.Format("tmp{0}", i.ToString("00000000") + "\t" + path));
                            }
                        }
                        else
                        {
                            using (StreamWriter sw = new StreamWriter(writePathAndMarkerInLog, true, System.Text.Encoding.Default))
                            {
                                await sw.WriteLineAsync(String.Format("tmp{0}", i.ToString("00000000") + "\t" + path));
                            }
                        }

                        ++i;
                    }
                }
                MessageBox.Show("Insert " + --i + " markers.");

            }
            catch (Exception e)
            {
                MessageBox.Show("Can't open file.\nOriginal error: " + e.Message);
            }
        }
    }
}
