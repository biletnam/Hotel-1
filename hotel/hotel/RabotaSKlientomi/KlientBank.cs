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
    public partial class KlientBank : Form
    {
        public KlientBank()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KlientBank_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "otelDataSet.bron". При необходимости она может быть перемещена или удалена.
            this.bronTableAdapter.FillBy1(this.otelDataSet.bron);
            label1.Visible = false;
            button2.Visible = false;
            databroniDataGridViewTextBoxColumn.Visible = false;
        } 
        string data = "";
                string summa = "";
        RabotaSFailami rsf = new RabotaSFailami();
        private void button1_Click(object sender, EventArgs e)
        {
            bool prv = false;
            openFileDialog1.InitialDirectory = Application.StartupPath.ToString();
                openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog1.ShowDialog();
                string failklientbank = rsf.outFile2(openFileDialog1.FileName);
                string[] masstrok = failklientbank.Split(new char[] { '\n' });
               
               
                    data = masstrok[masstrok.Length - 5];
                            summa = masstrok[masstrok.Length - 4];
                    
                            data = data.Remove(0, 5);
                            summa = summa.Remove(0, 6);
            button1.Visible = false;
            label1.Visible = true;
            button2.Visible = true;
            databroniDataGridViewTextBoxColumn.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mapping.Metjurnal metj = new Mapping.Metjurnal();
            metj.ADD(DateTime.Parse(data), Convert.ToInt32(summa), Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            this.Close();
        }
    }
}
