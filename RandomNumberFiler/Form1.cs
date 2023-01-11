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
using static System.Net.Mime.MediaTypeNames;
using System.Security.Cryptography;

namespace RandomNumberFiler
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private int Turnintoint(string inputstring, int biggerthen)
        {
            int inputnum;
            bool passesdparse = int.TryParse(inputstring, out inputnum);
            if (passesdparse && inputnum > biggerthen) { return inputnum; }
            else { return biggerthen - 1; }
        }

        
        private void Isempty(string inputstr)
        {
            if (inputstr == "")
            {
                startBUT.Text = "Start";
                startBUT.Enabled = false;
            }
            else
            {
                startBUT.Text = "Please input a number 1-10!";
                startBUT.Enabled = false;
            }
        }

        private void startBUT_Click(object sender, EventArgs e)
        {
            //make sure that the user input a number in the textbox
            int numoflines = Turnintoint(inputTB.Text, 0);
            if (numoflines != -1)
            {
                //make the file that will be writen into
                using (StreamWriter outputFile = File.CreateText(System.Windows.Forms.Application.StartupPath + "randomnumbers.txt"))
                {
                    //the for loop
                    for (int i = 0; i < numoflines; i++)
                    {
                        //make list of number stuff because in my testing that worked
                        //compond randoms to make it more random
                        outputFile.WriteLine(RandomNumber.Between(0, 99).ToString());
                    }
                }
                //reread the file
                using (StreamReader readed = new StreamReader(System.Windows.Forms.Application.StartupPath + "randomnumbers.txt"))
                {
                    //read it all
                    string readstuff = readed.ReadToEnd();
                    //this doesin't remove it, do you know why?
                    readstuff = readstuff.Replace("\n", "");
                    //show user
                    MessageBox.Show($"The contents of this are:\n{readstuff}");
                }
            }
        }
    }

    public static class RandomNumber
    {
        private static readonly RNGCryptoServiceProvider _generator = new RNGCryptoServiceProvider();
        public static int Between(int minimumValue, int maximumValue)
        {
            byte[] randomNumbers = new byte[1];
            _generator.GetBytes(randomNumbers);
            double asciiValueOfRandomCharacter = Convert.ToDouble(randomNumbers[0]);
            double multiplier = Math.Max(0, (asciiValueOfRandomCharacter / 255d) - 0.00000000001d);
            int range = (maximumValue - 1) - minimumValue;
            double randomValueInRange = Math.Floor(multiplier * range);
            return (int)(minimumValue + randomValueInRange);
        }
    }

}
