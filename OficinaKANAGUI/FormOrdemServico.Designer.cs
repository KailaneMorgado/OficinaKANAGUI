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
            this.btnLancar = new System.Windows.Forms.Button();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.dgvServicos = new System.Windows.Forms.DataGridView();
            this.dgvVeiculos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
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
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuario_CellClick);
            // 
            // btnLancar
            // 
            this.btnLancar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(166)))), ((int)(((byte)(149)))));
            this.btnLancar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLancar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(138)))), ((int)(((byte)(115)))));
            this.btnLancar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLancar.Location = new System.Drawing.Point(79, 282);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(153, 37);
            this.btnLancar.TabIndex = 4;
            this.btnLancar.Text = "Lançar";
            this.btnLancar.UseVisualStyleBackColor = false;
            this.btnLancar.Click += new System.EventHandler(this.btnLancar_Click);
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQuantidade.Location = new System.Drawing.Point(144, 235);
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(122, 26);
            this.txbQuantidade.TabIndex = 3;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(27, 235);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(111, 23);
            this.lblQuantidade.TabIndex = 1;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // dgvServicos
            // 
            this.dgvServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicos.Location = new System.Drawing.Point(954, 80);
            this.dgvServicos.Name = "dgvServicos";
            this.dgvServicos.Size = new System.Drawing.Size(304, 426);
            this.dgvServicos.TabIndex = 7;
            this.dgvServicos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServicos_CellClick);
            // 
            // dgvVeiculos
            // 
            this.dgvVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVeiculos.Location = new System.Drawing.Point(658, 80);
            this.dgvVeiculos.Name = "dgvVeiculos";
            this.dgvVeiculos.Size = new System.Drawing.Size(290, 430);
            this.dgvVeiculos.TabIndex = 8;
            this.dgvVeiculos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVeiculos_CellClick);
            // 
            // FormOrdemServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(193)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(1268, 522);
            this.Controls.Add(this.dgvVeiculos);
            this.Controls.Add(this.btnLancar);
            this.Controls.Add(this.dgvServicos);
            this.Controls.Add(this.txbQuantidade);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.lblOrdemServico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormOrdemServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordem de Serviço";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrdemServico;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnLancar;
        private System.Windows.Forms.TextBox txbQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.DataGridView dgvServicos;
        private System.Windows.Forms.DataGridView dgvVeiculos;
    }
}