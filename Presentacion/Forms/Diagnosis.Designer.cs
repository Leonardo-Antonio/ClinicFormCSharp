using System.ComponentModel;

namespace Presentacion.Forms
{
    partial class Diagnosis
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
            this.button4 = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_antecedente = new System.Windows.Forms.TextBox();
            this.txt_enfermedad = new System.Windows.Forms.TextBox();
            this.txt_motivo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_numHC = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (249)))), ((int) (((byte) (88)))), ((int) (((byte) (155)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(472, 327);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 56);
            this.button4.TabIndex = 122;
            this.button4.Text = "Generar Informe";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (249)))), ((int) (((byte) (88)))), ((int) (((byte) (155)))));
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btn_add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add.Location = new System.Drawing.Point(28, 337);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(81, 36);
            this.btn_add.TabIndex = 121;
            this.btn_add.Text = "Agregar";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_antecedente
            // 
            this.txt_antecedente.Location = new System.Drawing.Point(28, 277);
            this.txt_antecedente.Name = "txt_antecedente";
            this.txt_antecedente.Size = new System.Drawing.Size(574, 20);
            this.txt_antecedente.TabIndex = 120;
            // 
            // txt_enfermedad
            // 
            this.txt_enfermedad.Location = new System.Drawing.Point(28, 208);
            this.txt_enfermedad.Name = "txt_enfermedad";
            this.txt_enfermedad.Size = new System.Drawing.Size(574, 20);
            this.txt_enfermedad.TabIndex = 119;
            // 
            // txt_motivo
            // 
            this.txt_motivo.Location = new System.Drawing.Point(28, 140);
            this.txt_motivo.Name = "txt_motivo";
            this.txt_motivo.Size = new System.Drawing.Size(574, 20);
            this.txt_motivo.TabIndex = 118;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.Location = new System.Drawing.Point(25, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 16);
            this.label4.TabIndex = 117;
            this.label4.Text = "Antecedentes Patológicos del Paciente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(25, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 16);
            this.label3.TabIndex = 116;
            this.label3.Text = "Historia de la Enfermedad Actual del Paciente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(25, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 16);
            this.label2.TabIndex = 115;
            this.label2.Text = "Motivos de Consulta del Paciente:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label9.Location = new System.Drawing.Point(25, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 16);
            this.label9.TabIndex = 114;
            this.label9.Text = "Datos del Paciente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label5.Location = new System.Drawing.Point(25, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 17);
            this.label5.TabIndex = 113;
            this.label5.Text = "N° de Historia Clinica:";
            // 
            // txt_numHC
            // 
            this.txt_numHC.Location = new System.Drawing.Point(28, 80);
            this.txt_numHC.Name = "txt_numHC";
            this.txt_numHC.Size = new System.Drawing.Size(176, 20);
            this.txt_numHC.TabIndex = 112;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (249)))), ((int) (((byte) (88)))), ((int) (((byte) (155)))));
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btn_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_update.Location = new System.Drawing.Point(123, 337);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(81, 36);
            this.btn_update.TabIndex = 123;
            this.btn_update.Text = "Actualizar";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // lbl_ID
            // 
            this.lbl_ID.Location = new System.Drawing.Point(513, 55);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(51, 23);
            this.lbl_ID.TabIndex = 124;
            // 
            // Diagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 402);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_antecedente);
            this.Controls.Add(this.txt_enfermedad);
            this.Controls.Add(this.txt_motivo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_numHC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Diagnosis";
            this.Text = "Diagnosis";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lbl_ID;

        private System.Windows.Forms.Button btn_update;

        private System.Windows.Forms.TextBox txt_antecedente;

        private System.Windows.Forms.TextBox txt_enfermedad;

        private System.Windows.Forms.TextBox txt_motivo;

        private System.Windows.Forms.TextBox txt_numHC;

        private System.Windows.Forms.Button btn_add;

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;

        #endregion
    }
}