using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_01.Models
{
    public enum Nota
    {
        A, B, C, D, F
    }

    public class Matricula
    {
        public int MatriculaID { get; set; }
        public int CursoID { get; set; }
        public int EstudanteID { get; set; }
        public Nota? Nota { get; set; }

        public Curso Curso { get; set; }
        public Estudante Estudante { get; set; }
    }
}
