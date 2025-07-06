using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrabbleEngine
{
    internal class Word
    {
        private string value;
        private List<Letter> letterList;
        private int points;
        public string Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public int Points
        {
            get { return points; }
            set { this.points = value; }
        }
        public int Length
        {
            get { return value.Length; }
        }

        public Word(string pStrWord)
        {
            this.value = pStrWord.ToLower().Trim();
            this.points = 0;
            this.letterList = new List<Letter>();

            foreach (char c in this.value)
            {
                letterList.Add(new Letter(c));
            }
            CalculatePoints();
        }

        public void CalculatePoints()
        {
            int intTempPoints = 0;
            foreach(Letter c  in letterList)
            {
                intTempPoints += c.Points;
            }
            this.points = intTempPoints;
        }

        public string PrintWord()
        {
            return this.value;
        }

        public string PrintWordPoints()
        {
            return this.value + " (" + this.points + ")";
        }        
    }
}
