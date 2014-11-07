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
    public partial class Bronirovanie : Form
    {
        public Bronirovanie()
        {
            InitializeComponent();
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            dateTimePicker3.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker3.Format = DateTimePickerFormat.Short;
            obnclienta();
        }
        RabotaSFailami rsf = new RabotaSFailami();
        public void obnclienta()
        {
            rsf.GetData("SELECT id, nomer, cena, stavka, tip, mesta, zanitost FROM dbo.nomera", Program.Pole.pole, dataGridView1, nomeraBindingSource);
            dataGridView1.Columns[0].Visible = false;
        }
        private void Bronirovanie_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "otelDataSet.nomera". При необходимости она может быть перемещена или удалена.
            this.nomeraTableAdapter.FillBy(this.otelDataSet.nomera);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "otelDataSet.client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.otelDataSet.client);

        }
        Mapping.DBhotel dbhotel = new Mapping.DBhotel(hotel.Program.Pole.pole);
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Mapping.Metbron d = new Mapping.Metbron();
                if (dateTimePicker1.Value <= dateTimePicker2.Value )
                {
                    if (dateTimePicker2.Value < dateTimePicker3.Value)
                    {

                        d.ADD(Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value), Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), dateTimePicker1.Value, dateTimePicker2.Value, dateTimePicker3.Value);
                        Email email = new Email();
                        var linq=from n in dbhotel.hotel
                                 where n.id==1
                                 select n;
                        RabotaSKlientomi.Pass p = new Pass();
                        p.ShowDialog();
                        
                        foreach(var i in linq)
                        {
                            email.otpravka(dataGridView2.CurrentRow.Cells[2].Value.ToString(), i.email,hotel.Program.Pole.pass, dateTimePicker1.Value, dataGridView2.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[1].Value.ToString(), Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value), i.nazvanie, i.fioglbuha);
                        }this.Close();
                              
                
                    }else {MessageBox.Show("Дата заезда не может быть больше даты выезда"); }
                }
                else {MessageBox.Show("Дата брони не может быть больше даты заезда"); }
            }
            catch (ArgumentOutOfRangeException) {  }
            catch { MessageBox.Show("Error"); }
        }

       
    }
}
