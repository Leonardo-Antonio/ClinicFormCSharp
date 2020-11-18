using System;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace Presentacion.Forms
{
    public partial class Diagnosis : Form
    {
        EDiagnosis _eDiagnosis = new EDiagnosis();
        NDiagnosis _nDiagnosis = new NDiagnosis();
        public Diagnosis()
        {
            InitializeComponent();
            this.FillInTheFields();
            lbl_ID.Hide();
        }

        private void get_data()
        {
            _eDiagnosis.ID = int.Parse(lbl_ID.Text);
            _eDiagnosis.IDClinicHistory = Int32.Parse(txt_numHC.Text);
            _eDiagnosis.ReasonsForConsultation = txt_motivo.Text;
            _eDiagnosis.CurrentIllness = txt_enfermedad.Text;
            _eDiagnosis.PathologicalHistory = txt_antecedente.Text;
            _eDiagnosis.IDDdoctor = LogInDoc.ID;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            this.get_data();
            var response = _nDiagnosis.SaveDiagnosis(_eDiagnosis);
            MessageBox.Show(response);
        }

        private void FillInTheFields()
        {
            if (DiagnosisDoc.ID == 0)
                return;
            lbl_ID.Text = DiagnosisDoc.ID.ToString();
            txt_numHC.Text = DiagnosisDoc.IDHC.ToString();
            txt_motivo.Text = DiagnosisDoc.ReasonsForConsultation;
            txt_enfermedad.Text = DiagnosisDoc.CurrentIllness;
            txt_antecedente.Text = DiagnosisDoc.PathologicalHistory;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                this.get_data();
                MessageBox.Show(txt_motivo.Text);
                var response = _nDiagnosis.Update(_eDiagnosis);
                MessageBox.Show(response);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }
    }
}