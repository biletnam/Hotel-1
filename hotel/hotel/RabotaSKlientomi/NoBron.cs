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
    public partial class NoBron : Form
    {
        public NoBron()
        {
            InitializeComponent();
        }

        private void NoBron_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "otelDataSet.client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.otelDataSet.client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "otelDataSet.nomera". При необходимости она может быть перемещена или удалена.
            this.nomeraTableAdapter.FillBy(this.otelDataSet.nomera);

        }

        private void nomeraBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dateTimePicker1.Value <= dateTimePicker2.Value )
                {
                Mapping.Metjurnalnomera met = new Mapping.Metjurnalnomera();
                Mapping.Metnomera metnomera = new Mapping.Metnomera();
                
                    met.ADD("Нет", 1, Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value), dateTimePicker1.Value, dateTimePicker2.Value);
                  
                metnomera.Zan(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), "занят");
                this.Close();
                }
                else { MessageBox.Show("Дата заезда не может быть больше даты выезда"); }
            }
            catch { MessageBox.Show("Error"); }
        }
    }
}
            
            
