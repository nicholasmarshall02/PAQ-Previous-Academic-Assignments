using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double CalcStayCharges(double days)
        {
            return days * 350.0;
        }

        private double CalcMiscCharges(double medical, double surgical, double lab, double rehab)
        {
            return (medical + surgical + lab + rehab);
        }

        private double CalcTotalCharges(double days, double medical, double surgical, double lab, double rehab)
        {
            return CalcStayCharges(days) + CalcMiscCharges(medical, surgical, lab, rehab);
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            double days, medical, surgical, lab, rehab, stayTotal, totalFees, totalCharges;
            if (double.TryParse(textBoxDays.Text, out days))
            {
                if(double.TryParse(textBoxMedical.Text, out medical))
                {
                    if(double.TryParse(textBoxSurgical.Text, out surgical))
                    {
                        if(double.TryParse(textBoxLab.Text, out lab))
                        {
                            if(double.TryParse(textBoxRehab.Text, out rehab))
                            {
                                stayTotal = CalcStayCharges(days);
                                labelStay.Text = stayTotal.ToString();
                                totalFees = CalcMiscCharges(medical, surgical, lab, rehab);
                                labelMisc.Text = totalFees.ToString();
                                totalCharges = CalcTotalCharges(days, medical, surgical, lab, rehab);
                                labelTotal.Text = totalCharges.ToString();
                            }
                            else
                            {
                                MessageBox.Show("Invalid entry for rehab");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid entry for surgical");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid entry for surgical");
                    } 
                }
                
                else
                {
                    MessageBox.Show("Invalid entry for medical");
                }
            }
            else
            {
                MessageBox.Show("Invalid entry for days");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxDays.Clear();
            textBoxMedical.Clear();
            textBoxSurgical.Clear();
            textBoxLab.Clear();
            textBoxRehab.Clear();
            labelStay.Text = "";
            labelMisc.Text = "";
            labelTotal.Text = "";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
