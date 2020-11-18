using System;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace Presentacion.Forms
{
    public partial class SearchDiagnosis : Form
    {
        EPatient _ePatient = new EPatient();
        NDiagnosis _nDiagnosis = new NDiagnosis();
        
        public SearchDiagnosis()
        {
            InitializeComponent();
            ListDiagnosisPatient();
        }

        private void ListDiagnosisPatient()
        {
            _ePatient.FullName = txt_search.text;
            _ePatient.ID = txt_search.text;
            dgv_patients.DataSource = _nDiagnosis.ListDiagnosisPatient(_ePatient);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            ListDiagnosisPatient();
        }

        private void dgv_patients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_id.Text = dgv_patients.Rows[e.RowIndex].Cells["id"].Value.ToString();

            DiagnosisDoc.ID = int.Parse(dgv_patients.Rows[e.RowIndex].Cells["id"].Value.ToString());
            DiagnosisDoc.ReasonsForConsultation = dgv_patients.Rows[e.RowIndex].Cells["reasons_for_consultation"].Value.ToString();
            DiagnosisDoc.CurrentIllness = dgv_patients.Rows[e.RowIndex].Cells["current_illness"].Value.ToString();
            DiagnosisDoc.PathologicalHistory = dgv_patients.Rows[e.RowIndex].Cells["pathological_history"].Value.ToString();
            DiagnosisDoc.IDHC = int.Parse(dgv_patients.Rows[e.RowIndex].Cells["id_clinic_history"].Value.ToString());
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                var response = _nDiagnosis.Delete(Int32.Parse(lbl_id.Text));
                MessageBox.Show(response);
                ListDiagnosisPatient();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }
    }
}