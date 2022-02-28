using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Negocio
{
    public class NEstatusAlumno
    {
        private DEstatusAlumno _DEstatusAlumno = new DEstatusAlumno();
        public List<EstatusAlumno> Consultar() => _DEstatusAlumno.Consultar();
        public EstatusAlumno Consultar(int id) => _DEstatusAlumno.Consultar(id);
    }
}
