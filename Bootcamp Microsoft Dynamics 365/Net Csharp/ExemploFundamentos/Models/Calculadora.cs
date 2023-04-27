using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y){
            Console.WriteLine($"{x} + {y} = {x + y}");
            //$"{x} - estou pegando o valor da variável, nao estou somando ainda.
        }
        public void Subtrair(int x, int y){
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        public void Multiplicar(int x, int y){
            Console.WriteLine($"{x} * {y} = {x * y}");
        }
        public void Dividir(int x, int y){
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
        public void Potencia(int x, int y){
            double pot = Math.Pow(x,y);
      
            Console.WriteLine($"{x} ^ {y} = {pot}");
        }

        public void Seno(double angulo){

            double radiano = (angulo * Math.PI) / 180;

            double seno = Math.Sin(radiano);
      
            Console.WriteLine($"Seno de {angulo}º = {Math.Round(seno,4)}");
        }
        public void Tangente(double angulo){

            double radiano = angulo *( Math.PI / 180);

            double tange  = Math.Tan(radiano);
      
            Console.WriteLine($"Tangente de {angulo}º = {Math.Round(tange,4)}");
        }

        public void Cosseno(double angulo){
            // angulo medido em radianos, por isso precisamos realizar esta conversao

            double radiano = angulo * Math.PI / 180;

            double coseno = Math.Cos(radiano);
      
            Console.WriteLine($"Cosseno de {angulo}º = {Math.Round(coseno,4)}");
        }
        public void RaizQuadrada(double x){
             double raiz = Math.Sqrt(x);
      
            Console.WriteLine($"Raiz quadrada de {x} = {raiz}");
        }



    }
}