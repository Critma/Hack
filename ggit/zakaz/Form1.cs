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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f = new Form2();
            f.Show();
            this.Hide();
            f.FormClosing += ThisShow;
        }

        private void ThisShow(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Это пока не работает(");
        }
    }
}
