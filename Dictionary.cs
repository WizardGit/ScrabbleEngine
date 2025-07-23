using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrabbleEngine
{
    internal class Dictionary
    {
        private List<string> dictionary;
        private int length;

        public int Length
        {
            get { return dictionary.Count; }
        }

        public List<string> Dict
        {
            get { return dictionary; }
        }
        public Dictionary()
        {
            string filePath = "ScrabbleWords.txt";
            dictionary = new List<string>();

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
                    dictionary.Add(word.ToLower().Trim());
                }
            }
        }

        public string GetString(int index)
        {
            return this.dictionary[index];
        }

        public Word GetWord(int index)
        {
            return new Word(this.dictionary[index]);
        }
    }
}
