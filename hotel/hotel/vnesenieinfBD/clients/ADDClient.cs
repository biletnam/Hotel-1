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
    public partial class ADDClient : Form
    {
        public ADDClient()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                VisibleClient vc=new VisibleClient(); 
                Mapping.Metclient d = new Mapping.Metclient();
                d.ADD(textBoxFIO.Text.ToString(), textBoxEmail.Text.ToString());
                this.Close();
            }
            catch (ArgumentOutOfRangeException) { MessageBox.Show("Не все поля заполнены"); }
            catch { MessageBox.Show("Error"); }
        }
        
        private void ADDClient_Load(object sender, EventArgs e)
        {
          
        }
    }
}
