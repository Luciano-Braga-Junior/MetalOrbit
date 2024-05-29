﻿using Metalcoin.Core.Abstracts;

namespace Metalcoin.Core.Domain
{
    public class Produto : Entidade
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        /* EF Relation */
        public Guid FornecedorId { get; set; }
        public Fornecedor Fornecedor { get; set; }
        
        /* EF Relation Um produto para uma categoria*/

        public Guid CategoriaId { get; set; }
        public Categoria Categoria { get; set;}

    }
}
