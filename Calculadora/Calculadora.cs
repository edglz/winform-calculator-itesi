using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void txtDig_TextChanged(object sender, EventArgs e)
        {
            
            if (System.Text.RegularExpressions.Regex.IsMatch(txtDig.Text, "[^0-9.]"))
            {
                txtDig.Text = txtDig.Text.Remove(txtDig.Text.Length - 1);
            }
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void yoBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("IS21111627 Saúl Hernández Estrada", "Acerca de mi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
