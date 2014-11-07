using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hotel.Settings
{
    public partial class Firma : Form
    {
        public Firma()
        {
            InitializeComponent();
        }
        Mapping.DBhotel db = new Mapping.DBhotel(hotel.Program.Pole.pole);
        private void Firma_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = "Информация о фирме";
                var Firma = from n in db.hotel
                            where n.id == 1
                            select n;
                foreach (var i in Firma)
                {
                    textBox1.Text = i.nazvanie;
                    textBox2.Text = i.fioglbuha;
                    textBox3.Text = i.adres;
                    textBox4.Text = i.email;
                }
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Mapping.Methotel m = new Mapping.Methotel();
                m.Edit(1, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                this.Close();
            }
            catch (ArgumentOutOfRangeException) { MessageBox.Show("Не все поля заполнены"); }
            catch { MessageBox.Show("Error"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
