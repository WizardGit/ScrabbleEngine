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

/*
 * TODO:
 * Have a way to sort my length / points scored
 * You'll need to create some way to store points per letter
 */

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

        private void CreateMask(ref int pIntMinLength, ref bool pBlnIsMask, string pStrMask)
        {
            for (int i = pStrMask.Length - 1; i >= 0; i--)
            {
                pIntMinLength = i + 1;

                char c = pStrMask[i];
                if (c != '-')
                {
                    pBlnIsMask = true;
                    break;
                }
            }
        }

        private Boolean WordInLetters(string strWord, string strLetters, int intMinLength = 0, bool blnIsMask = false, string strMask = "-------")
        {
            if (strWord.Length < intMinLength)
                return false;

            strWord = strWord.ToLower().Trim();
            Boolean invalidChar;
            char[] cLetters = strLetters.ToCharArray();

            for (int intLetter = 0;  intLetter < strWord.Length; intLetter++)
            {
                char c = strWord[intLetter];

                if (blnIsMask == true)
                {
                    if ((strMask[intLetter] != '-') && (c != strMask[intLetter]))
                    {
                        return false;
                    }
                }                    

                invalidChar = true;
                for (int i = 0; (i < cLetters.Length) && (invalidChar == true); i++)
                {

                    if ((cLetters[i] == c) || (cLetters[i] == '*'))
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

            string strLetters = LettersTextbox.Text;
            string strMask = MaskTextBox.Text;
            if ( strLetters.Length != 7)
            {        
                MessageBox.Show("Must have seven letters!", "Not 7 letters", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (strMask.Length != 7)
            {
                MessageBox.Show("Must have seven letters in mask!", "Not 7 letters", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            int intMinLength = 0;
            bool blnIsMask = false;
            CreateMask(ref intMinLength, ref blnIsMask, strMask);
                        

            strLetters = strLetters.ToLower().Trim();
            Sort(ref strLetters);

            string strTempLetters;
            ProgressBar.Value = 0;
            ProgressBar.Maximum = 276645;
            int intProgressValue = 0;

            DisplayListBox.Items.Clear();

            // Read words line by line
            using (StreamReader reader = new StreamReader(filePath))
            {
                string word;
                while ((word = reader.ReadLine()) != null)
                {
                    strTempLetters = strLetters;
                    if (WordInLetters(word, strTempLetters, intMinLength, blnIsMask, strMask) == true)
                    {
                        //Console.WriteLine(word);
                        DisplayListBox.Items.Add(word);
                    }

                    intProgressValue++;
                    ProgressBar.Value = intProgressValue;
                    //Console.WriteLine(word); // You can replace this with any logic you want                    
                }
            }

            Console.WriteLine("Done reading all words." + intProgressValue);
            ProgressBar.Value = 0;
        }
    }
}
