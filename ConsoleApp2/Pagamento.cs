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

        // construtores (método)

        public Pagamento() { }

        public Pagamento(double _valor)
        {
            this.id = 0;
            valor = _valor;
        }

        // proriedades (encapsulamento - método de acesso)
        public int Id { get => id; set => id = value; }
        public DateTime Data { get => data; set => data = value; }
        public double ValorTroco { get => valor; set => valor = value; }
        public double Juro { get => juro; set => juro = value; }

        // método da classe (ações)
        public bool Registrar(Boleto  boleto, double valor)
        {
            bool resultado = false;
            if (valor >= boleto.Valor)
            {
                ValorTroco = valor - boleto.Valor;
                resultado = true;
            }
            else
            {
               ValorTroco = (valor - boleto.Valor) * -1;
            }
            return resultado;    
             
        }
        private double CalcularJuro(double capital, double montante)
        {
            juro = montante - capital;
            return juro;
        }

        public double CalcularParcela( double valor, double taxa, double periodo)
        {
            double montante = valor * Math.Pow(1 + (taxa/100),periodo);
            CalcularJuro(valor, montante);
            return montante/periodo;
        }
        public void Gravar()
        {

        }
    }
}
