using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class DDoctor
    {
        Connection cn = new Connection();

        public DataTable LogIn(EDoctor eDoctor)
        {
            const string sql = "SELECT " +
                                "id, name, a_p, a_m, dni, password, id_hour, " +
                                "id_speciality " +
                                "FROM tb_doctor " +
                                "WHERE dni = @dni " +
                                "AND " +
                                "password = @password";
            try
            {
                var dt = new DataTable();
                var cmd = new SqlCommand(sql, cn.DB());
                cmd.Parameters.AddWithValue("@dni", eDoctor.DNI);
                cmd.Parameters.AddWithValue("@password", eDoctor.Password);
                var data = new SqlDataAdapter(cmd);
                data.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                cn.DB().Close();
            }

            
        }
    }
}