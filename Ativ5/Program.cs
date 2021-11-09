using Ativ5.Models;
using System;
using System.Collections.Generic;

namespace Ativ5
{
    class Program
    {
        public static IEnumerable<object> ImcFinal { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo à calculadora de IMC");
            List<double> participantes = new List<double>();
            var count = 6;
            for (var i = 1; i < count; i++)
            {
                Console.WriteLine("Digita o nome, a idade, o peso(em kg) e a altura(em metros) da pessoa Nº" + i);
                string participante = Console.ReadLine();
                int idade = Int32.Parse(Console.ReadLine());
                double peso = double.Parse(Console.ReadLine());
                double altura = double.Parse(Console.ReadLine());
                var ImcFinal = CalculateImc(peso, altura, participantes);                               
                Console.WriteLine("O IMC do " + participante + " é " + ImcFinal.IMC);              
                double participanteIMC = ImcFinal.IMC;                
                participantes.Add(participanteIMC);
                var x = i + 1;
                
                if(x==6)
                {
                    Console.Clear();
                    Console.WriteLine("O menor imc é de "+ ImcFinal.ImcMenor);
                    Console.WriteLine("O maior imc é " + ImcFinal.ImcMaior);
                }
            }

        }

        public static Imc1 CalculateImc(double peso, double altura, List<double>participantes)
        {   
            
            var imcResult = new Imc1();
            imcResult.ImcMaior = 0;
            imcResult.ImcMenor = 0;
            imcResult.IMC = peso / Math.Pow(altura, 2);     
            
            foreach (double participanteIMC in participantes)
            {
                if (participanteIMC >= imcResult.ImcMaior)
                {
                    imcResult.ImcMaior = participanteIMC;

                }
                if (imcResult.ImcMenor == 0)
                {
                    imcResult.ImcMenor = participanteIMC;
                }
                if (participanteIMC <= imcResult.ImcMenor)
                {
                    imcResult.ImcMenor = participanteIMC;
                }        

            }

            return imcResult;
        }
    } 
}
