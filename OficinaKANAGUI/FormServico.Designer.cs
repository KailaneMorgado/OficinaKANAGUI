namespace OficinaKANAGUI
{
    partial class FormServico
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
            this.lblServico = new System.Windows.Forms.Label();
            this.dgvServico = new System.Windows.Forms.DataGridView();
            this.grbCadastrar = new System.Windows.Forms.GroupBox();
            this.lblNomeCadastrar = new System.Windows.Forms.Label();
            this.txbNomeCadastrar = new System.Windows.Forms.TextBox();
            this.lblPrecoCadastrar = new System.Windows.Forms.Label();
            this.txbPrecoCadastrar = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txbPrecoEditar = new System.Windows.Forms.TextBox();
            this.lblNomePreco = new System.Windows.Forms.Label();
            this.txbNomeEditar = new System.Windows.Forms.TextBox();
            this.lblNomeEditar = new System.Windows.Forms.Label();
            this.grbApagar = new System.Windows.Forms.GroupBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblSelecioneApagar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServico)).BeginInit();
            this.grbCadastrar.SuspendLayout();
            this.grbEditar.SuspendLayout();
            this.grbApagar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblServico
            // 
            this.lblServico.AutoSize = true;
            this.lblServico.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServico.Location = new System.Drawing.Point(239, 20);
            this.lblServico.Name = "lblServico";
            this.lblServico.Size = new System.Drawing.Size(310, 31);
            this.lblServico.TabIndex = 0;
            this.lblServico.Text = "Gerenciamento de Serviços";
            // 
            // dgvServico
            // 
            this.dgvServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServico.Location = new System.Drawing.Point(88, 77);
            this.dgvServico.Name = "dgvServico";
            this.dgvServico.Size = new System.Drawing.Size(648, 275);
            this.dgvServico.TabIndex = 1;
            this.dgvServico.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServico_CellClick);
            // 
            // grbCadastrar
            // 
            this.grbCadastrar.Controls.Add(this.btnCadastrar);
            this.grbCadastrar.Controls.Add(this.txbPrecoCadastrar);
            this.grbCadastrar.Controls.Add(this.lblPrecoCadastrar);
            this.grbCadastrar.Controls.Add(this.txbNomeCadastrar);
            this.grbCadastrar.Controls.Add(this.lblNomeCadastrar);
            this.grbCadastrar.Location = new System.Drawing.Point(12, 405);
            this.grbCadastrar.Name = "grbCadastrar";
            this.grbCadastrar.Size = new System.Drawing.Size(242, 176);
            this.grbCadastrar.TabIndex = 2;
            this.grbCadastrar.TabStop = false;
            this.grbCadastrar.Text = "Cadastrar";
            // 
            // lblNomeCadastrar
            // 
            this.lblNomeCadastrar.AutoSize = true;
            this.lblNomeCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCadastrar.Location = new System.Drawing.Point(0, 41);
            this.lblNomeCadastrar.Name = "lblNomeCadastrar";
            this.lblNomeCadastrar.Size = new System.Drawing.Size(53, 18);
            this.lblNomeCadastrar.TabIndex = 3;
            this.lblNomeCadastrar.Text = "Nome:";
            // 
            // txbNomeCadastrar
            // 
            this.txbNomeCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomeCadastrar.Location = new System.Drawing.Point(51, 40);
            this.txbNomeCadastrar.Name = "txbNomeCadastrar";
            this.txbNomeCadastrar.Size = new System.Drawing.Size(184, 22);
            this.txbNomeCadastrar.TabIndex = 4;
            // 
            // lblPrecoCadastrar
            // 
            this.lblPrecoCadastrar.AutoSize = true;
            this.lblPrecoCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecoCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoCadastrar.Location = new System.Drawing.Point(1, 80);
            this.lblPrecoCadastrar.Name = "lblPrecoCadastrar";
            this.lblPrecoCadastrar.Size = new System.Drawing.Size(52, 18);
            this.lblPrecoCadastrar.TabIndex = 5;
            this.lblPrecoCadastrar.Text = "Preço:";
            // 
            // txbPrecoCadastrar
            // 
            this.txbPrecoCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrecoCadastrar.Location = new System.Drawing.Point(52, 80);
            this.txbPrecoCadastrar.Name = "txbPrecoCadastrar";
            this.txbPrecoCadastrar.Size = new System.Drawing.Size(184, 22);
            this.txbPrecoCadastrar.TabIndex = 6;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(166)))), ((int)(((byte)(151)))));
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(40, 132);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(144, 38);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // grbEditar
            // 
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Controls.Add(this.txbPrecoEditar);
            this.grbEditar.Controls.Add(this.lblNomePreco);
            this.grbEditar.Controls.Add(this.txbNomeEditar);
            this.grbEditar.Controls.Add(this.lblNomeEditar);
            this.grbEditar.Location = new System.Drawing.Point(282, 405);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(242, 176);
            this.grbEditar.TabIndex = 12;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(166)))), ((int)(((byte)(151)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(40, 132);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(144, 38);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txbPrecoEditar
            // 
            this.txbPrecoEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrecoEditar.Location = new System.Drawing.Point(52, 80);
            this.txbPrecoEditar.Name = "txbPrecoEditar";
            this.txbPrecoEditar.Size = new System.Drawing.Size(184, 22);
            this.txbPrecoEditar.TabIndex = 6;
            // 
            // lblNomePreco
            // 
            this.lblNomePreco.AutoSize = true;
            this.lblNomePreco.BackColor = System.Drawing.Color.Transparent;
            this.lblNomePreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePreco.Location = new System.Drawing.Point(1, 80);
            this.lblNomePreco.Name = "lblNomePreco";
            this.lblNomePreco.Size = new System.Drawing.Size(52, 18);
            this.lblNomePreco.TabIndex = 5;
            this.lblNomePreco.Text = "Preço:";
            // 
            // txbNomeEditar
            // 
            this.txbNomeEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomeEditar.Location = new System.Drawing.Point(51, 40);
            this.txbNomeEditar.Name = "txbNomeEditar";
            this.txbNomeEditar.Size = new System.Drawing.Size(184, 22);
            this.txbNomeEditar.TabIndex = 4;
            // 
            // lblNomeEditar
            // 
            this.lblNomeEditar.AutoSize = true;
            this.lblNomeEditar.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEditar.Location = new System.Drawing.Point(0, 41);
            this.lblNomeEditar.Name = "lblNomeEditar";
            this.lblNomeEditar.Size = new System.Drawing.Size(53, 18);
            this.lblNomeEditar.TabIndex = 3;
            this.lblNomeEditar.Text = "Nome:";
            // 
            // grbApagar
            // 
            this.grbApagar.Controls.Add(this.btnApagar);
            this.grbApagar.Controls.Add(this.lblSelecioneApagar);
            this.grbApagar.Location = new System.Drawing.Point(535, 405);
            this.grbApagar.Name = "grbApagar";
            this.grbApagar.Size = new System.Drawing.Size(253, 176);
            this.grbApagar.TabIndex = 13;
            this.grbApagar.TabStop = false;
            this.grbApagar.Text = "Apagar";
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.Maroon;
            this.btnApagar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnApagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(166)))), ((int)(((byte)(151)))));
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.ForeColor = System.Drawing.Color.White;
            this.btnApagar.Location = new System.Drawing.Point(57, 113);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(144, 38);
            this.btnApagar.TabIndex = 10;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // lblSelecioneApagar
            // 
            this.lblSelecioneApagar.AutoSize = true;
            this.lblSelecioneApagar.BackColor = System.Drawing.Color.Transparent;
            this.lblSelecioneApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecioneApagar.Location = new System.Drawing.Point(6, 78);
            this.lblSelecioneApagar.Name = "lblSelecioneApagar";
            this.lblSelecioneApagar.Size = new System.Drawing.Size(237, 18);
            this.lblSelecioneApagar.TabIndex = 0;
            this.lblSelecioneApagar.Text = "Selecione um usuário para apagar:";
            // 
            // FormServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(193)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(800, 612);
            this.Controls.Add(this.grbApagar);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbCadastrar);
            this.Controls.Add(this.dgvServico);
            this.Controls.Add(this.lblServico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serviço";
            ((System.ComponentModel.ISupportInitialize)(this.dgvServico)).EndInit();
            this.grbCadastrar.ResumeLayout(false);
            this.grbCadastrar.PerformLayout();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.grbApagar.ResumeLayout(false);
            this.grbApagar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServico;
        private System.Windows.Forms.DataGridView dgvServico;
        private System.Windows.Forms.GroupBox grbCadastrar;
        private System.Windows.Forms.Label lblNomeCadastrar;
        private System.Windows.Forms.TextBox txbPrecoCadastrar;
        private System.Windows.Forms.Label lblPrecoCadastrar;
        private System.Windows.Forms.TextBox txbNomeCadastrar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txbPrecoEditar;
        private System.Windows.Forms.Label lblNomePreco;
        private System.Windows.Forms.TextBox txbNomeEditar;
        private System.Windows.Forms.Label lblNomeEditar;
        private System.Windows.Forms.GroupBox grbApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblSelecioneApagar;
    }
}