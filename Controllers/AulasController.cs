using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Models;
using System.Data;

namespace Controllers
{
    public class AulasController
    {
        ConnectorDAO dao;

        public bool insertAula(AulasModel aula)
        {
            try
            {
                dao = new ConnectorDAO();
                dao.connect();
                string query = "INSERT INTO aulas (TITULO) VALUES ('" + aula.Titulo + "')";
                dao.executeQuery(query);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar inserir a aula:" + ex.Message);
            }
            finally
            {
                dao = null;
            }
        }

        public DataTable getAulas()
        {
            DataTable dt = new DataTable();

            try
            {
                dao = new ConnectorDAO();
                dao.connect();

                dt = dao.result("SELECT ID, TITULO FROM aulas ORDER BY TITULO");

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro e não foi possível listar as aulas:" + ex.Message);
            }
        }

        public void deleteAula(int aulaId)
        {
            try
            {
                dao = new ConnectorDAO();
                dao.connect();
                string query = "DELETE FROM aulas WHERE ID = " + aulaId;
                dao.executeQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar excluir a aula:" + ex.Message);
            }
            finally
            {
                dao = null;
            }
        }

        public void updateAula(AulasModel aula)
        {
            try
            {
                dao = new ConnectorDAO();
                dao.connect();
                string query = "UPDATE aulas SET TITULO = '" + aula.Titulo + "' WHERE ID = '" + aula.Id + "'";
                dao.executeQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar atualizar a aula:" + ex.Message);
            }
            finally
            {
                dao = null;
            }
        }
    }
}
