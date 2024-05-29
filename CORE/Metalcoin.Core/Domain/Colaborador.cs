using Metalcoin.Core.Abstracts;

namespace Metalcoin.Core.Domain
{
    public class Colaborador : Entidade
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool Ativo { get; set; }
    }
}
