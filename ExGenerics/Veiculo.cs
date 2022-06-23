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
            throw new NotImplementedException();
        }
    }
}
