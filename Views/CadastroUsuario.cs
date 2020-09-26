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
using System.Security.Cryptography;
using Controllers;
using Models;

namespace HardTrainning
{
    public partial class frmCadastroUsuarios : Form
    {
        UsuariosController usuarioCtrl = new UsuariosController();
        UsuariosModel usuario = new UsuariosModel();

        public frmCadastroUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = usuarioCtrl.getUsuarios();
            dgvUsuarios.ClearSelection();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            

            // Verifica se tem o campo ID preenchido.
            if (txtID.Text.Equals(""))
            {
                if (!validaCampos())
                {
                    MessageBox.Show("Todos os campos são obrigatórios.");
                    return;
                }
                else
                {
                    usuario.Nome = txtNome.Text;
                    usuario.Email = txtEmail.Text;
                    usuario.Senha = MD5Hash(txtSenha.Text);
                    usuario.Permissao = cboPermissao.Text;

                    usuarioCtrl.insertUsuario(usuario);
                    MessageBox.Show("Cadastro efetuado com sucesso!");
                }
            }
            else
            {
                if (!validaCamposUpdate())
                {
                    MessageBox.Show("Os campos [Nome], [E-mail] são obrigatórios.");
                    return;
                }
                else
                {
                    usuario.Nome = txtNome.Text;
                    usuario.Email = txtEmail.Text;
                    usuario.Permissao = cboPermissao.Text;

                    if (!txtSenha.Text.Equals(""))
                    {
                        usuario.Senha = MD5Hash(txtSenha.Text);
                    }

                    usuario.Id = Convert.ToInt32(txtID.Text);
                    usuarioCtrl.updateUsuario(usuario);
                    MessageBox.Show("Cadastro atualizado com sucesso!");

                }
                
            }

            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            txtNome.Focus();

            dgvUsuarios.DataSource = usuarioCtrl.getUsuarios();
            resetForm();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtSenha.Clear();
            txtEmail.Clear();
            txtNome.Focus();

            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtSenha.Enabled = true;
            cboPermissao.Enabled = true;
        }

        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow rowUsuario = dgvUsuarios.Rows[e.RowIndex];

            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtSenha.Enabled = false;
            cboPermissao.Enabled = false;

            txtID.Text = rowUsuario.Cells[0].Value.ToString();
            txtNome.Text = rowUsuario.Cells[1].Value.ToString();
            txtEmail.Text = rowUsuario.Cells[2].Value.ToString();
            cboPermissao.SelectedItem = rowUsuario.Cells[3].Value;
                       
        }
        
        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtSenha.Enabled = true;
            cboPermissao.Enabled = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Tem certeza que deseja exlcluir este usuário?", "Important Question", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                int usuarioId = Convert.ToInt32(txtID.Text);
                usuarioCtrl.deleteUsuario(usuarioId);
                dgvUsuarios.DataSource = usuarioCtrl.getUsuarios();
                resetForm();
                MessageBox.Show("Cadastro excluído com sucesso!");
            }
        }

        private bool validaCampos()
        {
            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtSenha.Text))
            {
                return false;
            }

            return true;
        }

        private bool validaCamposUpdate()
        {
            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtEmail.Text))
            {
                return false;
            }

            return true;
        }

        private void clearForm()
        {
            txtID.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            cboPermissao.Text = cboPermissao.Items[0].ToString();
        }

        private void resetForm()
        {
            clearForm();
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtSenha.Enabled = false;
            cboPermissao.Enabled = false;
        }

    }
}
