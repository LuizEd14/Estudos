
namespace ExibirNome
{
    partial class frmExibirNome
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
            this.txtExibirNome = new System.Windows.Forms.TextBox();
            this.btnExibir = new System.Windows.Forms.Button();
            this.btnTroll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtExibirNome
            // 
            this.txtExibirNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExibirNome.Location = new System.Drawing.Point(77, 46);
            this.txtExibirNome.Name = "txtExibirNome";
            this.txtExibirNome.Size = new System.Drawing.Size(254, 20);
            this.txtExibirNome.TabIndex = 0;
            // 
            // btnExibir
            // 
            this.btnExibir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExibir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExibir.FlatAppearance.BorderSize = 0;
            this.btnExibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExibir.Location = new System.Drawing.Point(114, 96);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(178, 40);
            this.btnExibir.TabIndex = 1;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // btnTroll
            // 
            this.btnTroll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTroll.Location = new System.Drawing.Point(320, 170);
            this.btnTroll.Name = "btnTroll";
            this.btnTroll.Size = new System.Drawing.Size(82, 23);
            this.btnTroll.TabIndex = 2;
            this.btnTroll.Text = "Dinheiro grátis";
            this.btnTroll.UseVisualStyleBackColor = true;
            this.btnTroll.Click += new System.EventHandler(this.btnTroll_Click);
            // 
            // frmExibirNome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 205);
            this.Controls.Add(this.btnTroll);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.txtExibirNome);
            this.MinimumSize = new System.Drawing.Size(346, 244);
            this.Name = "frmExibirNome";
            this.Text = "Exibir Nome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtExibirNome;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Button btnTroll;
    }
}

