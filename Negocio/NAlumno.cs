using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Negocio
{
    public class NAlumno
    {
        private DAlumno _DAlumno = new DAlumno();
        public List<Alumno> Consultar() => _DAlumno.Consultar();
        public Alumno Consultar(int id) => _DAlumno.Consultar(id);
        
        public void AgregarAlumno(Alumno alumno) => _DAlumno.AgregarAlumno(alumno);
        
        public void Actualizar(Alumno alumno) => _DAlumno.Actualizar(alumno);

    
        public void Eliminar(int id) => _DAlumno.Eliminar(id);
        
    }
}
