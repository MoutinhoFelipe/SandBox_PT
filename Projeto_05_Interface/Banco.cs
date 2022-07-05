using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_05_Interface
{
    public class Banco
    {
        public Banco()
        {
            TabelaTimes = new TabelaTimes();
        }

        public TabelaTimes TabelaTimes { get; set; }
    }
}
