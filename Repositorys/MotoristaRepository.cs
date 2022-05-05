using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Services;

namespace WinFormsApp1.Repositorys
{
    public class MotoristaRepository
    {
        public static List<Motorista> InicializarMotoristas()
        {
            List<Motorista> motoristas = new List<Motorista>();
            motoristas.Add(new Motorista(1, "Glebson Santos"));
            motoristas.Add(new Motorista(2, "Maria Joaquina"));
            motoristas.Add(new Motorista(3, "João Silva"));
            motoristas.Add(new Motorista(4, "Alex Tavares"));
            motoristas.Add(new Motorista(5, "Guilherme Oliveira"));
            return motoristas;
        }

        public Motorista BuscarCliente(int id)
        {
            List<Motorista> motoristas = InicializarMotoristas();
            foreach (Motorista m in motoristas)
            {
                if (m.IdMotorista == id)
                {
                    return m;
                }
            }
            return null;
        }
    }
}
