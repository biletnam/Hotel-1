using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hotel.vnesenieinfBD.nomera
{
    public partial class EditNomer : Form
    {
        public EditNomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Mapping.Metnomera d = new Mapping.Metnomera();
                d.Edit(Program.Pole.id, textBox1.Text.ToString(), Convert.ToInt32(numericUpDown1.Value), comboBox3.Items[comboBox3.SelectedIndex].ToString(), comboBox2.Items[comboBox2.SelectedIndex].ToString(), zan, comboBox1.Items[comboBox1.SelectedIndex].ToString());
                this.Close();
            }
            catch (ArgumentOutOfRangeException) { MessageBox.Show("Не все поля заполнены"); }
            catch { MessageBox.Show("Error"); }
        }
        string zan = "";
        Mapping.DBnomera dbdopuslugi = new Mapping.DBnomera(hotel.Program.Pole.pole);
        private void EditNomer_Load(object sender, EventArgs e)
        {
            var linq = from n in dbdopuslugi.nomera
                       where n.id == Program.Pole.id
                       select n;
            foreach (var i in linq)
            {
                zan = i.zanitost;
                textBox1.Text = i.nomer;
                comboBox2.Text = i.tip;
                comboBox3.Text = i.stavka;
                numericUpDown1.Value = i.cena;
                comboBox1.Text = i.mesta;
            }
        }
    }
}
