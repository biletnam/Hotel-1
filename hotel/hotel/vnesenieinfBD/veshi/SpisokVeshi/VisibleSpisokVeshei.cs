using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hotel.vnesenieinfBD.veshi.SpisokVeshi
{
    public partial class VisibleSpisokVeshei : Form
    {
        public VisibleSpisokVeshei()
        {
            InitializeComponent();
            obnclienta();
        }
        RabotaSFailami rsf = new RabotaSFailami();
        private void VisibleSpisokVeshei_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "otelDataSet.veshi". При необходимости она может быть перемещена или удалена.
            this.veshiTableAdapter.Fill(this.otelDataSet.veshi);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "otelDataSet.veshi". При необходимости она может быть перемещена или удалена.
            this.veshiTableAdapter.Fill(this.otelDataSet.veshi);
            

        }
        public void obnclienta()
        {
            rsf.GetData("select * from veshi", Program.Pole.pole, dataGridView1, veshiBindingSource);
            dataGridView1.Columns[0].Visible = false;
        }
        private void buttonAddclient_Click(object sender, EventArgs e)
        {
            ADDSpisokVeshei addclient = new ADDSpisokVeshei();
            addclient.ShowDialog();
            obnclienta();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hotel.Program.Pole.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            EditSpisokVeshei editSpisokVeshei = new EditSpisokVeshei();
            editSpisokVeshei.ShowDialog();
            obnclienta();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hotel.Program.Pole.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DeleteSpisokVeshei deleteSpisokVeshei = new DeleteSpisokVeshei();
            deleteSpisokVeshei.ShowDialog();
            obnclienta();
        }
    }
}
