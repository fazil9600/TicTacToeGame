using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeGame
{
    public partial class Form1 : Form
    {
        bool checker;
        int plusone;

        void Enable_False()
        {
            bt_1.Enabled = false;
            bt_2.Enabled = false;
            bt_3.Enabled = false;
            bt_4.Enabled = false;
            bt_5.Enabled = false;
            bt_6.Enabled = false;
            bt_7.Enabled = false;
            bt_8.Enabled = false;
            bt_9.Enabled = false;
        }

        void score()
        {
            if(bt_1.Text == "X" && bt_2.Text == "X" && bt_3.Text == "X")
            {
                bt_1.BackColor = Color.PowderBlue;
                bt_2.BackColor = Color.PowderBlue;
                bt_3.BackColor = Color.PowderBlue;

                MessageBox.Show("The Winner is X","TicTacToe",MessageBoxButtons.OK,MessageBoxIcon.Information);
                plusone = int.Parse(lb_player_X.Text);
                lb_player_X.Text = Convert.ToString(plusone+1);
                Enable_False();

            }

            if (bt_1.Text == "X" && bt_4.Text == "X" && bt_7.Text == "X")
            {
                bt_1.BackColor = Color.PowderBlue;
                bt_4.BackColor = Color.PowderBlue;
                bt_7.BackColor = Color.PowderBlue;

                MessageBox.Show("The Winner is X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lb_player_X.Text);
                lb_player_X.Text = Convert.ToString(plusone+1);
                Enable_False();

            }

            if (bt_1.Text == "X" && bt_5.Text == "X" && bt_9.Text == "X")
            {
                bt_1.BackColor = Color.DeepPink;
                bt_5.BackColor = Color.DeepPink;
                bt_9.BackColor = Color.DeepPink; 

                MessageBox.Show("The Winner is X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lb_player_X.Text);
                lb_player_X.Text = Convert.ToString(plusone+1);
                Enable_False();

            }

            if (bt_3.Text == "X" && bt_5.Text == "X" && bt_7.Text == "X")
            {
                bt_3.BackColor = Color.Crimson;
                bt_5.BackColor = Color.Crimson;
                bt_7.BackColor = Color.Crimson;

                MessageBox.Show("The Winner is X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lb_player_X.Text);
                lb_player_X.Text = Convert.ToString(plusone+1);
                Enable_False();

            }

            if (bt_2.Text == "X" && bt_5.Text == "X" && bt_8.Text == "X")
            {
                bt_2.BackColor = Color.CadetBlue;
                bt_5.BackColor = Color.CadetBlue;
                bt_8.BackColor = Color.CadetBlue;
                ge
                MessageBox.Show("The Winner is X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lb_player_X.Text);
                lb_player_X.Text = Convert.ToString(plusone+1);
                Enable_False();

            }


            if (bt_1.Text == "O" && bt_2.Text == "O" && bt_3.Text == "O")
            {
                bt_1.BackColor = System.Drawing.Color.AliceBlue;
                bt_2.BackColor = System.Drawing.Color.AliceBlue;
                bt_3.BackColor = System.Drawing.Color.AliceBlue;

                MessageBox.Show("The Winner is O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lb_player_0.Text);
                lb_player_0.Text = Convert.ToString(plusone+1);
                Enable_False();

            }


            if (bt_1.Text == "O" && bt_4.Text == "O" && bt_7.Text == "O")
            {
                bt_1.BackColor = System.Drawing.Color.Purple;
                bt_4.BackColor = System.Drawing.Color.Purple;
                bt_7.BackColor = System.Drawing.Color.Purple;

                MessageBox.Show("The Winner is O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lb_player_0.Text);
                lb_player_0.Text = Convert.ToString(plusone + 1);
                Enable_False();

            }

            if (bt_1.Text == "O" && bt_5.Text == "O" && bt_9.Text == "O")
            {
                bt_1.BackColor = System.Drawing.Color.YellowGreen;
                bt_5.BackColor = System.Drawing.Color.YellowGreen;
                bt_9.BackColor = System.Drawing.Color.YellowGreen;

                MessageBox.Show("The Winner is O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lb_player_0.Text);
                lb_player_0.Text = Convert.ToString(plusone + 1);
                Enable_False();

            }

            if (bt_3.Text == "O" && bt_5.Text == "O" && bt_7.Text == "O")
            {
                bt_3.BackColor = System.Drawing.Color.BlueViolet;
                bt_5.BackColor = System.Drawing.Color.BlueViolet;
                bt_7.BackColor = System.Drawing.Color.BlueViolet;

                MessageBox.Show("The Winner is O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lb_player_0.Text);
                lb_player_0.Text = Convert.ToString(plusone + 1);
                Enable_False();

            }

            if (bt_2.Text == "O" && bt_5.Text == "O" && bt_8.Text == "O")
            {
                bt_2.BackColor = System.Drawing.Color.DarkKhaki;
                bt_5.BackColor = System.Drawing.Color.DarkKhaki;
                bt_8.BackColor = System.Drawing.Color.DarkKhaki;

                MessageBox.Show("The Winner is O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lb_player_0.Text);
                lb_player_0.Text = Convert.ToString(plusone + 1);
                Enable_False();

            }

            if (bt_3.Text == "O" && bt_6.Text == "O" && bt_9.Text == "O")
            {
                bt_3.BackColor = System.Drawing.Color.BurlyWood;
                bt_6.BackColor = System.Drawing.Color.BurlyWood;
                bt_9.BackColor = System.Drawing.Color.BurlyWood;

                MessageBox.Show("The Winner is O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lb_player_0.Text);
                lb_player_0.Text = Convert.ToString(plusone + 1);
                Enable_False();

            }

            if (bt_4.Text == "O" && bt_5.Text == "O" && bt_6.Text == "O")
            {
                bt_4.BackColor = System.Drawing.Color.OliveDrab;
                bt_5.BackColor = System.Drawing.Color.OliveDrab;
                bt_6.BackColor = System.Drawing.Color.OliveDrab;

                MessageBox.Show("The Winner is O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lb_player_0.Text);
                lb_player_0.Text = Convert.ToString(plusone + 1);
                Enable_False();

            }

            if (bt_7.Text == "O" && bt_8.Text == "O" && bt_9.Text == "O")
            {
                bt_7.BackColor = System.Drawing.Color.Lavender;
                bt_8.BackColor = System.Drawing.Color.Lavender;
                bt_9.BackColor = System.Drawing.Color.Lavender;

                MessageBox.Show("The Winner is O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lb_player_0.Text);
                lb_player_0.Text = Convert.ToString(plusone + 1);
                Enable_False();

            }






        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt_1_Click(object sender, EventArgs e)
        {
            if(checker == false)
            {
                bt_1.Text = "X";
                checker = true;
            }
            else
            {
                bt_1.Text = "O";
                checker = false;
            }
            score();
            bt_1.Enabled = false;
        }

        private void bt_2_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                bt_2.Text = "X";
                checker = true;
            }
            else
            {
                bt_2.Text = "O";
                checker = false;
            }
            score();
            bt_2.Enabled = false;
        }

        private void bt_3_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                bt_3.Text = "X";
                checker = true;
            }
            else
            {
                bt_3.Text = "O";
                checker = false;
            }
            score();
            bt_3.Enabled = false;
        }

        private void bt_4_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                bt_4.Text = "X";
                checker = true;
            }
            else
            {
                bt_4.Text = "O";
                checker = false;
            }
            score();
            bt_4.Enabled = false;
        }

        private void bt_5_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                bt_5.Text = "X";
                checker = true;
            }
            else
            {
                bt_5.Text = "O";
                checker = false;
            }
            score();
            bt_5.Enabled = false;
        }

        private void bt_6_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                bt_6.Text = "X";
                checker = true;
            }
            else
            {
                bt_6.Text = "O";
                checker = false;
            }
            score();
            bt_6.Enabled = false;
        }

        private void bt_7_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                bt_7.Text = "X";
                checker = true;
            }
            else
            {
                bt_7.Text = "O";
                checker = false;
            }
            score();
            bt_7.Enabled = false;
        }

        private void bt_8_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                bt_8.Text = "X";
                checker = true;
            }
            else
            {
                bt_8.Text = "O";
                checker = false;
            }
            score();
            bt_8.Enabled = false;
        }

        private void bt_9_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                bt_9.Text = "X";
                checker = true;
            }
            else
            {
                bt_9.Text = "O";
                checker = false;
            }
            score();
            bt_9.Enabled = false;
        }

        private void bt_new_game_Click(object sender, EventArgs e)
        {
            try
            {
                bt_1.Enabled = true;
                bt_2.Enabled = true;
                bt_3.Enabled = true;
                bt_4.Enabled = true;
                bt_5.Enabled = true;
                bt_6.Enabled = true;
                bt_7.Enabled = true;
                bt_8.Enabled = true;
                bt_9.Enabled = true;

                bt_1.Text = "";
                bt_2.Text = "";
                bt_3.Text = "";
                bt_4.Text = "";
                bt_5.Text = "";
                bt_6.Text = "";
                bt_7.Text = "";
                bt_8.Text = "";
                bt_9.Text = "";

                lb_player_X.Text = "0";
                lb_player_0.Text = "0";

                bt_1.BackColor = Color.WhiteSmoke;
                bt_2.BackColor = Color.WhiteSmoke;
                bt_3.BackColor = Color.WhiteSmoke;
                bt_4.BackColor = Color.WhiteSmoke;
                bt_5.BackColor = Color.WhiteSmoke;
                bt_6.BackColor = Color.WhiteSmoke;
                bt_7.BackColor = Color.WhiteSmoke;
                bt_8.BackColor = Color.WhiteSmoke;
                bt_9.BackColor = Color.WhiteSmoke;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            try
            {
                bt_1.Enabled = true;
                bt_2.Enabled = true;
                bt_3.Enabled = true;
                bt_4.Enabled = true;
                bt_5.Enabled = true;
                bt_6.Enabled = true;
                bt_7.Enabled = true;
                bt_8.Enabled = true;
                bt_9.Enabled = true;

                bt_1.Text = "";
                bt_2.Text = "";
                bt_3.Text = "";
                bt_4.Text = "";
                bt_5.Text = "";
                bt_6.Text = "";
                bt_7.Text = "";
                bt_8.Text = "";
                bt_9.Text = "";

                bt_new_game.Enabled = true;

                bt_1.BackColor = Color.WhiteSmoke;
                bt_2.BackColor = Color.WhiteSmoke;
                bt_3.BackColor = Color.WhiteSmoke;
                bt_4.BackColor = Color.WhiteSmoke;
                bt_5.BackColor = Color.WhiteSmoke;
                bt_6.BackColor = Color.WhiteSmoke;
                bt_7.BackColor = Color.WhiteSmoke;
                bt_8.BackColor = Color.WhiteSmoke;
                bt_9.BackColor = Color.WhiteSmoke;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit;
                iExit = MessageBox.Show("Are you sure", "TicTacToe",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (iExit == DialogResult.Yes)
                {
                    Application.Exit();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
