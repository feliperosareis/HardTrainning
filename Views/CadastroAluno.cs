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
            dgvAlunos.DataSource = alunoCtrl.getAlunos();
            dgvAlunos.ClearSelection();

        }

        private void btnSalvarAluno_Click(object sender, EventArgs e)
        {
            
            aluno.Nome = txtNome.Text;
            aluno.Email = txtEmail.Text;
            aluno.Celular = mskCelular.Text;
            aluno.Plano = cboPlano.Text;

            string nasc = mskNascimento.Text;

            if (!validaCampos())
            {
                return;
            }



            DateTime nascConvert = Convert.ToDateTime(nasc);
            aluno.DataNascimento = nascConvert.Year.ToString() + '-' + nascConvert.Month.ToString() + '-' + nascConvert.Day.ToString();
                        

            if (rdoAtivo.Checked)
            {
                aluno.Status = "Ativo";
            }
            else
            {
                aluno.Status = "Inativo";
            }
             
            // Verifica se tem o campo ID preenchido.
            if (txtID.Text.Equals(""))
            {
                alunoCtrl.insertAluno(aluno);
                MessageBox.Show("Cadastro efetuado com sucesso!");
            }
            else
            {
                aluno.Id = Convert.ToInt32(txtID.Text);
                alunoCtrl.updateAluno(aluno);
                MessageBox.Show("Cadastro atualizado com sucesso!");
            }
            

            dgvAlunos.DataSource = alunoCtrl.getAlunos();
            resetForm();

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            mskCelular.Enabled = true;
            mskNascimento.Enabled = true;
            cboPlano.Enabled = true;

            clearForm();
            
        }

        private void dgvAlunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow rowAluno = dgvAlunos.Rows[e.RowIndex];

            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            mskCelular.Enabled = false;
            mskNascimento.Enabled = false;
            cboPlano.Enabled = false;

            txtID.Text = rowAluno.Cells[0].Value.ToString();
            txtNome.Text = rowAluno.Cells[1].Value.ToString();
            txtEmail.Text = rowAluno.Cells[2].Value.ToString();
            mskCelular.Text = rowAluno.Cells[3].Value.ToString();
            mskNascimento.Text = rowAluno.Cells[4].Value.ToString();
            cboPlano.SelectedItem = rowAluno.Cells[5].Value.ToString();

            if (rowAluno.Cells[6].Value.ToString() == "Ativo")
            {
                rdoAtivo.Checked = true;
            }
            else
            {
                rdoInativo.Checked = true;
            }
            
        }

        private void clearForm()
        {
            txtID.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            mskCelular.Clear();
            mskNascimento.Clear();
            cboPlano.Text = cboPlano.Items[0].ToString();
            rdoAtivo.Checked = true;
        }

        private void resetForm()
        {
            clearForm();
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            mskCelular.Enabled = false;
            mskNascimento.Enabled = false;
            cboPlano.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            mskCelular.Enabled = true;
            mskNascimento.Enabled = true;
            cboPlano.Enabled = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Tem certeza que deseja exlcluir este aluno?", "Important Question", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                int alunoId = Convert.ToInt32(txtID.Text);
                alunoCtrl.deleteAluno(alunoId);
                dgvAlunos.DataSource = alunoCtrl.getAlunos();
                resetForm();
                MessageBox.Show("Cadastro excluído com sucesso!");
            }
        }

        private void mskNascimento_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Data inválida!");
            }
        }


        private bool validaCampos()
        {
            Console.WriteLine(txtNome.Text.ToString());
            Console.WriteLine(txtEmail.Text.ToString());
            Console.WriteLine(mskCelular.Text.ToString());
            Console.WriteLine(mskNascimento.Text.ToString());


            // Valida a idade mínima para ingressar na academia.
            string nasc = mskNascimento.Text;
            if (calculaIdade(nasc) < 16)
            {
                MessageBox.Show("Este aluno é menor de 16 anos e não pode ingressar na academia");
                return false;
            }


            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtEmail.Text) || !mskCelular.MaskFull || !mskNascimento.MaskFull)
            {
                MessageBox.Show("Todos os campos são obrigatórios.");
                return false;
            }

            return true;
        }


        private int calculaIdade(string dataNasc)
        {
            int anoAtual = DateTime.Now.Year;
            int anoNasc = Convert.ToDateTime(dataNasc).Year;
            int idade = anoAtual - anoNasc;

            if (DateTime.Now.DayOfYear < Convert.ToDateTime(dataNasc).DayOfYear)
            {
                idade = idade - 1;
            }
            
            return idade;
        }
    }
}
