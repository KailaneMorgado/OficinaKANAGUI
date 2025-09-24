namespace OficinaKANAGUI
{
    partial class FormOrdemServico
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
            this.lblOrdemServico = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.grbInformacoes = new System.Windows.Forms.GroupBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.txbIdServico = new System.Windows.Forms.TextBox();
            this.txbOrdemServico = new System.Windows.Forms.TextBox();
            this.lblServico = new System.Windows.Forms.Label();
            this.lblOrdem = new System.Windows.Forms.Label();
            this.grbLancamento = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLancar = new System.Windows.Forms.Button();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.txbDescricaoServico = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblDescServico = new System.Windows.Forms.Label();
            this.dgvServicos = new System.Windows.Forms.DataGridView();
            this.dgvVeiculos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.grbInformacoes.SuspendLayout();
            this.grbLancamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrdemServico
            // 
            this.lblOrdemServico.AutoSize = true;
            this.lblOrdemServico.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdemServico.Location = new System.Drawing.Point(276, 25);
            this.lblOrdemServico.Name = "lblOrdemServico";
            this.lblOrdemServico.Size = new System.Drawing.Size(209, 31);
            this.lblOrdemServico.TabIndex = 0;
            this.lblOrdemServico.Text = "Ordem de Serviço";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(362, 80);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(290, 430);
            this.dgvUsuarios.TabIndex = 1;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrdemServico_CellClick);
            // 
            // grbInformacoes
            // 
            this.grbInformacoes.Controls.Add(this.btnContinuar);
            this.grbInformacoes.Controls.Add(this.txbIdServico);
            this.grbInformacoes.Controls.Add(this.txbOrdemServico);
            this.grbInformacoes.Controls.Add(this.lblServico);
            this.grbInformacoes.Controls.Add(this.lblOrdem);
            this.grbInformacoes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInformacoes.Location = new System.Drawing.Point(12, 80);
            this.grbInformacoes.Name = "grbInformacoes";
            this.grbInformacoes.Size = new System.Drawing.Size(318, 176);
            this.grbInformacoes.TabIndex = 4;
            this.grbInformacoes.TabStop = false;
            this.grbInformacoes.Text = "Informações";
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(166)))), ((int)(((byte)(149)))));
            this.btnContinuar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnContinuar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(138)))), ((int)(((byte)(115)))));
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuar.Location = new System.Drawing.Point(89, 124);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(118, 37);
            this.btnContinuar.TabIndex = 4;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // txbIdServico
            // 
            this.txbIdServico.Location = new System.Drawing.Point(148, 81);
            this.txbIdServico.Name = "txbIdServico";
            this.txbIdServico.Size = new System.Drawing.Size(129, 26);
            this.txbIdServico.TabIndex = 3;
            // 
            // txbOrdemServico
            // 
            this.txbOrdemServico.Location = new System.Drawing.Point(148, 38);
            this.txbOrdemServico.Name = "txbOrdemServico";
            this.txbOrdemServico.Size = new System.Drawing.Size(129, 26);
            this.txbOrdemServico.TabIndex = 2;
            // 
            // lblServico
            // 
            this.lblServico.AutoSize = true;
            this.lblServico.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServico.Location = new System.Drawing.Point(16, 84);
            this.lblServico.Name = "lblServico";
            this.lblServico.Size = new System.Drawing.Size(126, 23);
            this.lblServico.TabIndex = 1;
            this.lblServico.Text = "Id do Serviço:";
            // 
            // lblOrdem
            // 
            this.lblOrdem.AutoSize = true;
            this.lblOrdem.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdem.Location = new System.Drawing.Point(6, 38);
            this.lblOrdem.Name = "lblOrdem";
            this.lblOrdem.Size = new System.Drawing.Size(141, 23);
            this.lblOrdem.TabIndex = 0;
            this.lblOrdem.Text = "Ordem Serviço:";
            // 
            // grbLancamento
            // 
            this.grbLancamento.Controls.Add(this.btnCancelar);
            this.grbLancamento.Controls.Add(this.btnLancar);
            this.grbLancamento.Controls.Add(this.txbQuantidade);
            this.grbLancamento.Controls.Add(this.txbDescricaoServico);
            this.grbLancamento.Controls.Add(this.lblQuantidade);
            this.grbLancamento.Controls.Add(this.lblDescServico);
            this.grbLancamento.Enabled = false;
            this.grbLancamento.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLancamento.Location = new System.Drawing.Point(12, 279);
            this.grbLancamento.Name = "grbLancamento";
            this.grbLancamento.Size = new System.Drawing.Size(318, 227);
            this.grbLancamento.TabIndex = 6;
            this.grbLancamento.TabStop = false;
            this.grbLancamento.Text = "Lançamentos";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(166)))), ((int)(((byte)(149)))));
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(138)))), ((int)(((byte)(115)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(72, 177);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(153, 37);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLancar
            // 
            this.btnLancar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(166)))), ((int)(((byte)(149)))));
            this.btnLancar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLancar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(138)))), ((int)(((byte)(115)))));
            this.btnLancar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLancar.Location = new System.Drawing.Point(72, 133);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(153, 37);
            this.btnLancar.TabIndex = 4;
            this.btnLancar.Text = "Lançar";
            this.btnLancar.UseVisualStyleBackColor = false;
            this.btnLancar.Click += new System.EventHandler(this.btnLancar_Click);
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Location = new System.Drawing.Point(190, 81);
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(122, 26);
            this.txbQuantidade.TabIndex = 3;
            // 
            // txbDescricaoServico
            // 
            this.txbDescricaoServico.Location = new System.Drawing.Point(190, 35);
            this.txbDescricaoServico.Name = "txbDescricaoServico";
            this.txbDescricaoServico.ReadOnly = true;
            this.txbDescricaoServico.Size = new System.Drawing.Size(122, 26);
            this.txbDescricaoServico.TabIndex = 2;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(39, 84);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(111, 23);
            this.lblQuantidade.TabIndex = 1;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // lblDescServico
            // 
            this.lblDescServico.AutoSize = true;
            this.lblDescServico.BackColor = System.Drawing.Color.Transparent;
            this.lblDescServico.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescServico.Location = new System.Drawing.Point(0, 38);
            this.lblDescServico.Name = "lblDescServico";
            this.lblDescServico.Size = new System.Drawing.Size(193, 23);
            this.lblDescServico.TabIndex = 0;
            this.lblDescServico.Text = "Descriçao do Serviço:";
            // 
            // dgvServicos
            // 
            this.dgvServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicos.Location = new System.Drawing.Point(954, 80);
            this.dgvServicos.Name = "dgvServicos";
            this.dgvServicos.Size = new System.Drawing.Size(304, 426);
            this.dgvServicos.TabIndex = 7;
            // 
            // dgvVeiculos
            // 
            this.dgvVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVeiculos.Location = new System.Drawing.Point(658, 80);
            this.dgvVeiculos.Name = "dgvVeiculos";
            this.dgvVeiculos.Size = new System.Drawing.Size(290, 430);
            this.dgvVeiculos.TabIndex = 8;
            // 
            // FormOrdemServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(193)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(1268, 522);
            this.Controls.Add(this.dgvVeiculos);
            this.Controls.Add(this.dgvServicos);
            this.Controls.Add(this.grbLancamento);
            this.Controls.Add(this.grbInformacoes);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.lblOrdemServico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormOrdemServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordem de Serviço";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.grbInformacoes.ResumeLayout(false);
            this.grbInformacoes.PerformLayout();
            this.grbLancamento.ResumeLayout(false);
            this.grbLancamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrdemServico;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.GroupBox grbInformacoes;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.TextBox txbIdServico;
        private System.Windows.Forms.TextBox txbOrdemServico;
        private System.Windows.Forms.Label lblServico;
        private System.Windows.Forms.Label lblOrdem;
        private System.Windows.Forms.GroupBox grbLancamento;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLancar;
        private System.Windows.Forms.TextBox txbQuantidade;
        private System.Windows.Forms.TextBox txbDescricaoServico;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblDescServico;
        private System.Windows.Forms.DataGridView dgvServicos;
        private System.Windows.Forms.DataGridView dgvVeiculos;
    }
}