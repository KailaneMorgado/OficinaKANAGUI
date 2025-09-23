using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaKANAGUI.Model
{
    internal class OrdemServico
    {
        public int Id { get; set; }
        public int IdVeiculo { get; set; }
        public int IdUsuario { get; set; }
        public int IdServico { get; set; }
        public DateTime DataEntrada { get; set; }
        public bool Situacao { get; set; }
    }
}
