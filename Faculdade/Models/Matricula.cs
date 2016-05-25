using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Faculdade.Models
{
    
    public class Matricula
    {
        public int MatriculaID { get; set; }
        public DateTime DataMatricula { get; set; }
        public int CursoID { get; set; }
        public int AlunoID { get; set; }

        public virtual Curso Curso { get; set; }
        public virtual Aluno Aluno { get; set; }
    }

}