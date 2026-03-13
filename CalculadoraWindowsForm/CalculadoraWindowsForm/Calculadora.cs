namespace CalculadoraWindowsForm
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        double numero1 = 0;
        double numero2 = 0;
        string operacao = "";

        private void Botao_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            string valor = botao.Text;
            txtCalculo.Text += valor;// é o visor
        }

        private void Operador_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            // Guarda oque está no Visor
            numero1 = Convert.ToDouble(txtCalculo.Text);
            operacao = botao.Text;
            txtCalculo.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            numero2 = Convert.ToDouble(txtCalculo.Text);

            double resultado = 0;

            switch (operacao)
            {
                case "+":
                    resultado = numero1 + numero2;
                    break;

                case "-":
                    resultado = numero1 - numero2;
                    break;

                case "*":
                    resultado = numero1 * numero2;
                    break;

                case "/":
                    resultado = numero1 / numero2;
                    break;
            }

            txtCalculo.Text = resultado.ToString();


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCalculo.Clear();
            numero1 = 0;    numero2 = 0;
            operacao = "";
        }
        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (txtCalculo.Text.Length > 0)
            {
                txtCalculo.Text = txtCalculo.Text.Substring(0, txtCalculo.Text.Length - 1);
            }
        }
    }
}