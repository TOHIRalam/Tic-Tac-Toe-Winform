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
        public int player_ = 1, counter = 0;
        public void button_design(Button btn) 
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 1;
            btn.BackColor = Color.White;
            btn.FlatAppearance.BorderColor = Color.LightGray;
            btn.FlatAppearance.MouseOverBackColor = Color.White;
        }

        public bool winnerFound()
        {
            return ((button1.Text == button2.Text && button1.Text == button3.Text && button1.Text != "") || (button4.Text == button5.Text && button4.Text == button6.Text && button4.Text != "")
                 || (button7.Text == button8.Text && button7.Text == button9.Text && button7.Text != "") || (button1.Text == button5.Text && button1.Text == button9.Text && button1.Text != "")
                 || (button3.Text == button5.Text && button3.Text == button7.Text && button3.Text != "") || (button1.Text == button4.Text && button1.Text == button7.Text && button1.Text != "")
                 || (button3.Text == button6.Text && button3.Text == button9.Text && button3.Text != ""));
        }

        public void disable_buttons()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button_design(button1);
            button_design(button2);
            button_design(button3);
            button_design(button4);
            button_design(button5);
            button_design(button6);
            button_design(button7);
            button_design(button8);
            button_design(button9);
            label1.ForeColor = Color.Blue;
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void releaseDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("April 18, 2021");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. The game is played on a grid that's 3 squares by 3 squares.\n2. " +
                "In this case player 1 is X and player 2 is O" +
                "Players take turns putting their marks in empty squares.\n3. The first player to get 3 of his/her " +
                "marks in a row (up, down, across, or diagonally) is the winner.\n" +
                "4. When all 9 squares are full, the game is over. If no player has 3 marks in a row, the game ends in a tie.");
        }

        private void button_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if(btn.Text == "")
            {
                btn.Text = (player_ % 2 != 0) ? "O" : "X";
                btn.ForeColor = (player_ % 2 != 0) ? Color.Blue : Color.Red; counter++;
                if (++player_ % 2 != 0) { label1.Text = "Player-1(O)"; label1.ForeColor = Color.Blue; } else { label1.Text = "Player-2(X)"; label1.ForeColor = Color.Red; }
                if (winnerFound()) { disable_buttons(); MessageBox.Show((btn.Text == "O") ? "Game Over!\nPlayer-1(O) Win!" : "Game Over!\nPlayer-2(X) Win!"); }
                else if(counter == 9) { disable_buttons(); MessageBox.Show("It's a tie!"); }
            }
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Release Date: April 18, 2021");
        }
    }
}
