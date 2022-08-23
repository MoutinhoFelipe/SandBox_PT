using System;
using System.Collections.Generic;

namespace UltimaHora.Models
{
    public partial class VendaProduto
    {
        public int? IdVenda { get; set; }
        public int? IdProduto { get; set; }
        public int? QuantidadeProduto { get; set; }

        public virtual Produto? IdProdutoNavigation { get; set; }
        public virtual Vendum? IdVendaNavigation { get; set; }
    }
}
