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
    public partial class Edit : System.Web.UI.Page
    {
        NAlumno asd = new NAlumno();
        //Alumno alumno = new Alumno { id = 1, nombre = "jorge", primerApellido = "sanchez", segundoApellido = "castillo", correo = "alberto@mail.com", curp = "sacj910222hocnsr", fechaNacimiento = Convert.ToDateTime("1991/02/02"), telefono = "1234567890", sueldo = 27500, idEstadoOrigen = 2, idEstatus = 3 };
        Alumno alumnoact = new Alumno();
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                id = Convert.ToInt32(Request.QueryString["id"]);
                alumnoact = asd.Consultar(id);


                TextBox1.Text = Convert.ToString(alumnoact.nombre);
                TextBox2.Text = Convert.ToString(alumnoact.primerApellido);
                TextBox3.Text = Convert.ToString(alumnoact.segundoApellido);
                TextBox4.Text = Convert.ToString(alumnoact.correo);
                TextBox5.Text = Convert.ToString(alumnoact.telefono);
                TextBox6.Text = Convert.ToString(alumnoact.fechaNacimiento);
                TextBox7.Text = Convert.ToString(alumnoact.curp);
                TextBox8.Text = Convert.ToString(alumnoact.sueldo);
                TextBox9.Text = Convert.ToString(alumnoact.idEstadoOrigen);
                TextBox10.Text = Convert.ToString(alumnoact.idEstatus);
            }
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Alumno actual = new Alumno();
            actual.id = Convert.ToInt32(Request.QueryString["id"]);
            actual.nombre = TextBox1.Text;
            actual.primerApellido = TextBox2.Text;
            actual.segundoApellido = TextBox3.Text;
            actual.correo = TextBox4.Text;
            actual.telefono = TextBox5.Text;
            actual.fechaNacimiento = Convert.ToDateTime(TextBox6.Text);
            actual.curp = TextBox7.Text;
            actual.sueldo = Convert.ToDecimal(TextBox8.Text);
            actual.idEstadoOrigen = Convert.ToInt32(TextBox9.Text);
            actual.idEstatus = Convert.ToInt16(TextBox10.Text);
            asd.Actualizar(actual);
           
        }
        
    }
}