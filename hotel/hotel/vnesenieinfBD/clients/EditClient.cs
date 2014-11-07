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
    public partial class EditClient : Form
    {
        public EditClient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                VisibleClient vc = new VisibleClient();
                Mapping.Metclient d = new Mapping.Metclient();
                d.Edit(Program.Pole.id, textBox1.Text.ToString(), textBox2.Text.ToString());
                this.Close();
            }
            catch (ArgumentOutOfRangeException) { MessageBox.Show("Не все поля заполнены"); }
            catch { MessageBox.Show("Error"); }
        }
        Mapping.DBclient dbclient = new  Mapping.DBclient(Program.Pole.pole);
        private void EditClient_Load(object sender, EventArgs e)
        {
            var linqclient = from n in dbclient.client
                             where n.id == Program.Pole.id
                     select n;
            foreach (var i in linqclient)
            {
                textBox1.Text = i.fio;
                textBox2.Text = i.email;
            }
           
        }
    }
}
