using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operadora {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double total, excedente, minutos, subTotal, franquia;

            Console.Write("Digite a quantidade de minutos: ");
            minutos = double.Parse(Console.ReadLine());

            franquia = 100;
            if (minutos < franquia) {
                Console.WriteLine("Valor a pagar: R$50.00");
            }
            else {
                excedente = minutos - franquia;
                subTotal = excedente * 2;
                total = subTotal + 50.00;
                Console.WriteLine("Valor a pagar: " + total.ToString("F2"));
            }

        }
    }
}
