using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Amanda Pace
 * CST-117 Bll Hughes
 * December 8 2020
 * 
 * Out of class assignment 4
 * 
 * This assignment was done with references from class
 * as well as from Zac Almas (classmate).
 */
namespace OutOfClass4
{
    public partial class TicTacToe : Form
    {
        public TicTacToe()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Event handler for generating new tic tac toe game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnStartGame_Click(object sender, EventArgs e)
        {
            //Define variables

            //Assigns numeric value to position
            int[,] ticGame = new int[3, 3];

            //Assigns X/O value to position
            string[,] xsAndOs = new string[3, 3];

            //Placeholder for which won
            string results = "";



            //Initialize Random Number Generator

            Random randNum = new Random();

            //For loop 1: goes through each row position
            for (int row = 0; row < ticGame.GetLength(0); row++)
            {
                //For loop 2: goes through each column position
                for (int col = 0; col < ticGame.GetLength(1); col++)
                {
                    //Insert random number 0/1 into array for each spot
                    ticGame[row, col] = randNum.Next(0, 2);

                    //Assigning letter value for each number
                    if (ticGame[row, col] == 1)
                    {
                        xsAndOs[row, col] = "X";
                    }
                    else
                    {
                        xsAndOs[row, col] = "O";
                    }

                }

            }

            //Assign results to GUI place/tictactoe board

            //Top Row
            lblR0C0.Text = xsAndOs[0, 0];
            lblR1C0.Text = xsAndOs[1, 0];
            lblR2C0.Text = xsAndOs[2, 0];

            //Middle row
            lblR0C1.Text = xsAndOs[0, 1];
            lblR1C1.Text = xsAndOs[1, 1];
            lblR2C1.Text = xsAndOs[2, 1];

            //Bottom row
            lblR0C2.Text = xsAndOs[0, 2];
            lblR1C2.Text = xsAndOs[1, 2];
            lblR2C2.Text = xsAndOs[2, 2];

            //Call method to find winner

            GameLogic checkWin = new GameLogic();

            //Assign number (0-2)/ winner value to determine result
            int win = checkWin.FindWinner(ticGame);


            if (win == 0)
            {
                results = "O wins!";
            }
            if (win == 1)
            {
                results = "X wins!";
            }
            if (win == 2)
            {
                results = "It's a draw!";
            }

            lblWinner.Text = results;

        }



    }
}
