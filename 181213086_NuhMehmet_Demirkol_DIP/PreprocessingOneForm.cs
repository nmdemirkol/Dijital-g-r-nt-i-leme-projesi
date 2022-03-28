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
    public partial class PreprocessingOneForm : Form
    {
        public Bitmap activeImage, zoomActiveImage;


        public PreprocessingOneForm()
        {
            InitializeComponent();
        }

        private void PreprocessingOneForm_Load(object sender, EventArgs e)
        {
            AllGroupBoxVisble();
            preprocessingCmb.SelectedIndex = 0;
            preprocessingCmb.Enabled = false;
            
            imagePic.Image = activeImage;
        }

        private void preprocessingRbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (preprocessingRbtn.Checked == true)
            {
                preprocessingCmb.Enabled = true;
            }
        }

        private void notPreprocessingRbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (notPreprocessingRbtn.Checked == true)
            {
                preprocessingCmb.Enabled = false;
            }
        }

        private void AllGroupBoxVisble()
        {
            grayGroupBox.Visible = false;
            blackWhiteGroupBox.Visible = false;
            zoomGroupBox.Visible = false;
            cropGroupBox.Visible = false;
        }

        private void preprocessingCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            AllGroupBoxVisble();
            if (preprocessingCmb.SelectedIndex == 1)
            {
                grayGroupBox.Visible = true;
            }
            else if (preprocessingCmb.SelectedIndex == 2)
            {
                blackWhiteGroupBox.Visible = true;
            }
            else if (preprocessingCmb.SelectedIndex == 3)
            {
                zoomGroupBox.Visible = true;
                zoomActiveImage = activeImage;
            }
            else if (preprocessingCmb.SelectedIndex == 4)
            {
                cropGroupBox.Visible = true;
              imageInfoLabel.Text = "Genişliği = " + activeImage.Width + " | Yüksekliği = " + activeImage.Height;


            }
        }

        private void convertGrayBtn_Click(object sender, EventArgs e)
        {
           
            Bitmap _image = new Bitmap(activeImage);

            progressBar.Minimum = 0;
            progressBar.Maximum = _image.Width + _image.Height;
            progressBar.Value = 0;
            int x, y;

            for (x = 0; x < _image.Width; x++)
            {
                for (y = 0; y < _image.Height; y++)
                {
                    Color pixelColor = _image.GetPixel(x, y);
                    int r = pixelColor.R;
                    int g = pixelColor.G;
                    int b = pixelColor.B;

                    int grayValue = (r + g + b) / 3;
                    Color newColor = Color.FromArgb(grayValue, grayValue, grayValue);

                    _image.SetPixel(x, y, newColor);
                  
                }
                progressBar.Value = x + y;
            }

            imagePic.Image = _image;

        }

        private void convertBlackWhiteBtn_Click(object sender, EventArgs e)
        {
            decimal thresholdValue = thresholdValueNum.Value;
            Bitmap _image = new Bitmap(activeImage);

            progressBar.Minimum = 0;
            progressBar.Maximum = _image.Width + _image.Height;
            progressBar.Value = 0;
            int x, y;

            for (x = 0; x < _image.Width; x++)
            {
                for (y = 0; y < _image.Height; y++)
                {
                    Color pixelColor = _image.GetPixel(x, y);
                    int r = pixelColor.R;
                    int newValue;
                    if (r > thresholdValue)
                    {
                        newValue = 255;
                    }
                    else
                    {
                        newValue = 0;
                    }


                    Color newColor = Color.FromArgb(newValue, newValue, newValue);

                    _image.SetPixel(x, y, newColor);
                }
                progressBar.Value = x + y;
            }

            imagePic.Image = _image;
        }

        private void zoomInBtn_Click(object sender, EventArgs e)
        {
            float zoomFactor = 1.5f;
            Size newSize = new Size((int)(zoomActiveImage.Width * zoomFactor), (int)(zoomActiveImage.Height * zoomFactor));
            zoomActiveImage = new Bitmap(activeImage, newSize);

            imagePic.Image = zoomActiveImage;
        }

        private void CropBtn_Click(object sender, EventArgs e)
        {
            int width = int.Parse(widthTxt.Text);
            int height = int.Parse(heightTxt.Text);
            int xPos = int.Parse(xPosTxt.Text);
            int yPos = int.Parse(yPosTxt.Text);

            if (width > activeImage.Width)
            {
                width = activeImage.Width;
            }

            if (height > activeImage.Height)
            {
                height = activeImage.Height;
            }

            Bitmap _image = new Bitmap(activeImage);
            Bitmap _newImage = new Bitmap(width, height);
            int x, y;

            progressBar.Minimum = 0;
            progressBar.Maximum = width + height - 1;
            progressBar.Value = 0;

            for (x = xPos; x < width + xPos; x++)
            {
                for (y = yPos; y < height + yPos; y++)
                {

                    Color pixelColor = _image.GetPixel(x, y);



                    Color newColor = Color.FromArgb(pixelColor.R, pixelColor.G, pixelColor.B);


                    _newImage.SetPixel(x - xPos, y - yPos, newColor);

                }
                progressBar.Value = (x - xPos ) + (y - yPos );


            }

            imagePic.Image = _newImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            activeImage = (Bitmap)imagePic.Image;
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
             PreprocessingTwoForm fr = new PreprocessingTwoForm();
            fr.activeImage = activeImage;
            fr.ShowDialog();
        }


        private void zoomOutBtn_Click(object sender, EventArgs e)
        {
            float zoomFactor = 1.5f;
            Size newSize = new Size((int)(zoomActiveImage.Width / zoomFactor), (int)(zoomActiveImage.Height / zoomFactor));
            zoomActiveImage = new Bitmap(activeImage, newSize);
            imagePic.Image = zoomActiveImage;
        }
    }
}
