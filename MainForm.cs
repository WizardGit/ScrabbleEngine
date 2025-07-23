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
            CreateBoard();
        }

        private bool blnSortAscending = true;
        private List<Word> lstWords; 

        private void ProcessBtn_Click(object sender, EventArgs e)
        {
            string strLetters = LettersTextbox.Text;
            string strMask = MaskTextBox.Text;

            Line line = new Line(strMask);
            line.SimpleLineCheck(strLetters, out List<Word> pLstStrWords, ProgressBar);

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

            Line line = new Line(strMask);
            line.LineCheck(strLetters, out List<Word> pLstStrWords, ProgressBar);

            lstWords = pLstStrWords;

            DisplayListBox.Items.Clear();

            foreach (Word word in pLstStrWords)
            {
                DisplayListBox.Items.Add(word.PrintWordPoints());
            }
        }

        private void CreateBoard()
        {
            TextBox[,] board = new TextBox[15, 15];

            for (int row = 0; row < 15; row++)
            {
                for (int col = 0; col < 15; col++)
                {
                    TextBox tb = new TextBox
                    {
                        MaxLength = 1,
                        TextAlign = HorizontalAlignment.Center,
                        Dock = DockStyle.Fill
                    };

                    board[row, col] = tb;
                    gridTableLayout.Controls.Add(tb, col, row);
                }
            }
        }
    }
}
