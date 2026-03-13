using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CalculadoraWindowsForm
{
    public partial class FrmIdade : Form
    {
        public FrmIdade()
        {
            InitializeComponent();
        }

        int idade;
        int resultado;

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            idade = int.Parse(txtGrab.Text);
            switch (idade)
            {
                case >= 60:
                    MessageBox.Show("Você é Idoso");
                    lbInformacao.Text = "Idoso";
                    break;

                case >= 30:
                    MessageBox.Show("Você é Jovem");
                    lbInformacao.Text = "Jovem";
                    break;

                case >= 18:
                    MessageBox.Show("Você é Adulto");
                    lbInformacao.Text = "Adulto";
                    break;

                case >= 12:
                    MessageBox.Show("Você é Adolescente");
                    lbInformacao.Text = "Adolescente";
                    break;

                case <= 11:
                    MessageBox.Show("Você é Criança");
                    lbInformacao.Text = "Criança";
                    break;

            }
        }
    }
}
