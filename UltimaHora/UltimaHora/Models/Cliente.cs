using System;
using System.Collections.Generic;

namespace UltimaHora.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Venda = new HashSet<Vendum>();
        }

        public string Nome { get; set; } = null!;
        public int Id { get; set; }

        public virtual ICollection<Vendum> Venda { get; set; }
    }
}
