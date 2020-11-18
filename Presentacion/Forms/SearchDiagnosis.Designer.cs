using System.ComponentModel;

namespace Presentacion.Forms
{
    partial class SearchDiagnosis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchDiagnosis));
            this.dgv_patients = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new Bunifu.Framework.UI.BunifuTextbox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_patients)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_patients
            // 
            this.dgv_patients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_patients.Location = new System.Drawing.Point(13, 69);
            this.dgv_patients.Name = "dgv_patients";
            this.dgv_patients.Size = new System.Drawing.Size(622, 285);
            this.dgv_patients.TabIndex = 6;
            this.dgv_patients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_patients_CellClick);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(400, 12);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 39);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "buscar";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.SystemColors.Control;
            this.txt_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_search.BackgroundImage")));
            this.txt_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_search.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txt_search.Icon = ((System.Drawing.Image)(resources.GetObject("txt_search.Icon")));
            this.txt_search.Location = new System.Drawing.Point(31, 12);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(344, 39);
            this.txt_search.TabIndex = 4;
            this.txt_search.text = "";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(481, 12);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 39);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "Eliminar";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(497, 53);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(0, 13);
            this.lbl_id.TabIndex = 8;
            // 
            // SearchDiagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 363);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.dgv_patients);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchDiagnosis";
            this.Text = "SearchDiagnosis";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_patients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btn_delete;

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dgv_patients;
        private Bunifu.Framework.UI.BunifuTextbox txt_search;

        #endregion

        private System.Windows.Forms.Label lbl_id;
    }
}