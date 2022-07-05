using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_04_POO
{
    abstract class Pessoa
    {
        //Propriedades da Classe
        public string nome;
        public int idade;
        public bool aposentado;

        //Métodos Abstracts
        public abstract string aposentar();

        public string apresentar()
        {
            return $"Nome: {getNome()} | Idade: {getIdade()}";
        }

        //Métodos Gerais
        public string fazerAniversario()
        {
            this.idade++;
            return $"{this.nome} está fazendo {this.idade} anos!";
        }

        //Métodos Getters e Setters
        public string getNome()
        {
            return this.nome;
        }

        private void setNome(string s)
        {
            this.nome = s;
        }

        public int getIdade()
        {
            return this.idade;
        }

        private void setIdade(int n)
        {
            this.idade = n;
        }
    }

}
