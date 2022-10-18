using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Login.Modelo;
using Login.Controle;

namespace Login.Interface
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            var _mdlLogin = new mdlLogin();
            _mdlLogin.usuario = txtUsuario.Text;
            _mdlLogin.senha = txtSenha.Text;

            if ((_mdlLogin.usuario != "") & (_mdlLogin.senha != null))
            {
                ctlLogin _ctlLogin = new ctlLogin();
                bool retorno = _ctlLogin.ValidaLoginSQL(_mdlLogin);

                if (retorno == true)
                {
                    txtUsuario.Enabled = false;
                    txtSenha.Enabled = false;
                    btnGravar.Enabled = false;
                    btnConsultarIdade.Enabled = true;
                    MessageBox.Show("Usuario cadastrado com sucesso");
                }
            }
            else
            {
                MessageBox.Show("Favor digitar usuário e senha!");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void btnConsultarIdade_Click(object sender, EventArgs e)
        {
            frmModuloInicial _frmModuloInicial = new frmModuloInicial();
            _frmModuloInicial.txtLogin.Text = txtUsuario.Text;
            _frmModuloInicial.Show();
        }

    }
}
