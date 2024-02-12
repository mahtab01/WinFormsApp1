using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Sru1 : Form
    {
        List <St> students;
        St selectedStudent;
        public Sru1()
        {
            InitializeComponent();
            students = new List<St>();
            selectedStudent = null;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_FirstName.Text.Trim() == "" || txt_LastName.Text.Trim() == "" ||
                txt_ID.Text.Trim() == "")
            {
                MessageBox.Show(" اطلاعات نام و نام خانوادگی و شماره دانشجویی نمی تواند خالی باشد ");
                return;
            }
            if (selectedStudent == null)
            {
                // Register
                St student = new St ();
                student.FirstName = txt_FirstName.Text.Trim();
                student.LastName = txt_LastName.Text.Trim();
                student.ID = Convert.ToInt32(txt_ID.Text.Trim());

                
                student.Gender = radio_Female.Checked;

                students.Add(student);
                MessageBox.Show("اطلاعات ثبت شد");
            }
            else
            {
                // edit
                selectedStudent.FirstName = txt_FirstName.Text.Trim();
                selectedStudent.LastName = txt_LastName.Text.Trim();
                selectedStudent.ID = Convert.ToInt32(txt_ID.Text.Trim());
             
                selectedStudent.Gender = radio_Female.Checked;

                MessageBox.Show("اطلاعات ویرایش شد");

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            return;

            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) ;
            return;

            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void radio_Female_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
