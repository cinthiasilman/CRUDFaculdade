using Faculdade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Faculdade.DAL
{
    public class FaculdadeInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<FaculdadeContext>
    {
        protected override void Seed(FaculdadeContext context)
        {
            var alunos = new List<Aluno>
            {
            new Aluno{Nome="Carlos",Sobrenome="Alexander",DataMatricula=DateTime.Parse("2005-09-01")},
            new Aluno{Nome="Melissa",Sobrenome="Alonso",DataMatricula=DateTime.Parse("2002-09-01")},
            new Aluno{Nome="Artur",Sobrenome="Asdrubal",DataMatricula=DateTime.Parse("2003-09-01")},
            new Aluno{Nome="Gabriela",Sobrenome="Barzdukas",DataMatricula=DateTime.Parse("2002-09-01")},
            new Aluno{Nome="Yana",Sobrenome="Li",DataMatricula=DateTime.Parse("2002-09-01")},
            new Aluno{Nome="Pedro",Sobrenome="Justice",DataMatricula=DateTime.Parse("2001-09-01")},
            new Aluno{Nome="Laura",Sobrenome="Norman",DataMatricula=DateTime.Parse("2003-09-01")},
            new Aluno{Nome="Nino",Sobrenome="Olivetto",DataMatricula=DateTime.Parse("2005-09-01")}
            };

            alunos.ForEach(s => context.Alunos.Add(s));
            context.SaveChanges();
            var cursos = new List<Curso>
            {
            new Curso{CursoID=1050,Descricao="Sistemas de Informacao",},
            new Curso{CursoID=4022,Descricao="Ciência da Computação",},
            new Curso{CursoID=4041,Descricao="Administração",},
            new Curso{CursoID=1045,Descricao="Ciências Contábeis",},
            new Curso{CursoID=3141,Descricao="Direito",},
            new Curso{CursoID=2021,Descricao="Letras",},
            new Curso{CursoID=2042,Descricao="Engenharia de Produção",}
            };
            cursos.ForEach(s => context.Cursos.Add(s));
            context.SaveChanges();
            var matriculas = new List<Matricula>
            {
            new Matricula{AlunoID=1,CursoID=1050},
            new Matricula{AlunoID=1,CursoID=4022},
            new Matricula{AlunoID=1,CursoID=4041},
            new Matricula{AlunoID=2,CursoID=1045},
            new Matricula{AlunoID=2,CursoID=3141},
            new Matricula{AlunoID=2,CursoID=2021},
            new Matricula{AlunoID=3,CursoID=1050},
            new Matricula{AlunoID=4,CursoID=1050,},
            new Matricula{AlunoID=4,CursoID=4022},
            new Matricula{AlunoID=5,CursoID=4041},
            new Matricula{AlunoID=6,CursoID=1045},
            new Matricula{AlunoID=7,CursoID=3141},
            };
            matriculas.ForEach(s => context.Matriculas.Add(s));
            context.SaveChanges();
        }
    }

}