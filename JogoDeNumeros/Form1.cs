using System;
using System.Windows.Forms;

namespace JogoDeNumeros
{
    public partial class frmJogoDeNumeros : Form
    {
        int rNumber;
        int numeroTentativas = 10;
        int palpitedojogador;
        bool jogoGanho = false;
        string dica;
        Random ran;

        public frmJogoDeNumeros()
        {
            InitializeComponent();
            ran = new Random(); // Inicializa o Random uma única vez
            rNumber = ran.Next(1, 101); // Gera o número aleatório
        }

        private void btnTentativas_Click(object sender, EventArgs e)
        {
            if (numeroTentativas == 0 || jogoGanho)
            {
                txtResultado.Text = "O jogo acabou, você não tem mais tentativas!";
                return;
            }

            if (!int.TryParse(txtNumeroInserido.Text, out palpitedojogador) || palpitedojogador < 1 || palpitedojogador > 100)
            {
                MessageBox.Show("Por Favor, insira números de 1 a 100", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            numeroTentativas--;
            lblNumeroTentativas.Text = numeroTentativas.ToString();

            if (palpitedojogador > rNumber)
            {
                dica = $"{palpitedojogador} é grande que o número que escolhi.";
            }
            else if (palpitedojogador < rNumber)
            {
                dica = $"{palpitedojogador} é pouco que o número que escolhi.";
            }
            else
            {
                dica = $"Parabéns, você ganhou!";
                jogoGanho = true;
            }

            txtResultado.Text = dica;

        }
    }
}