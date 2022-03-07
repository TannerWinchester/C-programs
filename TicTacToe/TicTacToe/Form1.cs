using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool turn = true;//true = x turn, false = o turn.
        int turnCount = 0;
        //static String player1, player2;

        public Form1()
        {
            InitializeComponent();
        }
        /*
        public static void setPlayerNames(String n1, String n2)
        {
            player1 = n1;
            player2 = n2;
        }*/

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Tanner Winchester: ENJOY!", "Tic Tac Toe About");
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
            }
            else if(!turn)
            {
                b.Text = "O";
            }
                turn = !turn;
                b.Enabled = false;
                turnCount++;
                CheckForWinner();
        }

        private void CheckForWinner()
        {
            bool there_is_a_winner = false;

            //horizontal checks
             if((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                there_is_a_winner = true;
             else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                there_is_a_winner = true;
             else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                there_is_a_winner = true;

            //vertical checks
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                there_is_a_winner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                there_is_a_winner = true;
            //diagonal checks
            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                there_is_a_winner = true;


            if (there_is_a_winner)
            {
                DisableButtons();
                String winner;
                if (turn)
                {
                    winner = p2.Text;
                    o_win_count.Text = (Int32.Parse(o_win_count.Text) + 1).ToString();
                }
                else
                {
                    winner = p1.Text;
                    x_win_count.Text = (Int32.Parse(x_win_count.Text) + 1).ToString();
                }

                MessageBox.Show(winner + " Wins!", "Yay!");
                
            }//end if
            else
            {
                
                if (turnCount == 9)
                {
                    draw_count.Text = (Int32.Parse(draw_count.Text) + 1).ToString();
                    MessageBox.Show("Draw!", "Bummer!");
                }
            }//end else

        }//end checkforwinner

        private void DisableButtons()
        {

                foreach (Control c in Controls)
                {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                    b.Text = "";
                }
                catch { }
                }//end foreach
        }

        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turnCount = 0;
       
                foreach (Control c in Controls)
                {
                   try
                   {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                   }//end try
                catch { }
                }//end foreach


        }

        private void Button_Enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (turn)

                    b.Text = "X";
                else
                    b.Text = "O";
            }//end if
            

        }

        private void Button_Leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if(b.Enabled)
            {
                b.Text = "";

            }//end if
        }

        private void ResetWinCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            o_win_count.Text = "0";
            x_win_count.Text = "0";
            draw_count.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           /* Form f2 = new Form2();
            f2.ShowDialog();
            label1.Text = player1;
            label3.Text = player2;
           */
        }
    }
}
