using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Boleto
    {
        public int Id { get; set; }
        public double Valor { get; set; }
        public string BarCode { get; set; }
        public DateTime Vencimento { get; set; }
        public Boleto() { }

        public int DiasDeAtraso()
        {
            //return (int)Vencimento.Subtract(DateTime.Today).TotalDays * -1;
            return (int)DateTime.Today.Subtract(Vencimento).TotalDays;
        }
    }
} 