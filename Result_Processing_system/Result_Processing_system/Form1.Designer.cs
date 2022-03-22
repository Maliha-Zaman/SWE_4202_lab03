namespace Result_Processing_system
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Idsearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.attendance = new System.Windows.Forms.Label();
            this.final = new System.Windows.Forms.Label();
            this.mid = new System.Windows.Forms.Label();
            this.quiztotal = new System.Windows.Forms.Label();
            this.quiz4 = new System.Windows.Forms.Label();
            this.quiz3 = new System.Windows.Forms.Label();
            this.quiz2 = new System.Windows.Forms.Label();
            this.quiz1 = new System.Windows.Forms.Label();
            this.viva = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.grade = new System.Windows.Forms.Label();
            this.percen = new System.Windows.Forms.Label();
            this.label_attendance = new System.Windows.Forms.Label();
            this.label_q1 = new System.Windows.Forms.Label();
            this.label_q2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_q3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_qtotal = new System.Windows.Forms.Label();
            this.label_mid = new System.Windows.Forms.Label();
            this.label_final = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label_viva = new System.Windows.Forms.Label();
            this.label_Total = new System.Windows.Forms.Label();
            this.label_percen = new System.Windows.Forms.Label();
            this.label_grade = new System.Windows.Forms.Label();
            this.label_q4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(91, 128);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(203, 228);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(529, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // textBox_Idsearch
            // 
            this.textBox_Idsearch.Location = new System.Drawing.Point(556, 42);
            this.textBox_Idsearch.Name = "textBox_Idsearch";
            this.textBox_Idsearch.Size = new System.Drawing.Size(100, 22);
            this.textBox_Idsearch.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(565, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ClickonSearch);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Result Processing System";
            // 
            // attendance
            // 
            this.attendance.AutoSize = true;
            this.attendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendance.Location = new System.Drawing.Point(528, 148);
            this.attendance.Name = "attendance";
            this.attendance.Size = new System.Drawing.Size(98, 20);
            this.attendance.TabIndex = 6;
            this.attendance.Text = "Attendance:";
            // 
            // final
            // 
            this.final.AutoSize = true;
            this.final.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.final.Location = new System.Drawing.Point(528, 288);
            this.final.Name = "final";
            this.final.Size = new System.Drawing.Size(50, 20);
            this.final.TabIndex = 7;
            this.final.Text = "Final:";
            // 
            // mid
            // 
            this.mid.AutoSize = true;
            this.mid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mid.Location = new System.Drawing.Point(528, 268);
            this.mid.Name = "mid";
            this.mid.Size = new System.Drawing.Size(41, 20);
            this.mid.TabIndex = 8;
            this.mid.Text = "MId:";
            // 
            // quiztotal
            // 
            this.quiztotal.AutoSize = true;
            this.quiztotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quiztotal.Location = new System.Drawing.Point(528, 248);
            this.quiztotal.Name = "quiztotal";
            this.quiztotal.Size = new System.Drawing.Size(152, 20);
            this.quiztotal.TabIndex = 9;
            this.quiztotal.Text = "Quiz Total(Best 3):";
            // 
            // quiz4
            // 
            this.quiz4.AutoSize = true;
            this.quiz4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quiz4.Location = new System.Drawing.Point(528, 228);
            this.quiz4.Name = "quiz4";
            this.quiz4.Size = new System.Drawing.Size(63, 20);
            this.quiz4.TabIndex = 10;
            this.quiz4.Text = "Quiz 4:";
            // 
            // quiz3
            // 
            this.quiz3.AutoSize = true;
            this.quiz3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quiz3.Location = new System.Drawing.Point(528, 208);
            this.quiz3.Name = "quiz3";
            this.quiz3.Size = new System.Drawing.Size(63, 20);
            this.quiz3.TabIndex = 11;
            this.quiz3.Text = "Quiz 3:";
            // 
            // quiz2
            // 
            this.quiz2.AutoSize = true;
            this.quiz2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quiz2.Location = new System.Drawing.Point(528, 188);
            this.quiz2.Name = "quiz2";
            this.quiz2.Size = new System.Drawing.Size(63, 20);
            this.quiz2.TabIndex = 12;
            this.quiz2.Text = "Quiz 2:";
            // 
            // quiz1
            // 
            this.quiz1.AutoSize = true;
            this.quiz1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quiz1.Location = new System.Drawing.Point(528, 168);
            this.quiz1.Name = "quiz1";
            this.quiz1.Size = new System.Drawing.Size(63, 20);
            this.quiz1.TabIndex = 13;
            this.quiz1.Text = "Quiz 1:";
            // 
            // viva
            // 
            this.viva.AutoSize = true;
            this.viva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viva.Location = new System.Drawing.Point(528, 308);
            this.viva.Name = "viva";
            this.viva.Size = new System.Drawing.Size(46, 20);
            this.viva.TabIndex = 14;
            this.viva.Text = "Viva:";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(528, 328);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(141, 20);
            this.total.TabIndex = 15;
            this.total.Text = "Total(Out of 300):";
            // 
            // grade
            // 
            this.grade.AutoSize = true;
            this.grade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grade.Location = new System.Drawing.Point(528, 368);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(60, 20);
            this.grade.TabIndex = 16;
            this.grade.Text = "Grade:";
            // 
            // percen
            // 
            this.percen.AutoSize = true;
            this.percen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percen.Location = new System.Drawing.Point(528, 348);
            this.percen.Name = "percen";
            this.percen.Size = new System.Drawing.Size(99, 20);
            this.percen.TabIndex = 17;
            this.percen.Text = "Percentage:";
            // 
            // label_attendance
            // 
            this.label_attendance.AutoSize = true;
            this.label_attendance.Location = new System.Drawing.Point(648, 152);
            this.label_attendance.Name = "label_attendance";
            this.label_attendance.Size = new System.Drawing.Size(0, 16);
            this.label_attendance.TabIndex = 18;
            // 
            // label_q1
            // 
            this.label_q1.AutoSize = true;
            this.label_q1.Location = new System.Drawing.Point(648, 172);
            this.label_q1.Name = "label_q1";
            this.label_q1.Size = new System.Drawing.Size(0, 16);
            this.label_q1.TabIndex = 19;
            // 
            // label_q2
            // 
            this.label_q2.AutoSize = true;
            this.label_q2.Location = new System.Drawing.Point(648, 192);
            this.label_q2.Name = "label_q2";
            this.label_q2.Size = new System.Drawing.Size(0, 16);
            this.label_q2.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(648, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 21;
            // 
            // label_q3
            // 
            this.label_q3.AutoSize = true;
            this.label_q3.Location = new System.Drawing.Point(648, 212);
            this.label_q3.Name = "label_q3";
            this.label_q3.Size = new System.Drawing.Size(0, 16);
            this.label_q3.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(648, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 16);
            this.label8.TabIndex = 23;
            // 
            // label_qtotal
            // 
            this.label_qtotal.AutoSize = true;
            this.label_qtotal.Location = new System.Drawing.Point(686, 252);
            this.label_qtotal.Name = "label_qtotal";
            this.label_qtotal.Size = new System.Drawing.Size(0, 16);
            this.label_qtotal.TabIndex = 24;
            // 
            // label_mid
            // 
            this.label_mid.AutoSize = true;
            this.label_mid.Location = new System.Drawing.Point(648, 272);
            this.label_mid.Name = "label_mid";
            this.label_mid.Size = new System.Drawing.Size(0, 16);
            this.label_mid.TabIndex = 25;
            // 
            // label_final
            // 
            this.label_final.AutoSize = true;
            this.label_final.Location = new System.Drawing.Point(648, 292);
            this.label_final.Name = "label_final";
            this.label_final.Size = new System.Drawing.Size(0, 16);
            this.label_final.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(648, 312);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 16);
            this.label12.TabIndex = 27;
            // 
            // label_viva
            // 
            this.label_viva.AutoSize = true;
            this.label_viva.Location = new System.Drawing.Point(648, 311);
            this.label_viva.Name = "label_viva";
            this.label_viva.Size = new System.Drawing.Size(0, 16);
            this.label_viva.TabIndex = 28;
            // 
            // label_Total
            // 
            this.label_Total.AutoSize = true;
            this.label_Total.Location = new System.Drawing.Point(666, 331);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(0, 16);
            this.label_Total.TabIndex = 29;
            // 
            // label_percen
            // 
            this.label_percen.AutoSize = true;
            this.label_percen.Location = new System.Drawing.Point(666, 352);
            this.label_percen.Name = "label_percen";
            this.label_percen.Size = new System.Drawing.Size(0, 16);
            this.label_percen.TabIndex = 30;
            // 
            // label_grade
            // 
            this.label_grade.AutoSize = true;
            this.label_grade.Location = new System.Drawing.Point(666, 372);
            this.label_grade.Name = "label_grade";
            this.label_grade.Size = new System.Drawing.Size(0, 16);
            this.label_grade.TabIndex = 31;
            // 
            // label_q4
            // 
            this.label_q4.AutoSize = true;
            this.label_q4.Location = new System.Drawing.Point(648, 231);
            this.label_q4.Name = "label_q4";
            this.label_q4.Size = new System.Drawing.Size(0, 16);
            this.label_q4.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_q4);
            this.Controls.Add(this.label_grade);
            this.Controls.Add(this.label_percen);
            this.Controls.Add(this.label_Total);
            this.Controls.Add(this.label_viva);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label_final);
            this.Controls.Add(this.label_mid);
            this.Controls.Add(this.label_qtotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label_q3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_q2);
            this.Controls.Add(this.label_q1);
            this.Controls.Add(this.label_attendance);
            this.Controls.Add(this.percen);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.total);
            this.Controls.Add(this.viva);
            this.Controls.Add(this.quiz1);
            this.Controls.Add(this.quiz2);
            this.Controls.Add(this.quiz3);
            this.Controls.Add(this.quiz4);
            this.Controls.Add(this.quiztotal);
            this.Controls.Add(this.mid);
            this.Controls.Add(this.final);
            this.Controls.Add(this.attendance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_Idsearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Idsearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label attendance;
        private System.Windows.Forms.Label final;
        private System.Windows.Forms.Label mid;
        private System.Windows.Forms.Label quiztotal;
        private System.Windows.Forms.Label quiz4;
        private System.Windows.Forms.Label quiz3;
        private System.Windows.Forms.Label quiz2;
        private System.Windows.Forms.Label quiz1;
        private System.Windows.Forms.Label viva;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label grade;
        private System.Windows.Forms.Label percen;
        private System.Windows.Forms.Label label_attendance;
        private System.Windows.Forms.Label label_q1;
        private System.Windows.Forms.Label label_q2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_q3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_qtotal;
        private System.Windows.Forms.Label label_mid;
        private System.Windows.Forms.Label label_final;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label_viva;
        private System.Windows.Forms.Label label_Total;
        private System.Windows.Forms.Label label_percen;
        private System.Windows.Forms.Label label_grade;
        private System.Windows.Forms.Label label_q4;
    }
}

