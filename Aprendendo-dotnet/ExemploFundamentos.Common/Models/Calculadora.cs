using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y){
            Console.WriteLine($"{x} + {y} = {x + y}" );
        }
        public void Subtrair(int x, int y){
            Console.WriteLine($"{x} - {y} = {x - y}" );
        }
        public void Dividir(int x, int y){
            Console.WriteLine($"{x} / {y} = {x / y}" );
        }
        public void Multiplicar(int x, int y){
            Console.WriteLine($"{x} * {y} = {x * y}" );
        }

        public void Potencia(int x, int y){
            double resultado = Math.Pow(x, y);
            Console.WriteLine($"{x} ** {y} = {resultado}" );
        }

        public void RaizQuadrada(int x){
            double resultado = Math.Sqrt(x);
            Console.WriteLine($"Raiz quadrada de {x} = {Math.Round(resultado, 3)}");
        }
        public void Sen(double angulo){
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo} = {Math.Round(seno ,4)}");
        }
        public void Cos(double angulo){
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"Coseno de {angulo} = {Math.Round(coseno,4)}");
        }
        public void Tan(double angulo){
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo} = {Math.Round(tangente,4)}");
        }
    }
}