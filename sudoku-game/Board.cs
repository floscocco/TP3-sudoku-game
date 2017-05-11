using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sudoku_game
{
    class Board
    {
        private string name;
        private List<Token> listToken;
        private int[,] currentBoard;

        public Board(string name)
        {
            this.name = name;
            listToken = new List<Token>();
        }

        public void BuildBoard(int size)
        {
            int tokenAmount;
            tokenAmount = size * size;
            currentBoard = new int[size, size];
            LoadBoard(tokenAmount);
        }

        public void LoadBoard(int sizeBoard)
        {

            for (int i = 0; i < sizeBoard; i++)
            {
                for (int j = 0; j < sizeBoard; j++)
                {
                    Random r = new Random();
                    currentBoard[i, j] = r.Next(0, sizeBoard);
                    if (checkY(i, j, sizeBoard) == false)
                    {

                    }
                }

            }



        }
        private bool checkY(int x, int y, int size)
        {
            Random r = new Random();
            for (int z = 0; z < size; z++)
            {
                if (currentBoard[x, y] == currentBoard[x, z] && y != z)
                {
                    currentBoard[x, y] = r.Next(0, size);
                    return false;
                }
            }
            return false;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        internal List<Token> ListToken
        {
            get
            {
                return listToken;
            }

            set
            {
                listToken = value;
            }
        }

        public int[,] CurrentBoard
        {
            get
            {
                return currentBoard;
            }

            set
            {
                currentBoard = value;
            }
        }
    }
}
