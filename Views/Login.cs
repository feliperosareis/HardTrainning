using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using Controllers;
using System.Security.Cryptography;

namespace HardTrainning
{
    /*
    +--------------------------------------------------------+
    |                 <<< PROFESSOR ALEX >>>                 |
    |                                                        |
    |   Utilizar os dados abaixo para logar no sistema:      |
    |                                                        |
    |       usuário: admin@admin.com                         |
    |       senha: 123                                       |
    +--------------------------------------------------------+
    */

    public partial class frmLogin : Form
    {
        UsuariosModel aluno = new UsuariosModel();
        UsuariosController alunoCtrl = new UsuariosController();

        LoginController login = new LoginController();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtUsuario.Text;
                string senha = MD5Hash(txtSenha.Text);
                if ( login.dologin(usuario, senha) )
                {
                    frmDashboard dash = new frmDashboard();
                    this.Hide();
                    dash.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("Usuário ou senha não conferem. \nTente novamente!");
                    txtSenha.Clear();
                    txtSenha.Focus();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
    }
}
