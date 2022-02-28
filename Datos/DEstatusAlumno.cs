using Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DEstatusAlumno
    {
        public static string _connString = ConfigurationManager.ConnectionStrings["localConnection"].ConnectionString;
        public static List<EstatusAlumno> listEstatusAlumno = new List<EstatusAlumno>();
        public List<EstatusAlumno> Consultar()
        {
            string query;
            SqlCommand comando;
            DataTable dtEstatus = new DataTable();
            query = "select * from EstatusAlumnos";
            using (SqlConnection con = new SqlConnection(_connString))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.Text;
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                adapter.Fill(dtEstatus);
                con.Close();
            }
            listEstatusAlumno = new List<EstatusAlumno>();
            foreach (DataRow item in dtEstatus.Rows)
            {
                EstatusAlumno estatus = new EstatusAlumno();
                estatus.id = Convert.ToInt16(item["id"]);
                estatus.clave = item["clave"].ToString();
                estatus.nombre = item["nombre"].ToString();

                listEstatusAlumno.Add(estatus);
            }
            //foreach (var item in listEstatus)
            //{
            //    Console.WriteLine($"id: {item.Id}, clave: {item.Clave}, nombre: {item.Nombre}");
            //}
            return listEstatusAlumno;
        }
        public EstatusAlumno Consultar(int id)
        {
            string query;
            SqlCommand comando;
            DataTable uno = new DataTable();
            query = $"select * from EstatusAlumnos where id={id}";
            using (SqlConnection con = new SqlConnection(_connString))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.Text;
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                adapter.Fill(uno);
                con.Close();
            }
            //listEstatus = new List<Estatus>();
            EstatusAlumno estatus = new EstatusAlumno();
            foreach (DataRow item in uno.Rows)
            {
                estatus.id = Convert.ToInt16(item["id"]);
                estatus.clave = item["clave"].ToString();
                estatus.nombre = item["nombre"].ToString();

                //listEstatus.Add(estatus);
            }
            //foreach (var item in listEstatus)
            //{
            //    Console.WriteLine($"id: {item.Id}, clave: {item.Clave}, nombre: {item.Nombre}");
            //}
            //Console.WriteLine($"id: {estatus.Id}, clave: {estatus.Clave}, nombre: {estatus.Nombre}");
            //Console.ReadKey();
            return estatus;
        }
        
    }
}
