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
    public partial class bron : Form
    {
        public bron()
        {
            InitializeComponent();
        }

        private void bron_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "otelDataSet.bron". При необходимости она может быть перемещена или удалена.
            this.bronTableAdapter.Fill(this.otelDataSet.bron);

        }
        RabotaSFailami rsf = new RabotaSFailami();
        public void obnclienta()
        {
            rsf.GetData(" SELECT  bron.id, bron.idclienta, bron.idnomera, bron.databroni, bron.datazaezda, bron.dataviezda, client.fio, nomera.id AS Expr2, nomera.nomer FROM            bron INNER JOIN     client ON bron.idclienta = client.id INNER JOIN nomera ON bron.idnomera = nomera.id", Program.Pole.pole, dataGridView1,bronBindingSource);
            dataGridView1.Columns[0].Visible = false;
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            RabotaSKlientomi.Bronirovanie visibleclient = new RabotaSKlientomi.Bronirovanie();
            visibleclient.ShowDialog();
            obnclienta();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Mapping.Metbron metclient = new Mapping.Metbron();
                metclient.Delete(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                obnclienta();
            }
            catch { MessageBox.Show("Error"); }
        }
    }
}
