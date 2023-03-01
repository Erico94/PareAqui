using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana03
{
    public class Ticket
    {
        public DateTime Entrada { get; set; }
        public DateTime Saida { get; set; }
        public bool Ativo { get; set; }
        public Ticket(DateTime entrada, DateTime saida, bool ativo)
        {
            Entrada = entrada;
            Saida = saida;
            Ativo = ativo;
        }
        public Ticket()
        {
            
        }


        public double CalcularTempo()
        {
            var tempo = Saida - Entrada;
            return tempo.TotalMinutes;
        }

        public double CalcularValor() { 
        double valorTotal = CalcularTempo() * 0.09;
            return  valorTotal;
        }

        
    }

   
}
