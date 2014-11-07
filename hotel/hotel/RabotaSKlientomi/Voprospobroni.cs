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
    public partial class Voprospobroni : Form
    {
        public Voprospobroni()
        {
            InitializeComponent();
        }

        private void Voprospobroni_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "otelDataSet.bron". При необходимости она может быть перемещена или удалена.
            this.bronTableAdapter.Fill(this.otelDataSet.bron);

        }
        Mapping.DBbron db = new Mapping.DBbron(hotel.Program.Pole.pole);
        private void button1_Click(object sender, EventArgs e)
        {
            try
                
            {
                hotel.Program.Pole.id=Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                
                Mapping.Metnomera met = new Mapping.Metnomera();
                Mapping.Metjurnalnomera d = new Mapping.Metjurnalnomera();
                var linq = from n in db.bron
                           where n.id == hotel.Program.Pole.id
                           select n;
                foreach (var i in linq)
                {
                    d.ADD("Да", i.id, i.idnomera, i.idclienta, i.datazaezda, i.dataviezda);
                    met.Zan(i.idnomera, "занят");
                    //MessageBox.Show(("да " + i.id + " " + i.idnomera + " " + i.idclienta + " " + i.datazaezda + " " + i.dataviezda).ToString());
                }
                this.Close();
            }
            catch (ArgumentOutOfRangeException) { MessageBox.Show("Не все поля заполнены"); }
            catch { MessageBox.Show("Error"); }
        }
    }
}
