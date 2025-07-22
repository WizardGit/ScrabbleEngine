using ScrabbleEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrabbleEngine
{
    internal class Board
    {
        public Square[,] grid;

        public Square[,] Grid
        {            
            get { return grid; }
        }

        public Board()
        {
            grid = new Square[15, 15];

            grid[0, 0] = new Square(Square.BonusType.tripleWord);
            grid[0, 1] = new Square(Square.BonusType.nothing);
            grid[0, 2] = new Square(Square.BonusType.nothing);
            grid[0, 3] = new Square(Square.BonusType.doubleLetter);
            grid[1, 1] = new Square(Square.BonusType.doubleWord);
        }
    }
}
