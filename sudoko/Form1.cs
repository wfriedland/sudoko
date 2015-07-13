using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sudoko
{
    public partial class Form1 : Form
    {
        sudoko game = new sudoko();
        Button quessButton;
        int spotsToQuess = 20;
        int blankSpace;
        int seconds;
        int minutes;
        public Form1()
        {
            InitializeComponent();
        }

        //
        // brute strenght setup of gameboard
        //
        private void Form1_Load(object sender, EventArgs e)
        {
            this.gameBoard.SuspendLayout();
            this.SuspendLayout();
            gameBoard.Controls.Add((Control)button1);
            gameBoard.Controls.Add((Control)button2);
            gameBoard.Controls.Add((Control)button3);
            gameBoard.Controls.Add((Control)button4);
            gameBoard.Controls.Add((Control)button5);
            gameBoard.Controls.Add((Control)button6);
            gameBoard.Controls.Add((Control)button7);
            gameBoard.Controls.Add((Control)button8);
            gameBoard.Controls.Add((Control)button9);
            gameBoard.Controls.Add((Control)button10);
            gameBoard.Controls.Add((Control)button11);
            gameBoard.Controls.Add((Control)button12);
            gameBoard.Controls.Add((Control)button13);
            gameBoard.Controls.Add((Control)button14);
            gameBoard.Controls.Add((Control)button15);
            gameBoard.Controls.Add((Control)button16);
            gameBoard.Controls.Add((Control)button17);
            gameBoard.Controls.Add((Control)button18);
            gameBoard.Controls.Add((Control)button19);
            gameBoard.Controls.Add((Control)button20);
            gameBoard.Controls.Add((Control)button21);
            gameBoard.Controls.Add((Control)button22);
            gameBoard.Controls.Add((Control)button23);
            gameBoard.Controls.Add((Control)button24);
            gameBoard.Controls.Add((Control)button25);
            gameBoard.Controls.Add((Control)button26);
            gameBoard.Controls.Add((Control)button27);
            gameBoard.Controls.Add((Control)button28);
            gameBoard.Controls.Add((Control)button29);
            gameBoard.Controls.Add((Control)button30);
            gameBoard.Controls.Add((Control)button31);
            gameBoard.Controls.Add((Control)button32);
            gameBoard.Controls.Add((Control)button33);
            gameBoard.Controls.Add((Control)button34);
            gameBoard.Controls.Add((Control)button35);
            gameBoard.Controls.Add((Control)button36);
            gameBoard.Controls.Add((Control)button37);
            gameBoard.Controls.Add((Control)button38);
            gameBoard.Controls.Add((Control)button39);
            gameBoard.Controls.Add((Control)button40);
            gameBoard.Controls.Add((Control)button41);
            gameBoard.Controls.Add((Control)button42);
            gameBoard.Controls.Add((Control)button43);
            gameBoard.Controls.Add((Control)button44);
            gameBoard.Controls.Add((Control)button45);
            gameBoard.Controls.Add((Control)button46);
            gameBoard.Controls.Add((Control)button47);
            gameBoard.Controls.Add((Control)button48);
            gameBoard.Controls.Add((Control)button49);
            gameBoard.Controls.Add((Control)button50);
            gameBoard.Controls.Add((Control)button51);
            gameBoard.Controls.Add((Control)button52);
            gameBoard.Controls.Add((Control)button53);
            gameBoard.Controls.Add((Control)button54);
            gameBoard.Controls.Add((Control)button55);
            gameBoard.Controls.Add((Control)button56);
            gameBoard.Controls.Add((Control)button57);
            gameBoard.Controls.Add((Control)button58);
            gameBoard.Controls.Add((Control)button59);
            gameBoard.Controls.Add((Control)button60);
            gameBoard.Controls.Add((Control)button61);
            gameBoard.Controls.Add((Control)button62);
            gameBoard.Controls.Add((Control)button63);
            gameBoard.Controls.Add((Control)button64);
            gameBoard.Controls.Add((Control)button65);
            gameBoard.Controls.Add((Control)button66);
            gameBoard.Controls.Add((Control)button67);
            gameBoard.Controls.Add((Control)button68);
            gameBoard.Controls.Add((Control)button69);
            gameBoard.Controls.Add((Control)button70);
            gameBoard.Controls.Add((Control)button71);
            gameBoard.Controls.Add((Control)button72);
            gameBoard.Controls.Add((Control)button73);
            gameBoard.Controls.Add((Control)button74);
            gameBoard.Controls.Add((Control)button75);
            gameBoard.Controls.Add((Control)button76);
            gameBoard.Controls.Add((Control)button77);
            gameBoard.Controls.Add((Control)button78);
            gameBoard.Controls.Add((Control)button79);
            gameBoard.Controls.Add((Control)button80);
            gameBoard.Controls.Add((Control)button81);
            this.gameBoard.ResumeLayout();
            this.ResumeLayout();
            this.BackColor = System.Drawing.Color.LightSkyBlue;
        }


        //
        // New Game !!!
        //
        private void startNewGame()
        {
            //
            //  initialize a new sudoko game and load in into the gameboard
            //
            int idx = 0;
            game.initGame();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    gameBoard.Controls[idx].Text = game.cel[i, j].ToString();
                    gameBoard.Controls[idx].BackColor = System.Drawing.Color.LightGray;
                    gameBoard.Controls[idx].ForeColor = System.Drawing.Color.Black;
                    game.attr[idx] = celAttributes.Set;
                    idx++;
                }
            }

            // 
            //  Blank out random spaces. Harder games will blank out more spaces
            ///
            blankSpace = 0;
            for (int i = 0; i < spotsToQuess; i++)
            {
                idx = game.r.Next(0, 80);
                if (game.attr[idx] != celAttributes.Hidden)
                {
                    blankSpace++;
                    gameBoard.Controls[idx].ForeColor = System.Drawing.Color.Yellow;
                    gameBoard.Controls[idx].BackColor = System.Drawing.Color.Yellow;
                    game.attr[idx] = celAttributes.Hidden;
                }
            }

            // 
            // Enable quess buttons
            //
            B1.Enabled = B2.Enabled = B3.Enabled = true;
            B4.Enabled = B5.Enabled = B6.Enabled = true;
            B7.Enabled = B8.Enabled = B9.Enabled = true;
            timer1.Interval = 1000;
            timer1.Start();
            minutes = 0;
            seconds = 0;
            MessageBox.Show("To play:\nFirst select a number\nThen select where you think it goes", 
                            "Good Luck, Have a Good Game", 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);

        }
        private void NewGame_Click(object sender, EventArgs e)
        {
            startNewGame();
        }

        //
        // What is the definition of brute strength programming? 
        // It is what follows .....
        //
        private void button1_Click(object sender, EventArgs e)
        {
            button_click(0);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            button_click(1);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            button_click(2);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            button_click(3);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            button_click(4);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            button_click(5);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            button_click(6);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            button_click(7);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            button_click(8);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            button_click(9);
        }
        private void button11_Click(object sender, EventArgs e)
        {
            button_click(10);
        }
        private void button12_Click(object sender, EventArgs e)
        {
            button_click(11);
        }
        private void button13_Click(object sender, EventArgs e)
        {
            button_click(12);
        }
        private void button14_Click(object sender, EventArgs e)
        {
            button_click(13);
        }
        private void button15_Click(object sender, EventArgs e)
        {
            button_click(14);
        }
        private void button16_Click(object sender, EventArgs e)
        {
            button_click(15);
        }
        private void button17_Click(object sender, EventArgs e)
        {
            button_click(16);
        }
        private void button18_Click(object sender, EventArgs e)
        {
            button_click(17);
        }
        private void button19_Click(object sender, EventArgs e)
        {
            button_click(18);
        }
        private void button20_Click(object sender, EventArgs e)
        {
            button_click(19);
        }
        private void button21_Click(object sender, EventArgs e)
        {
            button_click(20);
        }
        private void button22_Click(object sender, EventArgs e)
        {
            button_click(21);
        }
        private void button23_Click(object sender, EventArgs e)
        {
            button_click(22);
        }
        private void button24_Click(object sender, EventArgs e)
        {
            button_click(23);
        }
        private void button25_Click(object sender, EventArgs e)
        {
            button_click(24);
        }
        private void button26_Click(object sender, EventArgs e)
        {
            button_click(25);
        }
        private void button27_Click(object sender, EventArgs e)
        {
            button_click(26);
        }
        private void button28_Click(object sender, EventArgs e)
        {
            button_click(27);
        }
        private void button29_Click(object sender, EventArgs e)
        {
            button_click(28);
        }
        private void button30_Click(object sender, EventArgs e)
        {
            button_click(29);
        }
        private void button31_Click(object sender, EventArgs e)
        {
            button_click(30);
        }
        private void button32_Click(object sender, EventArgs e)
        {
            button_click(31);
        }
        private void button33_Click(object sender, EventArgs e)
        {
            button_click(32);
        }
        private void button34_Click(object sender, EventArgs e)
        {
            button_click(33);
        }
        private void button35_Click(object sender, EventArgs e)
        {
            button_click(34);
        }
        private void button36_Click(object sender, EventArgs e)
        {
            button_click(35);
        }
        private void button37_Click(object sender, EventArgs e)
        {
            button_click(36);
        }
        private void button38_Click(object sender, EventArgs e)
        {
            button_click(37);
        }
        private void button39_Click(object sender, EventArgs e)
        {
            button_click(38);
        }
        private void button40_Click(object sender, EventArgs e)
        {
            button_click(39);
        }
        private void button41_Click(object sender, EventArgs e)
        {
            button_click(40);
        }
        private void button42_Click(object sender, EventArgs e)
        {
            button_click(41);
        }
        private void button43_Click(object sender, EventArgs e)
        {
            button_click(42);
        }
        private void button44_Click(object sender, EventArgs e)
        {
            button_click(43);
        }
        private void button45_Click(object sender, EventArgs e)
        {
            button_click(44);
        }
        private void button46_Click(object sender, EventArgs e)
        {
            button_click(45);
        }
        private void button47_Click(object sender, EventArgs e)
        {
            button_click(46);
        }
        private void button48_Click(object sender, EventArgs e)
        {
            button_click(47);
        }
        private void button49_Click(object sender, EventArgs e)
        {
            button_click(48);
        }
        private void button50_Click(object sender, EventArgs e)
        {
            button_click(49);
        }
        private void button51_Click(object sender, EventArgs e)
        {
            button_click(50);
        }
        private void button52_Click(object sender, EventArgs e)
        {
            button_click(51);
        }
        private void button53_Click(object sender, EventArgs e)
        {
            button_click(52);
        }
        private void button54_Click(object sender, EventArgs e)
        {
            button_click(53);
        }
        private void button55_Click(object sender, EventArgs e)
        {
            button_click(54);
        }
        private void button56_Click(object sender, EventArgs e)
        {
            button_click(55);
        }
        private void button57_Click(object sender, EventArgs e)
        {
            button_click(56);
        }
        private void button58_Click(object sender, EventArgs e)
        {
            button_click(57);
        }
        private void button59_Click(object sender, EventArgs e)
        {
            button_click(58);
        }
        private void button60_Click(object sender, EventArgs e)
        {
            button_click(59);
        }
        private void button61_Click(object sender, EventArgs e)
        {
            button_click(60);
        }
        private void button62_Click(object sender, EventArgs e)
        {
            button_click(61);
        }
        private void button63_Click(object sender, EventArgs e)
        {
            button_click(62);
        }
        private void button64_Click(object sender, EventArgs e)
        {
            button_click(63);
        }
        private void button65_Click(object sender, EventArgs e)
        {
            button_click(64);
        }
        private void button66_Click(object sender, EventArgs e)
        {
            button_click(65);
        }
        private void button67_Click(object sender, EventArgs e)
        {
            button_click(66);
        }
        private void button68_Click(object sender, EventArgs e)
        {
            button_click(67);
        }
        private void button69_Click(object sender, EventArgs e)
        {
            button_click(68);
        }
        private void button70_Click(object sender, EventArgs e)
        {
            button_click(69);
        }
        private void button71_Click(object sender, EventArgs e)
        {
            button_click(70);
        }
        private void button72_Click(object sender, EventArgs e)
        {
            button_click(71);
        }
        private void button73_Click(object sender, EventArgs e)
        {
            button_click(72);
        }
        private void button74_Click(object sender, EventArgs e)
        {
            button_click(73);
        }
        private void button75_Click(object sender, EventArgs e)
        {
            button_click(74);
        }
        private void button76_Click(object sender, EventArgs e)
        {
            button_click(75);
        }
        private void button77_Click(object sender, EventArgs e)
        {
            button_click(76);
        }
        private void button78_Click(object sender, EventArgs e)
        {
            button_click(77);
        }
        private void button79_Click(object sender, EventArgs e)
        {
            button_click(78);
        }
        private void button80_Click(object sender, EventArgs e)
        {
            button_click(79);
        }
        private void button81_Click(object sender, EventArgs e)
        {
            button_click(80);
        }


        //
        // The player has made a choice. If the gameboard square matches the selected number,
        // reveal the correct choice. 
        //
        private void button_click(int idx)
        {
            if (game.attr[idx] == celAttributes.Hidden)
            {
                if (game.makeQuess == true && game.quess == gameBoard.Controls[idx].Text)
                {
                    gameBoard.Controls[idx].ForeColor = System.Drawing.Color.Black;
                    blankSpace--;
                }
                game.makeQuess = false;
                quessButton.BackColor = System.Drawing.Color.LightGray;
                if (blankSpace == 0)
                {
                    DialogResult r = MessageBox.Show("You Have Won! \n\nDo you want to play again?", "Winner  Winner  Winner", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (r == DialogResult.Yes)
                        startNewGame();
                    else
                        this.Close();
                }
            }
        }

        private void B1_Click(object sender, EventArgs e)
        {
            if (game.makeQuess == false)
            {
                quessButton = B1;
                quessButton.BackColor = System.Drawing.Color.Snow;
                game.makeQuess = true;
                game.quess = "1";
            }
        }
        private void B2_Click(object sender, EventArgs e)
        {
            if (game.makeQuess == false)
            {
                quessButton = B2;
                quessButton.BackColor = System.Drawing.Color.Snow;
                game.makeQuess = true;
                game.quess = "2";
            }
        }
        private void B3_Click(object sender, EventArgs e)
        {
            if (game.makeQuess == false)
            {
                quessButton = B3;
                quessButton.BackColor = System.Drawing.Color.Snow;
                game.makeQuess = true;
                game.quess = "3";
            }
        }
        private void B4_Click(object sender, EventArgs e)
        {
            if (game.makeQuess == false)
            {
                quessButton = B4;
                quessButton.BackColor = System.Drawing.Color.Snow;
                game.makeQuess = true;
                game.quess = "4";
            }
        }
        private void B5_Click(object sender, EventArgs e)
        {
            if (game.makeQuess == false)
            {
                quessButton = B5;
                quessButton.BackColor = System.Drawing.Color.Snow;
                game.makeQuess = true;
                game.quess = "5";
            }
        }
        private void B6_Click(object sender, EventArgs e)
        {
            if (game.makeQuess == false)
            {
                quessButton = B6;
                quessButton.BackColor = System.Drawing.Color.Snow;
                game.makeQuess = true;
                game.quess = "6";
            }
        }
        private void B7_Click(object sender, EventArgs e)
        {
            if (game.makeQuess == false)
            {
                quessButton = B7;
                quessButton.BackColor = System.Drawing.Color.Snow;
                game.makeQuess = true;
                game.quess = "7";
            }
        }
        private void B8_Click(object sender, EventArgs e)
        {
            if (game.makeQuess == false)
            {
                quessButton = B8;
                quessButton.BackColor = System.Drawing.Color.Snow;
                game.makeQuess = true;
                game.quess = "8";
            }
        }
        private void B9_Click(object sender, EventArgs e)
        {
            if (game.makeQuess == false)
            {
                quessButton = B9;
                quessButton.BackColor = System.Drawing.Color.Snow;
                game.makeQuess = true;
                game.quess = "9";
            }
        }

        private void easy_Click(object sender, EventArgs e)
        {
            spotsToQuess = 20;
        }

        private void Medium_Click(object sender, EventArgs e)
        {
            spotsToQuess = 30;
        }

        private void Hard_Click(object sender, EventArgs e)
        {
            spotsToQuess = 40;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            if (seconds == 60)
            {
                seconds = 0;
                minutes++;
                if (minutes == 10)
                {
                    DialogResult r = MessageBox.Show("Game Time has Elapsed\n\nDo you want to continue??",
                                                     "Time Has Expired",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Warning);
                    if (r == DialogResult.Yes)
                    {
                        minutes = 0;
                        seconds = 0;
                    }
                    else
                    {
                        timer1.Stop();
                        B1.Enabled = B2.Enabled = B3.Enabled = false;
                        B4.Enabled = B5.Enabled = B6.Enabled = false;
                        B7.Enabled = B8.Enabled = B9.Enabled = false;
                    }
                }
            }
            countDown.Text = minutes.ToString("D2")+":"+seconds.ToString("D2");
        }

    }
}