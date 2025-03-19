using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoDeIdade
{
    public partial class frmCalculoIdade : Form
    {
        public frmCalculoIdade()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtAnoAtual.Text, out int n1) && int.TryParse(txtAnoNasc.Text, out int n2))
            {
                lblIdade.Text = (n1 - n2).ToString();
            }
            else
            {
                MessageBox.Show("Insira só numeros!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
