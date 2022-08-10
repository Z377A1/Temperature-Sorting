using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Creative_Temperature_List
{
    public partial class Temp : Form
    {
        private TempRes formRes = new TempRes();

        public Temp()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            const double tempNormal = 36.0;
            double temp, max = tempNormal, min = tempNormal, sum = 0;
            int count = 0;

            try
            {
                StreamReader inputFile;

                inputFile = File.OpenText("list.txt");

                while (!inputFile.EndOfStream)
                {
                    temp = double.Parse(inputFile.ReadLine());

                    min = Min(min, temp);
                    max = Max(max, temp);

                    sum += temp;
                    count++;
                }

                lblLoaded.Visible = true;
                inputFile.Close();

                formRes.lsbOutput.Items.Add("From a list of " + count + " temperatures from list...");
                formRes.lsbOutput.Items.Add("");
                formRes.lsbOutput.Items.Add("Highest: " + max + " degrees celsius.");
                formRes.lsbOutput.Items.Add("Lowest: " + min + " degrees celsius.");
                formRes.lsbOutput.Items.Add("Average: " + (sum / count) + " degrees celsius.");
                formRes.lsbOutput.Items.Add("Difference in temperature: " + (max - min) + " degrees celsius.");
                formRes.lsbOutput.Items.Add("");
                formRes.lsbOutput.Items.Add("Want to save these results to a text file? Just click the save button.");
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private double Min(double min, double temp)
        {
            if (temp < min)
            {
                min = temp;
            }

            return min;
        }

        private double Max(double max, double temp)
        {
            if (temp > max)
            {
                max = temp;
            }

            return max;
        }

        private void Temp_Load(object sender, EventArgs e)
        {
            if (formRes.Visible == false)
            {
                formRes.Show();
            }
        }

        private void rbYes_CheckedChanged(object sender, EventArgs e)
        {
            formRes.btnSave.Visible = true;
            formRes.chbConfirm.Visible = true;
        }

        private void rbNo_CheckedChanged(object sender, EventArgs e)
        {
            formRes.btnSave.Visible = false;
            formRes.chbConfirm.Visible = false;
        }
    }
}
