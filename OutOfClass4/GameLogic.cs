using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OutOfClass4
{
    public class GameLogic
    {

        public int FindWinner(int[,] ticLayout)
        {
            int winResult = 2;

            //0 =  O wins
            //1 = X wins
            //2 = tie



            //---------------------------
            //Results for O Winning...
            //---------------------------


            //Wins on row...

            //Top Row
            if (ticLayout[0, 0] == 0 && ticLayout[0, 1] == 0 && ticLayout[0, 2] == 0)
            {
                winResult = 0;
            }

            //Middle row
            if (ticLayout[1, 0] == 0 && ticLayout[1, 1] == 0 && ticLayout[1, 2] == 0)
            {
                winResult = 0;
            }

            //Bottom Row
            if (ticLayout[2, 0] == 0 && ticLayout[2, 1] == 0 && ticLayout[2, 2] == 0)
            {
                winResult = 0;
            }



            //Wins on columns...


            //Left column
            if (ticLayout[0, 0] == 0 && ticLayout[1, 0] == 0 && ticLayout[2, 0] == 0)
            {
                winResult = 0;
            }

            //Middle Column
            if (ticLayout[0, 1] == 0 && ticLayout[1, 1] == 0 && ticLayout[2, 1] == 0)
            {
                winResult = 0;
            }
            
            //Right Column
            if (ticLayout[0, 2] == 0 && ticLayout[1, 2] == 0 && ticLayout[2, 2] == 0)
            {
                winResult = 0;
            }


            //Wins on diagonals...

            //From left to right
            if (ticLayout[0, 0] == 0 && ticLayout[1, 1] == 0 && ticLayout[2, 2] == 0)
            {
                winResult = 0;
            }

            //From right to left
            if (ticLayout[0, 2] == 0 && ticLayout[1, 1] == 0 && ticLayout[2, 0] == 0)
            {
                winResult = 0;
            }



            //---------------------------
            //Results for X Winning...
            //---------------------------

            //Wins in rows

            //Top row
            if (ticLayout[0,0] == 1 && ticLayout[0,1] == 1 && ticLayout[0,2] == 1)
            {
                winResult = 1;
            }

            //Middle row
            if (ticLayout[1, 0] == 1 && ticLayout[1, 1] == 1 && ticLayout[1, 2] == 1)
            {
                winResult = 1;
            }

            //Bottom row
            if (ticLayout[2, 0] == 1 && ticLayout[2, 1] == 1 && ticLayout[2, 2] == 1)
            {
                winResult = 1;
            }


            //Wins in columns

            //Left column
            if (ticLayout[0, 0] == 1 && ticLayout[1, 0] == 1 && ticLayout[2, 0] == 1)
            {
                winResult = 1;
            }

            //Middle column
            if (ticLayout[0, 1] == 1 && ticLayout[1, 1] == 1 && ticLayout[2, 1] == 1)
            {
                winResult = 1;
            }

            //Right column
            if (ticLayout[0, 2] == 1 && ticLayout[1, 2] == 1 && ticLayout[2, 2] == 1)
            {
                winResult = 1;
            }


            //Wins in diagonals

            //Left to right
            if (ticLayout[0,0] == 1 && ticLayout[1,1] == 1 && ticLayout[2,2] == 1)
            {
                winResult = 1;
            }

            //Left to right
            if (ticLayout[0, 2] == 1 && ticLayout[1, 1] == 1 && ticLayout[2, 0] == 1)
            {
                winResult = 1;
            }
           

            return winResult;
        }
    }
}
