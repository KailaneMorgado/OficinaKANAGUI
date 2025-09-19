using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OficinaKANAGUI
{
    public partial class MenuPrincipal : Form
    {
        //Variaveis globais:
        Model.Usuario usuario = new Model.Usuario(); 

        public MenuPrincipal(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            lblDescricao.Text = $"  Olá, {usuario.NomeCompleto}! \nEscolha uma das opções abaixo:";

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FormUsuario formUsuario = new FormUsuario(usuario);
            formUsuario.ShowDialog(); //Mostrar o form
        }

        private void btnVeiculo_Click(object sender, EventArgs e)
        {
            FormVeiculo formVeiculo = new FormVeiculo(usuario);
            formVeiculo.ShowDialog();
        }

        private void btnServico_Click(object sender, EventArgs e)
        {
            FormServico formServico = new FormServico(usuario);
            formServico.ShowDialog();
        }

        private void btnOrdemServico_Click(object sender, EventArgs e)
        {
            FormOrdemServico formOrdemServico = new FormOrdemServico(usuario);
            formOrdemServico.ShowDialog();
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            FormCaixa formCaixa = new FormCaixa(usuario);
            formCaixa.ShowDialog();
        }
    }
}
