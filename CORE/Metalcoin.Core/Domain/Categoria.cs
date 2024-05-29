using Metalcoin.Core.Abstracts;
using System.Reflection.Metadata;

namespace Metalcoin.Core.Domain
{
    public class Categoria : Entidade
    {
        public string Nome { get; set; }
        public bool Status { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }

        public virtual Produto Produto { get; set; }
    }
}
