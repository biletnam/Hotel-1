using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hotel.vnesenieinfBD.veshi.Reserv
{
    public partial class EditReserv : Form
    {
        public EditReserv()
        {
            InitializeComponent();
            var linq = from n in dbrezerv.rezerv
                       where n.id == Program.Pole.id
                       select n;
            foreach (var i in linq)
            {
                numericUpDown1.Value = i.kolichestvo;
                var linq2 = from n in dbdopuslugi.veshi
                            where n.id == i.idveshi
                            select n;
                foreach (var j in linq2) { comboBox1.Text=i.idveshi+" "+j.nazvanie; 
                }
                
            }var linq3 = from n in dbdopuslugi.veshi
                            select n;
                foreach (var K in linq3) { comboBox1.Items.Add(K.id + " " + K.nazvanie); }
        }
        Mapping.DBveshi dbdopuslugi = new Mapping.DBveshi(hotel.Program.Pole.pole);
        Mapping.DBrezerv dbrezerv = new Mapping.DBrezerv(hotel.Program.Pole.pole);
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                VisibleReserv vc = new VisibleReserv();
                Mapping.Metrezerv d = new Mapping.Metrezerv();
                string[] str= comboBox1.Items[comboBox1.SelectedIndex].ToString().Split(new char[]{ ' '});
                d.Edit(Program.Pole.id, Convert.ToInt32(str[0]), Convert.ToInt32(numericUpDown1.Value));
                this.Close();
            }
            catch (ArgumentOutOfRangeException) { MessageBox.Show("Не все поля заполнены"); }
            catch { MessageBox.Show("Error"); }
            
            
        }
    }
}
