﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {

        Boolean checker;
        int plusone;

        void Enable_False()
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

        void score()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X") {

                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
            
            MessageBox.Show("The Winner is Player X","Tic-tac-toe",MessageBoxButtons.OK,MessageBoxIcon.Information);

            plusone = int.Parse(label4.Text);
            label4.Text = Convert.ToString(plusone + 1);
            Enable_False();
            }




            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {

                button1.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button7.BackColor = Color.Red;

                MessageBox.Show("The Winner is Player X", "Tic-tac-toe", MessageBoxButtons.OK, MessageBoxIcon.Information);

                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }


            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {

                button1.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button9.BackColor = Color.Red;

                MessageBox.Show("The Winner is Player X", "Tic-tac-toe", MessageBoxButtons.OK, MessageBoxIcon.Information);

                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone+1);
                Enable_False();
            }




            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {

                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button7.BackColor = Color.Red;

                MessageBox.Show("The Winner is Player X", "Tic-tac-toe", MessageBoxButtons.OK, MessageBoxIcon.Information);

                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone+1);
                Enable_False();
            }

            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {

                button2.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button8.BackColor = Color.Red;

                MessageBox.Show("The Winner is Player X", "Tic-tac-toe", MessageBoxButtons.OK, MessageBoxIcon.Information);

                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone+1);
                Enable_False();
            }

            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {

                button3.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button9.BackColor = Color.Red;

                MessageBox.Show("The Winner is Player X", "Tic-tac-toe", MessageBoxButtons.OK, MessageBoxIcon.Information);

                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone+1);
                Enable_False();
            }




            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {

                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;

                MessageBox.Show("The Winner is Player X", "Tic-tac-toe", MessageBoxButtons.OK, MessageBoxIcon.Information);

                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone+1);
                Enable_False();
            }




            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {

                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;

                MessageBox.Show("The Winner is Player X", "Tic-tac-toe", MessageBoxButtons.OK, MessageBoxIcon.Information);

                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone+1);
                Enable_False();
            }





            //**********player o*************



            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {

                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;

                MessageBox.Show("The Winner is Player O", "Tic-tac-toe", MessageBoxButtons.OK, MessageBoxIcon.Information);

                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone+1);
                Enable_False();
            }




            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {

                button1.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button7.BackColor = Color.Red;

                MessageBox.Show("The Winner is Player O", "Tic-tac-toe", MessageBoxButtons.OK, MessageBoxIcon.Information);

                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone+1);
                Enable_False();
            }


            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {

                button1.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button9.BackColor = Color.Red;

                MessageBox.Show("The Winner is Player O", "Tic-tac-toe", MessageBoxButtons.OK, MessageBoxIcon.Information);

                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone+1);
                Enable_False();
            }




            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {

                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button7.BackColor = Color.Red;

                MessageBox.Show("The Winner is Player O", "Tic-tac-toe", MessageBoxButtons.OK, MessageBoxIcon.Information);

                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone+1);
                Enable_False();
            }

            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {

                button2.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button8.BackColor = Color.Red;

                MessageBox.Show("The Winner is Player O", "Tic-tac-toe", MessageBoxButtons.OK, MessageBoxIcon.Information);

                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone+1);
                Enable_False();
            }

            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {

                button3.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button9.BackColor = Color.Red;

                MessageBox.Show("The Winner is Player O", "Tic-tac-toe", MessageBoxButtons.OK, MessageBoxIcon.Information);

                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone+1);
                Enable_False();
            }




            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {

                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;

                MessageBox.Show("The Winner is Player O", "Tic-tac-toe", MessageBoxButtons.OK, MessageBoxIcon.Information);

                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone+1);
                Enable_False();
            }




            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {

                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;

                MessageBox.Show("The Winner is Player O", "Tic-tac-toe", MessageBoxButtons.OK, MessageBoxIcon.Information);

                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone+1);
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button1.Text = "X";
                checker = true;

            }
            else
            {

                button1.Text = "O";
                checker = false;
            }
            score();
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button2.Text = "X";
                checker = true;

            }
            else
            {

                button2.Text = "O";
                checker = false;
            }
            score();
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button3.Text = "X";
                checker = true;

            }
            else
            {

                button3.Text = "O";
                checker = false;
            }
            score();
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button4.Text = "X";
                checker = true;

            }
            else
            {

                button4.Text = "O";
                checker = false;
            }
            score();
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button5.Text = "X";
                checker = true;

            }
            else
            {

                button5.Text = "O";
                checker = false;
            }
            score();
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button6.Text = "X";
                checker = true;

            }
            else
            {

                button6.Text = "O";
                checker = false;
            }
            score();
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button7.Text = "X";
                checker = true;

            }
            else
            {

                button7.Text = "O";
                checker = false;
            }
            score();
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button8.Text = "X";
                checker = true;

            }
            else
            {

                button8.Text = "O";
                checker = false;
            }
            score();
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button9.Text = "X";
                checker = true;

            }
            else
            {

                button9.Text = "O";
                checker = false;
            }
            score();
            button9.Enabled = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
                try{

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;



            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            label4.Text = "0";
            label5.Text = "0";



            button1.BackColor = Color.WhiteSmoke;
            button2.BackColor = Color.WhiteSmoke;
            button3.BackColor = Color.WhiteSmoke;
            button4.BackColor = Color.WhiteSmoke;
            button5.BackColor = Color.WhiteSmoke;
            button6.BackColor = Color.WhiteSmoke;
            button7.BackColor = Color.WhiteSmoke;
            button8.BackColor = Color.WhiteSmoke;
            button9.BackColor = Color.WhiteSmoke;

        }
             catch(Exception ex)
            {

                MessageBox.Show(ex.Message, "Tic Tac Toe",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try{
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;



            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";


            button12.Enabled = true;

            button1.BackColor = Color.WhiteSmoke;
            button2.BackColor = Color.WhiteSmoke;
            button3.BackColor = Color.WhiteSmoke;
            button4.BackColor = Color.WhiteSmoke;
            button5.BackColor = Color.WhiteSmoke;
            button6.BackColor = Color.WhiteSmoke;
            button7.BackColor = Color.WhiteSmoke;
            button8.BackColor = Color.WhiteSmoke;
            button9.BackColor = Color.WhiteSmoke;
            }
             catch(Exception ex)
            {

                MessageBox.Show(ex.Message, "Tic Tac Toe",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult IExit;
                IExit = MessageBox.Show("Confirm to exit", "Tic Tac Toe",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);


                if(IExit == DialogResult.Yes){
                    Application.Exit();
                }
            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message, "Tic Tac Toe",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            }
        }
    }

