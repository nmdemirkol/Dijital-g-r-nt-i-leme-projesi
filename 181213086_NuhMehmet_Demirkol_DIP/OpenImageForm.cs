using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _181213086_NuhMehmet_Demirkol_DIP
{
    public partial class OpenImageForm : Form
    {

        Bitmap activeImage;
        public OpenImageForm()
        {
            InitializeComponent();
        }

        private void newImageOpenBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                imagePic.Image = new Bitmap(open.FileName);
                imagePathTxt.Text = open.FileName;
                activeImage = new Bitmap(open.FileName);
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (activeImage!=null)
            {
                PreprocessingOneForm fr = new PreprocessingOneForm();
                fr.activeImage = activeImage;

                fr.ShowDialog();
            }
            else
            {
                string message = "Lütfen Bir Resim Açınız";
                string title = "Uyarı";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            }
          
        }
    }
}
