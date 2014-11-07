using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hotel.vnesenieinfBD.nomera
{
    public partial class AddNomer : Form
    {
        public AddNomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                VisibleNomer vc = new VisibleNomer();
                Mapping.Metnomera d = new Mapping.Metnomera();
                d.ADD(textBox1.Text.ToString(), Convert.ToInt32(numericUpDown1.Value), comboBox1.Items[comboBox1.SelectedIndex].ToString(), comboBox2.Items[comboBox2.SelectedIndex].ToString(), "не занят", comboBox1.Items[comboBox1.SelectedIndex].ToString());
                this.Close();
            }
            catch (ArgumentOutOfRangeException) { MessageBox.Show("Не все поля заполнены"); }
            //catch { MessageBox.Show("Error"); }
        }
    }
}
