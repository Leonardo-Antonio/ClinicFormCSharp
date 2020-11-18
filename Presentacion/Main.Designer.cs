using System.ComponentModel;

namespace Presentacion
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pnl_sidebar = new System.Windows.Forms.Panel();
            this.btn_diagnosis = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_search = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_poweroff = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_LogIn = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnl_move = new System.Windows.Forms.Panel();
            this.lbl_dni = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_fullname = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.header = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnl_main = new System.Windows.Forms.Panel();
            this.pnl_login = new System.Windows.Forms.Panel();
            this.lbl_password = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbldni = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_dni = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_LogInUser = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pnl_sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_diagnosis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_poweroff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_LogIn)).BeginInit();
            this.pnl_move.SuspendLayout();
            this.pnl_main.SuspendLayout();
            this.pnl_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_sidebar
            // 
            this.pnl_sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnl_sidebar.Controls.Add(this.btn_diagnosis);
            this.pnl_sidebar.Controls.Add(this.btn_search);
            this.pnl_sidebar.Controls.Add(this.btn_poweroff);
            this.pnl_sidebar.Controls.Add(this.panel2);
            this.pnl_sidebar.Controls.Add(this.btn_LogIn);
            this.pnl_sidebar.Location = new System.Drawing.Point(0, 0);
            this.pnl_sidebar.Name = "pnl_sidebar";
            this.pnl_sidebar.Size = new System.Drawing.Size(49, 435);
            this.pnl_sidebar.TabIndex = 2;
            // 
            // btn_diagnosis
            // 
            this.btn_diagnosis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_diagnosis.BackColor = System.Drawing.Color.Transparent;
            this.btn_diagnosis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_diagnosis.Image = ((System.Drawing.Image)(resources.GetObject("btn_diagnosis.Image")));
            this.btn_diagnosis.ImageActive = null;
            this.btn_diagnosis.Location = new System.Drawing.Point(0, 106);
            this.btn_diagnosis.Name = "btn_diagnosis";
            this.btn_diagnosis.Size = new System.Drawing.Size(49, 41);
            this.btn_diagnosis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_diagnosis.TabIndex = 7;
            this.btn_diagnosis.TabStop = false;
            this.btn_diagnosis.Zoom = 13;
            this.btn_diagnosis.Click += new System.EventHandler(this.btn_diagnosis_Click);
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.ImageActive = null;
            this.btn_search.Location = new System.Drawing.Point(0, 153);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(49, 41);
            this.btn_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_search.TabIndex = 6;
            this.btn_search.TabStop = false;
            this.btn_search.Zoom = 13;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_poweroff
            // 
            this.btn_poweroff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_poweroff.BackColor = System.Drawing.Color.Transparent;
            this.btn_poweroff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_poweroff.Image = ((System.Drawing.Image)(resources.GetObject("btn_poweroff.Image")));
            this.btn_poweroff.ImageActive = null;
            this.btn_poweroff.Location = new System.Drawing.Point(0, 394);
            this.btn_poweroff.Name = "btn_poweroff";
            this.btn_poweroff.Size = new System.Drawing.Size(46, 41);
            this.btn_poweroff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_poweroff.TabIndex = 5;
            this.btn_poweroff.TabStop = false;
            this.btn_poweroff.Zoom = 13;
            this.btn_poweroff.Click += new System.EventHandler(this.btn_poweroff_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(55, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 3;
            // 
            // btn_LogIn
            // 
            this.btn_LogIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_LogIn.BackColor = System.Drawing.Color.Transparent;
            this.btn_LogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LogIn.Image = ((System.Drawing.Image)(resources.GetObject("btn_LogIn.Image")));
            this.btn_LogIn.ImageActive = null;
            this.btn_LogIn.Location = new System.Drawing.Point(0, 59);
            this.btn_LogIn.Name = "btn_LogIn";
            this.btn_LogIn.Size = new System.Drawing.Size(49, 41);
            this.btn_LogIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_LogIn.TabIndex = 4;
            this.btn_LogIn.TabStop = false;
            this.btn_LogIn.Zoom = 13;
            // 
            // pnl_move
            // 
            this.pnl_move.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_move.Controls.Add(this.lbl_dni);
            this.pnl_move.Controls.Add(this.lbl_fullname);
            this.pnl_move.Location = new System.Drawing.Point(55, 0);
            this.pnl_move.Name = "pnl_move";
            this.pnl_move.Size = new System.Drawing.Size(671, 27);
            this.pnl_move.TabIndex = 3;
            // 
            // lbl_dni
            // 
            this.lbl_dni.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_dni.Location = new System.Drawing.Point(537, 0);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(134, 27);
            this.lbl_dni.TabIndex = 1;
            this.lbl_dni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_fullname
            // 
            this.lbl_fullname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_fullname.Location = new System.Drawing.Point(3, 0);
            this.lbl_fullname.Name = "lbl_fullname";
            this.lbl_fullname.Size = new System.Drawing.Size(134, 27);
            this.lbl_fullname.TabIndex = 0;
            this.lbl_fullname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // header
            // 
            this.header.Fixed = true;
            this.header.Horizontal = true;
            this.header.TargetControl = this.pnl_move;
            this.header.Vertical = true;
            // 
            // pnl_main
            // 
            this.pnl_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_main.Controls.Add(this.pnl_login);
            this.pnl_main.Location = new System.Drawing.Point(55, 33);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(671, 402);
            this.pnl_main.TabIndex = 4;
            // 
            // pnl_login
            // 
            this.pnl_login.Controls.Add(this.lbl_password);
            this.pnl_login.Controls.Add(this.lbldni);
            this.pnl_login.Controls.Add(this.txt_dni);
            this.pnl_login.Controls.Add(this.btn_LogInUser);
            this.pnl_login.Controls.Add(this.txt_password);
            this.pnl_login.Location = new System.Drawing.Point(166, 73);
            this.pnl_login.Name = "pnl_login";
            this.pnl_login.Size = new System.Drawing.Size(390, 240);
            this.pnl_login.TabIndex = 12;
            // 
            // lbl_password
            // 
            this.lbl_password.Location = new System.Drawing.Point(22, 89);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(78, 15);
            this.lbl_password.TabIndex = 9;
            this.lbl_password.Text = "Password:";
            this.lbl_password.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbldni
            // 
            this.lbldni.Location = new System.Drawing.Point(22, 26);
            this.lbldni.Name = "lbldni";
            this.lbldni.Size = new System.Drawing.Size(100, 15);
            this.lbldni.TabIndex = 8;
            this.lbldni.Text = "DNI:";
            this.lbldni.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txt_dni
            // 
            this.txt_dni.BackColor = System.Drawing.Color.White;
            this.txt_dni.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_dni.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_dni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_dni.HintForeColor = System.Drawing.Color.Empty;
            this.txt_dni.HintText = "";
            this.txt_dni.isPassword = false;
            this.txt_dni.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_dni.LineIdleColor = System.Drawing.Color.Transparent;
            this.txt_dni.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_dni.LineThickness = 3;
            this.txt_dni.Location = new System.Drawing.Point(22, 41);
            this.txt_dni.Margin = new System.Windows.Forms.Padding(4);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(346, 39);
            this.txt_dni.TabIndex = 3;
            this.txt_dni.Text = "78965413";
            this.txt_dni.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_LogInUser
            // 
            this.btn_LogInUser.ActiveBorderThickness = 1;
            this.btn_LogInUser.ActiveCornerRadius = 20;
            this.btn_LogInUser.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_LogInUser.ActiveForecolor = System.Drawing.Color.White;
            this.btn_LogInUser.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_LogInUser.BackColor = System.Drawing.SystemColors.Control;
            this.btn_LogInUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_LogInUser.BackgroundImage")));
            this.btn_LogInUser.ButtonText = "Ingresar";
            this.btn_LogInUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LogInUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogInUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_LogInUser.IdleBorderThickness = 1;
            this.btn_LogInUser.IdleCornerRadius = 20;
            this.btn_LogInUser.IdleFillColor = System.Drawing.Color.White;
            this.btn_LogInUser.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_LogInUser.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_LogInUser.Location = new System.Drawing.Point(22, 156);
            this.btn_LogInUser.Margin = new System.Windows.Forms.Padding(5);
            this.btn_LogInUser.Name = "btn_LogInUser";
            this.btn_LogInUser.Size = new System.Drawing.Size(346, 51);
            this.btn_LogInUser.TabIndex = 7;
            this.btn_LogInUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_LogInUser.Click += new System.EventHandler(this.btn_LogInUser_Click);
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.White;
            this.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_password.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_password.HintForeColor = System.Drawing.Color.Empty;
            this.txt_password.HintText = "";
            this.txt_password.isPassword = false;
            this.txt_password.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_password.LineIdleColor = System.Drawing.Color.Transparent;
            this.txt_password.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_password.LineThickness = 3;
            this.txt_password.Location = new System.Drawing.Point(22, 108);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(346, 39);
            this.txt_password.TabIndex = 4;
            this.txt_password.Text = "password";
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 436);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.pnl_move);
            this.Controls.Add(this.pnl_sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnl_sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_diagnosis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_poweroff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_LogIn)).EndInit();
            this.pnl_move.ResumeLayout(false);
            this.pnl_main.ResumeLayout(false);
            this.pnl_login.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private Bunifu.Framework.UI.BunifuCustomLabel lbldni;

        private Bunifu.Framework.UI.BunifuCustomLabel lbl_password;

        private System.Windows.Forms.Panel pnl_login;

        private Bunifu.Framework.UI.BunifuThinButton2 btn_LogInUser;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_dni;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_password;

        private Bunifu.Framework.UI.BunifuCustomLabel lbl_dni;

        private Bunifu.Framework.UI.BunifuCustomLabel lbl_fullname;

        private Bunifu.Framework.UI.BunifuImageButton btn_diagnosis;

        private Bunifu.Framework.UI.BunifuImageButton btn_search;

        private System.Windows.Forms.Panel pnl_main;

        private Bunifu.Framework.UI.BunifuImageButton btn_poweroff;

        private Bunifu.Framework.UI.BunifuDragControl header;
        private System.Windows.Forms.Panel pnl_move;
        private System.Windows.Forms.Panel pnl_sidebar;

        private System.Windows.Forms.Panel panel2;

        private Bunifu.Framework.UI.BunifuImageButton btn_LogIn;

        #endregion
    }
}