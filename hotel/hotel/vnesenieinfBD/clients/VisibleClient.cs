using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hotel.vnesenieinfBD.clients
{
    public partial class VisibleClient : Form
    {
        public VisibleClient()
        {
            InitializeComponent();
            obnclienta();
        }
        public void obnclienta()
        {
            rsf.GetData("select * from client", Program.Pole.pole,dataGridView1,clientBindingSource);
            dataGridView1.Columns[0].Visible = false;
        }
        public void obnclienta2()
        {
            rsf.GetData(rsf.dataAdapter.SelectCommand.CommandText, Program.Pole.pole,dataGridView1,clientBindingSource);
            dataGridView1.Columns[0].Visible = false;
        }
        private void VisibleClient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "otelDataSet.client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter2.Fill(this.otelDataSet.client);
            obnclienta();
        }
        RabotaSFailami rsf = new RabotaSFailami();
        private void buttonAddclient_Click(object sender, EventArgs e)
        {
            ADDClient addclient = new ADDClient();
            addclient.ShowDialog();
            obnclienta2();
        }

        private void buttonEditclient_Click(object sender, EventArgs e)
        {
            hotel.Program.Pole.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            EditClient editclient = new EditClient();
            editclient.ShowDialog();
            obnclienta2();
        }

        private void buttonDeliteClient_Click(object sender, EventArgs e)
        {

            hotel.Program.Pole.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DeleteClient deleteclient = new DeleteClient();
            deleteclient.ShowDialog();
            obnclienta2();

        }
       
    }
}
