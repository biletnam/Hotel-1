using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hotel.vnesenieinfBD.dopuslugi
{
    public partial class VisibleDopUslugi : Form
    {
        public VisibleDopUslugi()
        {
            InitializeComponent();
            obnclienta("dopuslugi");
        }
        public void obnclienta(string tabl)
        {
            rsf.GetData("select * from " + tabl, Program.Pole.pole,dataGridView1,dopuslugiBindingSource);
            dataGridView1.Columns[0].Visible = false;
        }
        private void VisibleDopUslugi_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "otelDataSet.dopuslugi". При необходимости она может быть перемещена или удалена.
            this.dopuslugiTableAdapter2.Fill(this.otelDataSet.dopuslugi);
            

        }
        RabotaSFailami rsf = new RabotaSFailami();
        private void buttonAddclient_Click(object sender, EventArgs e)
        {
            AddDopUslugi addclient = new AddDopUslugi();
            addclient.ShowDialog();
            obnclienta("dopuslugi");
        }      


        private void buttonDeliteClient_Click(object sender, EventArgs e)
        {
            hotel.Program.Pole.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DeleteDopUslugi deleteclient = new DeleteDopUslugi();
            deleteclient.ShowDialog();
            obnclienta("dopuslugi");
        }

        private void buttonEditclient_Click(object sender, EventArgs e)
        {
            hotel.Program.Pole.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            EdidDopUslugi edit = new EdidDopUslugi();
            edit.ShowDialog();
            obnclienta("dopuslugi");
        }
        
    }
}
