using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Services
{
    public class Motorista
    {
        public int IdMotorista { get; set; }
        public string Nome { get; set; }

        public Motorista(int idMotorista, string nome)
        {
            IdMotorista = idMotorista;
            Nome = nome;
        }
        public override string ToString()
        {
            return Nome;
        }
    }
}
