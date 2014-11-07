using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hotel.vnesenieinfBD.veshi.Prikreplenie
{
    public partial class ADDprik : Form
    {
        public ADDprik()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                VisiblePrikreplenie vc = new VisiblePrikreplenie();
                Mapping.Metveshinomera d = new Mapping.Metveshinomera();
                var linq = from n in dbdopuslugi.veshi
                           where n.nazvanie == comboBox1.Items[comboBox1.SelectedIndex].ToString()
                           select n;
                var linq2 = from n in db.nomera
                           where n.nomer == comboBox2.Items[comboBox2.SelectedIndex].ToString()
                           select n;
                foreach (var i in linq)
                {
                    foreach (var j in linq2)
                    {
                        d.ADD(i.id, j.id,Convert.ToInt32(numericUpDown1.Value));
                        break;
                    }
                    break;
                }
                this.Close();
            }
            catch (ArgumentOutOfRangeException) { MessageBox.Show("Не все поля заполнены"); }
            catch { MessageBox.Show("Error"); }
        }
Mapping.DBveshi dbdopuslugi = new Mapping.DBveshi(hotel.Program.Pole.pole);
Mapping.DBnomera db = new Mapping.DBnomera(hotel.Program.Pole.pole);
        private void ADDprik_Load(object sender, EventArgs e)
        {
            var linq = from n in dbdopuslugi.veshi
                       select n;
            foreach (var i in linq)
            {
                comboBox1.Items.Add(i.nazvanie);
            }
            var linq2 = from n in db.nomera
                       select n;
            foreach (var i in linq2)
            {
                comboBox2.Items.Add(i.nomer);
            }
        }
    }
}
