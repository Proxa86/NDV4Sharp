namespace NDV4Sharp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOpenFolderSrc = new System.Windows.Forms.Button();
            this.buttonOpenFolderBin = new System.Windows.Forms.Button();
            this.labelInformation = new System.Windows.Forms.Label();
            this.buttonExcel = new System.Windows.Forms.Button();
            this.listBoxReport = new System.Windows.Forms.ListBox();
            this.buttonOpenFolderForInsertMarker = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOpenFolderSrc
            // 
            this.buttonOpenFolderSrc.Location = new System.Drawing.Point(12, 40);
            this.buttonOpenFolderSrc.Name = "buttonOpenFolderSrc";
            this.buttonOpenFolderSrc.Size = new System.Drawing.Size(147, 23);
            this.buttonOpenFolderSrc.TabIndex = 0;
            this.buttonOpenFolderSrc.Text = "OpenFolderSrcWithMarkers";
            this.buttonOpenFolderSrc.UseVisualStyleBackColor = true;
            this.buttonOpenFolderSrc.Click += new System.EventHandler(this.buttonOpenFolderSrc_Click);
            // 
            // buttonOpenFolderBin
            // 
            this.buttonOpenFolderBin.Location = new System.Drawing.Point(165, 40);
            this.buttonOpenFolderBin.Name = "buttonOpenFolderBin";
            this.buttonOpenFolderBin.Size = new System.Drawing.Size(145, 23);
            this.buttonOpenFolderBin.TabIndex = 1;
            this.buttonOpenFolderBin.Text = "OpenFolderBinWithMarkers";
            this.buttonOpenFolderBin.UseVisualStyleBackColor = true;
            this.buttonOpenFolderBin.Click += new System.EventHandler(this.buttonOpenFolderBin_Click);
            // 
            // labelInformation
            // 
            this.labelInformation.AutoSize = true;
            this.labelInformation.Location = new System.Drawing.Point(13, 138);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(0, 13);
            this.labelInformation.TabIndex = 2;
            // 
            // buttonExcel
            // 
            this.buttonExcel.Location = new System.Drawing.Point(12, 70);
            this.buttonExcel.Name = "buttonExcel";
            this.buttonExcel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonExcel.Size = new System.Drawing.Size(298, 23);
            this.buttonExcel.TabIndex = 3;
            this.buttonExcel.Text = "OpenReportExcel";
            this.buttonExcel.UseVisualStyleBackColor = true;
            this.buttonExcel.Click += new System.EventHandler(this.buttonExcel_Click);
            // 
            // listBoxReport
            // 
            this.listBoxReport.FormattingEnabled = true;
            this.listBoxReport.Location = new System.Drawing.Point(12, 100);
            this.listBoxReport.Name = "listBoxReport";
            this.listBoxReport.Size = new System.Drawing.Size(298, 30);
            this.listBoxReport.TabIndex = 4;
            // 
            // buttonOpenFolderForInsertMarker
            // 
            this.buttonOpenFolderForInsertMarker.Location = new System.Drawing.Point(12, 13);
            this.buttonOpenFolderForInsertMarker.Name = "buttonOpenFolderForInsertMarker";
            this.buttonOpenFolderForInsertMarker.Size = new System.Drawing.Size(298, 23);
            this.buttonOpenFolderForInsertMarker.TabIndex = 5;
            this.buttonOpenFolderForInsertMarker.Text = "OpenFolderForInsertMarker";
            this.buttonOpenFolderForInsertMarker.UseVisualStyleBackColor = true;
            this.buttonOpenFolderForInsertMarker.Click += new System.EventHandler(this.buttonOpenFolderForInsertMarker_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 158);
            this.Controls.Add(this.buttonOpenFolderForInsertMarker);
            this.Controls.Add(this.listBoxReport);
            this.Controls.Add(this.buttonExcel);
            this.Controls.Add(this.labelInformation);
            this.Controls.Add(this.buttonOpenFolderBin);
            this.Controls.Add(this.buttonOpenFolderSrc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenFolderSrc;
        private System.Windows.Forms.Button buttonOpenFolderBin;
        private System.Windows.Forms.Label labelInformation;
        private System.Windows.Forms.Button buttonExcel;
        private System.Windows.Forms.ListBox listBoxReport;
        private System.Windows.Forms.Button buttonOpenFolderForInsertMarker;
    }
}

