using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ADO;
using Modelo;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlumnosController : ControllerBase
    {
        private readonly AlumnoRepository _alumnoRepository;

        public AlumnosController(AlumnoRepository alumnoRepository)
        {
            _alumnoRepository = alumnoRepository;
        }

        /// <summary>
        ///Metodo que devuelve los datos de todos los alumnos
        /// </summary>
        /// <param name=""></param>
        /// <returns>Una Lista de array de todos los alumnos</returns>
        // Metodo que devuelve los datos de todos los alumnos
        [HttpGet]
        public async Task<ActionResult<List<Alumno>>> GetAllAlumnos()
        {
            //Esperando los datos de manera asíncrona y guardar en la varible alumnos
            var alumnos = await _alumnoRepository.GetAllAlumno();
            return Ok(alumnos);//Retornando todos los alumnos

        }
        /// <summary>
        /// GetAlumnoByCodigo obtiene el registro de una llamada por busqueda de su id 
        /// </summary>
        /// <param name= "id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<Alumno>> GetAlumnoById(int id)
        {
            var alumno = await _alumnoRepository.GetAlumnoById(id);
            if (alumno == null)
            {
                return NotFound();
            }
            return Ok(alumno);
        }
        /// <summary>
        /// GetAlumnoByCodigo obtiene el registro de una llamada por busqueda de su codigo 
        /// </summary>
        /// <param name= "codigo"></param>
        /// <returns></returns>
        [HttpGet("{codigo}")]
        public async Task<ActionResult<Alumno>> GetAlumnoByCodigo(string codigo)
        {
            var alumno = await _alumnoRepository.GetAlumnoByCodigo(codigo);
            if (alumno == null)
            {
                return NotFound();
            }
            return Ok(alumno);
        }

        /// <summary>
        /// AddAlumno registra un alumno 
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns></returns>

        [HttpPost]
        public async Task<IActionResult> AddAlumno(Alumno alumno)
        {
            await _alumnoRepository.AddAlumno(alumno);
            return Ok();
        }
        /// <summary>
        /// UpdateAlumno modifica el registro de un alumno
        /// </summary>
        /// <param name="id,alumno"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAlumno(int id, Alumno alumno)
        {
            if (id != alumno.id)
            {
                return BadRequest();
            }
            await _alumnoRepository.UpdateAlumno(alumno);
            return Ok();
        }
        //<summary>
        /// DeleteAlumno este metodo recibe el id del alumno
        ///y lo elimina de la base de datos 
        //</summary>
        //<param name="id"></param>
        //<returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAlumno(int id)
        {
            var alumno = await _alumnoRepository.GetAlumnoById(id);//obtener al alumno;
            if (alumno == null)
            {
                return NotFound();
            }
            await _alumnoRepository.DeleteAlumno(alumno);//borrar el alumno;
            return Ok();
        }
    }
}


