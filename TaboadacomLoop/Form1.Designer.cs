
namespace TaboadacomLoop
{
    partial class frmTabuadaLoop
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlFundo = new System.Windows.Forms.Panel();
            this.pnlDireita = new System.Windows.Forms.Panel();
            this.pnlEsquerda = new System.Windows.Forms.Panel();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnExecutarTaboada = new System.Windows.Forms.Button();
            this.lstTabuada = new System.Windows.Forms.ListBox();
            this.pnlFundo.SuspendLayout();
            this.pnlDireita.SuspendLayout();
            this.pnlEsquerda.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Patrick Hand", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(41, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(132, 26);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Insira um número";
            // 
            // pnlFundo
            // 
            this.pnlFundo.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pnlFundo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFundo.Controls.Add(this.pnlEsquerda);
            this.pnlFundo.Controls.Add(this.pnlDireita);
            this.pnlFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFundo.Location = new System.Drawing.Point(0, 0);
            this.pnlFundo.Name = "pnlFundo";
            this.pnlFundo.Size = new System.Drawing.Size(438, 457);
            this.pnlFundo.TabIndex = 1;
            // 
            // pnlDireita
            // 
            this.pnlDireita.BackColor = System.Drawing.Color.Azure;
            this.pnlDireita.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDireita.Controls.Add(this.btnExecutarTaboada);
            this.pnlDireita.Controls.Add(this.txtNumero);
            this.pnlDireita.Controls.Add(this.lblTitulo);
            this.pnlDireita.Location = new System.Drawing.Point(206, 10);
            this.pnlDireita.Name = "pnlDireita";
            this.pnlDireita.Size = new System.Drawing.Size(218, 433);
            this.pnlDireita.TabIndex = 1;
            // 
            // pnlEsquerda
            // 
            this.pnlEsquerda.BackColor = System.Drawing.Color.Azure;
            this.pnlEsquerda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlEsquerda.Controls.Add(this.lstTabuada);
            this.pnlEsquerda.Location = new System.Drawing.Point(10, 10);
            this.pnlEsquerda.Name = "pnlEsquerda";
            this.pnlEsquerda.Size = new System.Drawing.Size(181, 433);
            this.pnlEsquerda.TabIndex = 2;
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(46, 48);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(127, 62);
            this.txtNumero.TabIndex = 1;
            this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnExecutarTaboada
            // 
            this.btnExecutarTaboada.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnExecutarTaboada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExecutarTaboada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExecutarTaboada.Font = new System.Drawing.Font("Patrick Hand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecutarTaboada.Location = new System.Drawing.Point(61, 130);
            this.btnExecutarTaboada.Name = "btnExecutarTaboada";
            this.btnExecutarTaboada.Size = new System.Drawing.Size(97, 55);
            this.btnExecutarTaboada.TabIndex = 2;
            this.btnExecutarTaboada.Text = "Executar Tabuada";
            this.btnExecutarTaboada.UseVisualStyleBackColor = false;
            this.btnExecutarTaboada.Click += new System.EventHandler(this.btnExecutarTaboada_Click);
            // 
            // lstTabuada
            // 
            this.lstTabuada.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTabuada.FormattingEnabled = true;
            this.lstTabuada.ItemHeight = 27;
            this.lstTabuada.Location = new System.Drawing.Point(3, 10);
            this.lstTabuada.Name = "lstTabuada";
            this.lstTabuada.Size = new System.Drawing.Size(171, 409);
            this.lstTabuada.TabIndex = 0;
            // 
            // frmTabuadaLoop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 457);
            this.Controls.Add(this.pnlFundo);
            this.Name = "frmTabuadaLoop";
            this.Text = "Tabuada com Loop";
            this.pnlFundo.ResumeLayout(false);
            this.pnlDireita.ResumeLayout(false);
            this.pnlDireita.PerformLayout();
            this.pnlEsquerda.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlFundo;
        private System.Windows.Forms.Panel pnlEsquerda;
        private System.Windows.Forms.Panel pnlDireita;
        private System.Windows.Forms.Button btnExecutarTaboada;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.ListBox lstTabuada;
    }
}

