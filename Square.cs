using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrabbleEngine
{
    internal class Square
    {
        public enum BonusType
        {
            nothing,
            doubleLetter,
            tripleLetter,
            doubleWord,
            tripleWord
        }

        private char value;
        private List<Letter> validValues;
        private BonusType bonusType;
        public char Value
        {
            get { return value; }
            set 
            { 
                this.value = value;
                validValues = new List<Letter>
                {
                    new Letter(value)
                };
            }
        }

        public BonusType Bonus
        {
            get { return this.bonusType; }
        }
        public List<Letter> ValidValues
        {
            get { return this.validValues; }
        }

        public Square(BonusType pBonusType, char pstrValue = Letter.NoLetter) 
        {
            if (pBonusType != BonusType.nothing)
            {
                bonusType = pBonusType;
            }

            validValues = new List<Letter>();
            if (pstrValue != Letter.NoLetter)
            {
                value = pstrValue;
                validValues.Add(new Letter(pstrValue));
            }
            else
            {                
                validValues.Add(new Letter('a'));
                validValues.Add(new Letter('b'));
                validValues.Add(new Letter('c'));
                validValues.Add(new Letter('d'));
                validValues.Add(new Letter('e'));
                validValues.Add(new Letter('f'));
                validValues.Add(new Letter('g'));
                validValues.Add(new Letter('h'));
                validValues.Add(new Letter('i'));
                validValues.Add(new Letter('j'));
                validValues.Add(new Letter('k'));
                validValues.Add(new Letter('l'));
                validValues.Add(new Letter('m'));
                validValues.Add(new Letter('n'));
                validValues.Add(new Letter('o'));
                validValues.Add(new Letter('p'));
                validValues.Add(new Letter('q'));
                validValues.Add(new Letter('r'));
                validValues.Add(new Letter('s'));
                validValues.Add(new Letter('t'));
                validValues.Add(new Letter('u'));
                validValues.Add(new Letter('v'));
                validValues.Add(new Letter('w'));
                validValues.Add(new Letter('x'));
                validValues.Add(new Letter('y'));
                validValues.Add(new Letter('z'));
            }                
        } 

        public bool RemoveLetter(char letter)
        {
            return validValues.Remove(validValues.Find(p => p.Value == letter));
        }
        public bool RemoveLetter(Letter letter)
        {
            return validValues.Remove(validValues.Find(p => p.Value == letter.Value));
        }
    }
}
