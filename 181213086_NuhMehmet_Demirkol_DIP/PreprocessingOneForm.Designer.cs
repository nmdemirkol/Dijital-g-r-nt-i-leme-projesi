namespace _181213086_NuhMehmet_Demirkol_DIP
{
    partial class PreprocessingOneForm
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
            this.preprocessingRbtn = new System.Windows.Forms.RadioButton();
            this.notPreprocessingRbtn = new System.Windows.Forms.RadioButton();
            this.preprocessingCmb = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grayGroupBox = new System.Windows.Forms.GroupBox();
            this.convertGrayBtn = new System.Windows.Forms.Button();
            this.imagePic = new System.Windows.Forms.PictureBox();
            this.nextBtn = new System.Windows.Forms.Button();
            this.blackWhiteGroupBox = new System.Windows.Forms.GroupBox();
            this.convertBlackWhiteBtn = new System.Windows.Forms.Button();
            this.thresholdValueNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.zoomGroupBox = new System.Windows.Forms.GroupBox();
            this.zoomOutBtn = new System.Windows.Forms.Button();
            this.zoomInBtn = new System.Windows.Forms.Button();
            this.cropGroupBox = new System.Windows.Forms.GroupBox();
            this.imageInfoLabel = new System.Windows.Forms.Label();
            this.CropBtn = new System.Windows.Forms.Button();
            this.yPosTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.xPosTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.heightTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.widthTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.grayGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePic)).BeginInit();
            this.blackWhiteGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdValueNum)).BeginInit();
            this.zoomGroupBox.SuspendLayout();
            this.cropGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // preprocessingRbtn
            // 
            this.preprocessingRbtn.AutoSize = true;
            this.preprocessingRbtn.Location = new System.Drawing.Point(13, 13);
            this.preprocessingRbtn.Name = "preprocessingRbtn";
            this.preprocessingRbtn.Size = new System.Drawing.Size(172, 17);
            this.preprocessingRbtn.TabIndex = 0;
            this.preprocessingRbtn.Text = "Ön İşleme Uygulamak İstiyorum";
            this.preprocessingRbtn.UseVisualStyleBackColor = true;
            this.preprocessingRbtn.CheckedChanged += new System.EventHandler(this.preprocessingRbtn_CheckedChanged);
            // 
            // notPreprocessingRbtn
            // 
            this.notPreprocessingRbtn.AutoSize = true;
            this.notPreprocessingRbtn.Checked = true;
            this.notPreprocessingRbtn.Location = new System.Drawing.Point(13, 36);
            this.notPreprocessingRbtn.Name = "notPreprocessingRbtn";
            this.notPreprocessingRbtn.Size = new System.Drawing.Size(186, 17);
            this.notPreprocessingRbtn.TabIndex = 1;
            this.notPreprocessingRbtn.TabStop = true;
            this.notPreprocessingRbtn.Text = "Ön İşleme Uygulamak İstemiyorum";
            this.notPreprocessingRbtn.UseVisualStyleBackColor = true;
            this.notPreprocessingRbtn.CheckedChanged += new System.EventHandler(this.notPreprocessingRbtn_CheckedChanged);
            // 
            // preprocessingCmb
            // 
            this.preprocessingCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.preprocessingCmb.FormattingEnabled = true;
            this.preprocessingCmb.Items.AddRange(new object[] {
            "-- Önişlem menüsü-1 --",
            "Renkli resmi > Gri seviye resme dönüştürme",
            "Gri resmi > Siyah Beyaz resme dönüştürme(Eşik girerek)",
            "Zoom in – Zoom out",
            "Resimden istenilen bölgenin kesilip alınması"});
            this.preprocessingCmb.Location = new System.Drawing.Point(13, 60);
            this.preprocessingCmb.Name = "preprocessingCmb";
            this.preprocessingCmb.Size = new System.Drawing.Size(285, 21);
            this.preprocessingCmb.TabIndex = 2;
            this.preprocessingCmb.SelectedIndexChanged += new System.EventHandler(this.preprocessingCmb_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(12, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(286, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Resmi Hafızaya Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grayGroupBox
            // 
            this.grayGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grayGroupBox.Controls.Add(this.convertGrayBtn);
            this.grayGroupBox.Location = new System.Drawing.Point(12, 87);
            this.grayGroupBox.Name = "grayGroupBox";
            this.grayGroupBox.Size = new System.Drawing.Size(286, 333);
            this.grayGroupBox.TabIndex = 4;
            this.grayGroupBox.TabStop = false;
            this.grayGroupBox.Text = "Renkli resmi > Gri seviye resme dönüştürme";
            // 
            // convertGrayBtn
            // 
            this.convertGrayBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.convertGrayBtn.Location = new System.Drawing.Point(6, 19);
            this.convertGrayBtn.Name = "convertGrayBtn";
            this.convertGrayBtn.Size = new System.Drawing.Size(274, 23);
            this.convertGrayBtn.TabIndex = 0;
            this.convertGrayBtn.Text = "Resmi Gri Seviyeli Resme Dönüştür";
            this.convertGrayBtn.UseVisualStyleBackColor = true;
            this.convertGrayBtn.Click += new System.EventHandler(this.convertGrayBtn_Click);
            // 
            // imagePic
            // 
            this.imagePic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imagePic.Location = new System.Drawing.Point(304, 12);
            this.imagePic.Name = "imagePic";
            this.imagePic.Size = new System.Drawing.Size(468, 408);
            this.imagePic.TabIndex = 5;
            this.imagePic.TabStop = false;
            // 
            // nextBtn
            // 
            this.nextBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextBtn.Location = new System.Drawing.Point(607, 426);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(165, 23);
            this.nextBtn.TabIndex = 6;
            this.nextBtn.Text = "İleri ->";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // blackWhiteGroupBox
            // 
            this.blackWhiteGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.blackWhiteGroupBox.Controls.Add(this.convertBlackWhiteBtn);
            this.blackWhiteGroupBox.Controls.Add(this.thresholdValueNum);
            this.blackWhiteGroupBox.Controls.Add(this.label1);
            this.blackWhiteGroupBox.Location = new System.Drawing.Point(12, 87);
            this.blackWhiteGroupBox.Name = "blackWhiteGroupBox";
            this.blackWhiteGroupBox.Size = new System.Drawing.Size(286, 333);
            this.blackWhiteGroupBox.TabIndex = 7;
            this.blackWhiteGroupBox.TabStop = false;
            this.blackWhiteGroupBox.Text = " Gri resmi > Siyah Beyaz resme dönüştürme(Eşik girerek)";
           
            // 
            // convertBlackWhiteBtn
            // 
            this.convertBlackWhiteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.convertBlackWhiteBtn.Location = new System.Drawing.Point(9, 48);
            this.convertBlackWhiteBtn.Name = "convertBlackWhiteBtn";
            this.convertBlackWhiteBtn.Size = new System.Drawing.Size(271, 23);
            this.convertBlackWhiteBtn.TabIndex = 2;
            this.convertBlackWhiteBtn.Text = "Resmi Siyah Beyaz Resme Dönüştür";
            this.convertBlackWhiteBtn.UseVisualStyleBackColor = true;
            this.convertBlackWhiteBtn.Click += new System.EventHandler(this.convertBlackWhiteBtn_Click);
            // 
            // thresholdValueNum
            // 
            this.thresholdValueNum.Location = new System.Drawing.Point(112, 19);
            this.thresholdValueNum.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.thresholdValueNum.Name = "thresholdValueNum";
            this.thresholdValueNum.Size = new System.Drawing.Size(168, 20);
            this.thresholdValueNum.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eşik Değerini Giriniz";
            // 
            // zoomGroupBox
            // 
            this.zoomGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.zoomGroupBox.Controls.Add(this.zoomOutBtn);
            this.zoomGroupBox.Controls.Add(this.zoomInBtn);
            this.zoomGroupBox.Location = new System.Drawing.Point(12, 87);
            this.zoomGroupBox.Name = "zoomGroupBox";
            this.zoomGroupBox.Size = new System.Drawing.Size(286, 333);
            this.zoomGroupBox.TabIndex = 8;
            this.zoomGroupBox.TabStop = false;
            this.zoomGroupBox.Text = "Zoom in – Zoom out";
            // 
            // zoomOutBtn
            // 
            this.zoomOutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomOutBtn.Location = new System.Drawing.Point(147, 21);
            this.zoomOutBtn.Name = "zoomOutBtn";
            this.zoomOutBtn.Size = new System.Drawing.Size(133, 23);
            this.zoomOutBtn.TabIndex = 1;
            this.zoomOutBtn.Text = "Zoom Out";
            this.zoomOutBtn.UseVisualStyleBackColor = true;
            this.zoomOutBtn.Click += new System.EventHandler(this.zoomOutBtn_Click);
            // 
            // zoomInBtn
            // 
            this.zoomInBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomInBtn.Location = new System.Drawing.Point(6, 21);
            this.zoomInBtn.Name = "zoomInBtn";
            this.zoomInBtn.Size = new System.Drawing.Size(133, 23);
            this.zoomInBtn.TabIndex = 0;
            this.zoomInBtn.Text = "Zoom In";
            this.zoomInBtn.UseVisualStyleBackColor = true;
            this.zoomInBtn.Click += new System.EventHandler(this.zoomInBtn_Click);
            // 
            // cropGroupBox
            // 
            this.cropGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cropGroupBox.Controls.Add(this.imageInfoLabel);
            this.cropGroupBox.Controls.Add(this.CropBtn);
            this.cropGroupBox.Controls.Add(this.yPosTxt);
            this.cropGroupBox.Controls.Add(this.label5);
            this.cropGroupBox.Controls.Add(this.xPosTxt);
            this.cropGroupBox.Controls.Add(this.label4);
            this.cropGroupBox.Controls.Add(this.heightTxt);
            this.cropGroupBox.Controls.Add(this.label3);
            this.cropGroupBox.Controls.Add(this.widthTxt);
            this.cropGroupBox.Controls.Add(this.label2);
            this.cropGroupBox.Location = new System.Drawing.Point(12, 87);
            this.cropGroupBox.Name = "cropGroupBox";
            this.cropGroupBox.Size = new System.Drawing.Size(286, 333);
            this.cropGroupBox.TabIndex = 9;
            this.cropGroupBox.TabStop = false;
            this.cropGroupBox.Text = "Resimden istenilen bölgenin kesilip alınması";
            // 
            // imageInfoLabel
            // 
            this.imageInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageInfoLabel.AutoSize = true;
            this.imageInfoLabel.Location = new System.Drawing.Point(6, 160);
            this.imageInfoLabel.Name = "imageInfoLabel";
            this.imageInfoLabel.Size = new System.Drawing.Size(16, 13);
            this.imageInfoLabel.TabIndex = 9;
            this.imageInfoLabel.Text = "...";
            // 
            // CropBtn
            // 
            this.CropBtn.Location = new System.Drawing.Point(96, 127);
            this.CropBtn.Name = "CropBtn";
            this.CropBtn.Size = new System.Drawing.Size(184, 23);
            this.CropBtn.TabIndex = 8;
            this.CropBtn.Text = "İstenilen Alanı Kes";
            this.CropBtn.UseVisualStyleBackColor = true;
            this.CropBtn.Click += new System.EventHandler(this.CropBtn_Click);
            // 
            // yPosTxt
            // 
            this.yPosTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yPosTxt.Location = new System.Drawing.Point(96, 101);
            this.yPosTxt.Name = "yPosTxt";
            this.yPosTxt.Size = new System.Drawing.Size(184, 20);
            this.yPosTxt.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Y Pos";
            // 
            // xPosTxt
            // 
            this.xPosTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xPosTxt.Location = new System.Drawing.Point(96, 75);
            this.xPosTxt.Name = "xPosTxt";
            this.xPosTxt.Size = new System.Drawing.Size(184, 20);
            this.xPosTxt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "X Pos";
            // 
            // heightTxt
            // 
            this.heightTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.heightTxt.Location = new System.Drawing.Point(96, 49);
            this.heightTxt.Name = "heightTxt";
            this.heightTxt.Size = new System.Drawing.Size(184, 20);
            this.heightTxt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yükseklik";
            // 
            // widthTxt
            // 
            this.widthTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.widthTxt.Location = new System.Drawing.Point(96, 23);
            this.widthTxt.Name = "widthTxt";
            this.widthTxt.Size = new System.Drawing.Size(184, 20);
            this.widthTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Genişlik";
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(304, 426);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(297, 23);
            this.progressBar.TabIndex = 10;
            // 
            // PreprocessingOneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.blackWhiteGroupBox);
            this.Controls.Add(this.zoomGroupBox);
            this.Controls.Add(this.cropGroupBox);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.imagePic);
            this.Controls.Add(this.grayGroupBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.preprocessingCmb);
            this.Controls.Add(this.notPreprocessingRbtn);
            this.Controls.Add(this.preprocessingRbtn);
            this.Name = "PreprocessingOneForm";
            this.Text = "PreprocessingOneForm";
            this.Load += new System.EventHandler(this.PreprocessingOneForm_Load);
            this.grayGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagePic)).EndInit();
            this.blackWhiteGroupBox.ResumeLayout(false);
            this.blackWhiteGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdValueNum)).EndInit();
            this.zoomGroupBox.ResumeLayout(false);
            this.cropGroupBox.ResumeLayout(false);
            this.cropGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton preprocessingRbtn;
        private System.Windows.Forms.RadioButton notPreprocessingRbtn;
        private System.Windows.Forms.ComboBox preprocessingCmb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grayGroupBox;
        private System.Windows.Forms.PictureBox imagePic;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.GroupBox blackWhiteGroupBox;
        private System.Windows.Forms.GroupBox zoomGroupBox;
        private System.Windows.Forms.GroupBox cropGroupBox;
        private System.Windows.Forms.Button convertGrayBtn;
        private System.Windows.Forms.NumericUpDown thresholdValueNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button convertBlackWhiteBtn;
        private System.Windows.Forms.Button zoomOutBtn;
        private System.Windows.Forms.Button zoomInBtn;
        private System.Windows.Forms.Button CropBtn;
        private System.Windows.Forms.TextBox yPosTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox xPosTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox heightTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox widthTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label imageInfoLabel;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}