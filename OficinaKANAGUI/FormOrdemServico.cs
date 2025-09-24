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

        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegar a linha selecionada:
            int ls = dgvUsuarios.SelectedCells[0].RowIndex;

            //Colocar o ID do produto no campo de código:
          
            idUsuarioSelecionado = (int)dgvUsuarios.Rows[ls].Cells[0].Value;

            
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
                ordemServico.IdServico = idServicoSelecionado;
                ordemServico.Quantidade = int.Parse(txbQuantidade.Text);
                ordemServico.IdUsuario = idUsuarioSelecionado;
                ordemServico.IdVeiculo = idVeiculoSelecionado;
               

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
            txbQuantidade.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ResetarCampos();
        }

        private void dgvVeiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegar a linha selecionada:
            int ls = dgvVeiculos.SelectedCells[0].RowIndex;

            //Colocar o ID do produto no campo de código:

            idVeiculoSelecionado = (int)dgvVeiculos.Rows[ls].Cells[0].Value;
        }

        private void dgvServicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegar a linha selecionada:
            int ls = dgvServicos.SelectedCells[0].RowIndex;

            //Colocar o ID do produto no campo de código:

            idServicoSelecionado = (int)dgvServicos.Rows[ls].Cells[0].Value;
        }
    }
}
