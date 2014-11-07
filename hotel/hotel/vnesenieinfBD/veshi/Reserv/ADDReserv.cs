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
    public partial class ADDReserv : Form
    {
        public ADDReserv()
        {
            InitializeComponent();
        }
        Mapping.DBveshi dbdopuslugi = new Mapping.DBveshi(hotel.Program.Pole.pole);
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                VisibleReserv vc = new VisibleReserv();
                Mapping.Metrezerv d = new Mapping.Metrezerv();
                var linq = from n in dbdopuslugi.veshi
                           where n.nazvanie == comboBox1.Items[comboBox1.SelectedIndex].ToString()
                           select n;
                foreach(var i in linq)
                {
                d.ADD(i.id, Convert.ToInt32(numericUpDown1.Value));
                break;
                }
                this.Close();
            }
            catch (ArgumentOutOfRangeException) { MessageBox.Show("Не все поля заполнены"); }
            catch { MessageBox.Show("Error"); }
        }
        
        private void ADDReserv_Load(object sender, EventArgs e)
        {
            var linq = from n in dbdopuslugi.veshi
                       select n;
            foreach (var i in linq)
            {
                comboBox1.Items.Add( i.nazvanie);
            }
        }
    }
   
}
