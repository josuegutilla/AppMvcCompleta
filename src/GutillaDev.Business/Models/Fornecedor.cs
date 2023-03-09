using GutillaDev.Business.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GutillaDev.Business.Models
{
    public class Fornecedor : Entity
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public TipoFornecedor TipoFornecedor { get; set; } //enumeração;
        public Endereco Endereco { get; set; } //composição tem 1;
        public bool Ativo { get; set; }
        public IEnumerable<Produto> Produtos { get; set; } //composição tem vários;
    }
}
