using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Entidades;
using System.Threading;

namespace Presentacion.Alumnos
{
    public partial class Create : System.Web.UI.Page
    {
        NAlumno asd = new NAlumno();
        //Alumno alumnos = new Alumno { id = 1, nombre = "jorge", primerApellido = "sanchez", segundoApellido = "castillo", correo = "alberto@mail.com", curp = "sacj910222hocnsr", fechaNacimiento = Convert.ToDateTime("1991-02-02"), telefono = "1234567890", sueldo = 27500, idEstadoOrigen = 2, idEstatus = 3 };
       Alumno alumno = new Alumno();
        NEstado oEstado = new NEstado();
        NEstatusAlumno oStatus = new NEstatusAlumno();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    DropDownList1.DataSource = oEstado.Consultar();
                    DropDownList1.DataValueField = "id";
                    DropDownList1.DataTextField = "nombre";
                    DropDownList1.DataBind();
                    DropDownList2.DataSource = oStatus.Consultar();
                    DropDownList2.DataValueField = "id";
                    DropDownList2.DataTextField = "nombre";
                    DropDownList2.DataBind();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }  
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                alumno.nombre = TextBox1.Text;
                alumno.primerApellido = TextBox2.Text;
                alumno.segundoApellido = TextBox3.Text;
                alumno.correo = TextBox4.Text;
                alumno.telefono = TextBox5.Text;
                alumno.fechaNacimiento = Convert.ToDateTime(TextBox6.Text);
                alumno.curp = TextBox7.Text;
                alumno.sueldo = Convert.ToDecimal(TextBox8.Text);
                alumno.idEstadoOrigen = Convert.ToInt32(DropDownList1.SelectedValue);
                alumno.idEstatus = Convert.ToInt16(DropDownList2.SelectedValue);

                asd.AgregarAlumno(alumno);
                Thread.Sleep(3000);

                Response.Redirect("Index.aspx");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}