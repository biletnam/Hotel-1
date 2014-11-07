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
    public partial class OformlenieVNomer : Form
    {
        public OformlenieVNomer()
        {
            InitializeComponent();
            obnclienta();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            RabotaSKlientomi.Voprospobroni visibleclient = new RabotaSKlientomi.Voprospobroni();
            visibleclient.ShowDialog();
            obnclienta();
        }

        private void OformlenieVNomer_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "otelDataSet.jurnalnomera". При необходимости она может быть перемещена или удалена.
            this.jurnalnomeraTableAdapter.Fill(this.otelDataSet.jurnalnomera);

        }
        RabotaSFailami rsf = new RabotaSFailami();
        public void obnclienta()
        {
            rsf.GetData(" SELECT        nomera.nomer AS Expr3, client.fio, jurnalnomera.* FROM            jurnalnomera INNER JOIN nomera ON jurnalnomera.idnomera = nomera.id INNER JOIN client ON jurnalnomera.idclienta = client.id", Program.Pole.pole,dataGridView1,jurnalnomeraBindingSource);
            dataGridView1.Columns[0].Visible = false;
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            RabotaSKlientomi.NoBron visibleclient = new RabotaSKlientomi.NoBron();
            visibleclient.ShowDialog();
            obnclienta();
        }
        Mapping.DBjurnalnomera db = new Mapping.DBjurnalnomera(hotel.Program.Pole.pole);
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
            Mapping.Metjurnalnomera met = new Mapping.Metjurnalnomera();
            Mapping.Metnomera metnomera = new Mapping.Metnomera();
                hotel.Program.Pole.id=Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var linq = from n in db.jurnalnomera
                       where n.id == hotel.Program.Pole.id
                       select n;
           
                foreach(var i in linq)
                { 
                    met.Delete(hotel.Program.Pole.id);
                    metnomera.Zan(i.idnomera, "не занят");
                }
            obnclienta();
            }
            catch { MessageBox.Show("Error"); }
        }
    }
}
