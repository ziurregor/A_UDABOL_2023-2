using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    public class Alumno
    {
            [Key]
            [Column("id")]
       //completar el modelo segun los datos que se necesitan para el modelo de alumno

			public int id { get; set; }
			
			public string Codigo { get; set; }
			public string Nombre { get; set; }
			public string PrimerRegistro { get; set; }
			public string CorreoPersonal { get; set; }
			public string CorreoUdabol { get; set; }
			public string Verificacion { get; set; }
			public int IsActive { get; set; }

			public int Ex_GIT_6PTS { get; set; }
			public int Ex_ADOO_8PTS { get; set; }
			public int Ex_ScrumTra_41PTS { get; set; }
			public int Ex_SOLID_8PTS { get; set; }
			public int Ex_12FactApp_12PTS { get; set; }
			public int Ex_Docker_5PTS { get; set; }
			
/*
			// En caso de presentar problemas con el sensitiveCase

			public string codigo { get; set; }
			public string nombre { get; set; }
			public string primerRegistro { get; set; }
			public string correoPersonal { get; set; }
			public string correoUdabol { get; set; }
			
			public string verificacion { get; set; }
			public int isActive { get; set; }

			public int ex_GIT_6PTS { get; set; }
			public int ex_ADOO_8PTS { get; set; }
			public int ex_ScrumTra_41PTS { get; set; }
			public int ex_SOLID_8PTS { get; set; }
			public int ex_12FactApp_12PTS { get; set; }
			public int ex_Docker_5PTS { get; set; }
*/

    }
}

