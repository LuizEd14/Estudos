using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alertas
{
    public partial class frmAlertas : Form
    {
        public frmAlertas()
        {
            InitializeComponent();
        }

        private void btnAlertaSimples_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esse é um alerta simples.", "Alerta");
        }

        private void btnAlertaRobusto_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Vamos programar um sistema?", "Título aqui", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                MessageBox.Show("Aeeeee!");
            } else if (resposta == DialogResult.No)
            {
                DialogResult resultado = MessageBox.Show("Aw... sério? :(", ":(", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    MessageBox.Show(":(");
                } else
                {
                    MessageBox.Show("Ata! Que susto!");
                }
            }

        }
    }
}
