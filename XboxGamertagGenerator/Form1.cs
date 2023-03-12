using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace XboxGamertagGenerator
{
    using CrypticWizard.RandomWordGenerator;
    using static CrypticWizard.RandomWordGenerator.WordGenerator; //for brevity, not required

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process myProcess = new Process();

            try
            {
                // true is the default, but it is important not to set it to false
                myProcess.StartInfo.UseShellExecute = true;
                myProcess.StartInfo.FileName = "http://twitter.com/UJlCOS";
                myProcess.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("There was an error opening the url: http://twitter.com/UJlCOS");
            }
        }
        private void generateButton_Click(object sender, EventArgs e)
        {
            Random rndNum = new Random();

            WordGenerator myWordGenerator = new WordGenerator();
            string noun = myWordGenerator.GetWord(PartOfSpeech.noun);
            string adjective = myWordGenerator.GetWord(PartOfSpeech.adj);

            

            string capAdjective = char.ToUpper(adjective[0]) + adjective.Substring(1);
            string capNoun = char.ToUpper(noun[0]) + noun.Substring(1);

            if (capAdjective.Contains("-"))
            {
                //Check for words such as "joy-filled"
                string newWord1 = myWordGenerator.GetWord(PartOfSpeech.adj);
                string newWord2 = char.ToUpper(newWord1[0]) + newWord1.Substring(1);
                capAdjective = capAdjective.Replace(capAdjective, newWord2);
            }

            if (capNoun.Contains("-"))
            {
                //Apparently noun list has words with this.
                string newWord1 = myWordGenerator.GetWord(PartOfSpeech.noun);
                string newWord2 = char.ToUpper(newWord1[0]) + newWord1.Substring(1);
                capNoun = capNoun.Replace(capNoun, newWord2);
            }

            int randomNum = rndNum.Next(10, 99);
            string genNumber = randomNum.ToString();

            gamertagList.Items.Add(String.Format("{0}{1}{2}", capAdjective, capNoun, genNumber));
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            const string sPath = "gamertags.txt";

            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath);
            foreach (var item in gamertagList.Items)
            {
                SaveFile.WriteLine(item);
            }

            SaveFile.Close();

            MessageBox.Show("Gamertags saved to file: gamertags.txt\nThis is located in the same folder as the program.");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            gamertagList.Items.Clear();
        }

        private void generatemultiButton_Click(object sender, EventArgs e)
        {
            generateButton.PerformClick();
            generateButton.PerformClick();
            generateButton.PerformClick();
            generateButton.PerformClick();
            generateButton.PerformClick();
            generateButton.PerformClick();
            generateButton.PerformClick();
            generateButton.PerformClick();
            generateButton.PerformClick();
            generateButton.PerformClick();
            //Such a dirty way to do it, but it works i guess
        }

        private void gamertagList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(this.gamertagList.SelectedItem.ToString());
        }
    }
}