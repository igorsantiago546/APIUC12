using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Pagamento
    {
        // atributos (características)
        private int id;
        private DateTime data;
        private double valor;
        private double juro;
        private Boleto boleto;

        // construtores (método)

        public Pagamento() 
        { // Criando composição
           Boleto = new Boleto();
        }



        // proriedades (encapsulamento - método de acesso)
        public int Id { get => id; set => id = value; }
        public DateTime Data { get => data; set => data = value; }
        public double Valor { get => valor; set => valor = value; }
        public double Juro { get => juro; set => juro = value; }
        public Boleto Boleto { get => boleto; set => boleto = value; }

        // método da classe (ações)
        public bool Registrar(double valor) //E uma agregação 
        {
            bool resultado = false;
            if (valor >= boleto.Valor)
            {
                Valor = valor - boleto.Valor;
                resultado = true;
            }
            else
            {
               Valor = (valor - boleto.Valor) * -1;
            }
            return resultado;    
             
        }
        public double CalcularJuro()
        {
            int dias = boleto.DiasDeAtraso();
            return dias * 0.45;
        }

        public double CalcularParcela( double valor, double taxa, double periodo)
        {
            double montante = valor * Math.Pow(1 + (taxa/100),periodo);
            return montante/periodo;
        }
        public void Gravar()
        {

        }
    }
}
