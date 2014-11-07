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
    public partial class DopUslugi : Form
    {
        public DopUslugi()
        {
            InitializeComponent();
        }

        private void DopUslugi_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "otelDataSet.jurnaldopuslug". При необходимости она может быть перемещена или удалена.
            this.jurnaldopuslugTableAdapter.Fill(this.otelDataSet.jurnaldopuslug);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "otelDataSet.jurnaldopuslug". При необходимости она может быть перемещена или удалена.
            this.jurnaldopuslugTableAdapter.Fill(this.otelDataSet.jurnaldopuslug);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Mapping.Metjurnaldopuslug met = new Mapping.Metjurnaldopuslug();
                hotel.Program.Pole.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                met.Delete(hotel.Program.Pole.id);                 
                obnclienta();
            }
            catch { MessageBox.Show("Error"); }
        }
        RabotaSFailami rsf = new RabotaSFailami();
        public void obnclienta()
        {
            rsf.GetData("SELECT        dopuslugi.nazvanie, client.fio, nomera.nomer, jurnalnomera.datazaezda, jurnalnomera.dataviezda, nomera.id AS Expr1, jurnaldopuslug.*FROM    jurnaldopuslug INNER JOIN   dopuslugi ON jurnaldopuslug.iddopuslug = dopuslugi.id INNER JOIN client ON jurnaldopuslug.idclienta = client.id INNER JOIN  jurnalnomera ON jurnaldopuslug.idjurnalanomera = jurnalnomera.id INNER JOIN nomera ON jurnalnomera.idnomera = nomera.id", Program.Pole.pole, dataGridView1, jurnaldopuslugBindingSource);
            dataGridView1.Columns[0].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RabotaSKlientomi.OformlenieDopUslug visibleclient = new RabotaSKlientomi.OformlenieDopUslug();
            visibleclient.ShowDialog();
            obnclienta();
        }
    }
}
