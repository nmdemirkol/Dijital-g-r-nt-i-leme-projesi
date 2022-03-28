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
    public partial class PreprocessingTwoForm : Form
    {
        public Bitmap activeImage;
      
        private double[] frekans = new double[256];
        private double[] possibility = new double[256];
        private double[] cumulative = new double[256];
        private double[] round = new double[256];
        private double[] newPixel = new double[256];

        

        public PreprocessingTwoForm()
        {
            InitializeComponent();
        }

        private void PreprocessingTwoForm_Load(object sender, EventArgs e)
        {
            preprocessingCmb.Enabled = false;
            preprocessingCmb.SelectedIndex = 0;
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
            histogramSyncGroupBox.Visible = false;
            equalizationGroupBox.Visible = false;
            quantizationGroupBox.Visible = false;

        }
        private void preprocessingCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            AllGroupBoxVisble();
            if (preprocessingCmb.SelectedIndex == 1)
            {
                histogramSyncGroupBox.Visible = true;
                HistogramChart();
                imagePic.Image = activeImage;
            }
            else if(preprocessingCmb.SelectedIndex == 2)
            {
                equalizationGroupBox.Visible = true;

                

                NewImageCreate();
                EqualizationChart();
            }
            else if (preprocessingCmb.SelectedIndex == 3)
            {
                quantizationGroupBox.Visible = true;

            }

        }

        private void FrekansReset()
        {
            for (int i = 0; i < frekans.Length; i++)
            {
                frekans[i] = 0;
            }
        }

        private void cumulativeCalculate()
        {

        }

        private void FrekansCalculate()
        {
            FrekansReset();
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
                    frekans[r]++;


                }
                progressBar.Value = x + y;
            }

         
        }

        private void EqualizationFrekansCalculate()
        {
            FrekansReset();
            Bitmap _image = new Bitmap(imagePic.Image);
           


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
                    frekans[r]++;


                }
                progressBar.Value = x + y;
            }


        }


        private void PossibilityCalculate()
        {
            Bitmap _image = new Bitmap(activeImage);
            for (int i = 0; i < frekans.Length; i++)
            {
                possibility[i] = frekans[i] / (_image.Width * _image.Height);
            }
        }

        private void CumulativeCalculate()
        {
            Bitmap _image = new Bitmap(activeImage);
            for (int i = 0; i < cumulative.Length; i++)
            {
                if (i==0)
                {
                    cumulative[i] = possibility[i];
                }
                else
                {
                    cumulative[i] = possibility[i] + cumulative[i-1];
                }
                
            }
        }

        private void RoundCalculate()
        {
        
            for (int i = 0; i < round.Length; i++)
            {

       
               
                  round[i] = cumulative[i] * 255;
            }
        }

        private void HistogramChart()
        {

            histogramChart.Series["Pixel Color"].Points.Clear();
            FrekansCalculate();
            PossibilityCalculate();
            progressBar.Minimum = 0;
            progressBar.Maximum = possibility.Length-1;
            progressBar.Value = 0;
            for (int i = 0; i < possibility.Length; i++)
            {
                histogramChart.Series["Pixel Color"].Points.AddXY(i.ToString(), possibility[i]);
                
                histogramChart.ChartAreas[0].AxisY.LabelStyle.Format = "0.00";

                progressBar.Value = i;
            }





        }

        private void NewPixel()
        {
            for (int i = 0; i < newPixel.Length; i++)
            {
                newPixel[i] = Math.Round(round[i]);
            }
            
        }


        private void EqualizationChart()
        {

            EqualizationFrekansCalculate();
            PossibilityCalculate();

            equalizationCharta.Series["Pixel Color"].Points.Clear();

            progressBar.Minimum = 0;
            progressBar.Maximum = possibility.Length - 1;
            progressBar.Value = 0;
            for (int i = 0; i < possibility.Length; i++)
            {
                equalizationCharta.Series["Pixel Color"].Points.AddXY(i.ToString(), possibility[i]);

                equalizationCharta.ChartAreas[0].AxisY.LabelStyle.Format = "0.00";

                progressBar.Value = i;
            }



        }


        private void NewImageCreate()
        {
            FrekansCalculate();
            PossibilityCalculate();
            CumulativeCalculate();
            RoundCalculate();
            NewPixel();
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
                  

                    int grayValue = int.Parse( newPixel[r].ToString());
                    Color newColor = Color.FromArgb(grayValue, grayValue, grayValue);

                    _image.SetPixel(x, y, newColor);

                }
                progressBar.Value = x + y;
            }

            imagePic.Image = _image;
           
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            FilterForm fr = new FilterForm();
            fr.activeImage = activeImage;
    
            fr.ShowDialog();
        }

        private void quantizationBtn_Click(object sender, EventArgs e)
        {
            double tonsValue = double.Parse( tonsNum.Value.ToString());
            int[] _newPixel = new int[256];
        

            for (int i = 0; i < frekans.Length; i++)
            {
                double a = ((frekans[i] + 1) / tonsValue) * 8;
                _newPixel[i] = int.Parse(Math.Round(a).ToString());
                
            }
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
                    double a = ((r ) / (tonsValue)) ;
                    double a2 = (Math.Floor(a) * ( tonsValue));
                    int grayValue = int.Parse(Math.Round(a2).ToString());

                 
                    Color newColor = Color.FromArgb(grayValue, grayValue, grayValue);

                    _image.SetPixel(x, y, newColor);

                }
                progressBar.Value = x + y;
            }

            imagePic.Image = _image;
        }

        private void SaveImageBtn_Click(object sender, EventArgs e)
        {
            activeImage = new Bitmap(imagePic.Image);
        }
    }
}
