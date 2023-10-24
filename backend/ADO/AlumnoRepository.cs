using System;
using ADO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Modelo;


//ADO using TuProyecto.Data;

namespace ADO
{
    public class AlumnoRepository 
    {
        //private readonly ApplicationDbContext _context;
        private readonly ApplicationDbContext _context;
        

        public AlumnoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Alumno>> GetAllAlumno()
        {
            return await _context.Alumnos.ToListAsync();
        }

        public async Task<Alumno> GetAlumnoById(int id)
        {
            return await _context.Alumnos.FindAsync(id);
        }

        public async Task<Alumno> GetAlumnoByCodigo(string codigo)
        {
            var alumno = await _context.Alumnos.FirstOrDefaultAsync(a => a.Codigo == codigo);
            if (alumno == null)
            {
                throw new Exception("Alumno no encontrado");
            }
            return alumno;
        }


        public async Task AddAlumno(Alumno alumno)
        {
            //adicionar el codigo para adicionar un dato tipo alumno
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAlumno(Alumno alumno)
        {
            //modificar el context.Alumnos actualizando el dato con el alumno
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAlumno(Alumno alumno)
        {
            //_context.Alumnos borrar el alumno
            await _context.SaveChangesAsync();
        }
    }
}

