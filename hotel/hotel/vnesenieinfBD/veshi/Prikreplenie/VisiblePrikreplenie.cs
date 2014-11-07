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
    public partial class VisiblePrikreplenie : Form
    {
        public VisiblePrikreplenie()
        {
            InitializeComponent();
        }

        private void VisiblePrikreplenie_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "otelDataSet.veshinomera". При необходимости она может быть перемещена или удалена.
            this.veshinomeraTableAdapter.Fill(this.otelDataSet.veshinomera);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "otelDataSet.veshinomera". При необходимости она может быть перемещена или удалена.
            this.veshinomeraTableAdapter.Fill(this.otelDataSet.veshinomera);

        }
        RabotaSFailami rsf = new RabotaSFailami();
        public void obnclienta()
        {
            rsf.GetData("SELECT        veshinomera.id, veshinomera.idveshi, veshinomera.idnomera, veshinomera.kolichestvo, nomera.id AS Expr1, nomera.nomer, veshi.nazvanie FROM            veshinomera INNER JOIN  nomera ON veshinomera.idnomera = nomera.id INNER JOIN veshi ON veshinomera.idveshi = veshi.id", Program.Pole.pole, dataGridView1, veshinomeraBindingSource);
            dataGridView1.Columns[0].Visible = false;
        }
        private void buttonAddclient_Click(object sender, EventArgs e)
        {
            ADDprik addclient = new ADDprik();
            addclient.ShowDialog();
            obnclienta();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hotel.Program.Pole.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Editprik editSpisokVeshei = new Editprik();
            editSpisokVeshei.ShowDialog();
            obnclienta();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hotel.Program.Pole.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DeletePrik deleteSpisokVeshei = new DeletePrik();
            deleteSpisokVeshei.ShowDialog();
            obnclienta();
        }
    }
}
