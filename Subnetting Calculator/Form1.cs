using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subnetting_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.subnettingTypeComboBox.SelectedIndex = 0;
        }

        private void onlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.')) 
            {
                e.Handled = true;
            }
        }

        private void firstOctectTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
        }

        private void scondOctectTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
        }

        private void thirdOctectTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
        }

        private void fourthOctectTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
        }

        private void maskTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
        }

        private void numberRequestedTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            this.resultTxtBox.Text = "";
            String ipC = "";
            try
            {
                if (Int32.Parse(maskTxtBox.Text) <= 8)
                {
                    ipC = "A";
                }
                else if (Int32.Parse(maskTxtBox.Text) > 8 && Int32.Parse(maskTxtBox.Text) <= 16)
                {
                    ipC = "B";
                }
                else if (Int32.Parse(maskTxtBox.Text) > 16 && Int32.Parse(maskTxtBox.Text) <= 24)
                {
                    ipC = "C";
                }
                Calculator calc = new Calculator(Int32.Parse(firstOctectTxtBox.Text), Int32.Parse(scondOctectTxtBox.Text),
                                                 Int32.Parse(thirdOctectTxtBox.Text), Int32.Parse(fourthOctectTxtBox.Text),
                                                 Int32.Parse(maskTxtBox.Text), Int32.Parse(numberRequestedTxtBox.Text), ipC);
                ArrayList res = null;
                if (subnettingTypeComboBox.SelectedIndex == 0)
                {
                    res = calc.calculateBySubNets();
                }
                else
                {
                    res = calc.calculateByHosts();
                }
                Result resI;
                address nMask = (address)res[res.Count - 1];
                resultTxtBox.AppendText("New Mask: " + nMask.toString() + "\n");
                for (int i = 0; i < res.Count - 1; i++)
                {
                    resI = (Result)res[i];
                    resultTxtBox.AppendText("\nSubnet: " + resI.getNetwork().toString());
                    resultTxtBox.AppendText("\nFirst IP Usable: " + resI.getFirst().toString());
                    resultTxtBox.AppendText("\nLast IP Usable: " + resI.getLast().toString());
                    resultTxtBox.AppendText("\nBroadcast: " + resI.getBroad().toString());
                    resultTxtBox.AppendText("\n\n");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Plz enter your Correct , IPs And Host");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
