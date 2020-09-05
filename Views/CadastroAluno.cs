using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Controllers;
using Models;


namespace HardTrainning
{
    public partial class frmCadastroAluno : Form
    {
        AlunosModel aluno = new AlunosModel();
        AlunosController alunoCtrl = new AlunosController();

        public frmCadastroAluno()
        {
            InitializeComponent();
        }

        private void CadastroAluno_Load(object sender, EventArgs e)
        {

            

        }

        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {
            aluno.Nome = txtNome.Text;
            aluno.Email = txtEmail.Text;
            aluno.Celular = mskCelular.Text;
            aluno.Plano = cboPlano.Text;

            string nasc = mskNascimento.Text;
            
            DateTime nascConvert = Convert.ToDateTime(nasc);
            aluno.DataNascimento = nascConvert.Year.ToString() + '-' + nascConvert.Month.ToString() + '-' + nascConvert.Day.ToString();

            int status = 1;
            if (rdoInativo.Checked)
            {
                status = 0;
            }
            aluno.Status = status;

            alunoCtrl.insertAluno(aluno);

            this.Close();
            frmListagemAlunos frm = new frmListagemAlunos();
            frm.ShowDialog();

        }
    }
}
