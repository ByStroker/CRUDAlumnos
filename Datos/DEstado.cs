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
    public class DEstado
    {
        public static string _connString = ConfigurationManager.ConnectionStrings["localConnection"].ConnectionString;
        public static List<Estado> listEstados = new List<Estado>();
        public List<Estado> Consultar()
        {
            string query;
            SqlCommand comando;
            DataTable dtEstado = new DataTable();
            query = "select * from Estados";
            using (SqlConnection con = new SqlConnection(_connString))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.Text;
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                adapter.Fill(dtEstado);
                con.Close();
            }
            listEstados = new List<Estado>();
            foreach (DataRow item in dtEstado.Rows)
            {
                Estado estados = new Estado();
                estados.id = Convert.ToInt32(item["id"]);
                estados.nombre = item["nombre"].ToString();
                estados.Curp = item["Curp"].ToString();
                
                listEstados.Add(estados);
            }
            //foreach (var item in listEstatus)
            //{
            //    Console.WriteLine($"id: {item.Id}, clave: {item.Clave}, nombre: {item.Nombre}");
            //}
            return listEstados;
        }
        public Estado Consultar(int id)
        {
            string query;
            SqlCommand comando;
            DataTable uno = new DataTable();
            query = $"select * from Estados where id={id}";
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
            Estado estado = new Estado();
            foreach (DataRow item in uno.Rows)
            {
                estado.id = Convert.ToInt32(item["id"]);
                estado.nombre = item["nombre"].ToString();
                estado.Curp = item["Curp"].ToString();
                
                //listEstatus.Add(estatus);
            }
            //foreach (var item in listEstatus)
            //{
            //    Console.WriteLine($"id: {item.Id}, clave: {item.Clave}, nombre: {item.Nombre}");
            //}
            //Console.WriteLine($"id: {estatus.Id}, clave: {estatus.Clave}, nombre: {estatus.Nombre}");
            //Console.ReadKey();
            return estado;
        }
    }
}
