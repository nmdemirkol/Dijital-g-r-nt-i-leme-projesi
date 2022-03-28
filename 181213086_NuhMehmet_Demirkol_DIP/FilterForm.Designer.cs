namespace _181213086_NuhMehmet_Demirkol_DIP
{
    partial class FilterForm
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
            this.filterCmb = new System.Windows.Forms.ComboBox();
            this.notFilterRbtn = new System.Windows.Forms.RadioButton();
            this.filterRbtn = new System.Windows.Forms.RadioButton();
            this.quantizationGroupBox = new System.Windows.Forms.GroupBox();
            this.gaussianBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.standardDeviationNum = new System.Windows.Forms.NumericUpDown();
            this.imagePic = new System.Windows.Forms.PictureBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.nextBtn = new System.Windows.Forms.Button();
            this.SaveImageBtn = new System.Windows.Forms.Button();
            this.quantizationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.standardDeviationNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePic)).BeginInit();
            this.SuspendLayout();
            // 
            // filterCmb
            // 
            this.filterCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterCmb.FormattingEnabled = true;
            this.filterCmb.Items.AddRange(new object[] {
            "-- Filtreleme Menüsü --",
            "Gaussian Bulanıklaştırma filtresi (Parametre olarak istenilen standart sapma (σ) " +
                "değerine göre)",
            "Keskinleştirme filtresi",
            "Kenar bulma filtresi",
            "Ortalama (Mean) filtresi",
            "Ortanca (Median) filtresi",
            "Kontra Harmonik Ortalama filtresi"});
            this.filterCmb.Location = new System.Drawing.Point(12, 59);
            this.filterCmb.Name = "filterCmb";
            this.filterCmb.Size = new System.Drawing.Size(285, 21);
            this.filterCmb.TabIndex = 8;
            this.filterCmb.SelectedIndexChanged += new System.EventHandler(this.filterCmb_SelectedIndexChanged);
            // 
            // notFilterRbtn
            // 
            this.notFilterRbtn.AutoSize = true;
            this.notFilterRbtn.Checked = true;
            this.notFilterRbtn.Location = new System.Drawing.Point(12, 35);
            this.notFilterRbtn.Name = "notFilterRbtn";
            this.notFilterRbtn.Size = new System.Drawing.Size(183, 17);
            this.notFilterRbtn.TabIndex = 7;
            this.notFilterRbtn.TabStop = true;
            this.notFilterRbtn.Text = "Filtreleme Uygulamak İstemiyorum";
            this.notFilterRbtn.UseVisualStyleBackColor = true;
            this.notFilterRbtn.CheckedChanged += new System.EventHandler(this.notFilterRbtn_CheckedChanged);
            // 
            // filterRbtn
            // 
            this.filterRbtn.AutoSize = true;
            this.filterRbtn.Location = new System.Drawing.Point(12, 12);
            this.filterRbtn.Name = "filterRbtn";
            this.filterRbtn.Size = new System.Drawing.Size(169, 17);
            this.filterRbtn.TabIndex = 6;
            this.filterRbtn.Text = "Filtreleme Uygulamak İstiyorum";
            this.filterRbtn.UseVisualStyleBackColor = true;
            this.filterRbtn.CheckedChanged += new System.EventHandler(this.filterRbtn_CheckedChanged);
            // 
            // quantizationGroupBox
            // 
            this.quantizationGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.quantizationGroupBox.Controls.Add(this.gaussianBtn);
            this.quantizationGroupBox.Controls.Add(this.label1);
            this.quantizationGroupBox.Controls.Add(this.standardDeviationNum);
            this.quantizationGroupBox.Location = new System.Drawing.Point(12, 86);
            this.quantizationGroupBox.Name = "quantizationGroupBox";
            this.quantizationGroupBox.Size = new System.Drawing.Size(285, 333);
            this.quantizationGroupBox.TabIndex = 11;
            this.quantizationGroupBox.TabStop = false;
            this.quantizationGroupBox.Text = "Gaussian Bulanıklaştırma filtresi ";
            // 
            // gaussianBtn
            // 
            this.gaussianBtn.Location = new System.Drawing.Point(174, 34);
            this.gaussianBtn.Name = "gaussianBtn";
            this.gaussianBtn.Size = new System.Drawing.Size(105, 23);
            this.gaussianBtn.TabIndex = 3;
            this.gaussianBtn.Text = "Oluştur";
            this.gaussianBtn.UseVisualStyleBackColor = true;
            this.gaussianBtn.Click += new System.EventHandler(this.gaussianBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Standart Sapma Değerini Giriniz";
            // 
            // standardDeviationNum
            // 
            this.standardDeviationNum.Location = new System.Drawing.Point(9, 37);
            this.standardDeviationNum.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.standardDeviationNum.Name = "standardDeviationNum";
            this.standardDeviationNum.Size = new System.Drawing.Size(153, 20);
            this.standardDeviationNum.TabIndex = 1;
            // 
            // imagePic
            // 
            this.imagePic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imagePic.Location = new System.Drawing.Point(304, 12);
            this.imagePic.Name = "imagePic";
            this.imagePic.Size = new System.Drawing.Size(468, 408);
            this.imagePic.TabIndex = 12;
            this.imagePic.TabStop = false;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(304, 426);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(297, 23);
            this.progressBar.TabIndex = 14;
            // 
            // nextBtn
            // 
            this.nextBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextBtn.Location = new System.Drawing.Point(607, 426);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(165, 23);
            this.nextBtn.TabIndex = 13;
            this.nextBtn.Text = "İleri ->";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // SaveImageBtn
            // 
            this.SaveImageBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SaveImageBtn.Location = new System.Drawing.Point(12, 426);
            this.SaveImageBtn.Name = "SaveImageBtn";
            this.SaveImageBtn.Size = new System.Drawing.Size(286, 23);
            this.SaveImageBtn.TabIndex = 16;
            this.SaveImageBtn.Text = "Resmi Hafızaya Kaydet";
            this.SaveImageBtn.UseVisualStyleBackColor = true;
            this.SaveImageBtn.Click += new System.EventHandler(this.SaveImageBtn_Click);
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.SaveImageBtn);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.imagePic);
            this.Controls.Add(this.quantizationGroupBox);
            this.Controls.Add(this.filterCmb);
            this.Controls.Add(this.notFilterRbtn);
            this.Controls.Add(this.filterRbtn);
            this.Name = "FilterForm";
            this.Text = "FlterForm";
            this.Load += new System.EventHandler(this.FilterForm_Load);
            this.quantizationGroupBox.ResumeLayout(false);
            this.quantizationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.standardDeviationNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox filterCmb;
        private System.Windows.Forms.RadioButton notFilterRbtn;
        private System.Windows.Forms.RadioButton filterRbtn;
        private System.Windows.Forms.GroupBox quantizationGroupBox;
        private System.Windows.Forms.Button gaussianBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown standardDeviationNum;
        private System.Windows.Forms.PictureBox imagePic;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button SaveImageBtn;
    }
}