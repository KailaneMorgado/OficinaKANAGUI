namespace OficinaKANAGUI
{
    partial class FormVeiculo
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
            this.dgvVeiculos = new System.Windows.Forms.DataGridView();
            this.grbCadastrar = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txbCorCadastrar = new System.Windows.Forms.TextBox();
            this.lblCorCadastrar = new System.Windows.Forms.Label();
            this.txbAnoCadastrar = new System.Windows.Forms.TextBox();
            this.lblAnoCadastrar = new System.Windows.Forms.Label();
            this.txbMarcaCadastrar = new System.Windows.Forms.TextBox();
            this.lblMarcaCadastrar = new System.Windows.Forms.Label();
            this.txbModeloCadastrar = new System.Windows.Forms.TextBox();
            this.lblModeloCadastrar = new System.Windows.Forms.Label();
            this.txbPlacaCadastrar = new System.Windows.Forms.TextBox();
            this.lblPlacaCadastrar = new System.Windows.Forms.Label();
            this.lblVeiculos = new System.Windows.Forms.Label();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txbCorEditar = new System.Windows.Forms.TextBox();
            this.lblCorEditar = new System.Windows.Forms.Label();
            this.txbAnoEditar = new System.Windows.Forms.TextBox();
            this.lblAnoEditar = new System.Windows.Forms.Label();
            this.txbMarcaEditar = new System.Windows.Forms.TextBox();
            this.lblMarcaEditar = new System.Windows.Forms.Label();
            this.txbModeloEditar = new System.Windows.Forms.TextBox();
            this.lblModeloEditar = new System.Windows.Forms.Label();
            this.txbPlacaEditar = new System.Windows.Forms.TextBox();
            this.lblPlacaEditar = new System.Windows.Forms.Label();
            this.grbApagar = new System.Windows.Forms.GroupBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblSelecioneApagar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculos)).BeginInit();
            this.grbCadastrar.SuspendLayout();
            this.grbEditar.SuspendLayout();
            this.grbApagar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVeiculos
            // 
            this.dgvVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVeiculos.Location = new System.Drawing.Point(57, 94);
            this.dgvVeiculos.Name = "dgvVeiculos";
            this.dgvVeiculos.Size = new System.Drawing.Size(677, 298);
            this.dgvVeiculos.TabIndex = 0;
            this.dgvVeiculos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVeiculos_CellClick);
            // 
            // grbCadastrar
            // 
            this.grbCadastrar.Controls.Add(this.btnCadastrar);
            this.grbCadastrar.Controls.Add(this.txbCorCadastrar);
            this.grbCadastrar.Controls.Add(this.lblCorCadastrar);
            this.grbCadastrar.Controls.Add(this.txbAnoCadastrar);
            this.grbCadastrar.Controls.Add(this.lblAnoCadastrar);
            this.grbCadastrar.Controls.Add(this.txbMarcaCadastrar);
            this.grbCadastrar.Controls.Add(this.lblMarcaCadastrar);
            this.grbCadastrar.Controls.Add(this.txbModeloCadastrar);
            this.grbCadastrar.Controls.Add(this.lblModeloCadastrar);
            this.grbCadastrar.Controls.Add(this.txbPlacaCadastrar);
            this.grbCadastrar.Controls.Add(this.lblPlacaCadastrar);
            this.grbCadastrar.Location = new System.Drawing.Point(12, 413);
            this.grbCadastrar.Name = "grbCadastrar";
            this.grbCadastrar.Size = new System.Drawing.Size(253, 210);
            this.grbCadastrar.TabIndex = 1;
            this.grbCadastrar.TabStop = false;
            this.grbCadastrar.Text = "Cadastrar";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(201)))), ((int)(((byte)(192)))));
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(166)))), ((int)(((byte)(151)))));
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(45, 166);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(144, 38);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txbCorCadastrar
            // 
            this.txbCorCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCorCadastrar.Location = new System.Drawing.Point(60, 130);
            this.txbCorCadastrar.Name = "txbCorCadastrar";
            this.txbCorCadastrar.Size = new System.Drawing.Size(184, 22);
            this.txbCorCadastrar.TabIndex = 9;
            this.txbCorCadastrar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbCorCadastrar_KeyDown);
            // 
            // lblCorCadastrar
            // 
            this.lblCorCadastrar.AutoSize = true;
            this.lblCorCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.lblCorCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorCadastrar.Location = new System.Drawing.Point(7, 130);
            this.lblCorCadastrar.Name = "lblCorCadastrar";
            this.lblCorCadastrar.Size = new System.Drawing.Size(37, 18);
            this.lblCorCadastrar.TabIndex = 8;
            this.lblCorCadastrar.Text = "Cor:";
            // 
            // txbAnoCadastrar
            // 
            this.txbAnoCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAnoCadastrar.Location = new System.Drawing.Point(60, 104);
            this.txbAnoCadastrar.Name = "txbAnoCadastrar";
            this.txbAnoCadastrar.Size = new System.Drawing.Size(184, 22);
            this.txbAnoCadastrar.TabIndex = 7;
            this.txbAnoCadastrar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbAnoCadastrar_KeyDown);
            // 
            // lblAnoCadastrar
            // 
            this.lblAnoCadastrar.AutoSize = true;
            this.lblAnoCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.lblAnoCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnoCadastrar.Location = new System.Drawing.Point(6, 104);
            this.lblAnoCadastrar.Name = "lblAnoCadastrar";
            this.lblAnoCadastrar.Size = new System.Drawing.Size(38, 18);
            this.lblAnoCadastrar.TabIndex = 6;
            this.lblAnoCadastrar.Text = "Ano:";
            // 
            // txbMarcaCadastrar
            // 
            this.txbMarcaCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMarcaCadastrar.Location = new System.Drawing.Point(60, 78);
            this.txbMarcaCadastrar.Name = "txbMarcaCadastrar";
            this.txbMarcaCadastrar.Size = new System.Drawing.Size(184, 22);
            this.txbMarcaCadastrar.TabIndex = 5;
            this.txbMarcaCadastrar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbMarcaCadastrar_KeyDown);
            // 
            // lblMarcaCadastrar
            // 
            this.lblMarcaCadastrar.AutoSize = true;
            this.lblMarcaCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.lblMarcaCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaCadastrar.Location = new System.Drawing.Point(2, 78);
            this.lblMarcaCadastrar.Name = "lblMarcaCadastrar";
            this.lblMarcaCadastrar.Size = new System.Drawing.Size(54, 18);
            this.lblMarcaCadastrar.TabIndex = 4;
            this.lblMarcaCadastrar.Text = "Marca:";
            // 
            // txbModeloCadastrar
            // 
            this.txbModeloCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbModeloCadastrar.Location = new System.Drawing.Point(60, 52);
            this.txbModeloCadastrar.Name = "txbModeloCadastrar";
            this.txbModeloCadastrar.Size = new System.Drawing.Size(184, 22);
            this.txbModeloCadastrar.TabIndex = 3;
            this.txbModeloCadastrar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbModeloCadastrar_KeyDown);
            // 
            // lblModeloCadastrar
            // 
            this.lblModeloCadastrar.AutoSize = true;
            this.lblModeloCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.lblModeloCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModeloCadastrar.Location = new System.Drawing.Point(0, 51);
            this.lblModeloCadastrar.Name = "lblModeloCadastrar";
            this.lblModeloCadastrar.Size = new System.Drawing.Size(62, 18);
            this.lblModeloCadastrar.TabIndex = 2;
            this.lblModeloCadastrar.Text = "Modelo:";
            // 
            // txbPlacaCadastrar
            // 
            this.txbPlacaCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPlacaCadastrar.Location = new System.Drawing.Point(61, 26);
            this.txbPlacaCadastrar.Name = "txbPlacaCadastrar";
            this.txbPlacaCadastrar.Size = new System.Drawing.Size(184, 22);
            this.txbPlacaCadastrar.TabIndex = 1;
            this.txbPlacaCadastrar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbPlacaCadastrar_KeyDown);
            // 
            // lblPlacaCadastrar
            // 
            this.lblPlacaCadastrar.AutoSize = true;
            this.lblPlacaCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.lblPlacaCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacaCadastrar.Location = new System.Drawing.Point(2, 27);
            this.lblPlacaCadastrar.Name = "lblPlacaCadastrar";
            this.lblPlacaCadastrar.Size = new System.Drawing.Size(49, 18);
            this.lblPlacaCadastrar.TabIndex = 0;
            this.lblPlacaCadastrar.Text = "Placa:";
            // 
            // lblVeiculos
            // 
            this.lblVeiculos.AutoSize = true;
            this.lblVeiculos.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVeiculos.Location = new System.Drawing.Point(232, 35);
            this.lblVeiculos.Name = "lblVeiculos";
            this.lblVeiculos.Size = new System.Drawing.Size(312, 31);
            this.lblVeiculos.TabIndex = 2;
            this.lblVeiculos.Text = "Gerenciamento de Veiculos";
            // 
            // grbEditar
            // 
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Controls.Add(this.txbCorEditar);
            this.grbEditar.Controls.Add(this.lblCorEditar);
            this.grbEditar.Controls.Add(this.txbAnoEditar);
            this.grbEditar.Controls.Add(this.lblAnoEditar);
            this.grbEditar.Controls.Add(this.txbMarcaEditar);
            this.grbEditar.Controls.Add(this.lblMarcaEditar);
            this.grbEditar.Controls.Add(this.txbModeloEditar);
            this.grbEditar.Controls.Add(this.lblModeloEditar);
            this.grbEditar.Controls.Add(this.txbPlacaEditar);
            this.grbEditar.Controls.Add(this.lblPlacaEditar);
            this.grbEditar.Location = new System.Drawing.Point(271, 413);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(253, 210);
            this.grbEditar.TabIndex = 11;
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
            this.btnEditar.Location = new System.Drawing.Point(45, 166);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(144, 38);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txbCorEditar
            // 
            this.txbCorEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCorEditar.Location = new System.Drawing.Point(60, 130);
            this.txbCorEditar.Name = "txbCorEditar";
            this.txbCorEditar.Size = new System.Drawing.Size(184, 22);
            this.txbCorEditar.TabIndex = 9;
            // 
            // lblCorEditar
            // 
            this.lblCorEditar.AutoSize = true;
            this.lblCorEditar.BackColor = System.Drawing.Color.Transparent;
            this.lblCorEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorEditar.Location = new System.Drawing.Point(7, 130);
            this.lblCorEditar.Name = "lblCorEditar";
            this.lblCorEditar.Size = new System.Drawing.Size(37, 18);
            this.lblCorEditar.TabIndex = 8;
            this.lblCorEditar.Text = "Cor:";
            // 
            // txbAnoEditar
            // 
            this.txbAnoEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAnoEditar.Location = new System.Drawing.Point(60, 104);
            this.txbAnoEditar.Name = "txbAnoEditar";
            this.txbAnoEditar.Size = new System.Drawing.Size(184, 22);
            this.txbAnoEditar.TabIndex = 7;
            // 
            // lblAnoEditar
            // 
            this.lblAnoEditar.AutoSize = true;
            this.lblAnoEditar.BackColor = System.Drawing.Color.Transparent;
            this.lblAnoEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnoEditar.Location = new System.Drawing.Point(6, 104);
            this.lblAnoEditar.Name = "lblAnoEditar";
            this.lblAnoEditar.Size = new System.Drawing.Size(38, 18);
            this.lblAnoEditar.TabIndex = 6;
            this.lblAnoEditar.Text = "Ano:";
            // 
            // txbMarcaEditar
            // 
            this.txbMarcaEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMarcaEditar.Location = new System.Drawing.Point(60, 78);
            this.txbMarcaEditar.Name = "txbMarcaEditar";
            this.txbMarcaEditar.Size = new System.Drawing.Size(184, 22);
            this.txbMarcaEditar.TabIndex = 5;
            // 
            // lblMarcaEditar
            // 
            this.lblMarcaEditar.AutoSize = true;
            this.lblMarcaEditar.BackColor = System.Drawing.Color.Transparent;
            this.lblMarcaEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaEditar.Location = new System.Drawing.Point(2, 78);
            this.lblMarcaEditar.Name = "lblMarcaEditar";
            this.lblMarcaEditar.Size = new System.Drawing.Size(54, 18);
            this.lblMarcaEditar.TabIndex = 4;
            this.lblMarcaEditar.Text = "Marca:";
            // 
            // txbModeloEditar
            // 
            this.txbModeloEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbModeloEditar.Location = new System.Drawing.Point(60, 52);
            this.txbModeloEditar.Name = "txbModeloEditar";
            this.txbModeloEditar.Size = new System.Drawing.Size(184, 22);
            this.txbModeloEditar.TabIndex = 3;
            // 
            // lblModeloEditar
            // 
            this.lblModeloEditar.AutoSize = true;
            this.lblModeloEditar.BackColor = System.Drawing.Color.Transparent;
            this.lblModeloEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModeloEditar.Location = new System.Drawing.Point(0, 51);
            this.lblModeloEditar.Name = "lblModeloEditar";
            this.lblModeloEditar.Size = new System.Drawing.Size(62, 18);
            this.lblModeloEditar.TabIndex = 2;
            this.lblModeloEditar.Text = "Modelo:";
            // 
            // txbPlacaEditar
            // 
            this.txbPlacaEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPlacaEditar.Location = new System.Drawing.Point(61, 26);
            this.txbPlacaEditar.Name = "txbPlacaEditar";
            this.txbPlacaEditar.Size = new System.Drawing.Size(184, 22);
            this.txbPlacaEditar.TabIndex = 1;
            // 
            // lblPlacaEditar
            // 
            this.lblPlacaEditar.AutoSize = true;
            this.lblPlacaEditar.BackColor = System.Drawing.Color.Transparent;
            this.lblPlacaEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacaEditar.Location = new System.Drawing.Point(2, 27);
            this.lblPlacaEditar.Name = "lblPlacaEditar";
            this.lblPlacaEditar.Size = new System.Drawing.Size(49, 18);
            this.lblPlacaEditar.TabIndex = 0;
            this.lblPlacaEditar.Text = "Placa:";
            // 
            // grbApagar
            // 
            this.grbApagar.Controls.Add(this.btnApagar);
            this.grbApagar.Controls.Add(this.lblSelecioneApagar);
            this.grbApagar.Location = new System.Drawing.Point(535, 413);
            this.grbApagar.Name = "grbApagar";
            this.grbApagar.Size = new System.Drawing.Size(253, 210);
            this.grbApagar.TabIndex = 12;
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
            this.btnApagar.Location = new System.Drawing.Point(55, 130);
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
            // FormVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(193)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(800, 627);
            this.Controls.Add(this.grbApagar);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.lblVeiculos);
            this.Controls.Add(this.grbCadastrar);
            this.Controls.Add(this.dgvVeiculos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veículos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculos)).EndInit();
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

        private System.Windows.Forms.DataGridView dgvVeiculos;
        private System.Windows.Forms.GroupBox grbCadastrar;
        private System.Windows.Forms.Label lblPlacaCadastrar;
        private System.Windows.Forms.Label lblVeiculos;
        private System.Windows.Forms.TextBox txbPlacaCadastrar;
        private System.Windows.Forms.Label lblAnoCadastrar;
        private System.Windows.Forms.TextBox txbMarcaCadastrar;
        private System.Windows.Forms.Label lblMarcaCadastrar;
        private System.Windows.Forms.TextBox txbModeloCadastrar;
        private System.Windows.Forms.Label lblModeloCadastrar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txbCorCadastrar;
        private System.Windows.Forms.Label lblCorCadastrar;
        private System.Windows.Forms.TextBox txbAnoCadastrar;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txbCorEditar;
        private System.Windows.Forms.Label lblCorEditar;
        private System.Windows.Forms.TextBox txbAnoEditar;
        private System.Windows.Forms.Label lblAnoEditar;
        private System.Windows.Forms.TextBox txbMarcaEditar;
        private System.Windows.Forms.Label lblMarcaEditar;
        private System.Windows.Forms.TextBox txbModeloEditar;
        private System.Windows.Forms.Label lblModeloEditar;
        private System.Windows.Forms.TextBox txbPlacaEditar;
        private System.Windows.Forms.Label lblPlacaEditar;
        private System.Windows.Forms.GroupBox grbApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblSelecioneApagar;
    }
}