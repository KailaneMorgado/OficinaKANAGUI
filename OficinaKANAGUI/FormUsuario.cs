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
    public partial class FormUsuario : Form
    {
        //Objetos globais
        Model.Usuario usuario;

        int idSelecionado = 0; //armazenar o id do usuário selecionado p/ apagar ou editar

        public FormUsuario()
        {
            InitializeComponent();
            this.usuario = usuario;
        }
        public void AtualizarDgv()
        {
            //Mostrar as informações do bd no datagridview:
            dgv.DataSource = usuario.Listar();
        }
    }
}
