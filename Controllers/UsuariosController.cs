using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DAO;
using Models;
using System.Data;

namespace Controllers
{
    public class UsuariosController
    {
        ConnectorDAO dao;

        public bool insertUsuario(UsuariosModel usuario)
        {
            try
            {
                dao = new ConnectorDAO();
                dao.connect();
                string query = "INSERT INTO usuarios (NOME, EMAIL, SENHA, PERMISSAO) VALUES ('" + usuario.Nome + "', '"+ usuario.Email + "', '" + usuario.Senha + "', '" + usuario.Permissao + "')";
                dao.executeQuery(query);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar inserir o usuário:" + ex.Message);
            }
            finally
            {
                dao = null;
            }
        }


        public void updateUsuario(UsuariosModel usuario)
        {
            try
            {
                dao = new ConnectorDAO();
                dao.connect();
                string query = "UPDATE usuarios SET NOME = '" + usuario.Nome + "', EMAIL = '" + usuario.Email + "', SENHA = '" + usuario.Senha + "', PERMISSAO = '" + usuario.Permissao + "' WHERE ID = '" + usuario.Id + "'";
                dao.executeQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar atualizar o usuário:" + ex.Message);
            }
            finally
            {
                dao = null;
            }
        }

        public void deleteUsuario(int usuarioId)
        {
            try
            {
                dao = new ConnectorDAO();
                dao.connect();
                string query = "DELETE FROM usuarios WHERE ID = " + usuarioId;
                dao.executeQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar excluir o usuário:" + ex.Message);
            }
            finally
            {
                dao = null;
            }
        }


        public DataTable getUsuarios()
        {
            DataTable dt = new DataTable();

            try
            {
                dao = new ConnectorDAO();
                dao.connect();

                dt = dao.result("SELECT ID, NOME, EMAIL, PERMISSAO FROM usuarios");

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro e não foi possível listar os usuarios:" + ex.Message);
            }
        }

    }
}
