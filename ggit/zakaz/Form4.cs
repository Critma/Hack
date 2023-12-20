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
    public partial class Form4 : Form
    {
        Dictionary<string, decimal> Sclad;
        public Form4(Dictionary<string, decimal> Sclad)
        {
            InitializeComponent();
            this.Sclad = Sclad;
            FillOrders();
        }

        public void FillOrders()
        {
            var top = 350;
            decimal sum = 0;
            decimal price = 0;
            foreach (var item in this.Sclad)
            {
                Name = "";
                if (item.Key == "numericUpDownMac")
                {
                    Name = "булочка с маком";
                    sum += item.Value * 30;
                    price = 30;
                }
                else if (item.Key == "numericUpDownHotdog")
                {
                    Name = "хот - дог";
                    sum += item.Value * 50;
                    price = 50;
                }
                else if (item.Key == "numericUpDownPOvidlo")
                {
                    Name = "булочка в с повидлом";
                    sum += item.Value * 30;
                    price = 30;
                }
                else
                {
                    Name = "Неизвестный продукт";
                }
                var label = new Label { Location = new Point(40, top), Text = $"{Name} - {item.Value} штук по цене {price} = {item.Value * price} рублей", AutoSize = true };
                label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

                Controls.Add(label) ;
                top += 50;
            }
            labelItog.Text = $"Итог : {sum} рублей";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Заказ оформлен)");
        }
    }
}
