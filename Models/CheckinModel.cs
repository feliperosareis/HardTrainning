using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class CheckinModel
    {
        private int id;
        private int fkAulaId;
        private int fkAlunoId;

        public int Id { get => id; set => id = value; }

        public int FkAulaId { get => fkAulaId; set => fkAulaId = value; }
        
        public int FkAlunoId { get => fkAlunoId; set => fkAlunoId = value; }
    }
}
