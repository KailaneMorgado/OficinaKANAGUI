namespace OficinaKANAGUI
{
    partial class FormUsuario
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
            this.lblGerenciamentoUsuario = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.grbCadastrar = new System.Windows.Forms.GroupBox();
            this.txbSenhaCadastrar = new System.Windows.Forms.TextBox();
            this.txbEmailCadastrar = new System.Windows.Forms.TextBox();
            this.txbNomeCadastrar = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblSenhaCadastrar = new System.Windows.Forms.Label();
            this.lblEmailCadastrar = new System.Windows.Forms.Label();
            this.lblNomeCadastrar = new System.Windows.Forms.Label();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.txbSenhaEditar = new System.Windows.Forms.TextBox();
            this.txbEmailEditar = new System.Windows.Forms.TextBox();
            this.txbNomeEditar = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblSenhaEditar = new System.Windows.Forms.Label();
            this.lblEmailEditar = new System.Windows.Forms.Label();
            this.lblNomeEditar = new System.Windows.Forms.Label();
            this.grbApagar = new System.Windows.Forms.GroupBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblSelecioneApagar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.grbCadastrar.SuspendLayout();
            this.grbEditar.SuspendLayout();
            this.grbApagar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGerenciamentoUsuario
            // 
            this.lblGerenciamentoUsuario.AutoSize = true;
            this.lblGerenciamentoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(193)))), ((int)(((byte)(213)))));
            this.lblGerenciamentoUsuario.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGerenciamentoUsuario.Location = new System.Drawing.Point(271, 23);
            this.lblGerenciamentoUsuario.Name = "lblGerenciamentoUsuario";
            this.lblGerenciamentoUsuario.Size = new System.Drawing.Size(277, 27);
            this.lblGerenciamentoUsuario.TabIndex = 0;
            this.lblGerenciamentoUsuario.Text = "Gerenciamento de Usuários";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(82, 76);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(639, 244);
            this.dgvUsuarios.TabIndex = 1;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            // 
            // grbCadastrar
            // 
            this.grbCadastrar.Controls.Add(this.txbSenhaCadastrar);
            this.grbCadastrar.Controls.Add(this.txbEmailCadastrar);
            this.grbCadastrar.Controls.Add(this.txbNomeCadastrar);
            this.grbCadastrar.Controls.Add(this.btnCadastrar);
            this.grbCadastrar.Controls.Add(this.lblSenhaCadastrar);
            this.grbCadastrar.Controls.Add(this.lblEmailCadastrar);
            this.grbCadastrar.Controls.Add(this.lblNomeCadastrar);
            this.grbCadastrar.Location = new System.Drawing.Point(25, 338);
            this.grbCadastrar.Name = "grbCadastrar";
            this.grbCadastrar.Size = new System.Drawing.Size(223, 163);
            this.grbCadastrar.TabIndex = 2;
            this.grbCadastrar.TabStop = false;
            this.grbCadastrar.Text = "Cadastrar";
            // 
            // txbSenhaCadastrar
            // 
            this.txbSenhaCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSenhaCadastrar.Location = new System.Drawing.Point(60, 83);
            this.txbSenhaCadastrar.Name = "txbSenhaCadastrar";
            this.txbSenhaCadastrar.Size = new System.Drawing.Size(157, 22);
            this.txbSenhaCadastrar.TabIndex = 6;
            this.txbSenhaCadastrar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbSenhaCadastrar_KeyDown);
            // 
            // txbEmailCadastrar
            // 
            this.txbEmailCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmailCadastrar.Location = new System.Drawing.Point(60, 52);
            this.txbEmailCadastrar.Name = "txbEmailCadastrar";
            this.txbEmailCadastrar.Size = new System.Drawing.Size(157, 22);
            this.txbEmailCadastrar.TabIndex = 5;
            this.txbEmailCadastrar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbEmailCadastrar_KeyDown);
            // 
            // txbNomeCadastrar
            // 
            this.txbNomeCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomeCadastrar.Location = new System.Drawing.Point(60, 20);
            this.txbNomeCadastrar.Name = "txbNomeCadastrar";
            this.txbNomeCadastrar.Size = new System.Drawing.Size(157, 22);
            this.txbNomeCadastrar.TabIndex = 4;
            this.txbNomeCadastrar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbNomeCadastrar_KeyDown);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(45, 121);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(139, 36);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblSenhaCadastrar
            // 
            this.lblSenhaCadastrar.AutoSize = true;
            this.lblSenhaCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaCadastrar.Location = new System.Drawing.Point(7, 86);
            this.lblSenhaCadastrar.Name = "lblSenhaCadastrar";
            this.lblSenhaCadastrar.Size = new System.Drawing.Size(49, 16);
            this.lblSenhaCadastrar.TabIndex = 2;
            this.lblSenhaCadastrar.Text = "Senha:";
            // 
            // lblEmailCadastrar
            // 
            this.lblEmailCadastrar.AutoSize = true;
            this.lblEmailCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailCadastrar.Location = new System.Drawing.Point(6, 54);
            this.lblEmailCadastrar.Name = "lblEmailCadastrar";
            this.lblEmailCadastrar.Size = new System.Drawing.Size(44, 16);
            this.lblEmailCadastrar.TabIndex = 1;
            this.lblEmailCadastrar.Text = "Email:";
            // 
            // lblNomeCadastrar
            // 
            this.lblNomeCadastrar.AutoSize = true;
            this.lblNomeCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCadastrar.Location = new System.Drawing.Point(7, 20);
            this.lblNomeCadastrar.Name = "lblNomeCadastrar";
            this.lblNomeCadastrar.Size = new System.Drawing.Size(47, 16);
            this.lblNomeCadastrar.TabIndex = 0;
            this.lblNomeCadastrar.Text = "Nome:";
            // 
            // grbEditar
            // 
            this.grbEditar.Controls.Add(this.txbSenhaEditar);
            this.grbEditar.Controls.Add(this.txbEmailEditar);
            this.grbEditar.Controls.Add(this.txbNomeEditar);
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Controls.Add(this.lblSenhaEditar);
            this.grbEditar.Controls.Add(this.lblEmailEditar);
            this.grbEditar.Controls.Add(this.lblNomeEditar);
            this.grbEditar.Location = new System.Drawing.Point(290, 338);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(223, 163);
            this.grbEditar.TabIndex = 7;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar";
            // 
            // txbSenhaEditar
            // 
            this.txbSenhaEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSenhaEditar.Location = new System.Drawing.Point(60, 83);
            this.txbSenhaEditar.Name = "txbSenhaEditar";
            this.txbSenhaEditar.Size = new System.Drawing.Size(157, 22);
            this.txbSenhaEditar.TabIndex = 6;
            this.txbSenhaEditar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbSenhaEditar_KeyDown);
            // 
            // txbEmailEditar
            // 
            this.txbEmailEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmailEditar.Location = new System.Drawing.Point(60, 52);
            this.txbEmailEditar.Name = "txbEmailEditar";
            this.txbEmailEditar.Size = new System.Drawing.Size(157, 22);
            this.txbEmailEditar.TabIndex = 5;
            this.txbEmailEditar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbEmailEditar_KeyDown);
            // 
            // txbNomeEditar
            // 
            this.txbNomeEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomeEditar.Location = new System.Drawing.Point(60, 20);
            this.txbNomeEditar.Name = "txbNomeEditar";
            this.txbNomeEditar.Size = new System.Drawing.Size(157, 22);
            this.txbNomeEditar.TabIndex = 4;
            this.txbNomeEditar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbNomeEditar_KeyDown);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(45, 121);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(139, 36);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblSenhaEditar
            // 
            this.lblSenhaEditar.AutoSize = true;
            this.lblSenhaEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaEditar.Location = new System.Drawing.Point(7, 86);
            this.lblSenhaEditar.Name = "lblSenhaEditar";
            this.lblSenhaEditar.Size = new System.Drawing.Size(49, 16);
            this.lblSenhaEditar.TabIndex = 2;
            this.lblSenhaEditar.Text = "Senha:";
            // 
            // lblEmailEditar
            // 
            this.lblEmailEditar.AutoSize = true;
            this.lblEmailEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailEditar.Location = new System.Drawing.Point(6, 54);
            this.lblEmailEditar.Name = "lblEmailEditar";
            this.lblEmailEditar.Size = new System.Drawing.Size(44, 16);
            this.lblEmailEditar.TabIndex = 1;
            this.lblEmailEditar.Text = "Email:";
            // 
            // lblNomeEditar
            // 
            this.lblNomeEditar.AutoSize = true;
            this.lblNomeEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEditar.Location = new System.Drawing.Point(7, 20);
            this.lblNomeEditar.Name = "lblNomeEditar";
            this.lblNomeEditar.Size = new System.Drawing.Size(47, 16);
            this.lblNomeEditar.TabIndex = 0;
            this.lblNomeEditar.Text = "Nome:";
            // 
            // grbApagar
            // 
            this.grbApagar.Controls.Add(this.btnApagar);
            this.grbApagar.Controls.Add(this.lblSelecioneApagar);
            this.grbApagar.Location = new System.Drawing.Point(551, 338);
            this.grbApagar.Name = "grbApagar";
            this.grbApagar.Size = new System.Drawing.Size(223, 163);
            this.grbApagar.TabIndex = 8;
            this.grbApagar.TabStop = false;
            this.grbApagar.Text = "Apagar";
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.Maroon;
            this.btnApagar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnApagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.ForeColor = System.Drawing.Color.White;
            this.btnApagar.Location = new System.Drawing.Point(45, 99);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(139, 36);
            this.btnApagar.TabIndex = 3;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // lblSelecioneApagar
            // 
            this.lblSelecioneApagar.AutoSize = true;
            this.lblSelecioneApagar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecioneApagar.Location = new System.Drawing.Point(6, 51);
            this.lblSelecioneApagar.Name = "lblSelecioneApagar";
            this.lblSelecioneApagar.Size = new System.Drawing.Size(215, 19);
            this.lblSelecioneApagar.TabIndex = 0;
            this.lblSelecioneApagar.Text = "Selecione um usuário para apagar:\r\n";
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(193)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.grbApagar);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbCadastrar);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.lblGerenciamentoUsuario);
            this.Name = "FormUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Usuários";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
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

        private System.Windows.Forms.Label lblGerenciamentoUsuario;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.GroupBox grbCadastrar;
        private System.Windows.Forms.TextBox txbNomeCadastrar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblSenhaCadastrar;
        private System.Windows.Forms.Label lblEmailCadastrar;
        private System.Windows.Forms.Label lblNomeCadastrar;
        private System.Windows.Forms.TextBox txbSenhaCadastrar;
        private System.Windows.Forms.TextBox txbEmailCadastrar;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.TextBox txbSenhaEditar;
        private System.Windows.Forms.TextBox txbEmailEditar;
        private System.Windows.Forms.TextBox txbNomeEditar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblSenhaEditar;
        private System.Windows.Forms.Label lblEmailEditar;
        private System.Windows.Forms.Label lblNomeEditar;
        private System.Windows.Forms.GroupBox grbApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblSelecioneApagar;
    }
}