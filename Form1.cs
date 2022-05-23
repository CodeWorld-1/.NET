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
        string chance = "O";
        bool b1 = true;
        bool b2 = true;
        bool b3 = true;
        bool b4 = true;
        bool b5 = true;
        bool b6 = true;
        bool b7 = true;
        bool b8 = true;
        bool b9 = true;

        string p1 = "1";
        string p2 = "2";
        string p3 = "3";
        string p4 = "4";
        string p5 = "5";
        string p6 = "6";
        string p7 = "7";
        string p8 = "8";
        string p9 = "9";

        public Form1()
        {
            InitializeComponent();

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if (b1 == true)
            {
                if (chance == "X")
                {
                    button1.BackgroundImage = Properties.Resources.O;
                    button1.BackgroundImageLayout = ImageLayout.Stretch;
                    chance = "O";
                    p1 = "X";                }
                else
                {
                    button1.BackgroundImage = Properties.Resources.X;
                    button1.BackgroundImageLayout = ImageLayout.Stretch;
                    chance = "X";
                    p1 = "O";
                }
                b1 = false;
            }
            verifier(p1, p2, p3, p4, p5, p6, p7, p8, p9);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (b2 == true)
            {
                if (chance == "X")
                {
                    button2.BackgroundImage = Properties.Resources.O;
                    button2.BackgroundImageLayout = ImageLayout.Stretch;
                    chance = "O";
                    p2 = "X";
                }
                else
                {
                    button2.BackgroundImage = Properties.Resources.X;
                    button2.BackgroundImageLayout = ImageLayout.Stretch;
                    chance = "X";
                    p2 = "O";
                }
                b2 = false;
            }
            verifier(p1, p2, p3, p4, p5, p6, p7, p8, p9);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (b3 == true)
            {
                if (chance == "X")
                {
                    button3.BackgroundImage = Properties.Resources.O;
                    button3.BackgroundImageLayout = ImageLayout.Stretch;
                    chance = "O";
                    p3 = "X";
                }
                else
                {
                    button3.BackgroundImage = Properties.Resources.X;
                    button3.BackgroundImageLayout = ImageLayout.Stretch;
                    chance = "X";
                    p3 = "O";
                }
                b3 = false;
            }
            verifier(p1, p2, p3, p4, p5, p6, p7, p8, p9);
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            if (b4 == true)
            {
                if (chance == "X")
                {
                    button4.BackgroundImage = Properties.Resources.O;
                    button4.BackgroundImageLayout = ImageLayout.Stretch;
                    chance = "O";
                    p4 = "X";
                }
                else
                {
                    button4.BackgroundImage = Properties.Resources.X;
                    button4.BackgroundImageLayout = ImageLayout.Stretch;
                    chance = "X";
                    p4 = "O";
                }
                b4 = false;
            }
            verifier(p1, p2, p3, p4, p5, p6, p7, p8, p9);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (b5 == true)
            {
                if (chance == "X")
                {
                    button5.BackgroundImage = Properties.Resources.O;
                    button5.BackgroundImageLayout = ImageLayout.Stretch;
                    chance = "O";
                    p5 = "X";
                }
                else
                {
                    button5.BackgroundImage = Properties.Resources.X;
                    button5.BackgroundImageLayout = ImageLayout.Stretch;
                    chance = "X";
                    p5 = "O";
                }
                b5 = false;
            }
            verifier(p1, p2, p3, p4, p5, p6, p7, p8, p9);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (b6 == true)
            {
                if (chance == "X")
                {
                    button6.BackgroundImage = Properties.Resources.O;
                    button6.BackgroundImageLayout = ImageLayout.Stretch;
                    chance = "O";
                    p6 = "X";
                }
                else
                {
                    button6.BackgroundImage = Properties.Resources.X;
                    button6.BackgroundImageLayout = ImageLayout.Stretch;
                    chance = "X";
                    p6 = "O";
                }
                b6 = false;
            }
            verifier(p1, p2, p3, p4, p5, p6, p7, p8, p9);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (b7 == true)
            {

                if (chance == "X")
                {
                    button7.BackgroundImage = Properties.Resources.O;
                    button7.BackgroundImageLayout = ImageLayout.Stretch;
                    chance = "O";
                    p7 = "X";
                }
                else
                {
                    button7.BackgroundImage = Properties.Resources.X;
                    button7.BackgroundImageLayout = ImageLayout.Stretch;
                    chance = "X";
                    p7 = "O";
                }
                b7 = false;
            }
            verifier(p1, p2, p3, p4, p5, p6, p7, p8, p9);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (b8 == true)
            {

                if (chance == "X")
                {
                    button8.BackgroundImage = Properties.Resources.O;
                    button8.BackgroundImageLayout = ImageLayout.Stretch;
                    chance = "O";
                    p8 = "X";
                }
                else
                {
                    button8.BackgroundImage = Properties.Resources.X;
                    button8.BackgroundImageLayout = ImageLayout.Stretch;
                    chance = "X";
                    p8 = "O";
                }
                b8 = false;
            }
            verifier(p1, p2, p3, p4, p5, p6, p7, p8, p9);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (b9 == true)
            {

                if (chance == "X")
                {
                    button9.BackgroundImage = Properties.Resources.O;
                    button9.BackgroundImageLayout = ImageLayout.Stretch;
                    chance = "O";
                    p9 = "X";
                }
                else
                {
                    button9.BackgroundImage = Properties.Resources.X;
                    button9.BackgroundImageLayout = ImageLayout.Stretch;
                    chance = "X";
                    p9 = "O";
                }
                b9 = false;
            }
            verifier(p1, p2, p3, p4, p5, p6, p7, p8, p9);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            chance = "O";
            b1 = true;
            b2 = true;
            b3 = true;
            b4 = true;
            b5 = true;
            b6 = true;
            b7 = true;
            b8 = true;
            b9 = true;

            p1 = "1";
            p2 = "2";
            p3 = "3";
            p4 = "4";
            p5 = "5";
            p6 = "6";
            p7 = "7";
            p8 = "8";
            p9 = "9";

            button1.BackgroundImage = null;
            button2.BackgroundImage = null;
            button3.BackgroundImage = null;
            button4.BackgroundImage = null;
            button5.BackgroundImage = null;
            button6.BackgroundImage = null;
            button7.BackgroundImage = null;
            button8.BackgroundImage = null;
            button9.BackgroundImage = null;

            label4.Text = "Win Status: Match awaiting Completion...";
        }

        public void verifier(string v1, string v2, string v3, string v4, string v5, string v6, string v7, string v8, string v9)
        {
            if (v1 == v2 && v2 == v3)
            {
                if (v1 == "O")
                {
                    label4.Text = $"Player {textBox1.Text} wins the match against {textBox2.Text}.";
                }
                else
                {
                    label4.Text = $"Player {textBox2.Text} wins the match against {textBox1.Text}.";

                }
                finisher();
            }
            if (v1 == v4 && v4 == v7)
            {
                if (v1 == "O")
                {
                    label4.Text = $"Player {textBox1.Text} wins the match against {textBox2.Text}.";
                }
                else
                {
                    label4.Text = $"Player {textBox2.Text} wins the match against {textBox1.Text}.";

                }
                finisher();
            }
            if (v2 == v5 && v5 == v8)
            {
                if (v2 == "O")
                {
                    label4.Text = $"Player {textBox1.Text} wins the match against {textBox2.Text}.";
                }
                else
                {
                    label4.Text = $"Player {textBox2.Text} wins the match against {textBox1.Text}.";

                }
                finisher();
            }
            if (v3 == v6 && v6 == v9)
            {
                if (v3 == "O")
                {
                    label4.Text = $"Player {textBox1.Text} wins the match against {textBox2.Text}.";
                }
                else
                {
                    label4.Text = $"Player {textBox2.Text} wins the match against {textBox1.Text}.";

                }
                finisher();
            }
            if (v4 == v5 && v5 == v6)
            {
                if (v4 == "O")
                {
                    label4.Text = $"Player {textBox1.Text} wins the match against {textBox2.Text}.";
                }
                else
                {
                    label4.Text = $"Player {textBox2.Text} wins the match against {textBox1.Text}.";

                }
                finisher();
            }
            if (v7 == v8 && v8 == v9)
            {
                if (v7 == "O")
                {
                    label4.Text = $"Player {textBox1.Text} wins the match against {textBox2.Text}.";
                }
                else
                {
                    label4.Text = $"Player {textBox2.Text} wins the match against {textBox1.Text}.";

                }
                finisher();
            }
            if (v1 == v5 && v5 == v9)
            {
                if (v1 == "O")
                {
                    label4.Text = $"Player {textBox1.Text} wins the match against {textBox2.Text}.";
                }
                else
                {
                    label4.Text = $"Player {textBox2.Text} wins the match against {textBox1.Text}.";

                }
                finisher();
            }
            if (v3 == v5 && v5 == v7)
            {
                if (v3 == "O")
                {
                    label4.Text = $"Player {textBox1.Text} wins the match against {textBox2.Text}.";
                }
                else
                {
                    label4.Text = $"Player {textBox2.Text} wins the match against {textBox1.Text}.";
                  
                }
                finisher();
            }
            var ch1 = int.TryParse(p1, out int n);
            var ch2 = int.TryParse(p2, out n);
            var ch3 = int.TryParse(p3, out n);
            var ch4 = int.TryParse(p4, out n);
            var ch5 = int.TryParse(p5, out n);
            var ch6 = int.TryParse(p6, out n);
            var ch7 = int.TryParse(p7, out n);
            var ch8 = int.TryParse(p8, out n);
            var ch9 = int.TryParse(p9, out n);

            if(ch1==false && ch2==false && ch3 == false && ch4 == false && ch5 == false && ch6 == false && ch7 == false && ch8 == false && ch9 == false)
            {
                label4.Text = "Game ended in a Draw";
                finisher();
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public void finisher()
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
            System.IO.Stream str = Properties.Resources.applause_2;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }
        
    }
}