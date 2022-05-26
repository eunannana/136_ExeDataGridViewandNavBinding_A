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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
            this.Hide();
        }
    }
}
