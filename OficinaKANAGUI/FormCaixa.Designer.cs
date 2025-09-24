namespace OficinaKANAGUI
{
    partial class FormCaixa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCaixa = new System.Windows.Forms.Label();
            this.lblOrdem = new System.Windows.Forms.Label();
            this.txbOrdemServico = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvCaixa = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picboxCaixa = new System.Windows.Forms.PictureBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.chbPagamento = new System.Windows.Forms.CheckBox();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.mySqlCommand1 = new MySqlConnector.MySqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxCaixa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCaixa
            // 
            this.lblCaixa.AutoSize = true;
            this.lblCaixa.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaixa.Location = new System.Drawing.Point(277, 26);
            this.lblCaixa.Name = "lblCaixa";
            this.lblCaixa.Size = new System.Drawing.Size(88, 36);
            this.lblCaixa.TabIndex = 5;
            this.lblCaixa.Text = "Caixa";
            // 
            // lblOrdem
            // 
            this.lblOrdem.AutoSize = true;
            this.lblOrdem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdem.Location = new System.Drawing.Point(120, 95);
            this.lblOrdem.Name = "lblOrdem";
            this.lblOrdem.Size = new System.Drawing.Size(168, 20);
            this.lblOrdem.TabIndex = 7;
            this.lblOrdem.Text = "Ordem Serviço (email):";
            // 
            // txbOrdemServico
            // 
            this.txbOrdemServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbOrdemServico.Location = new System.Drawing.Point(294, 95);
            this.txbOrdemServico.Name = "txbOrdemServico";
            this.txbOrdemServico.Size = new System.Drawing.Size(209, 22);
            this.txbOrdemServico.TabIndex = 8;
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(150)))), ((int)(((byte)(120)))));
            this.btnListar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnListar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(111)))), ((int)(((byte)(85)))));
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar.Location = new System.Drawing.Point(323, 136);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(82, 34);
            this.btnListar.TabIndex = 9;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dgvCaixa
            // 
            this.dgvCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaixa.Location = new System.Drawing.Point(43, 176);
            this.dgvCaixa.Name = "dgvCaixa";
            this.dgvCaixa.Size = new System.Drawing.Size(619, 259);
            this.dgvCaixa.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OficinaKANAGUI.Properties.Resources.dinheiro;
            this.pictureBox1.Location = new System.Drawing.Point(260, 453);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // picboxCaixa
            // 
            this.picboxCaixa.Image = global::OficinaKANAGUI.Properties.Resources.Caixa;
            this.picboxCaixa.Location = new System.Drawing.Point(378, 12);
            this.picboxCaixa.Name = "picboxCaixa";
            this.picboxCaixa.Size = new System.Drawing.Size(55, 50);
            this.picboxCaixa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxCaixa.TabIndex = 6;
            this.picboxCaixa.TabStop = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotal.Location = new System.Drawing.Point(334, 476);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(47, 20);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "R$   -";
            // 
            // chbPagamento
            // 
            this.chbPagamento.AutoSize = true;
            this.chbPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbPagamento.Location = new System.Drawing.Point(260, 513);
            this.chbPagamento.Name = "chbPagamento";
            this.chbPagamento.Size = new System.Drawing.Size(182, 24);
            this.chbPagamento.TabIndex = 13;
            this.chbPagamento.Text = "Pagamento Recebido";
            this.chbPagamento.UseVisualStyleBackColor = true;
            this.chbPagamento.CheckedChanged += new System.EventHandler(this.chbPagamento_CheckedChanged);
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(150)))), ((int)(((byte)(120)))));
            this.btnEncerrar.Enabled = false;
            this.btnEncerrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEncerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(111)))), ((int)(((byte)(85)))));
            this.btnEncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncerrar.Location = new System.Drawing.Point(265, 549);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(168, 40);
            this.btnEncerrar.TabIndex = 14;
            this.btnEncerrar.Text = "Encerrar Ordem Serviço";
            this.btnEncerrar.UseVisualStyleBackColor = false;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CommandTimeout = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.Transaction = null;
            this.mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // FormCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(193)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(695, 601);
            this.Controls.Add(this.btnEncerrar);
            this.Controls.Add(this.chbPagamento);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvCaixa);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.txbOrdemServico);
            this.Controls.Add(this.lblOrdem);
            this.Controls.Add(this.picboxCaixa);
            this.Controls.Add(this.lblCaixa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCaixa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxCaixa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCaixa;
        private System.Windows.Forms.PictureBox picboxCaixa;
        private System.Windows.Forms.Label lblOrdem;
        private System.Windows.Forms.TextBox txbOrdemServico;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dgvCaixa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox chbPagamento;
        private System.Windows.Forms.Button btnEncerrar;
        private MySqlConnector.MySqlCommand mySqlCommand1;
    }
}