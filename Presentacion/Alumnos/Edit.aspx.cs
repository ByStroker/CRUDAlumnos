﻿using System;
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
    public partial class Edit : System.Web.UI.Page
    {
        NAlumno asd = new NAlumno();
        //Alumno alumno = new Alumno { id = 1, nombre = "jorge", primerApellido = "sanchez", segundoApellido = "castillo", correo = "alberto@mail.com", curp = "sacj910222hocnsr", fechaNacimiento = Convert.ToDateTime("1991/02/02"), telefono = "1234567890", sueldo = 27500, idEstadoOrigen = 2, idEstatus = 3 };
        Alumno alumnoact = new Alumno();
        NEstado nEstado = new NEstado();
        NEstatusAlumno nEstatus = new NEstatusAlumno();
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                id = Convert.ToInt32(Request.QueryString["id"]);
                alumnoact = asd.Consultar(id);
                List<Estado>  oEstado = nEstado.Consultar();
                List<EstatusAlumno> oEstatusAlumno = nEstatus.Consultar();
                Estado nombreestado = oEstado.Find(estado => estado.id == alumnoact.idEstadoOrigen);
                EstatusAlumno nombreestatus = oEstatusAlumno.Find(estatus => estatus.id == alumnoact.idEstatus);
                TextBox1.Text = Convert.ToString(alumnoact.nombre);
                TextBox2.Text = Convert.ToString(alumnoact.primerApellido);
                TextBox3.Text = Convert.ToString(alumnoact.segundoApellido);
                TextBox4.Text = Convert.ToString(alumnoact.correo);
                TextBox5.Text = Convert.ToString(alumnoact.telefono);
                TextBox6.Text = Convert.ToString(alumnoact.fechaNacimiento);
                TextBox7.Text = Convert.ToString(alumnoact.curp);
                TextBox8.Text = Convert.ToString(alumnoact.sueldo);
                DropDownList1.DataSource = oEstado;
                DropDownList1.DataValueField = "id";
                DropDownList1.DataTextField = "nombre";
                DropDownList1.DataBind();
                DropDownList1.SelectedValue =  nombreestado.id.ToString();

                DropDownList2.DataSource = oEstatusAlumno;
                DropDownList2.DataValueField = "id";
                DropDownList2.DataTextField = "nombre";
                DropDownList2.DataBind();
                DropDownList2.SelectedValue = nombreestatus.id.ToString();
               
            }
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
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
                actual.idEstadoOrigen = Convert.ToInt32(DropDownList1.SelectedValue);
                actual.idEstatus = Convert.ToInt16(DropDownList2.SelectedValue);
                asd.Actualizar(actual);
                Thread.Sleep(3000);
                Response.Redirect("Index.aspx",false);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx", false);
        }
    }
}