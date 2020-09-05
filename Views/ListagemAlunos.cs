using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using Controllers;

namespace HardTrainning
{
    public partial class frmListagemAlunos : Form
    {
        AlunosController conexao = new AlunosController();

        public frmListagemAlunos()
        {
            InitializeComponent();
        }

        private void ListagemAlunos_Load(object sender, EventArgs e)
        {
            dgvAlunos.DataSource = conexao.getAlunos();
            
        }

        private void btnNovoAluno_Click(object sender, EventArgs e)
        {
            this.Hide();   
            frmCadastroAluno form = new frmCadastroAluno();
            form.Show();
        }
    }
}
