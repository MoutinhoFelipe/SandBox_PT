using System;
using System.Collections.Generic;

namespace UltimaHora.Models
{
    public partial class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public double? Preco { get; set; }
    }
}
