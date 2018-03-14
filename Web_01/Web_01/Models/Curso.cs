using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Web_01.Models
{
    public class Curso
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CursoID { get; set; }
        public string Titulo { get; set; }
        public int Creditos { get; set; }

        public ICollection<Matricula> Matriculas { get; set; }
    }
}
