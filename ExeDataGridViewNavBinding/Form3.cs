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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Form4 detail = new Form4();
            detail.textBox1.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            detail.textBox2.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            detail.textBox3.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            detail.textBox4.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            detail.textBox5.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            detail.ShowDialog();
        }
    }
}
