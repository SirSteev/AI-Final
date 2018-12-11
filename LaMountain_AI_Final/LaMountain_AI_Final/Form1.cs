using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LaMountain_AI_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pbImageToMatch.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            pbImage.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
        }

        OpenFileDialog ofd = new OpenFileDialog();
        GeneticAlgorithm ga;
        DateTime timeStart;

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            ofd.Filter = "PNG|*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbImage.Image = Bitmap.FromFile(ofd.FileName);
                ga = new GeneticAlgorithm((Bitmap)pbImage.Image);
                ga.CalcFitnesses();
                btnRunGA.Enabled = true;
                pbImageToMatch.Image = ga.GetBestCitizen();
                tbFitnessVal.Text = ga.GetBestCitizenFitness().ToString();
                tbGenoration.Text = ga.Generation.ToString();
                
            }
        }

        private void btnRunGA_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            btnRunGA.Enabled = false;
            btnOpenFile.Enabled = false;

            timeStart = DateTime.Now;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ga.NextGeneration();
            pbImageToMatch.Image = ga.GetBestCitizen();
            tbFitnessVal.Text = ga.GetBestCitizenFitness().ToString();
            tbGenoration.Text = ga.Generation.ToString();

            if (ga.GetBestCitizenFitness() == 0)
            {
                timer1.Enabled = false;
                btnRunGA.Enabled = true;
                btnOpenFile.Enabled = true;
            }

            int elapsedTime = (int)DateTime.Now.Subtract(timeStart).TotalSeconds;
            tbElapsedTime.Text = elapsedTime / 60 / 60 + " : " + elapsedTime / 60 % 60 + " : " + elapsedTime % 60;
        }

        private void btnStopGA_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            btnOpenFile.Enabled = true;
            if (pbImage.Image != null) btnRunGA.Enabled = true;
        }
    }
}
