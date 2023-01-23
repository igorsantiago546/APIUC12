using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("TI92, Começou agora!!!!");
            int idade = 25;
            double medida = 15.98;
            sbyte x = 127;
            byte y = 25;
            short z = 6500;
            uint i = 0;
            ulong k = 0;


            string nome = "Igor Santiago Macedo";
            Console.WriteLine("Digite seu email");
            var email = Console.ReadLine();
            Console.WriteLine("O email do usuário " + nome + " é: " + email);
            var numero = nome.Length;
            Console.WriteLine("O nome do usuário possui " + numero + " letras.");

            double nota1 = 7, nota2 = 8, nota3 = 4, nota4 = 7;
            int mediai = Convert.ToInt32((nota1 + nota2 + nota3 + nota4) / 4);
            Console.WriteLine("A média int é:" + mediai);
            double mediad = (nota1 + nota2 + nota3 + nota4) / 4;
            Console.WriteLine("A média int é:" + mediad);



            double valor = 155.89;

            string birds = "15";
            valor = 124d;

            // conversão c#  Cast
            float massa = (float)145m;
            massa = (float)ObterValorD();

            // conversão c#  Parse
            decimal fauna = decimal.Parse(birds);

            // conversão c# Class Convert
            string zoo = fauna.ToString("R$ #.##");
            zoo = Convert.ToString(fauna);

            Console.WriteLine(fauna);

            Console.ReadKey();
        }
        public static decimal ObterValorD() { return 125m; }
    }
}




// Conversões C#
//3 tipos
//Cast
//Parse
//Class Convert