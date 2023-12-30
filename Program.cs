using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora {
    internal class Program {
        static void Main(string[] args) {

            // operadores matematicos
            // pedir para calcular entre 2 numeros int ou double
            // mostrar resultado 

            double n1, n2, result=0;
            string operaçao;
           
            Console.WriteLine("PROJETO CALCULADORA 2023");

            Console.WriteLine("Escolha um numero:");
            n1=double.Parse(Console.ReadLine());

            Console.WriteLine("digite a operaçao:");
            operaçao= Console.ReadLine();

            Console.WriteLine("digite o segundo numero");
            n2 = double.Parse(Console.ReadLine());

            switch (operaçao) {
                case "+":
                    result = n1+n2;
                    break;

                case "-":
                    result = n1-n2;
                    break;

                case "/":
                    result = n1 / n2;
                    break;

                case "*":
                    result = n1 * n2;
                    break;

                default:
                    Console.WriteLine("operação inválida!");
                    
                    break;

            }

            Console.WriteLine($"O resultado é igual a: {result} ");





        }
    }
}
