using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Label[] boxarray = new Label[9];
        String[] possibleWins = new String[8];
        bool xTurn;
        bool canClick = false;
        int numberClicks;
        private void Form1_Load(object sender, EventArgs e)
        {
            boxarray[0] = label2;

            boxarray[1] = label3;

            boxarray[2] = label4;

            boxarray[3] = label5;

            boxarray[4] = label6;

            boxarray[5] = label7;

            boxarray[6] = label8;
            boxarray[7] = label9;
            boxarray[8] = label10;

            possibleWins[0] = "012";
            possibleWins[1] = "345";
            possibleWins[2] = "678";
            possibleWins[3] = "036";
            possibleWins[4] = "147";
            possibleWins[5] = "258";
            possibleWins[6] = "048";
            possibleWins[7] = "246";

            for (int i = 0; i < 9; i++)
                boxarray[i].Text = "";
            Lbl1Message.Text = "Game Stopped";
            GrpFirst.Enabled = false;
            groupComputer.Enabled = false;

        }
        private void label7_Click(object sender, EventArgs e)
        {
            lblBox_Click( sender,e);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            lblBox_Click(sender, e);
        }

        private void label12_Click(object sender, EventArgs e)
        {
            lblBox_Click(sender, e);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(BtnStartStop.Text=="Start")
            {
                BtnStartStop.Text = "Stop Game";
                GrpPlayers.Enabled = false;
                GrpFirst.Enabled = false;
                groupComputer.Enabled = false;
                Exit.Enabled = false;
                xTurn = true;
                Lbl1Message.Text = "X's Turn";
              
                for (int i = 0; i < 9; i++)
                    boxarray[i].Text = "";
                canClick = true;
                numberClicks = 0;
            }

            else
            {
                BtnStartStop.Text = "Start Game";
                Lbl1Message.Text = "Game Stopped";
                GrpPlayers.Enabled = true;
                if (radioButton2.Checked)
                {
                    GrpFirst.Enabled = true;
                    groupComputer.Enabled = true;
                }
                Exit.Enabled = true;
                canClick = false;
            }


        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblBox_Click(object sender, EventArgs e)
        {
            String whoWon = "";
            int i;
            if (canClick)
            {
              
                Label clickedBox;
                clickedBox = (Label)sender;
               
                i = Convert.ToInt32(clickedBox.Name[clickedBox.Name.Length -1].ToString()) - 1;
               
                if (boxarray[i].Text != "")
                    return;
                numberClicks++;
                if (xTurn)
                {
                    boxarray[i].Text = "X";
                    xTurn = false;
                    Lbl1Message.Text = "O's Turn";
                }
                else
                {
                    boxarray[i].Text = "O";
                    xTurn = true;
                    Lbl1Message.Text = "X's Turn";
                }
             
                if (whoWon != "")
                {
                    Lbl1Message.Text = whoWon + " wins!";
                    BtnStartStop.PerformClick();
                    return;
                }
                else if (numberClicks == 9)
                {

                    Lbl1Message.Text = "It's a draw!";
                    BtnStartStop.PerformClick();
                    return;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            lblBox_Click(sender, e);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            lblBox_Click(sender, e);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            lblBox_Click(sender, e);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            lblBox_Click(sender, e);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            lblBox_Click(sender, e);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            lblBox_Click(sender, e);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            lblBox_Click(sender, e);
        }
    }
}
