namespace lab_task_2
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
            this.label_Name = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.label_Designation = new System.Windows.Forms.Label();
            this.Name_textbox = new System.Windows.Forms.TextBox();
            this.Designation_textbox = new System.Windows.Forms.TextBox();
            this.ID_textbox = new System.Windows.Forms.TextBox();
            this.save_button = new System.Windows.Forms.Button();
            this.Clear_button = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.show_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(102, 82);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(44, 16);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Name";
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(102, 123);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(20, 16);
            this.label_ID.TabIndex = 1;
            this.label_ID.Text = "ID";
            // 
            // label_Designation
            // 
            this.label_Designation.AutoSize = true;
            this.label_Designation.Location = new System.Drawing.Point(102, 166);
            this.label_Designation.Name = "label_Designation";
            this.label_Designation.Size = new System.Drawing.Size(79, 16);
            this.label_Designation.TabIndex = 2;
            this.label_Designation.Text = "Designation";
            // 
            // Name_textbox
            // 
            this.Name_textbox.Location = new System.Drawing.Point(187, 82);
            this.Name_textbox.Name = "Name_textbox";
            this.Name_textbox.Size = new System.Drawing.Size(100, 22);
            this.Name_textbox.TabIndex = 3;
            // 
            // Designation_textbox
            // 
            this.Designation_textbox.Location = new System.Drawing.Point(187, 166);
            this.Designation_textbox.Name = "Designation_textbox";
            this.Designation_textbox.Size = new System.Drawing.Size(100, 22);
            this.Designation_textbox.TabIndex = 4;
            // 
            // ID_textbox
            // 
            this.ID_textbox.Location = new System.Drawing.Point(187, 120);
            this.ID_textbox.Name = "ID_textbox";
            this.ID_textbox.Size = new System.Drawing.Size(100, 22);
            this.ID_textbox.TabIndex = 5;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(106, 257);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 6;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.Saveonclick);
            // 
            // Clear_button
            // 
            this.Clear_button.Location = new System.Drawing.Point(248, 257);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(75, 23);
            this.Clear_button.TabIndex = 7;
            this.Clear_button.Text = "Clear";
            this.Clear_button.UseVisualStyleBackColor = true;
            this.Clear_button.Click += new System.EventHandler(this.clearonclick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(493, 82);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(281, 148);
            this.listBox1.TabIndex = 8;
            // 
            // show_button
            // 
            this.show_button.Location = new System.Drawing.Point(548, 257);
            this.show_button.Name = "show_button";
            this.show_button.Size = new System.Drawing.Size(175, 23);
            this.show_button.TabIndex = 9;
            this.show_button.Text = "Show Employee List";
            this.show_button.UseVisualStyleBackColor = true;
            this.show_button.Click += new System.EventHandler(this.showEmpList);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.show_button);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.ID_textbox);
            this.Controls.Add(this.Designation_textbox);
            this.Controls.Add(this.Name_textbox);
            this.Controls.Add(this.label_Designation);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.label_Name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label_Designation;
        private System.Windows.Forms.TextBox Name_textbox;
        private System.Windows.Forms.TextBox Designation_textbox;
        private System.Windows.Forms.TextBox ID_textbox;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button show_button;
    }
}

