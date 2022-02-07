
namespace WindowsForms_Tic_Tac_Toe
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl1Message = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.GrpPlayers = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.GrpFirst = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.BtnStartStop = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.groupComputer = new System.Windows.Forms.GroupBox();
            this.Smart = new System.Windows.Forms.RadioButton();
            this.Random = new System.Windows.Forms.RadioButton();
            this.GrpPlayers.SuspendLayout();
            this.GrpFirst.SuspendLayout();
            this.groupComputer.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl1Message
            // 
            this.Lbl1Message.BackColor = System.Drawing.Color.LightCoral;
            this.Lbl1Message.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl1Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl1Message.ForeColor = System.Drawing.Color.Yellow;
            this.Lbl1Message.Location = new System.Drawing.Point(12, 25);
            this.Lbl1Message.Name = "Lbl1Message";
            this.Lbl1Message.Size = new System.Drawing.Size(388, 23);
            this.Lbl1Message.TabIndex = 0;
            this.Lbl1Message.Text = "X\'s Move";
            this.Lbl1Message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(153, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "X";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(318, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "X";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "X";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(153, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "X";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(332, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "X";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(12, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 23);
            this.label8.TabIndex = 9;
            this.label8.Text = "X";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(165, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 23);
            this.label9.TabIndex = 8;
            this.label9.Text = "X";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(332, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 23);
            this.label10.TabIndex = 7;
            this.label10.Text = "X";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label11.Location = new System.Drawing.Point(12, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(364, 21);
            this.label11.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label12.Location = new System.Drawing.Point(12, 222);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(364, 19);
            this.label12.TabIndex = 11;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label13.Location = new System.Drawing.Point(95, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 233);
            this.label13.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label14.Location = new System.Drawing.Point(247, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 233);
            this.label14.TabIndex = 13;
            // 
            // GrpPlayers
            // 
            this.GrpPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.GrpPlayers.Controls.Add(this.radioButton2);
            this.GrpPlayers.Controls.Add(this.radioButton1);
            this.GrpPlayers.Location = new System.Drawing.Point(497, 25);
            this.GrpPlayers.Name = "GrpPlayers";
            this.GrpPlayers.Size = new System.Drawing.Size(268, 100);
            this.GrpPlayers.TabIndex = 14;
            this.GrpPlayers.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(30, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(102, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "TwoPlayers";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(30, 56);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(96, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "OnePlayer";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // GrpFirst
            // 
            this.GrpFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.GrpFirst.Controls.Add(this.radioButton4);
            this.GrpFirst.Controls.Add(this.radioButton3);
            this.GrpFirst.Location = new System.Drawing.Point(497, 131);
            this.GrpFirst.Name = "GrpFirst";
            this.GrpFirst.Size = new System.Drawing.Size(268, 100);
            this.GrpFirst.TabIndex = 15;
            this.GrpFirst.TabStop = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.ForeColor = System.Drawing.Color.White;
            this.radioButton3.Location = new System.Drawing.Point(17, 39);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 21);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "You First";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.ForeColor = System.Drawing.Color.White;
            this.radioButton4.Location = new System.Drawing.Point(17, 66);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(117, 21);
            this.radioButton4.TabIndex = 2;
            this.radioButton4.Text = "ComputerFirst";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // BtnStartStop
            // 
            this.BtnStartStop.Location = new System.Drawing.Point(507, 364);
            this.BtnStartStop.Name = "BtnStartStop";
            this.BtnStartStop.Size = new System.Drawing.Size(268, 23);
            this.BtnStartStop.TabIndex = 16;
            this.BtnStartStop.Text = "Start";
            this.BtnStartStop.UseVisualStyleBackColor = true;
            this.BtnStartStop.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(507, 406);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(268, 23);
            this.Exit.TabIndex = 17;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // groupComputer
            // 
            this.groupComputer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupComputer.Controls.Add(this.Smart);
            this.groupComputer.Controls.Add(this.Random);
            this.groupComputer.Location = new System.Drawing.Point(497, 247);
            this.groupComputer.Name = "groupComputer";
            this.groupComputer.Size = new System.Drawing.Size(268, 100);
            this.groupComputer.TabIndex = 18;
            this.groupComputer.TabStop = false;
            // 
            // Smart
            // 
            this.Smart.AutoSize = true;
            this.Smart.ForeColor = System.Drawing.Color.White;
            this.Smart.Location = new System.Drawing.Point(17, 66);
            this.Smart.Name = "Smart";
            this.Smart.Size = new System.Drawing.Size(131, 21);
            this.Smart.TabIndex = 2;
            this.Smart.Text = "Smart Computer";
            this.Smart.UseVisualStyleBackColor = true;
            // 
            // Random
            // 
            this.Random.AutoSize = true;
            this.Random.Checked = true;
            this.Random.ForeColor = System.Drawing.Color.White;
            this.Random.Location = new System.Drawing.Point(17, 39);
            this.Random.Name = "Random";
            this.Random.Size = new System.Drawing.Size(147, 21);
            this.Random.TabIndex = 1;
            this.Random.TabStop = true;
            this.Random.Text = "Random Computer";
            this.Random.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupComputer);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.BtnStartStop);
            this.Controls.Add(this.GrpFirst);
            this.Controls.Add(this.GrpPlayers);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lbl1Message);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic_Tac_Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GrpPlayers.ResumeLayout(false);
            this.GrpPlayers.PerformLayout();
            this.GrpFirst.ResumeLayout(false);
            this.GrpFirst.PerformLayout();
            this.groupComputer.ResumeLayout(false);
            this.groupComputer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl1Message;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox GrpPlayers;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox GrpFirst;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button BtnStartStop;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.GroupBox groupComputer;
        private System.Windows.Forms.RadioButton Smart;
        private System.Windows.Forms.RadioButton Random;
    }
}

