using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Final;


namespace Final
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           

            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ErrorProvider name = new System.Windows.Forms.ErrorProvider();

            string UserName = textBox1.Text;
            string Password = textBox2.Text;

            OleDbConnection con = new OleDbConnection();

            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;
                                   Data Source=C:\Users\CompuNet\Documents\Database1.accdb;
                                   Persist Security Info=False;";
            OleDbCommand cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Userinfo where UserName='" + textBox1.Text + "' AND Password='" + textBox2.Text + "'";

            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {           
                this.Hide();
                Form5 f5 = new Form5(); 
                f5.Show();

            }

              else 
                {
                MessageBox.Show("Username or password is incorrect");
    
            }
            

            if (IsNameValid())
            {

                name.SetError(this.textBox1, String.Empty);

            }
              else
                {

                // Set the error if the name is not valid.
                name.SetError(this.textBox1, "Enter your Username.");

              }


            if (IsPaseValid())
            {

                name.SetError(this.textBox2, String.Empty);

            }
             else
               {
                // Set the error if the name is not valid.
                name.SetError(this.textBox2, "Enter your password.");

             }
        }


        private bool IsNameValid()
        {
            // Determine whether the text box contains a zero-length string.
            return (textBox1.Text.Length > 0);
        }

        private bool IsPaseValid()
        {
            // Determine whether the text box contains a zero-length string.
            return (textBox2.Text.Length > 0);
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
    }
}

