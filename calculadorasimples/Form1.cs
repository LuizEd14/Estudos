using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadorasimples
{
    public partial class frmCalculadoraSimples : Form
    {
        public frmCalculadoraSimples()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtPrimeiroNumero.Text, out float n1) && float.TryParse(txtSegundoNumero.Text, out float n2))
            {
                lblResultadoProduto.Text = (n1 + n2).ToString();
            }
            else
            {
                MessageBox.Show("Alguns dos blocos preenchidos tem letras ou caracteres especiais", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            /* lblResultadoProduto = (float.TryParse(txtPrimeiroNumero.Text, out float n1)) + (float.TryParse(txtSegundoNumero.Text, out float n2)).ToString(); */

        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtPrimeiroNumero.Text, out float n1) && float.TryParse(txtSegundoNumero.Text, out float n2))
            {
                lblResultadoProduto.Text = (n1 - n2).ToString();
            }
            else
            {
                MessageBox.Show("Alguns dos blocos preenchidos tem letras ou caracteres especiais", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            /* lblResultadoProduto = (float.TryParse(txtPrimeiroNumero.Text, out float n1)) - (float.TryParse(txtSegundoNumero.Text, out float n2)).ToString(); */

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtPrimeiroNumero.Text, out float n1) && float.TryParse(txtSegundoNumero.Text, out float n2))
            {
                lblResultadoProduto.Text = (n1 * n2).ToString();
            }
            else
            {
                MessageBox.Show("Alguns dos blocos preenchidos tem letras ou caracteres especiais", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            /* lblResultadoProduto = (float.TryParse(txtPrimeiroNumero.Text, out float n1)) * (float.TryParse(txtSegundoNumero.Text, out float n2)).ToString(); */

        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtPrimeiroNumero.Text, out float n1) && float.TryParse(txtSegundoNumero.Text, out float n2))
            {
                lblResultadoProduto.Text = (n1 / n2).ToString();
            }
            else
            {
                MessageBox.Show("Alguns dos blocos preenchidos tem letras ou caracteres especiais", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            /* lblResultadoProduto = (float.TryParse(txtPrimeiroNumero.Text, out float n1)) / (float.TryParse(txtSegundoNumero.Text, out float n2)).ToString(); */

        }
    }
}
