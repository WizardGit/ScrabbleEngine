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

        public char this[int index]
        {
            get { return this.letterList[index].Value; }
            set { this.letterList[index].Value = value; }
        }

        public bool WordMatchMask(int pintStartIndex, int pintEndIndex, string pstrMask)
        {
            if (pstrMask.Length < this.Length)
                return false;

            Word wrdMask = new Word(pstrMask);            

            for (int i = pintStartIndex; (i < pintEndIndex) && (i < this.Length); i++)
            {
                if (wrdMask[i] != '-')
                {
                    if (wrdMask.letterList[i].Value != this.letterList[i].Value)
                    {
                        return false;
                    }
                }                
            }
            return true;
        }

        public bool RemoveLetter(char pcharLetter, ref string pstrLetters)
        {
            char[] charListLetters = pstrLetters.ToCharArray();

            for (int i = 0; i < pstrLetters.Length; i++)
            {
                if (charListLetters[i] == pcharLetter)
                {
                    charListLetters[i] = '-';
                    pstrLetters = charListLetters.ToString();
                    return true;
                }
            }
            return false;
        }

        public bool WordMatchMask(int pintStartIndex, int pintEndIndex, string pstrMask, string pstrLetters, bool pblnMustHitMask)
        {
            bool blnHitMask;
            if (pblnMustHitMask == true)
            {
                blnHitMask = false;
            }
            else
            {
                blnHitMask = true;
            }


            if (pstrMask.Length < this.Length)
                return false;

            Word wrdMask = new Word(pstrMask);

            for (int i = pintStartIndex; (i < pintEndIndex) && (i < this.Length); i++)
            {
                if (wrdMask[i] != '-')
                {
                    if (wrdMask.letterList[i].Value != this.letterList[i].Value)
                    {
                        return false;
                    }
                    else
                    {
                        blnHitMask = true;
                    }
                }
                else
                {
                    if (RemoveLetter(this.letterList[i].Value, ref pstrLetters) == false)
                    {
                        return false;
                    }
                }                
            }
            return blnHitMask;
        }
    }
}
