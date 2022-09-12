using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class TabelaCalculos
    {
        public List<Calculo> _listaCalculos = new List<Calculo>();

        public List<Calculo> GetCalculos()
        {
            return _listaCalculos;
        }

        public void InsertCalculo(Calculo calculo)
        {
            _listaCalculos.Add(calculo);
        }

        public void DeleteCalculoById(int id)
        {

        }
    }
}
