using System;
using System.Data;
using System.Data.SqlClient;
using Datos.Valid;
using Entidades;

namespace Datos
{
    public class DDiagnosis
    {
        Connection cn = new Connection();

        public DataTable ListDiagnosis(EPatient _ePatient)
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
        }
        public string SaveDiagnosis(EDiagnosis eDiagnosis)
        {
            var msj = "";
            const string sql = "INSERT INTO tb_diagnosis ( " +
                               "reasons_for_consultation, " +
                               "current_illness, " +
                               "pathological_history, " +
                               "id_clinic_history, " +
                               "id_doctor ) " +
                               "VALUES (@rc, @ci, @ph, @idhc, @iddoc)";
            try
            {
                var cmd = new SqlCommand(sql, cn.DB());
                if ( String.IsNullOrEmpty(eDiagnosis.ReasonsForConsultation) ) 
                    cmd.Parameters.AddWithValue("@rc", Null.String(eDiagnosis.ReasonsForConsultation));
                else
                    cmd.Parameters.AddWithValue("@rc", eDiagnosis.ReasonsForConsultation);
                
                if ( String.IsNullOrEmpty(eDiagnosis.CurrentIllness) ) 
                    cmd.Parameters.AddWithValue("@ci", Null.String(eDiagnosis.CurrentIllness));
                else
                    cmd.Parameters.AddWithValue("@ci", eDiagnosis.CurrentIllness);
                
                if ( String.IsNullOrEmpty(eDiagnosis.PathologicalHistory) ) 
                    cmd.Parameters.AddWithValue("@ph", Null.String(eDiagnosis.PathologicalHistory));
                else
                    cmd.Parameters.AddWithValue("@ph", eDiagnosis.PathologicalHistory);
                
                cmd.Parameters.AddWithValue("@idhc", eDiagnosis.IDClinicHistory);
                cmd.Parameters.AddWithValue("@iddoc", eDiagnosis.IDDdoctor);
                cn.DB().Open();
                var response = cmd.ExecuteNonQuery();
                msj = response != 1 ? "Row not Affected" : "Diagnosis created successfully";
                return msj;
            }
            catch (Exception e)
            {
                msj = $"diagnosis could not be created {e.Message}";
                return msj;
            }
            finally
            {
                cn.DB().Close();
            }
        }

        public string Delete(int ID)
        {
            var msj = "";
            const string sql = "DELETE FROM tb_diagnosis WHERE id = @id";
            try
            {
                var cmd = new SqlCommand(sql, cn.DB());
                cmd.Parameters.AddWithValue("@id", ID);
                cn.DB().Open();
                var rowAffected = cmd.ExecuteNonQuery();
                msj = rowAffected != 1 ? "was successfully removed" : "diagnosis could not be removed";
                return msj;
            }
            catch (Exception e)
            {
                msj = $"diagnosis could not be removed {e.Message}";
                throw;
            }
            finally
            {
                cn.DB().Close();
            }
        }

        public string Update(EDiagnosis eDiagnosis)
        {
            var msj = "";
            const string sql = "UPDATE tb_diagnosis SET " +
                               "reasons_for_consultation = @rc, " +
                               "current_illness = @ci, " +
                               "pathological_history = @ph, " +
                               "id_clinic_history = @idhc " +
                               "WHERE id = @id";
            try
            {
                var cmd = new SqlCommand(sql, cn.DB());
                if ( String.IsNullOrEmpty(eDiagnosis.ReasonsForConsultation) ) 
                    cmd.Parameters.AddWithValue("@rc", Null.String(eDiagnosis.ReasonsForConsultation));
                else
                    cmd.Parameters.AddWithValue("@rc", eDiagnosis.ReasonsForConsultation);
                
                if ( String.IsNullOrEmpty(eDiagnosis.CurrentIllness) ) 
                    cmd.Parameters.AddWithValue("@ci", Null.String(eDiagnosis.CurrentIllness));
                else
                    cmd.Parameters.AddWithValue("@ci", eDiagnosis.CurrentIllness);
                
                if ( String.IsNullOrEmpty(eDiagnosis.PathologicalHistory) ) 
                    cmd.Parameters.AddWithValue("@ph", Null.String(eDiagnosis.PathologicalHistory));
                else
                    cmd.Parameters.AddWithValue("@ph", eDiagnosis.PathologicalHistory);
                
                cmd.Parameters.AddWithValue("@idhc", eDiagnosis.IDClinicHistory);
                cmd.Parameters.AddWithValue("@id", eDiagnosis.ID);
                cn.DB().Open();
                var response = cmd.ExecuteNonQuery();
                msj = response != 1 ? "Row not Affected" : "Diagnosis updated successfully";
                return msj;
            }
            catch (Exception e)
            {
                msj = $"diagnosis could not be updated {e.Message}";
                return msj;
            }
            finally
            {
                cn.DB().Close();
            }
        }
    }
}