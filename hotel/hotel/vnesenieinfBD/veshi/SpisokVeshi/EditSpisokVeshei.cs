using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hotel.vnesenieinfBD.veshi.SpisokVeshi
{
    public partial class EditSpisokVeshei : Form
    {
        public EditSpisokVeshei()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                VisibleSpisokVeshei vc = new VisibleSpisokVeshei();
                Mapping.Metveshi d = new Mapping.Metveshi();
                d.Edit(Program.Pole.id, textBox1.Text.ToString());
                this.Close();
            }
            catch (ArgumentOutOfRangeException) { MessageBox.Show("Не все поля заполнены"); }
            catch { MessageBox.Show("Error"); }
        }
        Mapping.DBveshi dbdopuslugi = new Mapping.DBveshi(hotel.Program.Pole.pole);

        private void EditSpisokVeshei_Load(object sender, EventArgs e)
        {
            var linq = from n in dbdopuslugi.veshi
                       where n.id == Program.Pole.id
                       select n;
            foreach (var i in linq)
            {
                textBox1.Text = i.nazvanie;
            }
        }

    }
}
