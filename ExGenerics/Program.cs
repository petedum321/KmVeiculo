using System;
using System.Collections.Generic;

namespace ExGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos veículos serão analizados: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            List<Veiculo> list = new List<Veiculo>();
            List<decimal> kmRodados = new List<decimal>();

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Digite a placa do veículo {i}: ");
                string placa = Console.ReadLine();

                Console.Write($"Digite a Km Inicial do veículo: ");
                decimal kmInicial = decimal.Parse(Console.ReadLine());

                Console.Write($"Digite a Km Final do veículo: ");
                decimal kmFinal = decimal.Parse(Console.ReadLine());

                list.Add(new Veiculo(placa, kmInicial, kmFinal));

                kmRodados.Add(kmFinal - kmInicial);
                Console.WriteLine();
            }

            CalculationService calculationService = new CalculationService();

            var result = calculationService.Max(kmRodados);

            int posicao = kmRodados.IndexOf(result);

            Console.WriteLine($"O veículo que andou mais foi o veículo de Placa: {list[posicao].Placa}");

            
        }
    }
}
