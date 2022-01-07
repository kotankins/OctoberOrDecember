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

namespace OctoberOrDecember
{
    public partial class Form1 : Form
    {
        List<float> decemberLowTemp = new List<float>();
        List<float> octoberLowTemp = new List<float>();
        List<float> decemberHighTemp = new List<float>();
        List<float> octoberHighTemp = new List<float>();

        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
           

        }//end of load

        private void buttonOctober_Click(object sender, EventArgs e)
        {
            try {
                octoberLowTemp.Add(float.Parse(textBoxLowTempInput.Text));
                octoberHighTemp.Add(float.Parse(textBoxHighTempInput.Text));
            }
            catch (Exception ex) {
                MessageBox.Show("Cannot understand your input. Please, tyr again.");
            }

            textBoxHighTempInput.Text = "";
            textBoxLowTempInput.Text = "";

            if ((octoberLowTemp.Count>0) && (decemberLowTemp.Count>0)) {
                buttonCalculate.Enabled = true;
            }
        }//end of october click

        private void buttonDecember_Click(object sender, EventArgs e)
        {
            try
            {
                decemberLowTemp.Add(float.Parse(textBoxLowTempInput.Text));
                decemberHighTemp.Add(float.Parse(textBoxHighTempInput.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot understand your input. Please, tyr again.");
            }

            textBoxHighTempInput.Text = "";
            textBoxLowTempInput.Text = "";

            if ((octoberLowTemp.Count > 0) && (decemberLowTemp.Count > 0))
            {
                buttonCalculate.Enabled = true;
            }
        }//end of december click

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            float octoberLowMiddle = -999;
            float decemberLowMiddle = -999;
            float octoberHighMiddle = -999;
            float decemberHighMiddle = -999;

            float distanceToDecember = 0;
            float distanceToOctober = 0;

            float lowTemp = -999;
            float highTemp = -999;

            string outcome = "";

            octoberLowMiddle = findAverage(octoberLowTemp);
            decemberLowMiddle = findAverage(decemberLowTemp);
            octoberHighMiddle = findAverage(octoberHighTemp);
            decemberHighMiddle = findAverage(decemberHighTemp);

            try {
                lowTemp = float.Parse(textBoxEnterLowTempInput.Text);
                highTemp = float.Parse(textBoxEnterHighTempInput.Text);
            }
            catch (Exception ex) {
                MessageBox.Show("Something wrong with your temperature. Please try again.");
            }


            distanceToDecember = distance(lowTemp, highTemp, decemberLowMiddle, decemberHighMiddle);
            distanceToOctober = distance(lowTemp, highTemp, octoberLowMiddle, octoberHighMiddle);

            if (distanceToDecember > distanceToOctober)
            {
                outcome = "October";
            }
            else {
                outcome = "December";    
            }

            labelAIThouthsOutput.Text = outcome;


        }//end of finding the month

        private float distance(float x1, float y1, float x2, float y2)
        {
            double sqDist = (x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2);
            double dist = Math.Pow(sqDist , 0.5);
            return (float)dist;
        }

        private float findAverage(List<float> tempList)
        {
            float average = -999;
            float sum = 0;

            for (int i = 0; i < tempList.Count; i++) {
                sum += tempList[i];
            }

            average = sum / tempList.Count;

            return average;
        }

       

        private void loadData(string fileName, List<float> tempList)
        {
            //load list from file
            float nextTemp = -999;
            try
            {
                StreamReader inputFile = new StreamReader(fileName);

                while (!inputFile.EndOfStream)
                {
                    nextTemp = float.Parse(inputFile.ReadLine());
                    tempList.Add(nextTemp); ;
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't find file");
            }

            //check that other lists are not empty, if not empty, enable testing button
            if ((decemberHighTemp.Count > 0) && (decemberLowTemp.Count > 0) && (octoberHighTemp.Count > 0) && (octoberLowTemp.Count > 0))
            {
                buttonCalculate.Enabled = true;
                buttonCorrect.Enabled = true;
                buttonIncorrect.Enabled = true;
            }

        }
         private void buttonLoadHighDec_Click(object sender, EventArgs e)
         {
            loadData("DecHighTemp.txt", decemberHighTemp);
         
            loadData("DecLowTemp.txt", decemberLowTemp);
       
            loadData("OctHighTemp.txt", octoberHighTemp);
       
            loadData("OctLowTemp.txt", octoberLowTemp);
        }

        private void buttonCorrect_Click(object sender, EventArgs e)
        {
            try
            {
                if (labelAIThouthsOutput.Text == "October")
                {
                    octoberLowTemp.Add(float.Parse(textBoxEnterLowTempInput.Text));
                    octoberHighTemp.Add(float.Parse(textBoxEnterHighTempInput.Text));
                }
                else
                {
                    decemberLowTemp.Add(float.Parse(textBoxEnterLowTempInput.Text));
                    decemberHighTemp.Add(float.Parse(textBoxEnterHighTempInput.Text));
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Not valid value");
            }
        }

        private void buttonIncorrect_Click(object sender, EventArgs e)
        {
            try { 
              if (labelAIThouthsOutput.Text == "December")
                {
                    octoberLowTemp.Add(float.Parse(textBoxEnterLowTempInput.Text));
                    octoberHighTemp.Add(float.Parse(textBoxEnterHighTempInput.Text));
                }
                else
                {
                    decemberLowTemp.Add(float.Parse(textBoxEnterLowTempInput.Text));
                    decemberHighTemp.Add(float.Parse(textBoxEnterHighTempInput.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not valid value");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float midOctH = findAverage(octoberHighTemp);
            float midOctL = findAverage(octoberLowTemp);
            float midDecH = findAverage(decemberHighTemp);
            float midDecL = findAverage(decemberLowTemp);
            MessageBox.Show("October High Temp Average: " + midOctH.ToString() + " October Low Temp Average: " + midOctL.ToString() + " December High Temp Average:  " + midDecH.ToString() + "December Low Temp Average:  " + midDecL.ToString());
        }
    }
}
