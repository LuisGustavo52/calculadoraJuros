namespace calculadoraJutos
{
    partial class Form1
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
            this.txtValorPrincipal = new System.Windows.Forms.TextBox();
            this.lblValorPrincipal = new System.Windows.Forms.Label();
            this.txtJurosAno = new System.Windows.Forms.TextBox();
            this.lblJuros = new System.Windows.Forms.Label();
            this.txtParcelas = new System.Windows.Forms.TextBox();
            this.lblParcelas = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResultadoJuros = new System.Windows.Forms.Label();
            this.txtValorJuros = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorParcela = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtValorPrincipal
            // 
            this.txtValorPrincipal.Location = new System.Drawing.Point(182, 77);
            this.txtValorPrincipal.Name = "txtValorPrincipal";
            this.txtValorPrincipal.Size = new System.Drawing.Size(223, 20);
            this.txtValorPrincipal.TabIndex = 0;
            // 
            // lblValorPrincipal
            // 
            this.lblValorPrincipal.AutoSize = true;
            this.lblValorPrincipal.Location = new System.Drawing.Point(257, 61);
            this.lblValorPrincipal.Name = "lblValorPrincipal";
            this.lblValorPrincipal.Size = new System.Drawing.Size(74, 13);
            this.lblValorPrincipal.TabIndex = 1;
            this.lblValorPrincipal.Text = "Valor Principal";
            // 
            // txtJurosAno
            // 
            this.txtJurosAno.Location = new System.Drawing.Point(182, 155);
            this.txtJurosAno.Name = "txtJurosAno";
            this.txtJurosAno.Size = new System.Drawing.Size(223, 20);
            this.txtJurosAno.TabIndex = 2;
            // 
            // lblJuros
            // 
            this.lblJuros.AutoSize = true;
            this.lblJuros.Location = new System.Drawing.Point(238, 139);
            this.lblJuros.Name = "lblJuros";
            this.lblJuros.Size = new System.Drawing.Size(107, 13);
            this.lblJuros.TabIndex = 3;
            this.lblJuros.Text = "Taxa de juros ao ano";
            // 
            // txtParcelas
            // 
            this.txtParcelas.Location = new System.Drawing.Point(182, 234);
            this.txtParcelas.Name = "txtParcelas";
            this.txtParcelas.Size = new System.Drawing.Size(223, 20);
            this.txtParcelas.TabIndex = 4;
            // 
            // lblParcelas
            // 
            this.lblParcelas.AutoSize = true;
            this.lblParcelas.Location = new System.Drawing.Point(243, 218);
            this.lblParcelas.Name = "lblParcelas";
            this.lblParcelas.Size = new System.Drawing.Size(102, 13);
            this.lblParcelas.TabIndex = 5;
            this.lblParcelas.Text = "Numero de parcelas";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(102, 312);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(149, 20);
            this.txtValorTotal.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Valor Total";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblResultadoJuros
            // 
            this.lblResultadoJuros.AutoSize = true;
            this.lblResultadoJuros.Location = new System.Drawing.Point(346, 290);
            this.lblResultadoJuros.Name = "lblResultadoJuros";
            this.lblResultadoJuros.Size = new System.Drawing.Size(59, 13);
            this.lblResultadoJuros.TabIndex = 8;
            this.lblResultadoJuros.Text = "Valor Juros";
            // 
            // txtValorJuros
            // 
            this.txtValorJuros.Location = new System.Drawing.Point(302, 312);
            this.txtValorJuros.Name = "txtValorJuros";
            this.txtValorJuros.Size = new System.Drawing.Size(149, 20);
            this.txtValorJuros.TabIndex = 9;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(246, 407);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Valor Parcela";
            // 
            // txtValorParcela
            // 
            this.txtValorParcela.Location = new System.Drawing.Point(210, 367);
            this.txtValorParcela.Name = "txtValorParcela";
            this.txtValorParcela.Size = new System.Drawing.Size(149, 20);
            this.txtValorParcela.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 474);
            this.Controls.Add(this.txtValorParcela);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtValorJuros);
            this.Controls.Add(this.lblResultadoJuros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.lblParcelas);
            this.Controls.Add(this.txtParcelas);
            this.Controls.Add(this.lblJuros);
            this.Controls.Add(this.txtJurosAno);
            this.Controls.Add(this.lblValorPrincipal);
            this.Controls.Add(this.txtValorPrincipal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValorPrincipal;
        private System.Windows.Forms.Label lblValorPrincipal;
        private System.Windows.Forms.TextBox txtJurosAno;
        private System.Windows.Forms.Label lblJuros;
        private System.Windows.Forms.TextBox txtParcelas;
        private System.Windows.Forms.Label lblParcelas;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResultadoJuros;
        private System.Windows.Forms.TextBox txtValorJuros;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValorParcela;
    }
}

