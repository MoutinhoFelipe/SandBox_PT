using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_05_Interface
{
    public class TabelaTimes
    {

        private List<Time> listaTimes;

        //Método Construtor
        public TabelaTimes()
        {
            this.listaTimes = new List<Time>();
        }

        public List<Time> ConsultarTimes()
        {
            return listaTimes;
        }

        public void inserirTime(Time t)
        {
            
            listaTimes.Add(t);
        }
    }
        //public string excluirTime(Time t)
        //{
        //    int i = 0;
        //    bool ocorrenciaExclusao = false;

        //    foreach (var time in listaTimes())
        //    {
        //        if (listaTimes[i].nome == s)
        //        {
        //            listaTimes.RemoveAt(i);
        //            break;
        //            ocorrenciaExclusao = true;
        //        }
        //    }

        //    if (ocorrenciaExclusao == true) {
        //        return $"Time {s} excluído com sucesso!";
        //    } else
        //    {
        //        return $"Time {s} não encontrado na Lista!";
        //    }
        //}
}
