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
    public partial class FormServico : Form
    {

        Model.Usuario usuario;

        int IdSelecionado = 0; //Armazenar o ID do produto selecionado para apagar

        public FormServico(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            AtualizarDgv();
        }

        public void AtualizarDgv()
        {
            //Declarando a variavel pra atualizar o dgv
            Model.Servico servico = new Model.Servico();

            //Mostrar as informações do bd no datagridview:
            dgvServico.DataSource = servico.Listar();
        }

        private void dgvServico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegar a linha selecionada:
            int ls = dgvServico.SelectedCells[0].RowIndex;

            //Colocar os valores das células nos txb's de edição:
            txbNomeEditar.Text = dgvServico.Rows[ls].Cells[1].Value.ToString();
            txbPrecoEditar.Text = dgvServico.Rows[ls].Cells[2].Value.ToString();

            //Armazenar o ID de quem foi selecionado:
            IdSelecionado = (int)dgvServico.Rows[ls].Cells[0].Value;

            //Ativar o grbEditar:
            grbEditar.Enabled = true;
            grbApagar.Enabled = true;

            //Ajustes no grbApagar:
            lblSelecioneApagar.Text = $"Apagar: {dgvServico.Rows[ls].Cells[1].Value.ToString()}";

            //Ativar o grbApagar:
            grbApagar.Enabled = true;
        }

        public void ResetarCampos()
        {
            //Atualizar o dgv:
            AtualizarDgv();

            //Limpar campos de edição:
            //Apagar os campos de cadastro (após cadastrar):
            txbNomeCadastrar.Clear();
            txbPrecoCadastrar.Clear();


            //Retornar o idSelecionado para 0
            IdSelecionado = 0;

            //Retornar o texto padrão do "apagar":
            lblSelecioneApagar.Text = "Selecione o usuário que deseja apagar";

            //Desabilitar os grbs:
            grbApagar.Enabled = false;
            grbEditar.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txbNomeEditar.Text.Length < 5)
            {
                MessageBox.Show("O nome do serviço deve ter no mínimo 4 caracteres!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbPrecoEditar.Text == "")
            {
                MessageBox.Show("Inserir o preço do serviço!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Fazer o cadastro...
                Model.Servico servicoCadastro = new Model.Servico();

                //Salvar os valores dos campos nos atributos do obj:
                servicoCadastro.NomeServico = txbNomeEditar.Text;
                servicoCadastro.Preco = double.Parse(txbPrecoEditar.Text);
                servicoCadastro.Id = IdSelecionado;

                //Executar o INSERT:
                if (servicoCadastro.Modificar())
                {
                    MessageBox.Show("Serviço modificado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Atualizar o dgv:
                    AtualizarDgv();

                    ResetarCampos();
                }
                else
                {
                    MessageBox.Show("Falha ao modificar serviço!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            //Perguntar se realmente quer apagar:
            DialogResult r = MessageBox.Show("Tem certeza que deseja apagar este serviço?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                //Prosseguir com a exclusão
                Model.Servico servicoApagar = new Model.Servico();
                servicoApagar.Id = IdSelecionado;

                if (servicoApagar.Apagar())
                {
                    MessageBox.Show("Serviço excluido com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetarCampos();
                }
                else
                {
                    MessageBox.Show("Falha ao excluir serviço", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            if (txbNomeCadastrar.Text.Length < 5)
            {
                MessageBox.Show("O nome do serviço deve ter no mínimo 4 caracteres!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbPrecoCadastrar.Text == "")
            {
                MessageBox.Show("Inserir o preço do serviço!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Fazer o cadastro...
                Model.Servico servicoCadastro = new Model.Servico();

                //Salvar os valores dos campos nos atributos do obj:
                servicoCadastro.NomeServico = txbNomeCadastrar.Text;
                servicoCadastro.Preco = double.Parse(txbPrecoCadastrar.Text);

                //Executar o INSERT:
                if (servicoCadastro.Cadastrar())
                {
                    MessageBox.Show("Serviço cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Atualizar o dgv:
                    AtualizarDgv();

                    ResetarCampos();
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar serviço!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
