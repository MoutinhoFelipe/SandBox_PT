using System;
using System.Collections.Generic;

namespace Projeto_05_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //TabelaTimes b1 = new TabelaTimes();
            Time t1 = new Time("Botafogo");
            Time t2 = new Time("Vasco");

            //b1.inserirTime(t1);
            //b1.inserirTime(t2);
            //Console.ReadKey();

            //foreach (Time t in b1.ConsultarTimes())
            //{
            //    Console.WriteLine(t.nome);
            //}

            Banco db = new Banco();
            db.TabelaTimes.inserirTime(t1);
            db.TabelaTimes.inserirTime(t2);

            foreach (var time in db.TabelaTimes.ConsultarTimes())
            {
                Console.WriteLine(time.nome);
            }
        }
    }
}
