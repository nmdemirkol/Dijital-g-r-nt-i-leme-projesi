namespace _181213086_NuhMehmet_Demirkol_DIP
{
    partial class OpenImageForm
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
            this.newImageOpenBtn = new System.Windows.Forms.Button();
            this.imagePathTxt = new System.Windows.Forms.TextBox();
            this.imagePic = new System.Windows.Forms.PictureBox();
            this.nextBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imagePic)).BeginInit();
            this.SuspendLayout();
            // 
            // newImageOpenBtn
            // 
            this.newImageOpenBtn.Location = new System.Drawing.Point(12, 12);
            this.newImageOpenBtn.Name = "newImageOpenBtn";
            this.newImageOpenBtn.Size = new System.Drawing.Size(165, 23);
            this.newImageOpenBtn.TabIndex = 0;
            this.newImageOpenBtn.Text = "Yeni Resim Aç";
            this.newImageOpenBtn.UseVisualStyleBackColor = true;
            this.newImageOpenBtn.Click += new System.EventHandler(this.newImageOpenBtn_Click);
            // 
            // imagePathTxt
            // 
            this.imagePathTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imagePathTxt.Location = new System.Drawing.Point(183, 14);
            this.imagePathTxt.Name = "imagePathTxt";
            this.imagePathTxt.Size = new System.Drawing.Size(289, 20);
            this.imagePathTxt.TabIndex = 1;
            // 
            // imagePic
            // 
            this.imagePic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imagePic.Location = new System.Drawing.Point(12, 41);
            this.imagePic.Name = "imagePic";
            this.imagePic.Size = new System.Drawing.Size(460, 379);
            this.imagePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePic.TabIndex = 2;
            this.imagePic.TabStop = false;
            // 
            // nextBtn
            // 
            this.nextBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextBtn.Location = new System.Drawing.Point(307, 426);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(165, 23);
            this.nextBtn.TabIndex = 3;
            this.nextBtn.Text = "İleri ->";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sayfa 1";
            // 
            // OpenImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.imagePic);
            this.Controls.Add(this.imagePathTxt);
            this.Controls.Add(this.newImageOpenBtn);
            this.Name = "OpenImageForm";
            this.Text = "OpenImageForm";
            ((System.ComponentModel.ISupportInitialize)(this.imagePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newImageOpenBtn;
        private System.Windows.Forms.TextBox imagePathTxt;
        private System.Windows.Forms.PictureBox imagePic;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Label label1;
    }
}