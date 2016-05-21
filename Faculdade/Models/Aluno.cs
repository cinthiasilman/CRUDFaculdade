using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Faculdade.Models
{
    public class Aluno
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataMatricula { get; set; }

        public virtual ICollection<Matricula> Matriculas { get; set; }
    }
}