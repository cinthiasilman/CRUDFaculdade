using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Faculdade.Models
{
    public class Curso
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CursoID { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<Matricula> Matriculas { get; set; }

    }
}