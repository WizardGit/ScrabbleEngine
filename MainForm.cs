using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrabbleEngine
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Sort(ref string strLetters)
        {
            List<char> cList = new List<char>();
            int intStarCount = 0;

            foreach (char c in strLetters) 
            {
                if (c == '*')
                    intStarCount++;
                else if (char.IsLetter(c) == true)
                    cList.Add(c);
                else
                    throw new Exception("Invalid Character!");
            }

            for (int i = 0; i < intStarCount; i++)
                cList.Add('*');

            strLetters = new string(cList.ToArray());
        }

        private Boolean WordInLetters(string strWord, string strLetters)
        {
            strWord = strWord.ToLower().Trim();
            Boolean invalidChar;
            char[] cLetters = strLetters.ToCharArray();
            //Console.WriteLine(cLetters[0]);
            //Console.WriteLine(strWord[0]);
            
            foreach (char c in strWord)
            {
                invalidChar = true;
                for (int i = 0; (i < cLetters.Length) && (invalidChar == true); i++) 
                {
                    if (cLetters[i] == c)
                    {
                        cLetters[i] = '-';
                        invalidChar = false;
                    }
                    else if (cLetters[i] == '*')
                    {
                        cLetters[i] = '-';
                        invalidChar = false;
                    }
                }
                if (invalidChar == true)
                {
                    return false;
                }
            }
            return true;
        }

        private void ProcessBtn_Click(object sender, EventArgs e)
        {
            string filePath = "ScrabbleWords.txt";

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Word list file not found.");
                return;
            }

            DisplayListBox.Items.Clear();

            int i = 0;
            ProgressBar.Value = 0;
            ProgressBar.Maximum = 276645;

            string strLetters = LettersTextbox.Text;
            if( strLetters.Length != 7)
            {        
                MessageBox.Show("Must have seven letters!", "Not 7 letters", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            strLetters = strLetters.ToLower().Trim();
            Sort(ref strLetters);

            string strTempLetters;

            // Read words line by line
            using (StreamReader reader = new StreamReader(filePath))
            {
                string word;
                while ((word = reader.ReadLine()) != null)
                {
                    strTempLetters = strLetters;
                    if (WordInLetters(word, strTempLetters) == true)
                    {
                        //Console.WriteLine(word);
                        DisplayListBox.Items.Add(word);
                    }

                    i++;
                    ProgressBar.Value = i;
                    //Console.WriteLine(word); // You can replace this with any logic you want                    
                }
            }

            Console.WriteLine("Done reading all words." + i);
            ProgressBar.Value = 0;
        }
    }
}
