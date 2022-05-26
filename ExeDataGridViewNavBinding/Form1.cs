using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeDataGridViewNavBinding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (username.Text == "Ann" && password.Text == "Ann123" && checkBox1.Checked)
            {
                new Form2().Show();
                this.Hide();
            }
            else if (username.Text != "Ann" || password.Text != "Ann123")
            {
                MessageBox.Show("Invalid username or Password");
                username.Clear();
                password.Clear();
                username.Focus();
            }
            else if (username.Text != "Ann" && password.Text != "Ann123")
            {
                MessageBox.Show("Invalid username and Password");
                username.Clear();
                password.Clear();
                username.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
