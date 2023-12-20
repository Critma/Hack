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
    public partial class Form3 : Form
    {
        public Dictionary<string, decimal> Sclad;
        public List<NumericUpDown> d = new List<NumericUpDown>();
        public Form3()
        {
            InitializeComponent();
            d.Add(numericUpDownHotdog);
            d.Add(numericUpDownMac);
            d.Add(numericUpDownPOvidlo);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sclad = new Dictionary<string, decimal>();
            foreach (var num in d)
            {
                 Sclad.Add(num.Name, num.Value); 
            }
            var f = new Form4(Sclad);
            f.Show();
            this.Hide();
            f.FormClosing += ShowForm;
        }

        private void ShowForm(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }
    }
}
