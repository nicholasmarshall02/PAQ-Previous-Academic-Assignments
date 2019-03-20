using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miles_and_Kilomter_Conversions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double distance = 0;
            double convertedDistance = 0;

            if (double.TryParse(textBoxDistance.Text, out distance))
            {
                if (listBoxFrom.SelectedIndex != -1)
                {
                    if (listBoxTo.SelectedIndex != -1)
                    {
                        if (listBoxFrom.SelectedIndex == 0 && listBoxTo.SelectedIndex == 0)
                        {
                            MessageBox.Show("Select different To unit");
                        }

                        if (listBoxFrom.SelectedIndex == 0 && listBoxTo.SelectedIndex == 1)
                        {
                            convertedDistance = distance / 1.609;
                        }

                        if (listBoxFrom.SelectedIndex == 1 && listBoxTo.SelectedIndex == 0)
                        {
                            convertedDistance = distance * 1.609;
                        }

                        if (listBoxFrom.SelectedIndex == 1 && listBoxTo.SelectedIndex == 1)
                        {
                            MessageBox.Show("Select different To unit");
                        }

                        lblConvertedDistance.Text = convertedDistance.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Must select a unit from To box");
                    }
                }
                else
                {
                    MessageBox.Show("Must select a unit from From box");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number for distance");
            }


        }
    }
}
