using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Entidades;
namespace Presentacion.Alumnos
{
    public partial class Details : System.Web.UI.Page
    {
        NAlumno asd = new NAlumno();
        Alumno alumnos = new Alumno();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(Request.QueryString["id"]);
            try
            {
                alumnos = asd.Consultar(id);

                LabelId.Text = Convert.ToString(alumnos.id);
                LabelNombre.Text = Convert.ToString(alumnos.nombre);
                LabelPrimerApellido.Text = Convert.ToString(alumnos.primerApellido);
                LabelSegundoApellido.Text = Convert.ToString(alumnos.segundoApellido);
                LabelCorreo.Text = Convert.ToString(alumnos.correo);
                LabelTelefono.Text = Convert.ToString(alumnos.telefono);
                LabelFechaNacimiento.Text = Convert.ToString(alumnos.fechaNacimiento);
                LabelCurp.Text = Convert.ToString(alumnos.curp);
                LabelSueldo.Text = Convert.ToString(alumnos.sueldo);
                LabelEstado.Text = Convert.ToString(alumnos.idEstadoOrigen);
                LabelEstatus.Text = Convert.ToString(alumnos.idEstatus);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
    }
}