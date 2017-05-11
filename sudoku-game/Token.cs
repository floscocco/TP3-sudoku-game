using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sudoku_game
{
    class Token
    {
            private int key;
            private int value;
            private bool state;
            private int[,] position;

            public Token(int key, int value, bool state)
            {
                this.key = key;
                this.value = value;
                this.state = state;
            }

            public int Key
            {
                get
                {
                    return key;
                }

                set
                {
                    key = value;
                }
            }

            public int Value
            {
                get
                {
                    return value;
                }

                set
                {
                    this.value = value;
                }
            }

            public bool State
            {
                get
                {
                    return state;
                }

                set
                {
                    state = value;
                }
            }

            public int[,] Position
            {
                get
                {
                    return position;
                }

                set
                {
                    position = value;
                }
            }
     }
    

}
