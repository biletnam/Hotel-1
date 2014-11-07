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
    public partial class AddDopUslugi : Form
    {
        public AddDopUslugi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                VisibleDopUslugi vc = new VisibleDopUslugi();
                Mapping.Metdopuslugi d = new Mapping.Metdopuslugi();
                d.ADD(textBox1.Text.ToString(), Convert.ToInt32(numericUpDown1.Value), comboBox1.Items[comboBox1.SelectedIndex].ToString());
                this.Close();
            }
            catch (ArgumentOutOfRangeException) { MessageBox.Show("Не все поля заполнены"); }
            catch { MessageBox.Show("Error"); }
        }
    }
}
