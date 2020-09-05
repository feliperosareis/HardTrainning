using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class AlunosModel
    {
        private int id;
        private string nome;
        private string email;
        private string celular;
        private string dataNascimento;
        private string plano;
        private int status;


        public int Id { get => id; set => id = value; }
        
        public string Nome { get => nome; set => nome = value; }
        
        public string Email { get => email; set => email = value; }
        
        public string Celular { get => celular; set => celular = value; }
        
        public string DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        
        public string Plano { get => plano; set => plano = value; }
        
        public int Status { get => status; set => status = value; }
    }
}
