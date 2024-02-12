
namespace WinFormsApp1
{
    partial class Sru1
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
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.hhhhh = new System.Windows.Forms.GroupBox();
            this.radio_Female = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hhhhh.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 19;
            this.button1.Text = "ثبت";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(286, 315);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(125, 27);
            this.textBox4.TabIndex = 18;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // hhhhh
            // 
            this.hhhhh.Controls.Add(this.radio_Female);
            this.hhhhh.Controls.Add(this.radioButton1);
            this.hhhhh.Location = new System.Drawing.Point(257, 176);
            this.hhhhh.Name = "hhhhh";
            this.hhhhh.Size = new System.Drawing.Size(250, 95);
            this.hhhhh.TabIndex = 16;
            this.hhhhh.TabStop = false;
            this.hhhhh.Text = "جنسیت";
            this.hhhhh.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radio_Female
            // 
            this.radio_Female.AutoSize = true;
            this.radio_Female.Location = new System.Drawing.Point(32, 61);
            this.radio_Female.Name = "radio_Female";
            this.radio_Female.Size = new System.Drawing.Size(46, 24);
            this.radio_Female.TabIndex = 1;
            this.radio_Female.Text = "زن";
            this.radio_Female.UseVisualStyleBackColor = true;
            this.radio_Female.UseWaitCursor = true;
            this.radio_Female.CheckedChanged += new System.EventHandler(this.radio_Female_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(29, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(52, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "مرد";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(274, 131);
            this.txt_ID.MaxLength = 10;
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(125, 27);
            this.txt_ID.TabIndex = 15;
            this.txt_ID.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txt_ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyDown);
            this.txt_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(274, 86);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(125, 27);
            this.txt_LastName.TabIndex = 14;
            this.txt_LastName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(274, 44);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(125, 27);
            this.txt_FirstName.TabIndex = 13;
            this.txt_FirstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "شماره دانشجویی";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "نام خانوادگی";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(426, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "نام";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(426, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "سال تولد";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Sru1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.hhhhh);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.txt_LastName);
            this.Controls.Add(this.txt_FirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "Sru1";
            this.Text = "Sru1";
            this.hhhhh.ResumeLayout(false);
            this.hhhhh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox hhhhh;
        private System.Windows.Forms.RadioButton radio_Female;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}