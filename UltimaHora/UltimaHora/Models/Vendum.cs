using System;
using System.Collections.Generic;

namespace UltimaHora.Models
{
    public partial class Vendum
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public DateTime DataHora { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; } = null!;
    }
}
