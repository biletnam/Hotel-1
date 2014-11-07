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
    public partial class Porcha : Form
    {
        public Porcha()
        {
            InitializeComponent();
        }

        private void Porcha_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "otelDataSet.veshinomera". При необходимости она может быть перемещена или удалена.
            this.veshinomeraTableAdapter.Fill(this.otelDataSet.veshinomera);
            label2.Visible = false;
            numericUpDown1.Visible = false;
            button1.Visible = false;
        }
        Mapping.DBveshinomera dbvn=new Mapping.DBveshinomera(hotel.Program.Pole.pole);
        Mapping.DBrezerv dbr = new Mapping.DBrezerv(hotel.Program.Pole.pole);
        private void button1_Click(object sender, EventArgs e)
        {            
            Mapping.Metveshinomera metvn = new Mapping.Metveshinomera();
            Mapping.Metrezerv metr = new Mapping.Metrezerv();
            var linq = from n in dbvn.veshinomera
                       where n.id == hotel.Program.Pole.id
                       select n;
            foreach (var i in linq)
            {
                var linq2 = from n in dbr.rezerv
                            where n.idveshi == i.idveshi
                            select n;
                foreach (var j in linq2)
                {
                    
                    if (i.kolichestvo >= Convert.ToInt32(numericUpDown1.Value) && j.kolichestvo > Convert.ToInt32(numericUpDown1.Value))
                    {
                        metr.Edit(j.id, i.idveshi, j.kolichestvo - Convert.ToInt32(numericUpDown1.Value));
                    }
                    else
                    {
                        if (i.kolichestvo >= Convert.ToInt32(numericUpDown1.Value) && j.kolichestvo == Convert.ToInt32(numericUpDown1.Value))
                        {
                            metr.Delete(j.id);
                        }
                        else { MessageBox.Show("Не хватает резервов"); }
                    }
                    
                }
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hotel.Program.Pole.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            label2.Visible = true;
            numericUpDown1.Visible = true;
            button1.Visible = true;
            label1.Visible = false;
            //dataGridView1.Visible = false;
            button2.Visible = false;
            var linq = from n in dbvn.veshinomera
                       where n.id == hotel.Program.Pole.id
                       select n;
            foreach (var i in linq)
            {
                numericUpDown1.Maximum = i.kolichestvo;
            }
            
        }
    }
}
