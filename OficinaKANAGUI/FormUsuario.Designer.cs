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
            this.lblNomeCadastrar = new System.Windows.Forms.Label();
            this.lblEmailCadastrar = new System.Windows.Forms.Label();
            this.lblSenhaCadastrar = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txbNomeCadastrar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.grbCadastrar.SuspendLayout();
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
            // 
            // grbCadastrar
            // 
            this.grbCadastrar.Controls.Add(this.txbNomeCadastrar);
            this.grbCadastrar.Controls.Add(this.btnCadastrar);
            this.grbCadastrar.Controls.Add(this.lblSenhaCadastrar);
            this.grbCadastrar.Controls.Add(this.lblEmailCadastrar);
            this.grbCadastrar.Controls.Add(this.lblNomeCadastrar);
            this.grbCadastrar.Location = new System.Drawing.Point(12, 338);
            this.grbCadastrar.Name = "grbCadastrar";
            this.grbCadastrar.Size = new System.Drawing.Size(223, 163);
            this.grbCadastrar.TabIndex = 2;
            this.grbCadastrar.TabStop = false;
            this.grbCadastrar.Text = "Cadastrar";
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
            // lblEmailCadastrar
            // 
            this.lblEmailCadastrar.AutoSize = true;
            this.lblEmailCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailCadastrar.Location = new System.Drawing.Point(10, 51);
            this.lblEmailCadastrar.Name = "lblEmailCadastrar";
            this.lblEmailCadastrar.Size = new System.Drawing.Size(44, 16);
            this.lblEmailCadastrar.TabIndex = 1;
            this.lblEmailCadastrar.Text = "Email:";
            // 
            // lblSenhaCadastrar
            // 
            this.lblSenhaCadastrar.AutoSize = true;
            this.lblSenhaCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaCadastrar.Location = new System.Drawing.Point(10, 80);
            this.lblSenhaCadastrar.Name = "lblSenhaCadastrar";
            this.lblSenhaCadastrar.Size = new System.Drawing.Size(49, 16);
            this.lblSenhaCadastrar.TabIndex = 2;
            this.lblSenhaCadastrar.Text = "Senha:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(70, 127);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(85, 30);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // txbNomeCadastrar
            // 
            this.txbNomeCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomeCadastrar.Location = new System.Drawing.Point(60, 20);
            this.txbNomeCadastrar.Name = "txbNomeCadastrar";
            this.txbNomeCadastrar.Size = new System.Drawing.Size(157, 22);
            this.txbNomeCadastrar.TabIndex = 4;
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(193)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.grbCadastrar);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.lblGerenciamentoUsuario);
            this.Name = "FormUsuario";
            this.Text = "FormUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.grbCadastrar.ResumeLayout(false);
            this.grbCadastrar.PerformLayout();
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
    }
}