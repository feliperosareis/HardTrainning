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
    public partial class frmCadastroAulas : Form
    {
        AulasController aulasCtrl = new AulasController();
        AulasModel aula = new AulasModel();

        public frmCadastroAulas()
        {
            InitializeComponent();
        }

        private void frmCadastroAulas_Load(object sender, EventArgs e)
        {
            dgvAulas.DataSource = aulasCtrl.getAulas();

            dgvAulas.Columns["ID"].Width = 40;
            dgvAulas.Columns["TITULO"].Width = 495;

            dgvAulas.ClearSelection();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            aula.Titulo = txtAula.Text;

            // Verifica se tem o campo ID preenchido.
            if (txtAulaID.Text.Equals(""))
            {
                if (txtAula.Text.Equals(""))
                {
                    MessageBox.Show("O campo Aula é obrigatório. \nTente novamente!");
                    txtAula.Focus();
                }
                else
                {
                    aulasCtrl.insertAula(aula);
                    MessageBox.Show("Cadastro efetuado com sucesso!");
                }
            }
            else
            {
                if (txtAula.Text.Equals(""))
                {
                    MessageBox.Show("O campo Aula é obrigatório. \nTente novamente!");
                    txtAula.Focus();
                }
                else
                {
                    aula.Id = Convert.ToInt32(txtAulaID.Text);
                    aulasCtrl.updateAula(aula);
                    MessageBox.Show("Cadastro atualizado com sucesso!");
                }
            }

            dgvAulas.DataSource = aulasCtrl.getAulas();
            resetForm();
        }

        private void clearForm()
        {
            txtAulaID.Clear();
            txtAula.Clear();
            txtAula.Focus();
        }

        private void resetForm()
        {
            clearForm();
            txtAula.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Tem certeza que deseja exlcluir esta aula?", "Important Question", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                int aulaId = Convert.ToInt32(txtAulaID.Text);
                aulasCtrl.deleteAula(aulaId);
                dgvAulas.DataSource = aulasCtrl.getAulas();
                resetForm();
                MessageBox.Show("Cadastro excluído com sucesso!");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtAula.Enabled = true;
        }

        private void btnNova_Click(object sender, EventArgs e)
        {
            txtAulaID.Clear();
            txtAula.Clear();
            txtAula.Focus();

            txtAula.Enabled = true;
        }

        private void dgvAulas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow rowAula = dgvAulas.Rows[e.RowIndex];

            txtAula.Enabled = false;

            txtAulaID.Text = rowAula.Cells[0].Value.ToString();
            txtAula.Text = rowAula.Cells[1].Value.ToString();
        }

       
    }
}
