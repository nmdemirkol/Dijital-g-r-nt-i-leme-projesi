using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _181213086_NuhMehmet_Demirkol_DIP
{
    public partial class SaveForm : Form
    {

        public Bitmap activeImage;
        public SaveForm()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(activeImage);
                if (FormatCmb.SelectedIndex == 1)
                {

                    bmp.Save(dialog.FileName+".jpg", ImageFormat.Jpeg);
                    SavedDialog();
                }
                else if (FormatCmb.SelectedIndex == 2)
                {
                    bmp.Save(dialog.FileName + ".bmp", ImageFormat.Bmp);
                    SavedDialog();
                }
                else if (FormatCmb.SelectedIndex == 3)
                {
                    bmp.Save(dialog.FileName + ".png", ImageFormat.Png);
                    SavedDialog();
                }
                else
                {
                    string message = "Lütfen Bir Format Seçiniz";
                    string title = "Uyarı";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                }


            }
        }

        private void SavedDialog()
        {
            string message = "Resim Kaydedildi";
            string title = "Başılı Kayıt";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
        }

        private void SaveForm_Load(object sender, EventArgs e)
        {
            FormatCmb.SelectedIndex = 0;
            imagePic.Image = activeImage;
        }
    }
}
