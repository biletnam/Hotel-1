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
    public partial class Viezd : Form
    {
        public Viezd()
        {
            InitializeComponent();
        }

        private void Viezd_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "otelDataSet.jurnalnomera". При необходимости она может быть перемещена или удалена.
            this.jurnalnomeraTableAdapter.FillBy(this.otelDataSet.jurnalnomera);

        }

        private void button1_Click(object sender, EventArgs e)
        {
                hotel.Program.Pole.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);           
                RabotaSKlientomi.Vopros visibleclient = new RabotaSKlientomi.Vopros();
                visibleclient.ShowDialog();

        }
    }
}
