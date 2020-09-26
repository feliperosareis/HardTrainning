using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class UsuariosModel
    {
        private int id;
        private string nome;
        private string email;
        private string senha;
        private string permissao;

        public int Id { get => id; set => id = value; }

        public string Nome { get => nome; set => nome = value; }
        
        public string Email { get => email; set => email = value; }

        public string Senha { get => senha; set => senha = value; }

        public string Permissao { get => permissao; set => permissao = value; }

        
    }
}
