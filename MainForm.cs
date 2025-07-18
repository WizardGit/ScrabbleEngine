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
 * allow mask letters to be multiple different letters
 */

namespace ScrabbleEngine
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SortComboBox.SelectedIndex = 0;
        }

        private bool blnSortAscending = true;
        private List<Word> lstWords;
        public const char charNoLetter = '-';
        public const char charAnyLetter = '*';

        private void LineCheck(string pstrMask, string pstrLetters, out List<Word> pLstStrWords)
        {
            ProgressBar.Value = 0;
            ProgressBar.Maximum = 276645 * pstrMask.Length;
            int intProgressValue = 0;

            ReturnScrabbleDictionary(out List<string> dictWords);

            pLstStrWords = new List<Word>();

            for (int i = 0; i < pstrMask.Length; i++)
            {
                Word debugWord = new Word("Words start at Index " + i.ToString());
                debugWord.AddToList(ref pLstStrWords);

                foreach (string word in dictWords)
                {
                    Word scrabbleWord = new Word(word);
                    if (scrabbleWord.WordMatchMask(i, pstrMask, pstrLetters, true) == true)
                    {
                        scrabbleWord.AddToList(ref pLstStrWords);
                    }

                    ProgressBar.Value = intProgressValue++;                  
                }                
            }
        }

        private void CreateAllWords(string pstrMask, string pstrLetters, out List<Word> pLstStrWords)
        {
            ReturnScrabbleDictionary(out List<string> dictWords);
            pLstStrWords = new List<Word>();

            if (pstrLetters.Length != 7)
            {
                MessageBox.Show("Must have seven letters!", "Not 7 letters", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int intMinLength = 0;
            int intMaxLength = pstrMask.Length;
            bool blnIsMask = false;
            CreateMask(ref intMinLength, ref blnIsMask, pstrMask);

            pstrLetters = pstrLetters.ToLower().Trim();
            Sort(ref pstrLetters);

            string strTempLetters;
            ProgressBar.Value = 0;
            ProgressBar.Maximum = 276645;
            int intProgressValue = 0;

            // Read words line by line
            foreach (string word in dictWords)
            {
                strTempLetters = pstrLetters;
                if (WordInLetters(word, strTempLetters, intMinLength, intMaxLength, blnIsMask, pstrMask) == true)
                {
                    pLstStrWords.Add(new Word(word));
                }
                
                ProgressBar.Value = intProgressValue++;                  
            }
        }

        private void ReturnScrabbleDictionary(out List<string> pLstStrWords)
        {
            string filePath = "ScrabbleWords.txt";
            pLstStrWords = new List<string>();

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Word list file not found.");
                return;
            }

            using (StreamReader reader = new StreamReader(filePath))
            {
                string word;
                while ((word = reader.ReadLine()) != null)
                {
                    pLstStrWords.Add(word.ToLower().Trim());                
                }
            }
        }

        private void Sort(ref string strLetters)
        {
            List<char> cList = new List<char>();
            int intStarCount = 0;

            foreach (char c in strLetters) 
            {
                if (c == charAnyLetter)
                    intStarCount++;
                else if (char.IsLetter(c) == true)
                    cList.Add(c);
                else
                    throw new Exception("Invalid Character!");
            }

            for (int i = 0; i < intStarCount; i++)
                cList.Add(charAnyLetter);

            strLetters = new string(cList.ToArray());
        }

        private void CreateMask(ref int pIntMinLength, ref bool pBlnIsMask, string pStrMask)
        {
            for (int i = pStrMask.Length - 1; i >= 0; i--)
            {
                pIntMinLength = i + 1;

                char c = pStrMask[i];
                if (c != charNoLetter)
                {
                    pBlnIsMask = true;
                    break;
                }
            }
        }

        private Boolean WordInLetters(string strWord, string strLetters, int intMinLength = 0, int intMaxLength = 7, bool blnIsMask = false, string strMask = "-------")
        {
            if ((strWord.Length < intMinLength) || (strWord.Length > intMaxLength))
                return false;

            strWord = strWord.ToLower().Trim();
            Boolean invalidChar;
            char[] cLetters = strLetters.ToCharArray();

            for (int intLetter = 0;  intLetter < strWord.Length; intLetter++)
            {
                char c = strWord[intLetter];

                if (blnIsMask == true)
                {
                    if ((strMask[intLetter] != charNoLetter) && (c != strMask[intLetter]))
                    {
                        return false;
                    }
                }                    

                invalidChar = true;
                for (int i = 0; (i < cLetters.Length) && (invalidChar == true); i++)
                {

                    if ((cLetters[i] == c) || (cLetters[i] == charAnyLetter))
                    {
                        cLetters[i] = charNoLetter;
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
            string strLetters = LettersTextbox.Text;
            string strMask = MaskTextBox.Text;
            CreateAllWords(strMask, strLetters, out List<Word> pLstStrWords);
            lstWords = pLstStrWords;

            DisplayListBox.Items.Clear();

            foreach (Word word in pLstStrWords)
            {
                DisplayListBox.Items.Add(word.PrintWordPoints());
            }
        }

        private void SortLengthBtn_Click(object sender, EventArgs e)
        {
            DisplayListBox.Items.Clear();

            lstWords.Sort((a, b) =>
            {
                return blnSortAscending
                    ? a.Length.CompareTo(b.Length)      // Ascending
                    : b.Length.CompareTo(a.Length);     // Descending
            });

            //lstWords.Sort((a, b) => b.Points.CompareTo(a.Points));
            foreach (Word word in lstWords)
            {
                DisplayListBox.Items.Add(word.PrintWordPoints());
            }
        }

        private void SortPointsBtn_Click(object sender, EventArgs e)
        {
            DisplayListBox.Items.Clear();

            lstWords.Sort((a, b) =>
            {
                return blnSortAscending
                    ? a.Points.CompareTo(b.Points)      // Ascending
                    : b.Points.CompareTo(a.Points);     // Descending
            });

            foreach (Word word in lstWords)
            {
                DisplayListBox.Items.Add(word.PrintWordPoints());
            }
        }

        private void SortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SortComboBox.SelectedIndex == 0)
            {
                blnSortAscending = true;
            }
            else if (SortComboBox.SelectedIndex == 1)
            {
                blnSortAscending = false;
            }
            else
            {
                throw new Exception("Not Valid selection");
            }
        }

        private void CheckWordBtn_Click(object sender, EventArgs e)
        {
            //All the words in the scrabble text list are uppercase, so let's just do that and match
            string strCheckWord = CheckWordTextBox.Text.ToUpper().Trim();

            string filePath = "ScrabbleWords.txt";

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Word list file not found.");
                return;
            }

            // Read words line by line
            using (StreamReader reader = new StreamReader(filePath))
            {
                string word;
                while ((word = reader.ReadLine()) != null)
                {
                    if (word == strCheckWord)
                    {
                        MessageBox.Show(strCheckWord + " is a Scrabble word!", "Word Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }                   
                }
            }
            MessageBox.Show(strCheckWord + " is NOT a Scrabble word!", "Word Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LineCheckBtn_Click(object sender, EventArgs e)
        {
            string strLetters = LettersTextbox.Text.ToLower().Trim();
            string strMask = LineCheckMaskTextBox.Text;

            LineCheck(strMask, strLetters, out List<Word> pLstStrWords);
            lstWords = pLstStrWords;

            DisplayListBox.Items.Clear();

            foreach (Word word in pLstStrWords)
            {
                DisplayListBox.Items.Add(word.PrintWordPoints());
            }
        }
    }
}
