using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace ConverterApp
    // This program was written by Gail Mosdell
    // Modified by Zachary Chang-Leng
    // It forms the base of a converter program for the OS-Assessment Two for Cert IV
    // Date : February 2017
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        // Global Variables and Constants
        double dbl_UofM;
        double[] dbl_Convert = new double[5];
        int cnt = 0;

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_CM_to_Inches_Click(object sender, EventArgs e)
        {
            const double CM_TO_INCH = 0.3937;

            // validate user entry and convert to a double

            if (!double.TryParse(txt_UnitOfMeasure.Text, out dbl_UofM))
            {
                // Clears all for re-attempt and tells user to retry
                MessageBox.Show("A numeric must be entered. Please re-enter the value.");
                txt_UnitOfMeasure.Clear();
                txt_UnitOfMeasure.Focus();
                txt_Convert.Clear();
                lbl_Convert.Text = "";
                lbl_Display.Text = "";
            }
            else
            {
                if (cnt < 5)
                {
                    // Conversion equation and displaying of results from conversion to inches from centimetres
                    dbl_Convert[cnt] = dbl_UofM * CM_TO_INCH;
                    txt_Convert.Text = dbl_Convert[cnt].ToString();
                    lbl_Display.Text = txt_UnitOfMeasure.Text + " centimetres is converted to ";
                    lbl_Convert.Text = " inches.";
                    cnt++;
                }

                else 
                {
                    // Takes readings and adds to listbox
                    for (int i = 0; i < cnt; i++)
                    {
                        readingsBox.Items.Add(dbl_Convert[i]);
                    }
                }
            }
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {

        }

        private void btn_C_to_Feet_Click(object sender, EventArgs e)
        {
            const double CM_TO_FEET = 0.0328084;

            // validate user entry and convert to a double

            if (!double.TryParse(txt_UnitOfMeasure.Text, out dbl_UofM))
            {
                // Clears all for re-attempt and tells user to retry
                MessageBox.Show("A numeric must be entered. Please re-enter the value.");
                txt_UnitOfMeasure.Clear();
                txt_UnitOfMeasure.Focus();
                txt_Convert.Clear();
                lbl_Convert.Text = "";
                lbl_Display.Text = "";
            }
            else
            {
                if (cnt < 5)
                {
                    // Conversion equation and displaying of results from conversion to feet from centimetres
                    dbl_Convert[cnt] = dbl_UofM * CM_TO_FEET;
                    txt_Convert.Text = dbl_Convert[cnt].ToString();
                    lbl_Display.Text = txt_UnitOfMeasure.Text + " centimetres is converted to ";
                    lbl_Convert.Text = " feet.";
                    cnt++;
                }
                else
                {
                    // Takes readings and adds to listbox
                    for (int i = 0; i < cnt; i++)
                    {
                        readingsBox.Items.Add(dbl_Convert[i]);
                    }
                }
            }
        }

        private void btn_K_to_Miles_Click(object sender, EventArgs e)
        {
            const double K_TO_MILES = 0.621371;

            // validate user entry and convert to a double

            if (!double.TryParse(txt_UnitOfMeasure.Text, out dbl_UofM))
            {
                // Clears all for re-attempt and tells user to retry
                MessageBox.Show("A numeric must be entered. Please re-enter the value.");
                txt_UnitOfMeasure.Clear();
                txt_UnitOfMeasure.Focus();
                txt_Convert.Clear();
                lbl_Convert.Text = "";
                lbl_Display.Text = "";
            }
            else
            {
                if (cnt < 5)
                {
                    // Conversion equation and displaying of results from conversion to miles from kilometres
                    dbl_Convert[cnt] = dbl_UofM * K_TO_MILES;
                    txt_Convert.Text = dbl_Convert[cnt].ToString();
                    lbl_Display.Text = txt_UnitOfMeasure.Text + " kilometres is converted to ";
                    lbl_Convert.Text = " miles.";
                    cnt++;
                }
                else
                {
                    // Takes readings and adds to listbox
                    for (int i = 0; i < cnt; i++)
                    {
                        readingsBox.Items.Add(dbl_Convert[i]);
                    }
                }
            }
        }

        private void btn_C_to_Fahrenheit_Click(object sender, EventArgs e)
        {
            const double C_TO_FAHREN = (1.8);

            // validate user entry and convert to a double

            if (!double.TryParse(txt_UnitOfMeasure.Text, out dbl_UofM))
            {
                // Clears all for re-attempt and tells user to retry
                MessageBox.Show("A numeric must be entered. Please re-enter the value.");
                txt_UnitOfMeasure.Clear();
                txt_UnitOfMeasure.Focus();
                txt_Convert.Clear();
                lbl_Convert.Text = "";
                lbl_Display.Text = "";
            }
            else
            {
                if (cnt < 5)
                {
                    // Conversion equation and displaying of results from conversion to fahrenheit from celsius
                    dbl_Convert[cnt] = dbl_UofM * C_TO_FAHREN + 32;
                    txt_Convert.Text = dbl_Convert[cnt].ToString();
                    lbl_Display.Text = txt_UnitOfMeasure.Text + " celsius is converted to ";
                    lbl_Convert.Text = " fahrenheit.";
                    cnt ++;
                }
                else
                {
                    // Takes readings and adds to listbox
                    for (int i = 0; i < cnt; i++)
                    {
                        readingsBox.Items.Add(dbl_Convert[i]);
                    }
                }
            }
        }

        private void txt_UnitOfMeasure_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_M_to_Feet_Click(object sender, EventArgs e)
        {
            const double M_TO_FEET = 3.28084;

            // validate user entry and convert to a double

            if (!double.TryParse(txt_UnitOfMeasure.Text, out dbl_UofM))
            {
                // Clears all for re-attempt and tells user to retry
                MessageBox.Show("A numeric must be entered. Please re-enter the value.");
                txt_UnitOfMeasure.Clear();
                txt_UnitOfMeasure.Focus();
                txt_Convert.Clear();
                lbl_Convert.Text = "";
                lbl_Display.Text = "";
            }
            else
            {
                if (cnt < 5)
                {
                    // Conversion equation and displaying of results from conversion to feet from metres
                    dbl_Convert[cnt] = dbl_UofM * M_TO_FEET;
                    txt_Convert.Text = dbl_Convert[cnt].ToString();
                    lbl_Display.Text = txt_UnitOfMeasure.Text + " metres is converted to ";
                    lbl_Convert.Text = " feet.";
                    cnt++;
                }
                else
                {
                    // Takes readings and adds to listbox
                    for (int i = 0; i < cnt; i++)
                    {
                        readingsBox.Items.Add(dbl_Convert[i]);
                    }
                }
            }
        }

        private void readingsBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Clear_All_Click(object sender, EventArgs e)
        {
            // Clears listbox and array
            readingsBox.Items.Clear();
        }
    }
}
