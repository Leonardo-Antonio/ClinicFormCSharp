using System;
using System.Windows.Forms;
using Entidades;
using Negocio;
using Presentacion.Forms;

namespace Presentacion
{
    public partial class Main : Form
    {
        EDoctor _eDoctor = new EDoctor();
        NDoctor _nDoctor = new NDoctor();
        public Main()
        {
            InitializeComponent();
        }

        private void Login()
        {
            _eDoctor.DNI = txt_dni.Text;
            _eDoctor.Password = txt_password.Text;
            try
            {
                var data = _nDoctor.Log_in(_eDoctor);
                MessageBox.Show($"Welcome {data.Rows[0]["name"].ToString()}");
                LogInDoc.User = true;
                LogInDoc.ID = Byte.Parse(data.Rows[0]["id"].ToString());
                LogInDoc.FullName = $"{data.Rows[0]["name"]} {data.Rows[0]["a_p"]} {data.Rows[0]["a_m"]}";
                LogInDoc.DNI = data.Rows[0]["dni"].ToString();
                lbl_fullname.Text = LogInDoc.FullName;
                lbl_dni.Text = $"DNI: {LogInDoc.DNI}";
                OpenForm(new Diagnosis());
                pnl_login.Enabled = false;
                btn_diagnosis.Enabled = true;
                btn_search.Enabled = true;
                btn_LogIn.Enabled = false;
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("User does not exist");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OpenForm(Form form)
        {
            if (this.pnl_main.Controls.Count > 0)
                this.pnl_main.Controls.RemoveAt(0);
            
            form.TopLevel = false;
            this.pnl_main.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (!LogInDoc.User)
            {
                btn_diagnosis.Enabled = false;
                btn_search.Enabled = false;
            }
        }

        private void btn_poweroff_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btn_s_Click(object sender, EventArgs e)
        {
            OpenForm(new Diagnosis());
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            OpenForm(new SearchDiagnosis());
        }

        private void btn_diagnosis_Click(object sender, EventArgs e)
        {
            OpenForm(new Diagnosis());
        }

        private void btn_LogInUser_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}