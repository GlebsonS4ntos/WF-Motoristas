using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Services
{
    public class Viagem
    {
        public Motorista Motorista { get; set; }
        public double ValorViagem {get; set; }

        public Viagem(Motorista motorista, double valorViagem)
        {
            Motorista = motorista;
            ValorViagem = valorViagem;
        }
    }
}
