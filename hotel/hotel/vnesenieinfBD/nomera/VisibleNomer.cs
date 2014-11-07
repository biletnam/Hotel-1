using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hotel.vnesenieinfBD.nomera
{
    public partial class VisibleNomer : Form
    {
        public VisibleNomer()
        {
            InitializeComponent();
            obnclienta("nomera");
        }
        public void obnclienta(string tabl)
        {
            rsf.GetData("select * from " + tabl, Program.Pole.pole, dataGridView1,nomeraBindingSource);
            dataGridView1.Columns[0].Visible = false;
        }
        private void VisibleNomer_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "otelDataSet.nomera". При необходимости она может быть перемещена или удалена.
            this.nomeraTableAdapter2.Fill(this.otelDataSet.nomera);
           

        }
        RabotaSFailami rsf = new RabotaSFailami();
       
        private void buttonAddclient_Click(object sender, EventArgs e)
        {
            AddNomer addclient = new AddNomer();
            addclient.ShowDialog();
           obnclienta("nomera");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hotel.Program.Pole.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            EditNomer editclient = new EditNomer();
            editclient.ShowDialog();
            obnclienta("nomera");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hotel.Program.Pole.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DeleteNomera deleteclient = new DeleteNomera();
            deleteclient.ShowDialog();
            obnclienta("nomera");
        }
    }
}
