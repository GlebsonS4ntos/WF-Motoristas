using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Repositorys;
using WinFormsApp1.Services;

namespace WinFormsApp1
{
    public partial class InformaçãoMotorista : Form
    {
        public InformaçãoMotorista()
        {
            InitializeComponent();
        }

        private void InformaçãoMotorista_Load(object sender, EventArgs e)
        {
            MotoristaRepository m = new();
            List<Motorista> list = MotoristaRepository.InicializarMotoristas();
            list.ForEach(m => comboBox1.Items.Add(m));


        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double valorTotal = 0;
            ViagemRepository v = new ViagemRepository();
            MotoristaRepository m = new MotoristaRepository();
            List<Viagem> list = v.RetornarLista();
            foreach(Viagem vi in list)
            {
                Motorista mo = m.BuscarCliente(comboBox1.SelectedIndex + 1);
                if (mo.IdMotorista == vi.Motorista.IdMotorista)
                {
                    valorTotal += vi.ValorViagem;
                }
            }
            lblValorTotal.Text = valorTotal.ToString();
        }
    }
}
