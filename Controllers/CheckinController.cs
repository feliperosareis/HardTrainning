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
    public class CheckinController
    {
        ConnectorDAO dao;

        public bool AlocarAluno(int aulaId, int alunoId)
        {
            try
            {
                dao = new ConnectorDAO();
                dao.connect();

                string query1 = "SELECT * FROM checkin WHERE FK_AULA_ID = "+ aulaId + " AND FK_ALUNO_ID = "+ alunoId;
                DataTable dt = dao.result(query1);
                
                if (dt.Rows.Count == 0)
                {
                    string query2 = "INSERT INTO checkin (FK_AULA_ID, FK_ALUNO_ID) VALUES ('" + aulaId + "', '" + alunoId + "')";
                    dao.executeQuery(query2);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar alocar o aluno na aula:" + ex.Message);
            }
            finally
            {
                dao = null;
            }
        }


        public bool DesalocarAluno(int aulaId, int alunoId)
        {
            try
            {
                dao = new ConnectorDAO();
                dao.connect();

                string query = "DELETE FROM checkin WHERE FK_ALUNO_ID = " + alunoId + " AND FK_AULA_ID = " + aulaId;
                dao.executeQuery(query);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro e não foi possível desalocar o aluno:" + ex.Message);
            }
        }


        public DataTable getCheckins(int aulaId)
        {
            DataTable dt = new DataTable();

            try
            {
                dao = new ConnectorDAO();
                dao.connect();

                string sql =  "SELECT c.FK_ALUNO_ID AS ID, al.NOME FROM checkin c ";
                       sql += "JOIN aulas a ON a.ID = c.FK_AULA_ID ";
                       sql += "JOIN alunos al ON al.ID = c.FK_ALUNO_ID ";
                       sql += "WHERE c.FK_AULA_ID = " + aulaId;
                dt = dao.result(sql);

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro e não foi possível listar os check-ins:" + ex.Message);
            }
        }


        public DataTable getAlunosMatriculados(int aulaId)
        {
            DataTable dtCheckin = this.getCheckins(aulaId);

            string arr = "";
            int i = 0;

            while (i < dtCheckin.Rows.Count)
            {
                if (i == dtCheckin.Rows.Count - 1)
                {
                    arr += dtCheckin.Rows[i]["ID"];
                }
                else
                {
                    arr += dtCheckin.Rows[i]["ID"] + ",";
                }
                
                i++;
            }

            
            try
            {
                dao = new ConnectorDAO();
                dao.connect();

                string sql = "";
                if (arr.Length > 0)
                {
                    sql =  "SELECT ID, NOME FROM alunos ";
                    sql += "WHERE ID NOT IN (" + arr + ")";
                }
                else
                {
                    sql = "SELECT ID, NOME FROM alunos";
                }


                dtCheckin = dao.result(sql);

                return dtCheckin;

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro e não foi possível listar os alunos: " + ex.Message);
            }

        }
        
    }
}
