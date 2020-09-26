using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Models;
using Controllers;
using System.Data;
using Renci.SshNet.Messages;

namespace Controllers
{
    public class LoginController
    {
        ConnectorDAO dao;

        UsuariosController usuarioCtrl = new UsuariosController();
        UsuariosModel usuario = new UsuariosModel();

        public bool dologin(string user, string password)
        {
            try
            {
                DataTable dt = new DataTable();

                dao = new ConnectorDAO();
                dao.connect();
                string query = "SELECT NOME, PERMISSAO FROM usuarios WHERE EMAIL = '"+ user +"' AND SENHA = '" + password + "'";
                dt = dao.result(query);

                Console.WriteLine("user = "+user);
                Console.WriteLine("user = " + password);

                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                
                return false;
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
