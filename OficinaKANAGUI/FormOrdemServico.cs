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
    public partial class FormOrdemServico : Form
    {
        int idUsuarioSelecionado = 0;
        int idVeiculoSelecionado = 0;
        int idServicoSelecionado = 0;

        Model.Usuario usuario;
        public FormOrdemServico(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            AtualizarDgv();
        }

        public void AtualizarDgv()
        {
            //Model.OrdemServico ordemServico = new Model.OrdemServico();
            //dgvUsuarios.DataSource = ordemServico.Listar();
            Model.Servico servico = new Model.Servico();
            Model.Usuario usuario = new Model.Usuario();
            Model.Veiculo veiculo = new Model.Veiculo();

            dgvServicos.DataSource = servico.Listar();
            dgvUsuarios.DataSource = usuario.Listar();
            dgvVeiculos.DataSource = veiculo.Listar();
        }

        private void dgvOrdemServico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegar a linha selecionada:
            int ls = dgvUsuarios.SelectedCells[0].RowIndex;

            //Colocar o ID do produto no campo de código:
            txbIdServico.Text = dgvUsuarios.Rows[ls].Cells[0].Value.ToString();

            //Colocar o nome do produto no campo informações:
            txbDescricaoServico.Text = dgvUsuarios.Rows[ls].Cells[1].Value.ToString();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            //Verificar se os campos estão vazios:
            if (txbOrdemServico.Text.Length == 0)
            {
                MessageBox.Show("Informe o número da ordem!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbIdServico.Text.Length == 0)
            {
                MessageBox.Show("Informe o ID do Serviço!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Desativar o grbInformacoes
                grbInformacoes.Enabled = false;

                //Ativar o grbLancamentos
                grbLancamento.Enabled = true;
            }
        }

        private void btnLancar_Click(object sender, EventArgs e)
        {
            //Verificar se a quantidade foi preenchida
            if (txbQuantidade.Text.Length == 0)
            {
                MessageBox.Show("Informe a quantidade!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Model.OrdemServico ordemServico = new Model.OrdemServico();
                ordemServico.IdServico = int.Parse(txbIdServico.Text);
                ordemServico.Quantidade = int.Parse(txbQuantidade.Text);
                ordemServico.NomeServico = txbDescricaoServico.Text;
                ordemServico.IdUsuario = usuario.Id;
                ordemServico.Email = txbOrdemServico.Text;

                if (ordemServico.Cadastrar())
                {
                    MessageBox.Show("Lançamento efetuado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetarCampos();
                }
                else
                {
                    MessageBox.Show("Falha ao efetuar lançamento!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void ResetarCampos()
        {
            //Limpar os txb's:
            txbDescricaoServico.Clear();
            txbIdServico.Clear();
            txbOrdemServico.Clear();
            txbQuantidade.Clear();

            //Resetar os grbs:
            grbLancamento.Enabled = false;
            grbInformacoes.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ResetarCampos();
        }
    }
}
