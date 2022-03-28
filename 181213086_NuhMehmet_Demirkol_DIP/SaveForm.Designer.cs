namespace _181213086_NuhMehmet_Demirkol_DIP
{
    partial class SaveForm
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
            this.imagePic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FormatCmb = new System.Windows.Forms.ComboBox();
            this.saveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagePic)).BeginInit();
            this.SuspendLayout();
            // 
            // imagePic
            // 
            this.imagePic.Location = new System.Drawing.Point(281, 12);
            this.imagePic.Name = "imagePic";
            this.imagePic.Size = new System.Drawing.Size(491, 437);
            this.imagePic.TabIndex = 0;
            this.imagePic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hangi Formatta Kaydetmek İstediğinizi Seçiniz";
            // 
            // FormatCmb
            // 
            this.FormatCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FormatCmb.FormattingEnabled = true;
            this.FormatCmb.Items.AddRange(new object[] {
            "-- Lütfen kaydetmek istediğiniz formatı seçiniz --",
            "*.jpg",
            "*.bmp",
            "*.png"});
            this.FormatCmb.Location = new System.Drawing.Point(12, 28);
            this.FormatCmb.Name = "FormatCmb";
            this.FormatCmb.Size = new System.Drawing.Size(263, 21);
            this.FormatCmb.TabIndex = 2;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(12, 55);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(263, 23);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Resmi Kaydet";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // SaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.FormatCmb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imagePic);
            this.Name = "SaveForm";
            this.Text = "SaveForm";
            this.Load += new System.EventHandler(this.SaveForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imagePic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FormatCmb;
        private System.Windows.Forms.Button saveBtn;
    }
}