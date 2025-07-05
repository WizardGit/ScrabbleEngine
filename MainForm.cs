using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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

        private void ProcessBtn_Click(object sender, EventArgs e)
        {
            string filePath = "ScrabbleWords.txt";

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Word list file not found.");
                return;
            }
            DisplayListBox.Items.Clear();
            DisplayListBox.Items.Add("Processing");

            int i = 0;
            ProgressBar.Value = 0;
            ProgressBar.Maximum = 276645;

            // Read words line by line
            using (StreamReader reader = new StreamReader(filePath))
            {
                string word;
                while ((word = reader.ReadLine()) != null)
                {
                    i++;
                    ProgressBar.Value = i;
                    //Console.WriteLine(word); // You can replace this with any logic you want
                    
                }
            }

            Console.WriteLine("Done reading all words." + i);
        }
    }
}
