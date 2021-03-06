﻿using System;
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

        public void updateAluno(AlunosModel aluno)
        {
            try
            {
                dao = new ConnectorDAO();
                dao.connect();
                string query = "UPDATE alunos SET NOME = '" + aluno.Nome + "', EMAIL = '" + aluno.Email + "', CELULAR = '" + aluno.Celular + "', DATA_NASCIMENTO = '" + aluno.DataNascimento + "', PLANO = '" + aluno.Plano + "', STATUS = '" + aluno.Status + "' WHERE ID = '" + aluno.Id + "'";
                dao.executeQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar atualizar o aluno:" + ex.Message);
            }
            finally
            {
                dao = null;
            }


        }

        public void deleteAluno(int alunoId)
        {
            try
            {
                dao = new ConnectorDAO();
                dao.connect();
                string query = "DELETE FROM alunos WHERE ID = " + alunoId;
                dao.executeQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar excluir o aluno:" + ex.Message);
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

                dt = dao.result("SELECT ID, NOME, EMAIL, CELULAR, DATE_FORMAT(DATA_NASCIMENTO, '%d/%m/%Y') AS NASCIMENTO, PLANO, STATUS FROM alunos");

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro e não possível listar os alunos:" + ex.Message);
            }

        }
        
    }
}
