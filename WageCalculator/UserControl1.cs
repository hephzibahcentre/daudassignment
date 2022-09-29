using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WageCalculator
{
    public partial class UserControl1: UserControl
    {
        //Minimum wage by region
        const double minWageAlberta = 15.00;
        const double minWageBritishColumbia = 15.65;
        const double minWageManitoba = 11.95;
        const double minWageNewBr = 11.95;
        const double minWageNewLab = 13.20;
        const double minWageNwT = 15.20;
        const double minWageNovaScotia = 13.35;
        const double minWageNunavut = 16.00;
        const double minWageOntario = 15.00;
        const double minWagePEI = 13.70;
        const double minWageQuebec = 14.25;
        const double minWageSaskatchewan = 11.81;
        const double minWageYukon = 15.70;

        //Input variables
        string inputRegWkHrs = "";
        string inputRegWagePH = "";
        string inputOvWkHrs;
        string inputOvWagePH;

        //Data output variables after calculation
        double displayRegHrs = 0.0;
        double displayOvHrs = 0;
        double displayRegPayTotal = 0.00;
        double displayOvPayTotal = 0.00;
        double displayTotalPay = 0.00;

        public UserControl1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioAlberta_CheckedChanged(object sender, EventArgs e)
        {
            outputMinWageMsg.Text = "The minimum wage in " + radioAlberta.Text + " is $" + String.Format("{0:0.00}", minWageAlberta) + " per hour";
        }

        private void radioBritishColumbia_CheckedChanged(object sender, EventArgs e)
        {
            outputMinWageMsg.Text = "The minimum wage in " + radioBritishColumbia.Text + " is $" + String.Format("{0:0.00}", minWageBritishColumbia) + " per hour";
        }

        private void radioManitoba_CheckedChanged(object sender, EventArgs e)
        {
            outputMinWageMsg.Text = "The minimum wage in " + radioManitoba.Text + " is $" + String.Format("{0:0.00}", minWageManitoba) + " per hour";
        }

        private void radioNewBr_CheckedChanged(object sender, EventArgs e)
        {
            outputMinWageMsg.Text = "The minimum wage in " + radioNewBr.Text + " is $" + String.Format("{0:0.00}", minWageNewBr) + " per hour";
        }

        private void radioNewLab_CheckedChanged(object sender, EventArgs e)
        {
            outputMinWageMsg.Text = "The minimum wage in " + radioNewLab.Text + " is $" + String.Format("{0:0.00}", minWageNewLab) + " per hour";
        }

        private void radioNwT_CheckedChanged(object sender, EventArgs e)
        {
            outputMinWageMsg.Text = "The minimum wage in " + radioNwT.Text + " is $" + String.Format("{0:0.00}", minWageNwT) + " per hour";
        }

        private void radioNovaScotia_CheckedChanged(object sender, EventArgs e)
        {
            outputMinWageMsg.Text = "The minimum wage in " + radioNovaScotia.Text + " is $" + String.Format("{0:0.00}", minWageNovaScotia) + " per hour";
        }

        private void radioNunavut_CheckedChanged(object sender, EventArgs e)
        {
            outputMinWageMsg.Text = "The minimum wage in " + radioNunavut.Text + " is $" + String.Format("{0:0.00}", minWageNunavut) + " per hour";
        }

        private void radioOntario_CheckedChanged(object sender, EventArgs e)
        {
            outputMinWageMsg.Text = "The minimum wage in " + radioOntario.Text + " is $" + String.Format("{0:0.00}", minWageOntario) + " per hour";
        }

        private void radioPEI_CheckedChanged(object sender, EventArgs e)
        {
            outputMinWageMsg.Text = "The minimum wage in " + radioPEI.Text + " is $" + String.Format("{0:0.00}", minWagePEI) + " per hour";
        }

        private void radioQuebec_CheckedChanged(object sender, EventArgs e)
        {
            outputMinWageMsg.Text = "The minimum wage in " + radioQuebec.Text + " is $" + String.Format("{0:0.00}", minWageQuebec) + " per hour";
        }

        private void radioSaskatchewan_CheckedChanged(object sender, EventArgs e)
        {
            outputMinWageMsg.Text = "The minimum wage in " + radioSaskatchewan.Text + " is $" + String.Format("{0:0.00}", minWageSaskatchewan) + " per hour";
        }

        private void radioYukon_CheckedChanged(object sender, EventArgs e)
        {
            outputMinWageMsg.Text = "The minimum wage in " + radioYukon.Text + " is $" + String.Format("{0:0.00}", minWageYukon) + " per hour";
        }

        private void btnCalWkPay_Click(object sender, EventArgs e)
        {
            //Fetching necessary values
            inputRegWkHrs = outputRegWkHrs.Text.ToString();
            inputRegWagePH = outputRegWagePH.Text.ToString();
            inputOvWkHrs = outputOvWkHrs.Text;
            inputOvWagePH = outputOvWagePH.Text.ToString();

            //Calculating and outputing weekly pay
            displayRegHrs = Convert.ToDouble(inputRegWkHrs);
            if (inputOvWkHrs.Length < 1)
            {
                inputOvWkHrs = "0";
                displayOvHrs = Convert.ToInt32(inputOvWkHrs);
            } else
            {
                displayOvHrs = Convert.ToInt32(inputOvWkHrs);
            }
            
            displayRegPayTotal = displayRegHrs * Convert.ToDouble(inputRegWagePH);

            if (inputOvWagePH.Length < 1)
            {
                inputOvWagePH = "0";
                displayOvPayTotal = Convert.ToDouble(displayOvHrs) * Convert.ToDouble(inputOvWagePH);
            }
            else
            {
                displayOvPayTotal = Convert.ToDouble(displayOvHrs) * Convert.ToDouble(inputOvWagePH);
            }
            
            displayTotalPay = displayRegPayTotal + displayOvPayTotal;
            
            outRegH.Text = inputRegWkHrs + " Hrs";
            outOvH.Text = displayOvHrs + " Hrs";
            outRegP.Text = "$" + String.Format("{0:0.00}", displayRegPayTotal).ToString();
            outOvP.Text = "$" + String.Format("{0:0.00}", displayOvPayTotal).ToString();
            outTotalP.Text = "$" + String.Format("{0:0.00}", displayTotalPay).ToString();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
