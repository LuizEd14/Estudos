
namespace ArrayUnidimencional_Vetor
{
    partial class frmVetor
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
            this.panelTopo = new System.Windows.Forms.Panel();
            this.panelBase = new System.Windows.Forms.Panel();
            this.lblTopo = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.btnTestar = new System.Windows.Forms.Button();
            this.panelTopo.SuspendLayout();
            this.panelBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopo
            // 
            this.panelTopo.BackColor = System.Drawing.Color.Navy;
            this.panelTopo.Controls.Add(this.lblTopo);
            this.panelTopo.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTopo.ForeColor = System.Drawing.Color.White;
            this.panelTopo.Location = new System.Drawing.Point(0, 0);
            this.panelTopo.Name = "panelTopo";
            this.panelTopo.Size = new System.Drawing.Size(486, 46);
            this.panelTopo.TabIndex = 0;
            // 
            // panelBase
            // 
            this.panelBase.BackColor = System.Drawing.Color.Navy;
            this.panelBase.Controls.Add(this.lblBase);
            this.panelBase.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBase.ForeColor = System.Drawing.Color.White;
            this.panelBase.Location = new System.Drawing.Point(0, 408);
            this.panelBase.Name = "panelBase";
            this.panelBase.Size = new System.Drawing.Size(486, 42);
            this.panelBase.TabIndex = 1;
            // 
            // lblTopo
            // 
            this.lblTopo.AutoSize = true;
            this.lblTopo.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopo.ForeColor = System.Drawing.Color.White;
            this.lblTopo.Location = new System.Drawing.Point(3, 9);
            this.lblTopo.Name = "lblTopo";
            this.lblTopo.Size = new System.Drawing.Size(481, 32);
            this.lblTopo.TabIndex = 0;
            this.lblTopo.Text = "Para testar o array unidimencional-vetor";
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBase.ForeColor = System.Drawing.Color.White;
            this.lblBase.Location = new System.Drawing.Point(100, 2);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(268, 32);
            this.lblBase.TabIndex = 0;
            this.lblBase.Text = "Clique no botão acima";
            // 
            // btnTestar
            // 
            this.btnTestar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnTestar.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestar.ForeColor = System.Drawing.Color.White;
            this.btnTestar.Location = new System.Drawing.Point(144, 130);
            this.btnTestar.Name = "btnTestar";
            this.btnTestar.Size = new System.Drawing.Size(196, 181);
            this.btnTestar.TabIndex = 2;
            this.btnTestar.Text = "OK";
            this.btnTestar.UseVisualStyleBackColor = false;
            this.btnTestar.Click += new System.EventHandler(this.btnTestar_Click);
            // 
            // frmVetor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(486, 450);
            this.Controls.Add(this.btnTestar);
            this.Controls.Add(this.panelBase);
            this.Controls.Add(this.panelTopo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmVetor";
            this.Text = "Vetor";
            this.panelTopo.ResumeLayout(false);
            this.panelTopo.PerformLayout();
            this.panelBase.ResumeLayout(false);
            this.panelBase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopo;
        private System.Windows.Forms.Label lblTopo;
        private System.Windows.Forms.Panel panelBase;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Button btnTestar;
    }
}

