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
    public class DAlumno
    {
        public static List<Alumno> listEstatus = new List<Alumno>();
        public static string _connString = ConfigurationManager.ConnectionStrings["localConnection"].ConnectionString;
        public List<Alumno> Consultar() {
            string query;
            SqlCommand comando;
            DataTable dtEstatus = new DataTable();
            query = "select * from Alumnos";
            using (SqlConnection con = new SqlConnection(_connString))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.Text;
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                adapter.Fill(dtEstatus);
                con.Close();
            }
            listEstatus = new List<Alumno>();
            foreach (DataRow item in dtEstatus.Rows)
            {
                Alumno estatus = new Alumno();
                estatus.id = Convert.ToInt32(item["id"]);
                estatus.nombre = item["nombre"].ToString();
                estatus.primerApellido = item["primerApellido"].ToString();
                estatus.segundoApellido = item["segundoApellido"].ToString();
                estatus.correo=item["correo"].ToString() ;
                estatus.telefono = item["telefono"].ToString();
                estatus.fechaNacimiento = Convert.ToDateTime(item["fechaNacimiento"]);
                estatus.curp = item["curp"].ToString();
                estatus.sueldo = Convert.ToDecimal(item["sueldo"]);
                estatus.idEstadoOrigen = Convert.ToInt32(item["idEstadoOrigen"].ToString());
                estatus.idEstatus = Convert.ToInt16(item["idEstatus"].ToString());
                listEstatus.Add(estatus);
            }
            //foreach (var item in listEstatus)
            //{
            //    Console.WriteLine($"id: {item.Id}, clave: {item.Clave}, nombre: {item.Nombre}");
            //}
            return listEstatus;
        
    }
        public Alumno Consultar(int id) {
            string query;
            SqlCommand comando;
            DataTable uno = new DataTable();
            query = $"select * from Alumnos where id={id}";
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
            Alumno estatus = new Alumno();
            foreach (DataRow item in uno.Rows)
            {
                estatus.id = Convert.ToInt32(item["id"]);
                estatus.nombre = item["nombre"].ToString();
                estatus.primerApellido = item["primerApellido"].ToString();
                estatus.segundoApellido = item["segundoApellido"].ToString();
                estatus.correo = item["correo"].ToString();
                estatus.telefono = item["telefono"].ToString();
                estatus.fechaNacimiento = Convert.ToDateTime(item["fechaNacimiento"]);
                estatus.curp = item["curp"].ToString();
                estatus.sueldo = Convert.ToDecimal(item["sueldo"]);
                estatus.idEstadoOrigen = Convert.ToInt32(item["idEstadoOrigen"].ToString());
                estatus.idEstatus = Convert.ToInt16(item["idEstatus"].ToString());
                //listEstatus.Add(estatus);
            }
            //foreach (var item in listEstatus)
            //{
            //    Console.WriteLine($"id: {item.Id}, clave: {item.Clave}, nombre: {item.Nombre}");
            //}
            //Console.WriteLine($"id: {estatus.Id}, clave: {estatus.Clave}, nombre: {estatus.Nombre}");
            //Console.ReadKey();
            return estatus;
            //throw new NotImplementedException();
        }
        public void AgregarAlumno(Alumno alumno) {
            string query;
            SqlCommand comando;
            //query = $"SP_AgregarAlumnos";
            query = $"INSERT INTO Alumnos VALUES('{alumno.nombre}', '{alumno.primerApellido}', '{alumno.segundoApellido}','{alumno.correo}', '{alumno.telefono}', '{alumno.fechaNacimiento}','{alumno.curp}', {alumno.sueldo},{alumno.idEstadoOrigen}, {alumno.idEstatus}); ";
            try
            {
                using (SqlConnection con = new SqlConnection(_connString))
                {
                    comando = new SqlCommand(query, con);
                    comando.CommandType = CommandType.Text;
                    con.Open();
                    comando.ExecuteNonQuery();
                    Console.WriteLine("Record Inserted Successfully");
                    con.Close();
                    Console.ReadKey();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            //return alumno.id;
        }
        public void Actualizar(Alumno alumno) {
            string query;
            SqlCommand comando;
            query = $"update Alumnos set nombre='{alumno.nombre}',primerApellido='{alumno.primerApellido}',segundoApellido='{alumno.segundoApellido}',correo='{alumno.correo}', telefono='{alumno.telefono}',fechaNacimiento= '{alumno.fechaNacimiento.ToString("dd/MM/yyyy")}',curp='{alumno.curp}',sueldo= {alumno.sueldo},idEstadoOrigen={alumno.idEstadoOrigen},idEstatus= {alumno.idEstatus} where id={alumno.id}";
            try
            {
                using (SqlConnection con = new SqlConnection(_connString))
                {
                    comando = new SqlCommand(query, con);
                    comando.CommandType = CommandType.Text;
                    con.Open();
                    comando.ExecuteNonQuery();
                    Console.WriteLine("Record updated Successfully");
                    con.Close();
                    Console.ReadKey();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
        }
        public void Eliminar(int id) {
            string query;
            SqlCommand comando;
            query = $"delete Alumnos where id = {id}";
            try
            {
                using (SqlConnection con = new SqlConnection(_connString))
                {
                    comando = new SqlCommand(query, con);
                    comando.CommandType = CommandType.Text;
                    con.Open();
                    comando.ExecuteNonQuery();
                    Console.WriteLine("Record deleted Successfully");
                    con.Close();
                    Console.ReadKey();
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("OOPs, something went wrong." + e);
            }
        }
    }
}
