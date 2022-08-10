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
    public partial class TempRes : Form
    {

        public TempRes()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int count;

            try
            {
                StreamWriter outputFile;
                count = lsbOutput.Items.Count;

                if (saveF.ShowDialog() == DialogResult.OK && chbConfirm.Checked)
                {
                    outputFile = File.CreateText(saveF.FileName);

                    for (int i = 0; i < count - 2; i++)
                    {
                        lsbOutput.SelectedIndex = i;
                        outputFile.WriteLine(lsbOutput.SelectedItem);
                    }

                    outputFile.Close();
                    Clear();
                    lsbOutput.Items.Add("Items saved to file successfully.");
                    lblSaved.Visible = true;
                    lsbOutput.Items.Add("");
                    lsbOutput.Items.Add("Please load file.");
                }
                else
                {
                    MessageBox.Show("Save file cancelled. Make sure confirm box checked.");
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            lsbOutput.Items.Add("Please load file.");
        }

        private void Clear()
        {
            Temp formTemp = new Temp();

            formTemp.lblLoaded.Visible = false;
            lblSaved.Visible = false;
            chbConfirm.Checked = false;
            lsbOutput.Items.Clear();
        }
    }
}
