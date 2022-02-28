using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
namespace Presentacion.Alumnos
{
    public partial class Index : System.Web.UI.Page
    {
        NAlumno asd = new NAlumno();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            GridView1.DataSource = asd.Consultar();
            GridView1.DataBind();

        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "Page") return;
                int accion = Convert.ToInt32(e.CommandArgument);
                GridViewRow fila = GridView1.Rows[accion];
                TableCell tc = fila.Cells[0];
                string id = tc.Text;
                string comando = e.CommandName;
                switch (comando)
                {
                    case "Select":
                        Response.Redirect($"~/Alumnos/Details.aspx?id={id}", false);
                        break;
                    case "SelectEdit":
                        Response.Redirect($"~/Alumnos/Edit.aspx?id={id}", false);
                        break;
                    case "SelectDelete":
                        Response.Redirect($"~/Alumnos/Delete.aspx?id={id}",false);
                        break;
                    default:
                        break;
                }
               
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}