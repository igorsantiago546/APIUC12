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
        public double Valor { get => valor; set => valor = value; }

        // método da classe (ações)
        public bool Registrar(Boleto  boleto)
        {
            return true;        
        }
        public double CalcularJuro()
        {
            return 0.0;
        }
        public void Gravar()
        {

        }
    }
}
