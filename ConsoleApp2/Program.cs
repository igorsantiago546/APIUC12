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
            //int idade = 25;
            //double medida = 15.98;
            //sbyte x = 127;
            //byte y = 25;
            //short z = 6500;
            //uint i = 0;
            //ulong k = 0;


            //string nome = "Igor Santiago Macedo";
            //Console.WriteLine("Digite seu email");
            //var email = Console.ReadLine();
            //Console.WriteLine("O email do usuário " + nome + " é: " + email);
            //var numero = nome.Length;
            //Console.WriteLine("O nome do usuário possui " + numero + " letras.");

            //double nota1 = 7, nota2 = 8, nota3 = 4, nota4 = 7;
            //int mediai = Convert.ToInt32((nota1 + nota2 + nota3 + nota4) / 4);
            //Console.WriteLine("A média int é:" + mediai);
            //double mediad = (nota1 + nota2 + nota3 + nota4) / 4;
            //Console.WriteLine("A média int é:" + mediad);



            //double valor = 155.89;

            //string birds = "15";
            //valor = 124d;

            // conversão c#  Cast
            //float massa = (float)145m;
            //massa = (float)ObterValorD();

            // conversão c#  Parse
            //decimal fauna = decimal.Parse(birds);

            // conversão c# Class Convert
            //string zoo = fauna.ToString("R$ #.##");
            //zoo = Convert.ToString(fauna);


            //Pagamento pagamento = new Pagamento();
            //pagamento.Boleto.Vencimento = Convert.ToDateTime("2022-12-07");
            //pagamento.Boleto.Valor = 198.50;
            //pagamento.Valor = pagamento.Boleto.Valor; 
            //if (pagamento.Boleto.DiasDeAtraso() > 0)
            //{
            //    pagamento.Valor += pagamento.CalcularJuro();
            //}
            //if (pagamento.Registrar(200))
            //{
            //    Console.WriteLine("Pagamento Realizado!");
            //    Console.WriteLine("Troco R${0}", pagamento.Valor.ToString("#.00"));
            //}
            //else
            //{
            //    Console.WriteLine("Pagamento Incompleto!");
            //    Console.WriteLine("Resta a pagar R${0}", pagamento.Valor);
            //}
            //Console.WriteLine("Boleto pago com " + pagamento.Boleto.DiasDeAtraso() + " dias de atraso.");

            //Console.WriteLine("Digite o valor do Capital");
            //double capital = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a taxa de juro");
            //double taxa = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o número de parcelas");
            //int parcelas = int.Parse(Console.ReadLine());


            //var valorParcela = pagamento.CalcularParcela(capital, taxa, parcelas);
            //Console.WriteLine("{0} parcelas de R${1}",parcelas,valorParcela.ToString("#.00"));
            //Console.WriteLine("Com juro total de R${0} no financiamento", pagamento.Juro.ToString("#.00"));

            //for (int i = 0; i < parcelas; i++)
            //{
            //    Console.WriteLine("{0}ª -> {1} -> {2} ",i+1,valorParcela.ToString("#.00"),DateTime.Now.Date);
            //}

            //string nome = " Igor Santiago Macedo";
            //Console.WriteLine(nome);
            //var letras = nome.Contains("Santiago"); // retorna verdadeiro caso o texto exista na String
            //Console.WriteLine("O nome possue as letras 'Santiago' = " + letras);
            //var x = nome.EndsWith("edo");
            //Console.WriteLine("O nome termina com 'edo' = " + x);
            //x = nome.EndsWith("ago");
            //Console.WriteLine("O nome termina com 'ago' = " + x);
            //var conta = nome.Count();
            //Console.WriteLine("O texto possui " +conta+ " caracteres");
            //var teste = nome.Split(' ');
            //Console.WriteLine(teste[0]);
            //Console.WriteLine(teste[1]);
            //Console.WriteLine(teste[2]);
            //foreach (var item in teste)
            //{
            //    Console.WriteLine(item);
            //}
            //string dataTexto = "16/02/2003";
            //string[] dataExplode = dataTexto.Split('/');

            //DateTime vencimento = Convert.ToDateTime("18/01/1995 16:35:20");

            //DateTime data = new DateTime(int.Parse(dataExplode[2]), int.Parse(dataExplode[1]), int.Parse(dataExplode[0]));

            //int[,] valor = { { 1, 3 }, { 2, 9 } };
            //Console.Write(valor[0,0]+" ");
            //Console.WriteLine(valor[0,1]);
            //Console.Write(valor[1,0]+" ");
            //Console.WriteLine(valor[1,1]);

            //Array times = valor;
            //Console.WriteLine("A matriz possui {0} posições" ,times.Length);

            //int numero = nome.Length;
            //var sub = nome.PadLeft(50);
            //Console.WriteLine(sub);
            //sub = dataTexto.PadLeft(50);
            //Console.WriteLine(sub);

            //Console.WriteLine("REMOVE: " + nome.Remove(4,3));
            //Console.WriteLine("SUBSTITUIR: " + nome.Replace('a','U'));
            //Console.WriteLine("SUBSTRING: " + nome.Substring(4,6));
            //Console.WriteLine("TRIM: " + nome.Trim());
            //Console.WriteLine("MINÚSCULO: " + nome.ToLower());
            //Console.WriteLine("MAIÚSCULO: " + nome.ToUpper());

            //string frase = "Socorram me subi no onibus em marrocos";

            //Console.WriteLine("REVERSO: " + nome.Reverse());
            //Console.WriteLine(frase);
            //Console.WriteLine();
            //for (int i = nome.Length-1; i >= 0; i--)
            //{
            //    Console.Write(nome.Substring(i,1));
            //}
            //Console.WriteLine();
            //Console.WriteLine();

            // Atividade C# - Manipulação de String e matrizes
            // 1 - Crie uma variável com o nome completo do Senac
            // Serviço Nacional de Aprendizagem Comercial
            //string senac = "Serviço Nacional de Aprendizagem Comercial";

            //Console.WriteLine(" 1 = " + senac);
            //Console.WriteLine();
            //// a - Mostre todo o conteúdo em Maiúsculo
            //Console.WriteLine(" a = " + senac.ToUpper());
            //Console.WriteLine();
            //// b - Mostre todo o conteúdo em Minúsculo
            //Console.WriteLine(" b = " + senac.ToLower());
            //Console.WriteLine();
            //// c - Mostre todo o conteúdo invertido
            //for (int i = senac.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(senac.Substring(i, 1));
            //}
            //Console.WriteLine();
            //// d - Mostre apenas a palavra Aprendizagem 
            //Console.WriteLine(" d = " + senac.Substring(20,12));
            //Console.WriteLine();
            //// e - Exiba usando foreach as palavras que formam a frase em uma matriz
            //string[] home = senac.Split(' ');
            //foreach (var rep in home)
            //{
            //    Console.Write(rep + " ");
            //}
            //Console.WriteLine();
            //// f - Exiba a quantidade de caractere descontando os espaços
            //var cont = senac.Replace(" ","").Length; 
            //Console.WriteLine(" f = Possui " + cont );
            //Console.WriteLine();
            //// g - mostre apenas a palavra Senac Invertida
            //string itq = "Senac Itaquera";
            //string g = itq.Substring(0,5);
            //for (int i = g.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(g.Substring(i, 1));
            //}
            //Console.WriteLine();
            //Console.WriteLine();
            //// h - substitua as letra 'a' por 'O' e 'i' por 'E'
            //Console.WriteLine(" h = " + senac.Replace('a','O').Replace('i','E'));
            //Console.WriteLine();

            //// i - mostre a palavra Comercial em uma matriz
            //string[] senacEx = senac.Split(' ');
            //Console.WriteLine("i = " + senacEx[4]);
            //Console.WriteLine();
            //// j - mostre a frase completa sem os espaços
            //string[] Uni = senac.Split(' ');
            //foreach (var rep in Uni)
            //{
            //    Console.Write(rep);
            //}

            // estruturas de repetição
            Console.Write("Digite um número de 1 a 9: ");
            int numero = int.Parse(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{3}º. -> {0} x {1} = {2}", i+1, numero, (i+1)*numero, i+1);
            }
            Console.WriteLine();
            for (int i = 10; i > 0 ; i--)
            {
                Console.WriteLine("{3}º. -> {0} x {1} = {2}", i, numero, i * numero, i );
                Console.WriteLine("Deseja continuar? (s/n)");
                if (Console.ReadLine() == "n") i = 0; i = 10;
            }

            Object[] mtz = new Object[4];
            string carro = "Honda";
            mtz[0] = carro;
            DateTime data = DateTime.Now.Date;
            mtz[1] = data;
            Boleto boleto = new Boleto();
            boleto.Valor = 1259.69;
            mtz[2] = boleto.Valor;
            List<Pagamento> lista = new List<Pagamento>();
            mtz[3] = lista;
            foreach (var objeto in mtz)
            {
                Console.WriteLine(objeto);
            }
            int[] vetor = { 2, 6, 5, 8 };
            foreach (var item in vetor)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();

        }
      
    }
}




// Conversões C#
//3 tipos
//Cast
//Parse
//Class Convert