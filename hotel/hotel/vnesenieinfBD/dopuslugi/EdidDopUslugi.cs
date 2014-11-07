using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hotel.vnesenieinfBD.dopuslugi
{
    public partial class EdidDopUslugi : Form
    {
        public EdidDopUslugi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                VisibleDopUslugi vc = new VisibleDopUslugi ();
                Mapping.Metdopuslugi d = new Mapping.Metdopuslugi();
                d.Edit(Program.Pole.id, textBox1.Text.ToString(), Convert.ToInt32(numericUpDown1.Value), comboBox1.Items[comboBox1.SelectedIndex].ToString());
                this.Close();
            }
            catch (ArgumentOutOfRangeException) { MessageBox.Show("Не все поля заполнены"); }
            catch { MessageBox.Show("Error"); }
        }
        Mapping.DBdopuslugi dbdopuslugi = new Mapping.DBdopuslugi(hotel.Program.Pole.pole);
        private void EdidDopUslugi_Load(object sender, EventArgs e)
        {
            var linq = from n in  dbdopuslugi.dopuslugi
                             where n.id == Program.Pole.id
                             select n;
            foreach (var i in linq)
            {
                textBox1.Text = i.nazvanie;
                comboBox1.Text = i.stavka;
                numericUpDown1.Value = i.cena;
            }
        }
    }
}
