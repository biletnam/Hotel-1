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
    public partial class Editprik : Form
    {
        public Editprik()
        {
            InitializeComponent();
        }
        Mapping.DBveshi dbdopuslugi = new Mapping.DBveshi(hotel.Program.Pole.pole);
        Mapping.DBnomera db = new Mapping.DBnomera(hotel.Program.Pole.pole);
        Mapping.DBveshinomera dbvn = new Mapping.DBveshinomera(hotel.Program.Pole.pole);
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                VisiblePrikreplenie vc = new VisiblePrikreplenie();
                Mapping.Metveshinomera d = new Mapping.Metveshinomera();
                string[] str = comboBox1.Items[comboBox1.SelectedIndex].ToString().Split(new char[] { ' ' });
                string[] str1 = comboBox2.Items[comboBox2.SelectedIndex].ToString().Split(new char[] { ' ' });
                d.Edit(Program.Pole.id, Convert.ToInt32(str[0]), Convert.ToInt32(str1[0]),Convert.ToInt32(numericUpDown1.Value));
                this.Close();
            }
            catch (ArgumentOutOfRangeException) { MessageBox.Show("Не все поля заполнены"); }
            catch { MessageBox.Show("Error"); }
            

           
            }

        private void Editprik_Load(object sender, EventArgs e)
        {
            var linq = from n in dbdopuslugi.veshi
                       select n;
            foreach (var i in linq)
            {
                comboBox1.Items.Add(i.id + " " + i.nazvanie);
            }
            var linq2 = from n in db.nomera
                        select n;
            foreach (var i in linq2)
            {
                comboBox2.Items.Add(i.id+ " "+i.nomer);
            }
            var linq3 = from n in dbvn.veshinomera
                        where n.id == Program.Pole.id
                        select n;
            foreach (var i in linq3)
            {
                numericUpDown1.Value = i.kolichestvo;
                var linq4 = from n in dbdopuslugi.veshi
                            where n.id == i.idveshi
                            select n;
                foreach (var j in linq4) { comboBox1.Text = i.idveshi + " " + j.nazvanie; }
                var linq5 = from n in db.nomera
                            where n.id == i.idnomera
                            select n;
                foreach (var j in linq5) { comboBox2.Text = i.idnomera + " " + j.nomer; }
            }
        }
        }
    }