using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaboadacomLoop
{
    public partial class frmTabuadaLoop : Form
    {
        int num;

        public frmTabuadaLoop()
        {
            InitializeComponent();
        }

        private void btnExecutarTaboada_Click(object sender, EventArgs e)
        {
            lstTabuada.Items.Clear();

            int numeroInserido = TentaAe(txtNumero.Text);

           for (int i = 1; i < 11; i++)
           {
                    lstTabuada.Items.Add(numeroInserido + "x" + i + "=" + (numeroInserido * i));
           }
            
            //Adicionar a tabuada para o número inserido
            /*
              int numeroInserido = Convert.ToInt32(txtNumero.Text);

                for (int i = 1; i < 11; i++)
                {
                    lstTabuada.Items.Add(numeroInserido + "x" + i + "=" + (numeroInserido * i));
                }
             */
        }

        private int TentaAe(string x)
        {
            try
            {
                num = Convert.ToInt32(x);
            }
            catch (Exception AAAAAI)
            {
                MessageBox.Show("Erro: " + AAAAAI.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return num;
        }
    }
}
