using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aulaTeste1
{
    public partial class frmGestaoNotas : Form
    {
        public frmGestaoNotas()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //resultado = (nota1+nota2+nota3+nota4)/4
            //se a nota do aluno for maior ou igual 7 (Aluno Aprovado), senão (Aluno Reprovado)

            int Np1;
            int Np2;
            int Np3;
            int Np4;
            int Resultado;

            Np1 = Convert.ToInt16(txtNP1.Text);
            Np2 = Convert.ToInt16(txtNP2.Text);
            Np3 = Convert.ToInt16(txtNP3.Text);
            Np4 = Convert.ToInt16(txtNP4.Text);

            Resultado = (Np1 + Np2 + Np3 + Np4) / 4;

            txtResultado.Text = Convert.ToString(Resultado);

            if (Resultado >= 7)
            {
                MessageBox.Show("Aluno Aprovado");
            }
            else
            {
                MessageBox.Show("Aluno Reprovado");
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNP1.Text = "";
            txtNP2.Text = "";
            txtNP3.Text = "";
            txtNP4.Text = "";
            txtResultado.Text = "";
        }
    }
}
