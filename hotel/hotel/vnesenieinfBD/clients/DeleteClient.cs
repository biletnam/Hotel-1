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
    public partial class DeleteClient : Form
    {
        public DeleteClient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Mapping.Metclient metclient = new Mapping.Metclient();
                metclient.Delete(Program.Pole.id);
                this.Close();
            }
            catch { MessageBox.Show("Error"); }
        }
    }
}
