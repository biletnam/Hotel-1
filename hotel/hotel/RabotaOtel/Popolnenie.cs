using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hotel.RabotaOtel
{
    public partial class Popolnenie : Form
    {
        public Popolnenie()
        {
            InitializeComponent();
        }
        RabotaSFailami rsf = new RabotaSFailami();
        Mapping.DBrezerv dbr = new Mapping.DBrezerv(hotel.Program.Pole.pole);
        Mapping.DBveshi dbv = new Mapping.DBveshi(hotel.Program.Pole.pole);
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Mapping.Metrezerv metr = new Mapping.Metrezerv();
                Mapping.Metveshi metv = new Mapping.Metveshi();
                openFileDialog1.InitialDirectory = Application.StartupPath.ToString();
                openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog1.ShowDialog();
                string predmet = rsf.outFile2(openFileDialog1.FileName);

                string[] masstrok = predmet.Split(new char[] { '\n' });
                int schet = 0;
                foreach (var i in masstrok)
                {
                    schet = 0;
                    if (i != "")
                    {
                        string[] masslov = i.Split(new char[] { '|' });
                        if (masslov[0] != "" && masslov[1] != "")
                        {
                            var linq = from n in dbv.veshi
                                       where n.nazvanie == masslov[0]
                                       select n;

                            foreach (var j in linq)
                            {
                                schet += 1;

                                var linq2 = from n in dbr.rezerv
                                            where n.idveshi == j.id
                                            select n;
                                foreach (var k in linq2)
                                {
                                    metr.Edit(k.id, k.idveshi, k.kolichestvo + Convert.ToInt32(masslov[1]));
                                }

                            }
                            if (schet == 0)
                            {
                                metv.ADD(masslov[0]);
                                var linq3 = from n in dbv.veshi
                                            where n.nazvanie == masslov[0]
                                            select n;
                                MessageBox.Show(masslov[0]);
                                foreach (var k in linq3)
                                {
                                    metr.ADD(k.id, Convert.ToInt32(masslov[1]));
                                    break;
                                }
                            }
                        }
                    }

                }
                
            }
            catch(IndexOutOfRangeException) {
                string predmet = rsf.outFile2(openFileDialog1.FileName);
                MessageBox.Show("Пополнено на " + predmet);
                this.Close();}
            }
        }
    }
