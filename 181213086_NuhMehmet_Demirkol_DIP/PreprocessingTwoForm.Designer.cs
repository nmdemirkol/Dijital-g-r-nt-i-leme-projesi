namespace _181213086_NuhMehmet_Demirkol_DIP
{
    partial class PreprocessingTwoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.preprocessingCmb = new System.Windows.Forms.ComboBox();
            this.notPreprocessingRbtn = new System.Windows.Forms.RadioButton();
            this.preprocessingRbtn = new System.Windows.Forms.RadioButton();
            this.histogramSyncGroupBox = new System.Windows.Forms.GroupBox();
            this.histogramChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.nextBtn = new System.Windows.Forms.Button();
            this.equalizationGroupBox = new System.Windows.Forms.GroupBox();
            this.equalizationCharta = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.imagePic = new System.Windows.Forms.PictureBox();
            this.quantizationGroupBox = new System.Windows.Forms.GroupBox();
            this.quantizationBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tonsNum = new System.Windows.Forms.NumericUpDown();
            this.quantizationChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SaveImageBtn = new System.Windows.Forms.Button();
            this.histogramSyncGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histogramChart)).BeginInit();
            this.equalizationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equalizationCharta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePic)).BeginInit();
            this.quantizationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tonsNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantizationChart)).BeginInit();
            this.SuspendLayout();
            // 
            // preprocessingCmb
            // 
            this.preprocessingCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.preprocessingCmb.FormattingEnabled = true;
            this.preprocessingCmb.Items.AddRange(new object[] {
            "-- Önişlem menüsü-2 --",
            "Histogram oluşturma",
            "Histogram Eşitleme (Equalization - Gri seviye resimde)",
            "Görüntü Nicemleme (Quantization – Ton Sayısı Seçilerek) "});
            this.preprocessingCmb.Location = new System.Drawing.Point(12, 59);
            this.preprocessingCmb.Name = "preprocessingCmb";
            this.preprocessingCmb.Size = new System.Drawing.Size(285, 21);
            this.preprocessingCmb.TabIndex = 5;
            this.preprocessingCmb.SelectedIndexChanged += new System.EventHandler(this.preprocessingCmb_SelectedIndexChanged);
            // 
            // notPreprocessingRbtn
            // 
            this.notPreprocessingRbtn.AutoSize = true;
            this.notPreprocessingRbtn.Checked = true;
            this.notPreprocessingRbtn.Location = new System.Drawing.Point(12, 35);
            this.notPreprocessingRbtn.Name = "notPreprocessingRbtn";
            this.notPreprocessingRbtn.Size = new System.Drawing.Size(186, 17);
            this.notPreprocessingRbtn.TabIndex = 4;
            this.notPreprocessingRbtn.TabStop = true;
            this.notPreprocessingRbtn.Text = "Ön İşleme Uygulamak İstemiyorum";
            this.notPreprocessingRbtn.UseVisualStyleBackColor = true;
            this.notPreprocessingRbtn.CheckedChanged += new System.EventHandler(this.notPreprocessingRbtn_CheckedChanged);
            // 
            // preprocessingRbtn
            // 
            this.preprocessingRbtn.AutoSize = true;
            this.preprocessingRbtn.Location = new System.Drawing.Point(12, 12);
            this.preprocessingRbtn.Name = "preprocessingRbtn";
            this.preprocessingRbtn.Size = new System.Drawing.Size(172, 17);
            this.preprocessingRbtn.TabIndex = 3;
            this.preprocessingRbtn.Text = "Ön İşleme Uygulamak İstiyorum";
            this.preprocessingRbtn.UseVisualStyleBackColor = true;
            this.preprocessingRbtn.CheckedChanged += new System.EventHandler(this.preprocessingRbtn_CheckedChanged);
            // 
            // histogramSyncGroupBox
            // 
            this.histogramSyncGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.histogramSyncGroupBox.Controls.Add(this.histogramChart);
            this.histogramSyncGroupBox.Location = new System.Drawing.Point(12, 86);
            this.histogramSyncGroupBox.Name = "histogramSyncGroupBox";
            this.histogramSyncGroupBox.Size = new System.Drawing.Size(510, 333);
            this.histogramSyncGroupBox.TabIndex = 8;
            this.histogramSyncGroupBox.TabStop = false;
            this.histogramSyncGroupBox.Text = "Histogram oluşturma";
            // 
            // histogramChart
            // 
            this.histogramChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.Name = "ChartArea1";
            this.histogramChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.histogramChart.Legends.Add(legend4);
            this.histogramChart.Location = new System.Drawing.Point(6, 19);
            this.histogramChart.Name = "histogramChart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Pixel Color";
            this.histogramChart.Series.Add(series4);
            this.histogramChart.Size = new System.Drawing.Size(498, 300);
            this.histogramChart.TabIndex = 0;
            this.histogramChart.Text = "Histogram";
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(304, 425);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(297, 23);
            this.progressBar.TabIndex = 12;
            // 
            // nextBtn
            // 
            this.nextBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextBtn.Location = new System.Drawing.Point(607, 425);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(165, 23);
            this.nextBtn.TabIndex = 11;
            this.nextBtn.Text = "İleri ->";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // equalizationGroupBox
            // 
            this.equalizationGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.equalizationGroupBox.Controls.Add(this.equalizationCharta);
            this.equalizationGroupBox.Location = new System.Drawing.Point(12, 86);
            this.equalizationGroupBox.Name = "equalizationGroupBox";
            this.equalizationGroupBox.Size = new System.Drawing.Size(510, 333);
            this.equalizationGroupBox.TabIndex = 9;
            this.equalizationGroupBox.TabStop = false;
            this.equalizationGroupBox.Text = "Histogram Eşitleme (Equalization - Gri seviye resimde)";
            // 
            // equalizationCharta
            // 
            this.equalizationCharta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea5.Name = "ChartArea1";
            this.equalizationCharta.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.equalizationCharta.Legends.Add(legend5);
            this.equalizationCharta.Location = new System.Drawing.Point(6, 19);
            this.equalizationCharta.Name = "equalizationCharta";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Pixel Color";
            this.equalizationCharta.Series.Add(series5);
            this.equalizationCharta.Size = new System.Drawing.Size(498, 300);
            this.equalizationCharta.TabIndex = 0;
            this.equalizationCharta.Text = "Equalization";
            // 
            // imagePic
            // 
            this.imagePic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imagePic.Location = new System.Drawing.Point(537, 105);
            this.imagePic.Name = "imagePic";
            this.imagePic.Size = new System.Drawing.Size(235, 300);
            this.imagePic.TabIndex = 14;
            this.imagePic.TabStop = false;
            // 
            // quantizationGroupBox
            // 
            this.quantizationGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.quantizationGroupBox.Controls.Add(this.quantizationBtn);
            this.quantizationGroupBox.Controls.Add(this.label1);
            this.quantizationGroupBox.Controls.Add(this.tonsNum);
            this.quantizationGroupBox.Controls.Add(this.quantizationChart);
            this.quantizationGroupBox.Location = new System.Drawing.Point(12, 86);
            this.quantizationGroupBox.Name = "quantizationGroupBox";
            this.quantizationGroupBox.Size = new System.Drawing.Size(510, 333);
            this.quantizationGroupBox.TabIndex = 10;
            this.quantizationGroupBox.TabStop = false;
            this.quantizationGroupBox.Text = "Görüntü Nicemleme (Quantization – Ton Sayısı Seçilerek) ";
            // 
            // quantizationBtn
            // 
            this.quantizationBtn.Location = new System.Drawing.Point(399, 16);
            this.quantizationBtn.Name = "quantizationBtn";
            this.quantizationBtn.Size = new System.Drawing.Size(105, 23);
            this.quantizationBtn.TabIndex = 3;
            this.quantizationBtn.Text = "Oluştur";
            this.quantizationBtn.UseVisualStyleBackColor = true;
            this.quantizationBtn.Click += new System.EventHandler(this.quantizationBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bit Sayısını Giriniz";
            // 
            // tonsNum
            // 
            this.tonsNum.Location = new System.Drawing.Point(103, 19);
            this.tonsNum.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.tonsNum.Name = "tonsNum";
            this.tonsNum.Size = new System.Drawing.Size(120, 20);
            this.tonsNum.TabIndex = 1;
            // 
            // quantizationChart
            // 
            this.quantizationChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea6.Name = "ChartArea1";
            this.quantizationChart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.quantizationChart.Legends.Add(legend6);
            this.quantizationChart.Location = new System.Drawing.Point(6, 45);
            this.quantizationChart.Name = "quantizationChart";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Pixel Color";
            this.quantizationChart.Series.Add(series6);
            this.quantizationChart.Size = new System.Drawing.Size(498, 274);
            this.quantizationChart.TabIndex = 0;
            this.quantizationChart.Text = "Equalization";
            // 
            // SaveImageBtn
            // 
            this.SaveImageBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SaveImageBtn.Location = new System.Drawing.Point(12, 426);
            this.SaveImageBtn.Name = "SaveImageBtn";
            this.SaveImageBtn.Size = new System.Drawing.Size(286, 23);
            this.SaveImageBtn.TabIndex = 15;
            this.SaveImageBtn.Text = "Resmi Hafızaya Kaydet";
            this.SaveImageBtn.UseVisualStyleBackColor = true;
            this.SaveImageBtn.Click += new System.EventHandler(this.SaveImageBtn_Click);
            // 
            // PreprocessingTwoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.SaveImageBtn);
            this.Controls.Add(this.quantizationGroupBox);
            this.Controls.Add(this.imagePic);
            this.Controls.Add(this.equalizationGroupBox);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.histogramSyncGroupBox);
            this.Controls.Add(this.preprocessingCmb);
            this.Controls.Add(this.notPreprocessingRbtn);
            this.Controls.Add(this.preprocessingRbtn);
            this.Name = "PreprocessingTwoForm";
            this.Text = "PreprocessingTwoForm";
            this.Load += new System.EventHandler(this.PreprocessingTwoForm_Load);
            this.histogramSyncGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.histogramChart)).EndInit();
            this.equalizationGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.equalizationCharta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePic)).EndInit();
            this.quantizationGroupBox.ResumeLayout(false);
            this.quantizationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tonsNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantizationChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox preprocessingCmb;
        private System.Windows.Forms.RadioButton notPreprocessingRbtn;
        private System.Windows.Forms.RadioButton preprocessingRbtn;
        private System.Windows.Forms.GroupBox histogramSyncGroupBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart histogramChart;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.GroupBox equalizationGroupBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart equalizationCharta;
        private System.Windows.Forms.PictureBox imagePic;
        private System.Windows.Forms.GroupBox quantizationGroupBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart quantizationChart;
        private System.Windows.Forms.Button quantizationBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown tonsNum;
        private System.Windows.Forms.Button SaveImageBtn;
    }
}