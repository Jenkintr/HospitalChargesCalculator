using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalCharges
{
    public partial class HospitalCharges : Form
    {
        public HospitalCharges()
        {
            InitializeComponent();
        }

        /**
         * The InputIsValid method converts the user input and stores it in the arguments (passed by reference). 
         * If the conversion is successful, the method returns true. Otherwise it retursn false.
         * @parms ref double daysSpent, ref double medCharges, ref double surgCharges, ref double labFees,
         *        ref double rehabCharges
         * @returns bool 
         */
        private bool InputIsValid(ref double daysSpent, ref double medCharges, ref double surgCharges, ref double labFees, ref double rehabCharges)
        {
            //Flag variable to indicate whether the input is good
            bool inputGood = false;

            //Try to convert inputs
            //Get daysSpent
            if (double.TryParse(daysSpentTextbox.Text, out daysSpent))
            {
                //Get medCharges
                if (double.TryParse(medChargesTextbox.Text, out medCharges))
                {
                    //Get surgCharges
                    if (double.TryParse(surgChargesTextbox.Text, out surgCharges))
                    {
                        //Get labFees
                        if (double.TryParse(labFeesTextbox.Text, out labFees))
                        {
                            //Get rehabCharges
                            if (double.TryParse(rehabChargesTextbox.Text, out rehabCharges))
                            {
                                //All inputs are good
                                inputGood = true;
                            }
                            else
                            {
                                //Display an error Message
                                MessageBox.Show("Invalid input for Amount of Rehab Charges.");
                            };
                        }
                        else
                        {
                            //display error message
                            MessageBox.Show("Invalid input for Amount of Lab Fees.");
                        }
                    }
                    else
                    {
                        //display error message
                        MessageBox.Show("Invalid input for Amount of Surgical Charges.");
                    }
                }
                else
                {
                    //display error message
                    MessageBox.Show("Invalid input for Amount of Medical Charges.");
                }
            }
            else
            {
                //display error message
                MessageBox.Show("Invalid input for Days Spent in Hospital.");
            }

            //return the result
            return inputGood;

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Variables to hold the user input
            double daysSpent = 0;
            double medCharges = 0;
            double surgCharges = 0;
            double labFees = 0;
            double rehabCharges = 0;

            //Variables for Calculations:
            double stay;
            double misc;
            double total;

            if (InputIsValid(ref daysSpent, ref medCharges, ref surgCharges, ref labFees, ref rehabCharges))
            {
                //Calculate charges:
                stay = CalcStayCharges(daysSpent);
                misc = CalcMiscCharges(medCharges, surgCharges, labFees, rehabCharges);                
                total = CalcTotalCharges(stay, misc);

                //Display output:
                stayChargesOutputLabel.Text = stay.ToString("c");
                miscChargesOutputLabel.Text = misc.ToString("c");
                totalChargesOutputLabel.Text = total.ToString("c");
            }
            
        }

        /**
        * This method calculates the overall total of medication, surgical, lab, rehab charges, and stay total.
        * @parms double stay, double misc
        * @returns double overallTotal
        */
        private double CalcTotalCharges(double stay, double misc)
        {
            double overallTotal;
            overallTotal = stay + misc;
            return overallTotal;
        }

        /**
        * This method calculates the total of medication, surgical, lab, and rehab charges.
        * @parms double medCharges, double surgCharges, double labFees, double rehabCharges
        * @returns double miscTotal
        */
        private double CalcMiscCharges(double medCharges, double surgCharges, double labFees, double rehabCharges )
        {
           double miscTotal;
           miscTotal = medCharges + surgCharges + labFees + rehabCharges;
           return miscTotal;
        }

        /**
        * This method calculates the total charges for the hospital stay based off of the user input.
        * @parms double daysSpent
        * @returns doubles stayTotal
        */
        private double CalcStayCharges(double daysSpent)
        {
            double stayTotal;
            stayTotal = daysSpent * 350;
            return stayTotal;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close the Form
            this.Close();
        }
    }
}
