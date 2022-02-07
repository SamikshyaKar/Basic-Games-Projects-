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

            for (int i = 0; i < 9; i++)
                boxarray[i].Text = "";
            Lbl1Message.Text = "Game Stopped";
            GrpFirst.Enabled = false;
            groupComputer.Enabled = false;

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BtnStartStop.Text = "Stop Game";
            GrpPlayers.Enabled = false;
            GrpFirst.Enabled = false;
            groupComputer.Enabled = false;
            Exit.Enabled = false;
            xTurn = true;
            Lbl1Message.Text = "X's Turn";
            // reset boxes
            for (int i = 0; i < 9; i++)
                boxarray[i].Text = "";
            canClick = true;
            numberClicks = 0;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
