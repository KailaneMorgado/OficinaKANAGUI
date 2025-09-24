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
    public partial class FormVeiculo : Form
    {

        Model.Usuario usuario;

        int IdSelecionado = 0; //Armazenar o ID do produto selecionado para apagar

        public FormVeiculo(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            AtualizarDgv();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txbPlacaCadastrar.Text.Length != 7)
            {
                MessageBox.Show("A placa deve ter 7 caracteres!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbModeloCadastrar.Text == "")
            {
                MessageBox.Show("Inserir o Modelo do Veículo!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbMarcaCadastrar.Text == "")
            {
                MessageBox.Show("Inserir a Marca do Veículo!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbAnoCadastrar.Text == "")
            {
                MessageBox.Show("Inserir o Ano do Veículo!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbCorCadastrar.Text == "")
            {
                MessageBox.Show("Inserir a Cor do Veículo!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Fazer o cadastro...
                Model.Veiculo veiculoCadastro = new Model.Veiculo();

                //Salvar os valores dos campos nos atributos do obj:
                veiculoCadastro.Placa = txbPlacaCadastrar.Text;
                veiculoCadastro.Modelo = txbModeloCadastrar.Text;
                veiculoCadastro.Marca = txbMarcaCadastrar.Text;
                veiculoCadastro.Ano = int.Parse(txbAnoCadastrar.Text);
                veiculoCadastro.Cor = txbCorCadastrar.Text;

                //Executar o INSERT:
                if (veiculoCadastro.Cadastrar())
                {
                    MessageBox.Show("Veículo cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Atualizar o dgv:
                    AtualizarDgv();

                    ResetarCampos();
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar veículo!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void AtualizarDgv()
        {
            //Declarando a variavel pra atualizar o dgv
            Model.Veiculo veiculo = new Model.Veiculo();

            //Mostrar as informações do bd no datagridview:
            dgvVeiculos.DataSource = veiculo.Listar();
        }

        private void dgvVeiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegar a linha selecionada:
            int ls = dgvVeiculos.SelectedCells[0].RowIndex;

            //Colocar os valores das células nos txb's de edição:
            txbPlacaEditar.Text = dgvVeiculos.Rows[ls].Cells[1].Value.ToString();
            txbModeloEditar.Text = dgvVeiculos.Rows[ls].Cells[2].Value.ToString();
            txbMarcaEditar.Text = dgvVeiculos.Rows[ls].Cells[3].Value.ToString();
            txbAnoEditar.Text = dgvVeiculos.Rows[ls].Cells[4].Value.ToString();
            txbCorEditar.Text = dgvVeiculos.Rows[ls].Cells[5].Value.ToString();

            //Armazenar o ID de quem foi selecionado:
            IdSelecionado = (int)dgvVeiculos.Rows[ls].Cells[0].Value;

            //Ativar o grbEditar:
            grbEditar.Enabled = true;
            grbApagar.Enabled = true;

            //Ajustes no grbApagar:
            lblSelecioneApagar.Text = $"Apagar: {dgvVeiculos.Rows[ls].Cells[1].Value.ToString()}";

            //Ativar o grbApagar:
            grbApagar.Enabled = true;
        }
        public void ResetarCampos()
        {
            //Atualizar o dgv:
            AtualizarDgv();

            //Limpar campos de edição:
            //Apagar os campos de cadastro (após cadastrar):
            txbPlacaCadastrar.Clear();
            txbModeloCadastrar.Clear();
            txbMarcaCadastrar.Clear();
            txbAnoCadastrar.Clear();
            txbCorCadastrar.Clear();

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
            if (txbPlacaEditar.Text.Length != 7)
            {
                MessageBox.Show("A placa deve ter 7 caracteres!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbModeloEditar.Text == "")
            {
                MessageBox.Show("Inserir o Modelo do Veículo!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbMarcaEditar.Text == "")
            {
                MessageBox.Show("Inserir a Marca do Veículo!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbAnoEditar.Text == "")
            {
                MessageBox.Show("Inserir o Ano do Veículo!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbCorEditar.Text == "")
            {
                MessageBox.Show("Inserir a Cor do Veículo!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Prosseguir com a edição:
                Model.Veiculo veiculoEditar = new Model.Veiculo();
                veiculoEditar.Placa = txbPlacaCadastrar.Text;
                veiculoEditar.Modelo = txbModeloCadastrar.Text;
                veiculoEditar.Marca = txbMarcaCadastrar.Text;
                veiculoEditar.Ano = int.Parse(txbAnoCadastrar.Text);
                veiculoEditar.Cor = txbCorCadastrar.Text;


                if (veiculoEditar.Modificar())
                {
                    MessageBox.Show("Veículo modificado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarDgv();

                    //Limpar campos de edição:
                    //Apagar os campos de cadastro (após cadastrar):
                    txbPlacaEditar.Clear();
                    txbModeloEditar.Clear();
                    txbMarcaEditar.Clear();
                    txbAnoEditar.Clear();
                    txbCorEditar.Clear();

                    //Retornar o idSelecionado para 0
                    IdSelecionado = 0;
                }
                else
                {
                    MessageBox.Show("Falha ao modificar veículo!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            //Perguntar se realmente quer apagar:
            DialogResult r = MessageBox.Show("Tem certeza que deseja apagar este veículo?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                //Prosseguir com a exclusão
                Model.Veiculo veiculoApagar = new Model.Veiculo();
                veiculoApagar.Id = IdSelecionado;

                if (veiculoApagar.Apagar())
                {
                    MessageBox.Show("Veículo excluido com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetarCampos();
                }
                else
                {
                    MessageBox.Show("Falha ao excluir veículo", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txbPlacaCadastrar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txbModeloCadastrar.Focus();
                e.Handled = true; // Impede o som de "beep" do Enter
            }
        }

        private void txbModeloCadastrar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txbMarcaCadastrar.Focus();
                e.Handled = true; // Impede o som de "beep" do Enter
            }
        }

        private void txbMarcaCadastrar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txbAnoCadastrar.Focus();
                e.Handled = true; // Impede o som de "beep" do Enter
            }
        }

        private void txbAnoCadastrar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txbCorCadastrar.Focus();
                e.Handled = true; // Impede o som de "beep" do Enter
            }
        }

        private void txbCorCadastrar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCadastrar.PerformClick();
            }
        }
    }
}
