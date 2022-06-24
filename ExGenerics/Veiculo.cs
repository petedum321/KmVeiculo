using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExGenerics
{
    class Veiculo : IComparable
    {
        public string Placa { get; set; }

        public decimal KmInicial { get; set; }

        public decimal KmFinal { get; set; }
        public decimal KmRodados { get; private set; }

        public Veiculo()
        {
        }

        public Veiculo(string placa, decimal kmInicial, decimal kmFinal)
        {
            Placa = placa;
            KmInicial = kmInicial;
            KmFinal = kmFinal;
        }
     

        public int CompareTo(object obj)
        {
            if (!(obj is Veiculo))
            {
                throw new ArgumentException("Comparing Error: argument is not a Veiculo");
            }

            KmRodados = KmFinal - KmInicial;

            Veiculo other = obj as Veiculo;
            return KmRodados.CompareTo(other.KmRodados);
        }

        public override string ToString()
        {
            return $"{Placa}"; 
        }
    }
}
