using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using MySql.Data.MySqlClient;
using DAO;
using System.Data;
using MySqlX.XDevAPI.Common;

namespace Controllers
{
    public class AlunosController
    {
        ConnectorDAO dao;

        public void insertAluno(AlunosModel aluno)
        {
            try
            {
                dao = new ConnectorDAO();
                dao.connect();
                string query = "INSERT INTO alunos (NOME, EMAIL, CELULAR, DATA_NASCIMENTO, PLANO, STATUS) VALUES ('" + aluno.Nome + "', '" + aluno.Email + "', '" + aluno.Celular + "', '" + aluno.DataNascimento + "', '" + aluno.Plano + "', '" + aluno.Status + "')";
                dao.executeQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar cadastrar o aluno:" + ex.Message);
            }
            finally
            {
                dao = null;
            }
            
        }

        public DataTable getAlunos ()
        {
            DataTable dt = new DataTable();

            try
            {
                dao = new ConnectorDAO();
                dao.connect();

                dt = dao.result("SELECT NOME, EMAIL, CELULAR, DATA_NASCIMENTO, PLANO, STATUS FROM alunos");

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro e não possível listar os alunos:" + ex.Message);
            }

        }

        
    }
}
