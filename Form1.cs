using System.Globalization;

namespace CALCULADORA_1
{
    public partial class Form1 : Form
    {
        decimal valor1= 0, valor2 = 0;
        string operacao = "";
        private NumberStyles cultereInfo;

        public Form1()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textoResult.Text += "1";
            textSalva.Text += "1";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textoResult.Text += "2";
            textSalva.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textoResult.Text += "3";
            textSalva.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textoResult.Text += "4";
            textSalva.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textoResult.Text += "5";
            textSalva.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textoResult.Text += "6";
            textSalva.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textoResult.Text += "7";
            textSalva.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
;            textoResult.Text += "8";
            textSalva.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textoResult.Text += "9";
            textSalva.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textoResult.Text += "0";

            textSalva.Text += "0";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textoResult.Clear();
            textSalva.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            
            textSalva.Text += " = ";
            if (textoResult.Text == "")
            {
                MessageBox.Show("DIGITE UM NUMERO");
            }
            else { 
            
            
                valor2 = decimal.Parse(textoResult.Text, CultureInfo.InvariantCulture);

            }


            switch (operacao)
            {
                case "SOMA":
                    textoResult.Text = Convert.ToString(valor1 + valor2);
                    textSalva.Text += textoResult.Text;
                    break;

                case "SUBTRACAO":
                    textoResult.Text = Convert.ToString(valor1 - valor2);
                    textSalva.Text += textoResult.Text;
                    break;

                case "MULTIPLICACAO":
                    textoResult.Text = Convert.ToString(valor1 * valor2);
                    textSalva.Text += textoResult.Text;
                    break;

                case "DIVISAO":
                    textoResult.Text = Convert.ToString(valor1 / valor2);
                    textSalva.Text += textoResult.Text;
                    break;

                              
                default:
                    MessageBox.Show("DIGITE UM NUMERO");
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            textoResult.Text += ".";
            textSalva.Text += ".";
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {

            textSalva.Text += " - ";
            if (textoResult.Text != "")
            {
                valor1 = decimal.Parse(textoResult.Text, CultureInfo.InvariantCulture);

                textoResult.Text = "";

                operacao = "SUBTRACAO";
            }
            else
            {
                MessageBox.Show("DIGITE UM NUMERO");
            }

        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            textSalva.Text += " * ";
            if (textoResult.Text != "")
            {
                valor1 = decimal.Parse(textoResult.Text, CultureInfo.InvariantCulture);
                textoResult.Text = "";
                operacao = "MULTIPLICACAO";

            }
            else
            {
                MessageBox.Show("DIGITE UM NUMERO");
            }


        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            textSalva.Text += " / ";
            if (textoResult.Text != "")
            {
                valor1 = decimal.Parse(textoResult.Text, CultureInfo.InvariantCulture);
                textoResult.Text = "";
                operacao = "DIVISAO";
            }
            else
            {
                MessageBox.Show("DIGITE UM NUMERO");
            }
                
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            textoResult.Text = "";
            textSalva.Text += " ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            textSalva.Text += " + ";
            if (textoResult.Text != "")
            {
                valor1 = decimal.Parse(textoResult.Text, CultureInfo.InvariantCulture);
                textoResult.Text = "";
               
                operacao = "SOMA";
            }
            else
            {
                MessageBox.Show("DIGITE UM NUMERO");
            }

        }
    }
}