using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    public class Alumno
    {
        [Key]
        [Column("id")]
        public int id { get; set; }
        public string? nombre { get; set; }
        public string? primerRegistro { get; set; }
        public string? correoPersonal { get; set; }
        public string? correoUdabol { get; set; }
        public string? codigo { get; set; }
        public string? verificacion { get; set; }
        public bool isActive { get; set; }
        public int ex_GIT_6PTS { get; set; }
        public int ex_ADOO_8PTS { get; set; }
        public int ex_ScrumTra_41PTS { get; set; }
        public int ex_SOLID_8PTS { get; set; }
        public int ex_12FactApp_12PTS { get; set; }
        public int ex_Docker_5PTS { get; set; }
    }
}

