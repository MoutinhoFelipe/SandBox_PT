using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_04_POO
{
    class Homem : Pessoa
    {
        //Propriedades específicas da Classe
        private bool calvicie;

        //Método Construtor
        public Homem(string s, int n)
        {
            this.nome = s;
            this.idade = n;
        }

        //Métodos Específicos

        public string colocarImplante()
        {
            if (this.calvicie == true)
            {
                this.calvicie = false;
                return $"{this.nome} colocou implante e não é mais calvo! Belíssimo corte!";
            } else
            {
                return $"{this.nome} não apresenta calvície!";
            }
        }
        public string getCalvicie()
        {
            if (this.calvicie == true) {
                return $"{this.nome} é calvo! Precisa comprar uma peruquinha!";
            } else {
                return $"{this.nome} não é calvo! Bonito corte!";
            }
        }

        public string fazerBarba()
        {
            return $"{this.nome} fez a barba! Um belo disfarçado";
        }

        //Método Abstrato
        public override string aposentar()
        {
            if (this.idade >= 65)
            {
                this.aposentado = true;
                return $"{this.nome} foi aposentado com sucesso!";
            }
            else
            {
                return $"Erro! {this.nome} não pode se aposentar com {this.idade} anos!";
            }
        }
    }
}
