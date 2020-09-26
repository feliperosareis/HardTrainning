using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardTrainning
{
    public partial class frmDashboard : Form
    {

        public frmDashboard()
        {
            InitializeComponent();
        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {
            frmCadastroAluno frmCadastroAluno = new frmCadastroAluno();
            frmCadastroAluno.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmCadastroUsuarios frmCadastroUsuarios = new frmCadastroUsuarios();
            frmCadastroUsuarios.Show();
        }

        private void btnAulas_Click(object sender, EventArgs e)
        {
            frmCadastroAulas frmCadastroAulas = new frmCadastroAulas();
            frmCadastroAulas.Show();
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            frmCheckin frmCheckin = new frmCheckin();
            frmCheckin.Show();
        }
    }
}
