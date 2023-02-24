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
        Memoria Memoria = new Memoria();
        Operacion optClass = new Operacion();
        private Boolean strSign = true;
        private int Index = 1;
       
        private String Yo = "IS21111627 Saúl Hernández Estrada";
        public int option;
        
        public Calculadora()
        {
            InitializeComponent();
        }

        private void txtDig_TextChanged(object sender, EventArgs e)
        {
            
            
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtRes.Text = strSign ? "Es positivo" : "Es negativo";
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void yoBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.Yo, "Acerca de mi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private bool checkIsEmpty()
        {
            return txtDig.Text != "" ? true :  false;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gMemoria_Click(object sender, EventArgs e)
        {
            if (txtDig.Text != "")
            {
                double valorTxt = Double.Parse(txtDig.Text);
                List<double> valores = new List<double>();
                valores.Add(3.1416);
                valores.Add(2.7182);
                valores.Add(1.618);
                if (valores.Contains(valorTxt))
                {
                    Memoria.set(valorTxt);
                    MessageBox.Show("Valor guardado en memoria", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Al parecer no el dato no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Ingresa un valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mMemoria_Click(object sender, EventArgs e)
        {
            if (Memoria.get() != 0.00)
            {
                if (txtDig.Text == "")
                {
                    txtDig.Text = txtDig.Text + Memoria.get().ToString();
                }
            }
            else
            {
                MessageBox.Show("La memoria está vacía", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInvert_Click(object sender, EventArgs e)
        {
            txtSign.Text = strSign ? "-" : "+";
            this.strSign = !strSign;
        }

        

        private void txtDig_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtDig.Text, "[^0-9.-]"))
            {
                txtDig.Text = txtDig.Text.Remove(txtDig.Text.Length - 1);
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            
            if (checkIsEmpty())
            {
                if (this.Index == 1)
                {
                    this.optClass.n1 = Double.Parse(String.Concat(strSign ? "+" : "-", txtDig.Text).Trim());
                    txtDig.Focus();
                    txtDig.Text = "";
                    this.Index++;
                    option = 1;
                }
                else
                {
                    this.Index--;
                    optClass.n2 = Double.Parse(String.Concat(strSign ? "+" : "-", txtDig.Text).Trim());
                    txtDig.Focus();
                    double div = optClass.division();
                    if (div < 0)
                    {
                        txtSign.Text = "-";
                        this.strSign = false;
                    }
                    else
                    {
                        txtSign.Text = "+";
                        this.strSign = true;
                    }
                    txtDig.Text = div.ToString().Replace(txtSign.Text, "");
                }
            }
            else
            {
                MessageBox.Show("Ingresa un valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (checkIsEmpty())
            {
                if (this.Index == 1)
                {
                    this.optClass.n1 = Double.Parse(String.Concat(strSign ? "+" : "-", txtDig.Text).Trim());
                    txtDig.Focus();
                    txtDig.Text = "";
                    this.Index++;
                    option = 2;
                }
                else
                {
                    this.Index--;
                    optClass.n2 = Double.Parse(String.Concat(strSign ? "+" : "-", txtDig.Text).Trim());
                    txtDig.Focus();
                    double div = optClass.resta();
                    if (div < 0)
                    {
                        txtSign.Text = "-";
                        this.strSign = false;
                    }
                    else
                    {
                        txtSign.Text = "+";
                        this.strSign = true;
                    }
                    txtDig.Text = div.ToString().Replace(txtSign.Text, "");
                }
            }
            else
            {
                MessageBox.Show("Ingresa un valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            if (checkIsEmpty())
            {
                if (this.Index == 1)
                {
                    this.optClass.n1 = Double.Parse(String.Concat(strSign ? "+" : "-", txtDig.Text).Trim());
                    txtDig.Focus();
                    txtDig.Text = "";
                    option = 3;
                    this.Index++;
                }
                else
                {
                    this.Index--;
                    optClass.n2 = Double.Parse(String.Concat(strSign ? "+" : "-", txtDig.Text).Trim());
                    txtDig.Focus();
                    double div = optClass.suma();
                    Console.WriteLine(div);
                    if (div < 0)
                    {
                        txtSign.Text = "-";
                        this.strSign = false;
                    }
                    else
                    {
                        txtSign.Text = "+";
                        this.strSign = true;
                    }
                    txtDig.Text = div.ToString().Replace(txtSign.Text, "");
                }
            }
            else
            {
                MessageBox.Show("Ingresa un valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (checkIsEmpty())
            {
                if (this.Index == 1)
                {
                    this.optClass.n1 = Double.Parse(String.Concat(strSign ? "+" : "-", txtDig.Text).Trim());
                    txtDig.Focus();
                    option = 4;
                    txtDig.Text = "";
                    this.Index++;
                }
                else
                {
                    this.Index--;
                    optClass.n2 = Double.Parse(String.Concat(strSign ? "+" : "-", txtDig.Text).Trim());
                    txtDig.Focus();
                    double div = optClass.multiplica();
                    if (div < 0)
                    {
                        txtSign.Text = "-";
                        this.strSign = false;
                    }
                    else
                    {
                        txtSign.Text = "+";
                        this.strSign = true;
                    }
                    txtDig.Text = div.ToString().Replace(txtSign.Text, "");
                }
            }
            else
            {
                MessageBox.Show("Ingresa un valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            if (checkIsEmpty())
            {
                if (this.Index == 1)
                {
                    this.optClass.n1 = Double.Parse(String.Concat(strSign ? "+" : "-", txtDig.Text).Trim());
                    txtDig.Focus();
                    txtDig.Text = "";
                    option = 5;
                    this.Index++;
                }
                else
                {
                    this.Index--;
                    optClass.n2 = Double.Parse(String.Concat(strSign ? "+" : "-", txtDig.Text).Trim());
                    txtDig.Focus();
                    double div = optClass.potencia();
                    if (div < 0)
                    {
                        txtSign.Text = "-";
                        this.strSign = false;
                    }
                    else
                    {
                        txtSign.Text = "+";
                        this.strSign = true;
                    }
                    txtDig.Text = div.ToString().Replace(txtSign.Text, "");
                }
            }
            else
            {
                MessageBox.Show("Ingresa un valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            if (checkIsEmpty())
            {
                if (this.Index == 1)
                {
                    this.optClass.n1 = Double.Parse(String.Concat(strSign ? "+" : "-", txtDig.Text).Trim());
                    txtDig.Focus();
                    txtDig.Text = "";
                    this.Index++;
                    option = 6;
                }
                else
                {
                    this.Index--;
                    optClass.n2 = Double.Parse(String.Concat(strSign ? "+" : "-", txtDig.Text).Trim());
                    txtDig.Focus();
                    double div = optClass.raiz();
                    if (div < 0)
                    {
                        txtSign.Text = "-";
                        this.strSign = false;
                    }
                    else
                    {
                        txtSign.Text = "+";
                        this.strSign = true;
                    }
                    txtDig.Text = div.ToString().Substring(0, 1);
                }
            }
            else
            {
                MessageBox.Show("Ingresa un valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Las operaciones hechas al momento son: {optClass.con}");
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (this.Index == 2)
            {
                switch (this.option)
                {
                    case 1:
                        btnDiv_Click(new object(), new EventArgs());
                        break;
                    case 2:
                        btnMin_Click(new object(), new EventArgs());
                        break;
                    case 3:
                        btnSum_Click(new object(), new EventArgs());
                        break;
                    case 4:
                        btnMult_Click(new object(), new EventArgs());
                        break;
                    case 5:
                        btnPow_Click(new object(), new EventArgs());
                        break;
                    case 6:
                        btnRaiz_Click(new object(), new EventArgs());
                        break;
                }
            }  
        }

        private void btnPrimo_Click(object sender, EventArgs e)
        {
            if (EsPrimo(Double.Parse(txtDig.Text)))
            {
                txtRes.Text = "Es primo";
            }
            else
            {
                txtRes.Text = "No es primo";
            }
        }
        static bool EsPrimo(Double numero)
        {
            for (int i = 2; i < numero; i++)
            {
                if ((numero % i) == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private void btnImpar_Click(object sender, EventArgs e)
        {
            if ((Double.Parse(txtDig.Text) % 2) == 0)
            {
                txtRes.Text = "Es par";
            }
            else
            {
                txtRes.Text = "Es impar";
            }
        }

        private void btnAb_Click(object sender, EventArgs e)
        {
            if (!strSign)
            {
                txtRes.Text = Math.Abs(Double.Parse(txtDig.Text)).ToString();
            }
        }
        static bool EsPar(int numero)
        {
            if ((numero % 2) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnZero_Click(object sender, EventArgs e)
        {
            optClass.n1 = 0.00;
            optClass.n2 = 0.00;
            this.Index = 1;
            option = 0;
            txtDig.Text = "0.00";
            listDetalle.Items.Clear();
            Memoria.set(0.00);
        }

        private void btnSucPar_Click(object sender, EventArgs e)
        {
            listDetalle.Items.Clear();
            if (txtDig.Text != "")
            {
                int v = (int) Math.Round(double.Parse(txtDig.Text));
                for (int x = 0; x <= v; x++)
                {
                    if (EsPar(x) && x != 0) {
                        listDetalle.Items.Add(x);
                    }
                }
            }
        }

        private void btnSucImpar_Click(object sender, EventArgs e)
        {
            listDetalle.Items.Clear();
            if (txtDig.Text != "")
            {
                int v = (int)Math.Round(double.Parse(txtDig.Text));
                for (int x = 0; x <= v; x++)
                {
                    if (!EsPar(x) && x != 0)
                    {
                        listDetalle.Items.Add(x);
                    }
                }
            }
        }
    }
}
