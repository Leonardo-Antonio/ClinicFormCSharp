using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class DPatient
    {
        Connection cn = new Connection();

        public DataTable ListIDType(EPatient _ePatient)
        {
            const string sql = "SELECT " +
                                "tb_dgs.id, " +
                                "CONCAT(tb_pt.name , ' ', tb_pt.a_p , ' ', tb_pt.a_m ) 'FullName', " +
                                "tb_pt.id 'DNI' , tb_idtype.type,  " +
                                "reasons_for_consultation,  " +
                                "current_illness, pathological_history,  " +
                                "currentDate, tb_dgs.id_clinic_history, " +
                                "tb_sp.speciality " +
                                    "FROM tb_diagnosis tb_dgs " +
                                "LEFT JOIN tb_patient tb_pt " +
                                "ON ( tb_dgs.id_clinic_history = tb_pt.id_clinic_history ) " +
                                "LEFT JOIN tb_type_identification tb_idtype " +
                                "ON ( tb_pt.id_type_identification = tb_idtype.id ) " +
                                "LEFT JOIN tb_doctor tb_doc " +
                                "ON ( tb_dgs.id_doctor = tb_doc.id ) " +
                                "LEFT JOIN tb_speciality tb_sp " +
                                "ON ( tb_doc.id_speciality= tb_sp.id ) " +
                                "WHERE  " +
                                "tb_pt.id = @id " +
                                "OR   " +
                                "CONCAT(tb_pt.name , ' ', tb_pt.a_p , ' ', tb_pt.a_m ) LIKE '%' + @fullname + '%' "; 
            try
            {
                var cmd = new SqlCommand(sql, cn.DB());
                cmd.Parameters.AddWithValue("@id", _ePatient.ID);
                cmd.Parameters.AddWithValue("@fullname", _ePatient.FullName);
                var data = new SqlDataAdapter(cmd);
                var dt = new DataTable();
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