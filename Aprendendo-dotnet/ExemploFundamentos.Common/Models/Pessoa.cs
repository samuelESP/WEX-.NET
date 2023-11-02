using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{
    public class Pessoa
    {
        //string pois meu nome vai ser uma string
        public string? Nome { get; set; }
        //int pois minha Idade vai ser um numero inteiro
        public int Idade { get; set; }
        //void pois não vai devolver nenhum valor;
        //Usa $"", pois som assim ele vai entender que vai receber valores dinâmicos
        public void Apresentar()
        {
            Console.WriteLine($"Ola meu nome é {Nome}, e tenho {Idade} anos!");
        }
    }
}