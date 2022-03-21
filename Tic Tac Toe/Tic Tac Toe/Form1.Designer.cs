namespace Tic_Tac_Toe
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.playerscore_label2 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.player_score = new System.Windows.Forms.Label();
            this.computer_score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 78);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_onclick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(192, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 78);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_onclick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(281, 108);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 78);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_onclick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(103, 192);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 78);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_onclick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(192, 192);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(83, 78);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_onclick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(281, 192);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(83, 78);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_onclick);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(103, 276);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(83, 78);
            this.button7.TabIndex = 6;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_onclick);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(192, 276);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(83, 78);
            this.button8.TabIndex = 7;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_onclick);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(281, 276);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(83, 78);
            this.button9.TabIndex = 8;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_onclick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(480, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Score";
            // 
            // playerscore_label2
            // 
            this.playerscore_label2.AutoSize = true;
            this.playerscore_label2.Location = new System.Drawing.Point(480, 139);
            this.playerscore_label2.Name = "playerscore_label2";
            this.playerscore_label2.Size = new System.Drawing.Size(48, 16);
            this.playerscore_label2.TabIndex = 10;
            this.playerscore_label2.Text = "player:";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(480, 170);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(68, 16);
            this.l.TabIndex = 11;
            this.l.Text = "Computer:";
            // 
            // player_score
            // 
            this.player_score.AutoSize = true;
            this.player_score.Location = new System.Drawing.Point(554, 139);
            this.player_score.Name = "player_score";
            this.player_score.Size = new System.Drawing.Size(0, 16);
            this.player_score.TabIndex = 12;
            // 
            // computer_score
            // 
            this.computer_score.AutoSize = true;
            this.computer_score.Location = new System.Drawing.Point(554, 170);
            this.computer_score.Name = "computer_score";
            this.computer_score.Size = new System.Drawing.Size(0, 16);
            this.computer_score.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.computer_score);
            this.Controls.Add(this.player_score);
            this.Controls.Add(this.l);
            this.Controls.Add(this.playerscore_label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label playerscore_label2;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label player_score;
        private System.Windows.Forms.Label computer_score;
    }
}

