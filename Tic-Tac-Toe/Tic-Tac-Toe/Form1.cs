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
        public Form1()
        {
            InitializeComponent();
        }
        public void temizle()
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
        public void check()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                MessageBox.Show("X WIN","GAME OVER",MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("O WIN", "GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
            }
            else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                MessageBox.Show("X WIN", "GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
            }
            else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                MessageBox.Show("O WIN", "GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
            }
            else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X WIN", "GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
            }
            else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("O WIN", "GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
            }
            else if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("X WIN", "GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
            }
            else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("O WIN", "GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
            }
            else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                MessageBox.Show("X WIN", "GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
            }
            else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                MessageBox.Show("O WIN", "GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
            }
            else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X WIN", "GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
            }
            else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("O WIN", "GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
            }
            else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X WIN", "GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
            }
            else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("O WIN", "GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
            }
            else if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("X WIN", "GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
            }
            else if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("O WIN", "GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
            }
            if (!string.IsNullOrEmpty(button1.Text) && !string.IsNullOrEmpty(button2.Text) && !string.IsNullOrEmpty(button3.Text) && !string.IsNullOrEmpty(button4.Text) && !string.IsNullOrEmpty(button5.Text) && !string.IsNullOrEmpty(button6.Text) && !string.IsNullOrEmpty(button7.Text) && !string.IsNullOrEmpty(button8.Text) && !string.IsNullOrEmpty(button9.Text))
            {
                MessageBox.Show("DRAW", "GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(button1.Text))
            {
                if (label8.Text == "X")
                {
                    button1.Text = "X";
                    label8.Text = "O";
                }
                else if (label8.Text == "O")
                {
                    button1.Text = "O";
                    label8.Text = "X";
                }
            }
            check();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(button2.Text))
            {
                if (label8.Text == "X")
                {
                    button2.Text = "X";
                    label8.Text = "O";
                }
                else if (label8.Text == "O")
                {
                    button2.Text = "O";
                    label8.Text = "X";
                }
            }
            check();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(button3.Text))
            {
                if (label8.Text == "X")
                {
                    button3.Text = "X";
                    label8.Text = "O";
                }
                else if (label8.Text == "O")
                {
                    button3.Text = "O";
                    label8.Text = "X";
                }
            }
            check();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(button4.Text))
            {
                if (label8.Text == "X")
                {
                    button4.Text = "X";
                    label8.Text = "O";
                }
                else if (label8.Text == "O")
                {
                    button4.Text = "O";
                    label8.Text = "X";
                }
            }
            check();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(button5.Text))
            {
                if (label8.Text == "X")
                {
                    button5.Text = "X";
                    label8.Text = "O";
                }
                else if (label8.Text == "O")
                {
                    button5.Text = "O";
                    label8.Text = "X";
                }
            }
            check();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(button6.Text))
            {
                if (label8.Text == "X")
                {
                    button6.Text = "X";
                    label8.Text = "O";
                }
                else if (label8.Text == "O")
                {
                    button6.Text = "O";
                    label8.Text = "X";
                }
            }
            check();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(button7.Text))
            {
                if (label8.Text == "X")
                {
                    button7.Text = "X";
                    label8.Text = "O";
                }
                else if (label8.Text == "O")
                {
                    button7.Text = "O";
                    label8.Text = "X";
                }
            }
            check();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(button8.Text))
            {
                if (label8.Text == "X")
                {
                    button8.Text = "X";
                    label8.Text = "O";
                }
                else if (label8.Text == "O")
                {
                    button8.Text = "O";
                    label8.Text = "X";
                }
            }
            check();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(button9.Text))
            {
                if (label8.Text == "X")
                {
                    button9.Text = "X";
                    label8.Text = "O";
                }
                else if (label8.Text == "O")
                {
                    button9.Text = "O";
                    label8.Text = "X";
                }
            }
            check();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label8.Text = "X";
        }
    }
}