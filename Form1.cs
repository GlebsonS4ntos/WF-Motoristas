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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                ckViagem1.Enabled = true;
            }
            else
            {
                ckViagem1.Enabled = false;
                ckViagem1.Checked = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                ckViagem2.Enabled = true;
            }
            else
            {
                ckViagem2.Enabled = false;
                ckViagem2.Checked = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                ckViagem3.Enabled = true;
            }
            else
            {
                ckViagem3.Enabled = false;
                ckViagem3.Checked = false;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                ckViagem4.Enabled = true;
            }
            else
            {
                ckViagem4.Enabled = false;
                ckViagem4.Checked = false;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                ckViagem5.Enabled = true;
            }
            else
            {
                ckViagem5.Enabled = false;
                ckViagem5.Checked = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ckViagem1.Enabled = false;
            ckViagem2.Enabled = false;
            ckViagem3.Enabled = false;
            ckViagem4.Enabled = false;
            ckViagem5.Enabled = false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(ckViagem1.Checked && txtValor1.Text != "")
            {
                MotoristaRepository mr = new();
                Motorista m = mr.BuscarCliente(1);
                ViagemRepository vr = new ViagemRepository();
                if(m != null)
                {
                    vr.AddViagem(new Viagem(m, double.Parse(txtValor1.Text)));
                    MessageBox.Show("Viagem Cadastrada !");
                }
            }
            else
            {
                MessageBox.Show("O usuario prescisa em viagem e o valor da mesma ser acrescentado");
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (ckViagem2.Checked && txtValor2.Text != "")
            {
                MotoristaRepository mr = new();
                Motorista m = mr.BuscarCliente(2);
                ViagemRepository vr = new ViagemRepository();
                if (m != null)
                {
                    vr.AddViagem(new Viagem(m, double.Parse(txtValor1.Text)));
                    MessageBox.Show("Viagem Cadastrada !");
                }
            }
            else
            {
                MessageBox.Show("O usuario prescisa em viagem e o valor da mesma ser acrescentado");
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (ckViagem3.Checked && txtValor3.Text != "")
            {
                MotoristaRepository mr = new();
                Motorista m = mr.BuscarCliente(3);
                ViagemRepository vr = new ViagemRepository();
                if (m != null)
                {
                    vr.AddViagem(new Viagem(m, double.Parse(txtValor1.Text)));
                    MessageBox.Show("Viagem Cadastrada !");
                }
            }
            else
            {
                MessageBox.Show("O usuario prescisa em viagem e o valor da mesma ser acrescentado");
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (ckViagem4.Checked && txtValor4.Text != "")
            {
                MotoristaRepository mr = new();
                Motorista m = mr.BuscarCliente(4);
                ViagemRepository vr = new ViagemRepository();
                if (m != null)
                {
                    vr.AddViagem(new Viagem(m, double.Parse(txtValor1.Text)));
                    MessageBox.Show("Viagem Cadastrada !");
                }
            }
            else
            {
                MessageBox.Show("O usuario prescisa em viagem e o valor da mesma ser acrescentado");
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (ckViagem5.Checked && txtValor5.Text != "")
            {
                MotoristaRepository mr = new();
                Motorista m = mr.BuscarCliente(5);
                ViagemRepository vr = new ViagemRepository();
                if (m != null)
                {
                    vr.AddViagem(new Viagem(m, double.Parse(txtValor1.Text)));
                    MessageBox.Show("Viagem Cadastrada !");
                }
            }
            else
            {
                MessageBox.Show("O usuario prescisa em viagem e o valor da mesma ser acrescentado");
            }
        }

        private void btnRelatorioPessoa_Click(object sender, EventArgs e)
        {
            InformaçãoMotorista inf = new();
            inf.Show();
        }
    }
}
