using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        bool turn = true;
        double turn_count = 0;

        bool playerWin = false;
        bool computerwin = false;

        double playerscore = 0;
        double computerscore = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_onclick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (turn)
            {
                btn.Text = "X";
                turn = false;
                turn_count++;


                if (turn_count == 9)
                {
                    MessageBox.Show("Draw!!");

                    refresh();
                    turn_count = 0;

                }

                winner_algo();



            }
            else
            {
                btn.Text = "O";
                turn = true;
                turn_count++;

                if (turn_count == 9)
                {
                    MessageBox.Show("Draw!!");
                    refresh();
                    turn_count = 0;

                }

                winner_algo();


            }

            if (playerWin == true)
            {

                playerscore++;
                player_score.Text = playerscore.ToString();
                turn_count = 0;
                playerWin = false;

            }
            else if (computerwin == true)
            {

                computerscore++;
                computer_score.Text = computerscore.ToString();
                turn_count = 0;
                computerwin = false;
            }

        }
        public void refresh()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }
        public void winner_algo()
        {


            if ((button1.Text == button2.Text) && (button3.Text == button2.Text) && (button1.Text != "") && (button2.Text != "") && (button3.Text != ""))
            {
                if (button1.Text == "X")
                {

                    MessageBox.Show("Player wins!!!");
                    playerWin = true;

                }
                else
                {
                    MessageBox.Show("computer wins!!!");
                    computerwin = true;
                }

                refresh();


            }

            if ((button4.Text == button5.Text) && (button5.Text == button6.Text) && (button4.Text != "") && (button5.Text != "") && (button6.Text != ""))
            {
                if (button4.Text == "X")
                {
                    MessageBox.Show("Player wins!!!");
                    playerWin = true;

                }
                else
                {
                    MessageBox.Show("computer wins!!!");

                    computerwin = true;
                }
                refresh();

            }

            if ((button7.Text == button8.Text) && (button8.Text == button9.Text) && (button7.Text != "") && (button8.Text != "") && (button9.Text != ""))
            {
                if (button7.Text == "X")
                {
                    MessageBox.Show("Player  wins!!!");

                    playerWin = true;

                }
                else
                {
                    MessageBox.Show("computer wins!!!");

                    computerwin = true;
                }
                refresh();
            }

            if ((button1.Text == button4.Text) && (button4.Text == button7.Text) && (button1.Text != "") && (button4.Text != "") && (button7.Text != ""))
            {
                if (button1.Text == "X")
                {
                    MessageBox.Show("Player  wins!!!");

                    playerWin = true;

                }
                else
                {
                    MessageBox.Show("computer wins!!!");

                    computerwin = true;
                }
                refresh();
            }

            if ((button2.Text == button5.Text) && (button5.Text == button8.Text) && (button2.Text != "") && (button5.Text != "") && (button8.Text != ""))
            {
                if (button2.Text == "X")
                {
                    MessageBox.Show("Player  wins!!!");

                    playerWin = true;

                }
                else
                {
                    MessageBox.Show("computer wins!!!");

                    computerwin = true;
                }
                refresh();
            }
            if ((button3.Text == button6.Text) && (button6.Text == button9.Text) && (button3.Text != "") && (button6.Text != "") && (button9.Text != ""))
            {
                if (button3.Text == "X")
                {
                    MessageBox.Show("Player  wins!!!");

                    playerWin = true;

                }
                else
                {
                    MessageBox.Show("computer wins!!!");

                    computerwin = true;
                }
                refresh();
            }
            if ((button1.Text == button5.Text) && (button5.Text == button9.Text) && (button1.Text != "") && (button5.Text != "") && (button9.Text != ""))
            {
                if (button1.Text == "X")
                {
                    MessageBox.Show("Player  wins!!!");

                    playerWin = true;

                }
                else
                {
                    MessageBox.Show("computer wins!!!");

                    computerwin = true;
                }
                refresh();
            }
            if ((button3.Text == button5.Text) && (button5.Text == button7.Text) && (button7.Text != "") && (button5.Text != "") && (button3.Text != ""))
            {
                if (button3.Text == "X")
                {
                    MessageBox.Show("Player wins!!!");

                    playerWin = true;

                }
                else
                {
                    MessageBox.Show("computer wins!!!");

                    computerwin = true;
                }
                refresh();

            }
        }
    }
}

