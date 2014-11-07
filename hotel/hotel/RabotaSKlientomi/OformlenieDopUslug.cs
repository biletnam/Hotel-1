using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hotel.RabotaSKlientomi
{
    public partial class OformlenieDopUslug : Form
    {
        public OformlenieDopUslug()
        {
            InitializeComponent();
        }

        private void OformlenieDopUslug_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "otelDataSet.jurnalnomera". При необходимости она может быть перемещена или удалена.
            this.jurnalnomeraTableAdapter.Fill(this.otelDataSet.jurnalnomera);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "otelDataSet.dopuslugi". При необходимости она может быть перемещена или удалена.
            this.dopuslugiTableAdapter.Fill(this.otelDataSet.dopuslugi);

        }
        Mapping.DBjurnalnomera db = new Mapping.DBjurnalnomera(hotel.Program.Pole.pole);
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                hotel.Program.Pole.id = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
                    Mapping.Metjurnaldopuslug met = new Mapping.Metjurnaldopuslug();
                    var linq = from n in db.jurnalnomera
                               where n.id == hotel.Program.Pole.id
                               select n;
                    foreach (var i in linq)
                    {
                        met.ADD(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), i.idclienta,i.id);
                    }
                    this.Close();
            }
            catch { MessageBox.Show("Error"); }
        }
    }
}
