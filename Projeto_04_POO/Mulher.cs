using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_04_POO
{
    class Mulher : Pessoa
    {
        private bool gravida;

        //Método Construtor
        public Mulher(string s, int n)
        {
            this.nome = s;
            this.idade = n;
        }

        //Método Exclusivo
        public string engravidar()
        {
            this.gravida = true;
            return $"Parabéns mamãe! {this.nome} ficou grávida!";
        }

        public string getGravida()
        {
            if (this.gravida == true)
            {
                return $"{this.nome} está grávida atualmente!";
            } else
            {
                return $"{this.nome} não está grávida atualmente";
            }
        }

        //Método Abstrato
        public override string aposentar()
        {
            if (this.idade >= 60)
            {
                this.aposentado = true;
                return $"{this.nome} foi aposentada com sucesso!";
            }
            else
            {
                return $"Erro! {this.nome} não pode se aposentar com {this.idade} anos!";
            }
        }
    }

}
