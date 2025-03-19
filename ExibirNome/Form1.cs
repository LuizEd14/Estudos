using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace ExibirNome
{
    public partial class frmExibirNome : Form
    {
        public frmExibirNome()
        {
            InitializeComponent();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            string nome = txtExibirNome.Text;
            MessageBox.Show($"Olá {nome}!");
        }

        private void btnTroll_Click(object sender, EventArgs e)
        {
            string url = "https://www.youtube.com/watch?v=XfELJU1mRMg";

            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }
    }
}
