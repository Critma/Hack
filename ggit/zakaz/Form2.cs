using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zakaz
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var f = new Form3();
            this.Hide();
            f.Show();
            f.FormClosing += ThisShow;
        }

        private void ThisShow(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Это пока не работает(");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Это пока не работает(");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Это пока не работает(");
        }
    }
}
