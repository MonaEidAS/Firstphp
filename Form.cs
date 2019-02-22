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

namespace Final
{
    public partial class Form2 : Form
    {
        // Connecteda with Database
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;
                                                  Data Source=C:\Users\CompuNet\Documents\Database1.accdb");

        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            ErrorProvider name = new System.Windows.Forms.ErrorProvider();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Userinfo values('" + textBox1.Text + "', '" + textBox2.Text + "', '" 
                                                              + textBox4.Text + "', '" + textBox3.Text + "')";

            if (IsNameValid())
            {               
                name.SetError(this.textBox4, String.Empty);
            }
            else 
            {    
                // Set the error if the name is not valid.
                name.SetError(this.textBox4, "Username is required.");              
            }
             if (IsPaseValid())
            {
               
                name.SetError(this.textBox3, String.Empty);
            }
            else
            {
                // Set the error if the name is not valid.
                name.SetError(this.textBox3, "Password is required.");                
            }
             
            cmd.ExecuteNonQuery();
            con.Close();


            if(IsNameValid() & IsPaseValid())
            {
                this.Hide();
                Form3 f3 = new Form3();
                f3.Show();
            }         
        }


        private bool IsNameValid()
        {
            // Determine whether the text box contains a zero-length string.
            return (textBox4.Text.Length > 0);
        }


        private bool IsPaseValid()
        {
            // Determine whether the text box contains a zero-length string.
            return (textBox3.Text.Length > 0);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.PasswordChar = '*';
        }
    }      }
