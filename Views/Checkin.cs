using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controllers;
using Models;

namespace HardTrainning
{
    public partial class frmCheckin : Form
    {
        AulasController aulaCtrl = new AulasController();
        AlunosController alunosCtrl = new AlunosController();
        CheckinController checkinCtrl = new CheckinController();
        

        public frmCheckin()
        {
            InitializeComponent();
        }

        private void frmCheckin_Load(object sender, EventArgs e)
        {
            DataTable dtAulas = new DataTable();
            dtAulas = aulaCtrl.getAulas();

            cboAulas.DataSource = dtAulas;
            cboAulas.DisplayMember = "TITULO";
            cboAulas.ValueMember = "ID";

            dgvAlunos.ClearSelection();
            dgvCheckin.ClearSelection();

        }

        private void dgvAlunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow rowAluno = dgvAlunos.Rows[e.RowIndex];
            txtAlunoID.Text = rowAluno.Cells[0].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int alunoId = Convert.ToInt32(txtAlunoID.Text);
            int aulaId = Convert.ToInt32(txtAulaID.Text);

            if (checkinCtrl.AlocarAluno(aulaId, alunoId))
            {
                dgvCheckin.DataSource = checkinCtrl.getCheckins(aulaId);
                dgvAlunos.DataSource = checkinCtrl.getAlunosMatriculados(aulaId);
            }

            dgvAlunos.ClearSelection();
            dgvCheckin.ClearSelection();

        }

        private void cboAulas_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAulaID.Text = cboAulas.SelectedValue.ToString();
            int aulaId = Convert.ToInt32(txtAulaID.Text);

            dgvAlunos.DataSource = alunosCtrl.getAlunos();
            dgvAlunos.Columns["EMAIL"].Visible = false;
            dgvAlunos.Columns["CELULAR"].Visible = false;
            dgvAlunos.Columns["NASCIMENTO"].Visible = false;
            dgvAlunos.Columns["PLANO"].Visible = false;
            dgvAlunos.Columns["STATUS"].Visible = false;

            dgvAlunos.Columns["ID"].Width = 40;
            dgvAlunos.Columns["NOME"].Width = 190;

            dgvAlunos.ClearSelection();

            DataTable dtAlunos = new DataTable();
            dtAlunos = checkinCtrl.getAlunosMatriculados(aulaId);
            dgvAlunos.DataSource = dtAlunos;

            if (txtAulaID.Text != "" && txtAlunoID.Text != "")
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }


            if (txtAulaID.Text != "")
            {
                dgvCheckin.DataSource = checkinCtrl.getCheckins(aulaId);

                dgvCheckin.Columns["ID"].Width = 40;
                dgvCheckin.Columns["NOME"].Width = 190;

            }
            
        }

        private void dgvAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ( txtAulaID.Text != "" && txtAlunoID.Text != "" )
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }

        private void dgvCheckin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow rowAluno = dgvCheckin.Rows[e.RowIndex];
            txtAlunoIDConfirmado.Text = rowAluno.Cells[0].Value.ToString();

            if (txtAulaID.Text != "" && txtAlunoIDConfirmado.Text != "")
            {
                btnRemove.Enabled = true;
            }
            else
            {
                btnRemove.Enabled = false;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int alunoId = Convert.ToInt32(txtAlunoIDConfirmado.Text);
            int aulaId = Convert.ToInt32(txtAulaID.Text);

            if (checkinCtrl.DesalocarAluno(aulaId, alunoId))
            {
                dgvCheckin.DataSource = checkinCtrl.getCheckins(aulaId);
                dgvAlunos.DataSource = checkinCtrl.getAlunosMatriculados(aulaId);
            }

            dgvAlunos.ClearSelection();
            dgvCheckin.ClearSelection();
        }

        
    }
}
