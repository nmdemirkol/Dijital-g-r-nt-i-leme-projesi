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
    public partial class FilterForm : Form
    {
        public Bitmap activeImage;


        public FilterForm()
        {
            InitializeComponent();
        }

        private void filterRbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (filterRbtn.Checked == true)
            {
                filterCmb.Enabled = true;
            }
        }

        private void notFilterRbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (notFilterRbtn.Checked == true)
            {
                filterCmb.Enabled = false;
            }
        }

        private void AllGroupBoxVisble()
        {
            quantizationGroupBox.Visible = false;

        }

        private void filterCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            AllGroupBoxVisble();
            if (filterCmb.SelectedIndex == 1)
            {
                quantizationGroupBox.Visible = true;

            }
            else if (filterCmb.SelectedIndex == 2)
            {
                Bitmap _image = new Bitmap(activeImage);

                Bitmap meanFilterImage = meanFilterBitmap();
 
                Bitmap borderImage = ImageExtractionBulurImage(_image,
               meanFilterImage);
                Bitmap NetlesmisResim = BorderCombineActiveImage(_image,
               borderImage);
                imagePic.Image = NetlesmisResim;
            }
            else if (filterCmb.SelectedIndex == 3)
            {
                prewittFilter();
            }

            else if (filterCmb.SelectedIndex == 4)
            {
                meanFilter();
            }
            else if (filterCmb.SelectedIndex == 5)
            {
                medianFiltresi();
            }
        }

        private void gaussianBtn_Click(object sender, EventArgs e)
        {
            Color activeColor;
            Bitmap _image, image;
            _image = new Bitmap(activeImage);
            image = new Bitmap(activeImage.Width, activeImage.Height);

            int x, y, i, j, countR, countG, countB, avgR, avgG, avgB;
            int[] matris = { 1, 4, 7, 4, 1, 4, 20, 33, 20, 4, 7, 33, 55, 33, 7, 4, 20, 33, 20, 4, 1, 4, 7, 4, 1 };
            int matrisToplami = 1 + 4 + 7 + 4 + 1 + 4 + 20 + 33 + 20 + 4 + 7 + 33 + 55 + 33 + 7 + 4 + 20 + 33 + 20 + 4 + 1 + 4 + 7 + 4 + 1;

            int size = 5; 
            int itemNumber = size * size;

            for (x = (size - 1) / 2; x < activeImage.Width - (size - 1) / 2; x++)

            {
                for (y = (size - 1) / 2; y < activeImage.Height - (size - 1) / 2; y++)
                {
                    countR = 0;
                    countG = 0;
                    countB = 0;

                    int k = 0; 
                    for (i = -((size - 1) / 2); i <= (size - 1) / 2; i++)
                    {
                        for (j = -((size - 1) / 2); j <= (size - 1) / 2; j++)
                        {
                            activeColor = _image.GetPixel(x + i, y + j);
                            countR = countR + activeColor.R * matris[k];
                            countG = countG + activeColor.G * matris[k];
                            countB = countB + activeColor.B * matris[k];
                            k++;
                        }
                        avgR = countR / matrisToplami;
                        avgG = countG / matrisToplami;
                        avgB = countB / matrisToplami;
                        image.SetPixel(x, y, Color.FromArgb(avgR, avgG, avgB));
                    }
                }
            }
            imagePic.Image = image;
        }


        public void meanFilter()
        {
            Color activeColor;
            Bitmap _image, image;
            _image = new Bitmap(activeImage);
            int imageWidth = _image.Width;
            int imageHeight = _image.Height;
            image = new Bitmap(imageWidth, imageHeight);
            int size = Convert.ToInt32("3"); 
            int x, y, i, j, countR, countG, countB, avgR, avgG, avgB;
            for (x = (size - 1) / 2; x < imageWidth - (size - 1) / 2; x++)
            {
                for (y = (size - 1) / 2; y < imageHeight - (size - 1) / 2; y++)
                {
                    countR = 0;
                    countG = 0;
                    countB = 0;
                    for (i = -((size - 1) / 2); i <= (size - 1) / 2; i++)
                    {
                        for (j = -((size - 1) / 2); j <= (size - 1) / 2; j++)
                        {
                            activeColor = _image.GetPixel(x + i, y + j);
                            countR = countR + activeColor.R;
                            countG = countG + activeColor.G;
                            countB = countB + activeColor.B;
                        }
                    }
                    avgR = countR / (size * size);
                    avgG = countG / (size * size);
                    avgB = countB / (size * size);
                    image.SetPixel(x, y, Color.FromArgb(avgR, avgG, avgB));
                }
            }
            imagePic.Image = image;
        }

        public Bitmap meanFilterBitmap()
        {
            Color activeColor;
            Bitmap _image, image;
            _image = new Bitmap(activeImage);
            int imageWidth = _image.Width;
            int imageHeight = _image.Height;
            image = new Bitmap(imageWidth, imageHeight);
            int size = Convert.ToInt32("3"); 
            int x, y, i, j, countR, countG, countB, avgR, avgG, avgB;
            for (x = (size - 1) / 2; x < imageWidth - (size - 1) / 2; x++)
            {
                for (y = (size - 1) / 2; y < imageHeight - (size - 1) / 2; y++)
                {
                    countR = 0;
                    countG = 0;
                    countB = 0;
                    for (i = -((size - 1) / 2); i <= (size - 1) / 2; i++)
                    {
                        for (j = -((size - 1) / 2); j <= (size - 1) / 2; j++)
                        {
                            activeColor = _image.GetPixel(x + i, y + j);
                            countR = countR + activeColor.R;
                            countG = countG + activeColor.G;
                            countB = countB + activeColor.B;
                        }
                    }
                    avgR = countR / (size * size);
                    avgG = countG / (size * size);
                    avgB = countB / (size * size);
                    image.SetPixel(x, y, Color.FromArgb(avgR, avgG, avgB));
                }
            }
            return image;
        }
        public void medianFiltresi()
        {
            Color activeColor;
            Bitmap _image, image;
            _image = new Bitmap(activeImage);
            int imageWidth = _image.Width;
            int imageHeight = _image.Height;
            image = new Bitmap(imageWidth, imageHeight);
            int size = Convert.ToInt32("5"); 
            int itemNumber = size * size;
            int[] R = new int[itemNumber];
            int[] G = new int[itemNumber];
            int[] B = new int[itemNumber];
            int[] Gri = new int[itemNumber];
            int x, y, i, j;
            for (x = (size - 1) / 2; x < imageWidth - (size - 1) / 2; x++)
            {
                for (y = (size - 1) / 2; y < imageHeight - (size - 1) / 2; y++)
                {
   
                    int k = 0;
                    for (i = -((size - 1) / 2); i <= (size - 1) / 2; i++)
                    {
                        for (j = -((size - 1) / 2); j <= (size - 1) / 2; j++)
                        {
                            activeColor = _image.GetPixel(x + i, y + j);
                            R[k] = activeColor.R;
                            G[k] = activeColor.G;
                            B[k] = activeColor.B;
                            Gri[k] = Convert.ToInt16(R[k] * 0.299 + G[k] * 0.587 + B[k] * 0.114);
                            k++;
                        }
                    }
                 
                    int GeciciSayi = 0;
                    for (i = 0; i < itemNumber; i++)
                    {
                        for (j = i + 1; j < itemNumber; j++)
                        {
                            if (Gri[j] < Gri[i])
                            {
                                GeciciSayi = Gri[i];
                                Gri[i] = Gri[j];
                                Gri[j] = GeciciSayi;
                                GeciciSayi = R[i];
                                R[i] = R[j];
                                R[j] = GeciciSayi;
                                GeciciSayi = G[i];
                                G[i] = G[j];
                                G[j] = GeciciSayi;
                                GeciciSayi = B[i];
                                B[i] = B[j];
                                B[j] = GeciciSayi;
                            }
                        }
                    }
                 
                    image.SetPixel(x, y, Color.FromArgb(R[(itemNumber - 1) / 2], G[(itemNumber - 1) /
                   2], B[(itemNumber - 1) / 2]));
                }
            }
            imagePic.Image = image;
        }

        public void prewittFilter()
        {
            Bitmap _image, image;
            _image = new Bitmap(activeImage);
            int imageWidth = _image.Width;
            int imageHeight = _image.Height;
            image = new Bitmap(imageWidth, imageHeight);

            int size = 3;
            int itemNumber = size * size;
            int x, y;
            Color Renk;
            int P1, P2, P3, P4, P5, P6, P7, P8, P9;
            for (x = (size - 1) / 2; x < imageWidth - (size - 1) / 2; x++)
            {
                for (y = (size - 1) / 2; y < imageHeight - (size - 1) / 2; y++)
                {
                    Renk = _image.GetPixel(x - 1, y - 1);
                    P1 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = _image.GetPixel(x, y - 1);
                    P2 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = _image.GetPixel(x + 1, y - 1);
                    P3 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = _image.GetPixel(x - 1, y);
                    P4 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = _image.GetPixel(x, y);
                    P5 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = _image.GetPixel(x + 1, y);
                    P6 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = _image.GetPixel(x - 1, y + 1);
                    P7 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = _image.GetPixel(x, y + 1);
                    P8 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = _image.GetPixel(x + 1, y + 1);
                    P9 = (Renk.R + Renk.G + Renk.B) / 3;
                    int Gx = Math.Abs(-P1 + P3 - P4 + P6 - P7 + P9);
                    int Gy = Math.Abs(P1 + P2 + P3 - P7 - P8 - P9); 
                    int PrewittDegeri = 0;
                    PrewittDegeri = Gx;
                    PrewittDegeri = Gy;
                    PrewittDegeri = Gx + Gy; 
                    if (PrewittDegeri > 255) PrewittDegeri = 255;
       
                    image.SetPixel(x, y, Color.FromArgb(PrewittDegeri, PrewittDegeri, PrewittDegeri));
                }
            }
            imagePic.Image = image;

        }


        public Bitmap ImageExtractionBulurImage(Bitmap _image, Bitmap meanFilterImage)
        {
            Color activeColor1, activeColor2, newColor;
            Bitmap image;
            int imageWidth = _image.Width;
            int imageHeight = _image.Height;
            image = new Bitmap(imageWidth, imageHeight);
            int R, G, B;
            double Olcekleme = 2;
            for (int x = 0; x < imageWidth; x++)
            {
                for (int y = 0; y < imageHeight; y++)
                {
                    activeColor1 = _image.GetPixel(x, y);
                    activeColor2 = meanFilterImage.GetPixel(x, y);
                    R = Convert.ToInt16(Olcekleme * Math.Abs(activeColor1.R - activeColor2.R));
                    G = Convert.ToInt16(Olcekleme * Math.Abs(activeColor1.G - activeColor2.G));
                    B = Convert.ToInt16(Olcekleme * Math.Abs(activeColor1.B - activeColor2.B));

                    if (R > 255) R = 255;
                    if (G > 255) G = 255;
                    if (B > 255) B = 255;
                    if (R < 0) R = 0;
                    if (G < 0) G = 0;
                    if (B < 0) B = 0;

                    newColor = Color.FromArgb(R, G, B);
                    image.SetPixel(x, y, newColor);
                }
            }
            return image;
        }

        public Bitmap BorderCombineActiveImage(Bitmap _image, Bitmap borderImage)
        {
            Color activeColor1, activeColor2, newColor;
            Bitmap image;
            int imageWidth = _image.Width;
            int imageHeight = _image.Height;
            image = new Bitmap(imageWidth, imageHeight);
            int R, G, B;
            for (int x = 0; x < imageWidth; x++)
            {
                for (int y = 0; y < imageHeight; y++)
                {
                    activeColor1 = _image.GetPixel(x, y);
                    activeColor2 = borderImage.GetPixel(x, y);
                    R = activeColor1.R + activeColor2.R;
                    G = activeColor1.G + activeColor2.G;
                    B = activeColor1.B + activeColor2.B;
                   
                    if (R > 255) R = 255;
                    if (G > 255) G = 255;
                    if (B > 255) B = 255;
                    if (R < 0) R = 0;
                    if (G < 0) G = 0;
                    if (B < 0) B = 0;
    
                    newColor = Color.FromArgb(R, G, B);
                    image.SetPixel(x, y, newColor);
                }
            }
            return image;
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            SaveForm fr = new SaveForm();
            fr.activeImage = activeImage;
        
            fr.ShowDialog();
        }

        private void SaveImageBtn_Click(object sender, EventArgs e)
        {
            activeImage = new Bitmap(imagePic.Image);
        }

        private void FilterForm_Load(object sender, EventArgs e)
        {
            imagePic.Image = new Bitmap(activeImage); 
        }
    }
}
