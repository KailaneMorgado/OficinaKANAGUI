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
    public partial class FormCaixa : Form
    {
        Model.Usuario usuario;
        int idusuario = 0;
        public FormCaixa(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            //Verificar se o campo está vazio
            if (txbOrdemServico.Text.Length == 0)
            {
                MessageBox.Show("Informe o e-mail do usuário!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                Model.OrdemServico ordemServico = new Model.OrdemServico();

                ordemServico.Email = txbOrdemServico.Text;

                //Tabela para receber o resultado da consulta SELECT
                DataTable resultado = ordemServico.BuscarPorFicha();

                //Verificar se existem linhas em "resultado":
                if (resultado.Rows.Count > 0)
                {
                    //Mostrar o dgv:
                    dgvCaixa.DataSource = resultado;

                    //Calcular o total e mostrar no lblTotal:
                    lblTotal.Text = "R$" + resultado.Compute("Sum(Total)", "True").ToString();
                    idusuario = (int)dgvCaixa.Rows[0].Cells["ID Usuario"].Value;
                }
                else
                {
                    //Limpar o dgv:
                    dgvCaixa.DataSource = null;

                    //Mostrar mensagem de erro:
                    MessageBox.Show("Não existem lançamentos neste e-mail!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void chbPagamento_CheckedChanged(object sender, EventArgs e)
        {
            btnEncerrar.Enabled = chbPagamento.Checked;
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja encerrar essa ordem de serviço?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                //Encerrar a comanda:
                Model.OrdemServico ordemServico = new Model.OrdemServico();
                ordemServico.IdUsuario = idusuario;

                //Executar o update para encerrar a comanda:
                if (ordemServico.EncerrarComanda())
                {
                    MessageBox.Show("Ordem de Serviço encerrada!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Resetar os campos:
                    txbOrdemServico.Clear();
                    dgvCaixa.DataSource = null;
                    chbPagamento.Checked = false;
                    btnEncerrar.Enabled = false;
                    lblTotal.Text = "R$  -";
                }
                else
                {
                    MessageBox.Show("Falha ao encerrar a Ordem de Serviço!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
