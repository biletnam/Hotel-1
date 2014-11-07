using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hotel.vnesenieinfBD.veshi.Reserv
{
    public partial class VisibleReserv : Form
    {
        public VisibleReserv()
        {
            InitializeComponent();
            obnclienta();
        }

        private void VisibleReserv_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "otelDataSet.rezerv". При необходимости она может быть перемещена или удалена.
            this.rezervTableAdapter.Fill(this.otelDataSet.rezerv);
        }
        RabotaSFailami rsf = new RabotaSFailami();
        public void obnclienta()
        {
            rsf.GetData("SELECT        rezerv.id, rezerv.idveshi, rezerv.kolichestvo, veshi.nazvanie, veshi.id AS Expr1 FROM  rezerv LEFT OUTER JOIN veshi ON rezerv.idveshi = veshi.id", Program.Pole.pole, dataGridView1, rezervBindingSource);
            dataGridView1.Columns[0].Visible = false;
        }
        public void obnclienta2()
        {
            rsf.GetData(rsf.dataAdapter.SelectCommand.CommandText, Program.Pole.pole, dataGridView1, rezervBindingSource);
            dataGridView1.Columns[0].Visible = false;
        }
        private void buttonAddclient_Click(object sender, EventArgs e)
        {
            ADDReserv addclient = new ADDReserv();
            addclient.ShowDialog();
            obnclienta2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hotel.Program.Pole.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            EditReserv editSpisokVeshei = new EditReserv();
            editSpisokVeshei.ShowDialog();
            obnclienta();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hotel.Program.Pole.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DeleteReserv deleteSpisokVeshei = new DeleteReserv();
            deleteSpisokVeshei.ShowDialog();
            obnclienta();
        }

   

      
    }
}
