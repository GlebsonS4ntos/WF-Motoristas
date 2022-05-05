using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Services;

namespace WinFormsApp1.Repositorys
{
    public class ViagemRepository
    {
        public static List<Viagem> todasViagens = new List<Viagem>();

        public void AddViagem(Viagem viagem)
        {
            todasViagens.Add(viagem);
        }

        public List<Viagem> RetornarLista()
        {
            return todasViagens;
        }
    }
}
