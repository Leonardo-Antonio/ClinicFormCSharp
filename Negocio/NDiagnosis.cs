using System.Data;
using Datos;
using Entidades;

namespace Negocio
{
    public class NDiagnosis
    {
        private DDiagnosis _dDiagnosis = new DDiagnosis();

        public string SaveDiagnosis(EDiagnosis eDiagnosis)
        {
            return _dDiagnosis.SaveDiagnosis(eDiagnosis);
        }

        public DataTable ListDiagnosisPatient(EPatient ePatient)
        {
            return _dDiagnosis.ListDiagnosis(ePatient);
        }

        public string Delete(int ID)
        {
            if (ID < 0)
            {
                return "The ID entered is invalid";
            }
            return _dDiagnosis.Delete(ID);
        }

        public string Update(EDiagnosis eDiagnosis)
        {
            return _dDiagnosis.Update(eDiagnosis);
        }
    }
}