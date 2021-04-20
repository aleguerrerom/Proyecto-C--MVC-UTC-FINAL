namespace Proyeto.UI
{
    partial class IngresarUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngresarUsuario));
            this.txtNombreUsu = new System.Windows.Forms.TextBox();
            this.txtCedulaUsu = new System.Windows.Forms.MaskedTextBox();
            this.dtpAnacimiento = new System.Windows.Forms.DateTimePicker();
            this.cmbPerfil = new System.Windows.Forms.ComboBox();
            this.txtClaveUsu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancelarUsu = new System.Windows.Forms.Button();
            this.btnAgregarUsu = new System.Windows.Forms.Button();
            this.txtUsuarioUs = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNombreUsu
            // 
            this.txtNombreUsu.Location = new System.Drawing.Point(194, 39);
            this.txtNombreUsu.Name = "txtNombreUsu";
            this.txtNombreUsu.Size = new System.Drawing.Size(116, 20);
            this.txtNombreUsu.TabIndex = 0;
            // 
            // txtCedulaUsu
            // 
            this.txtCedulaUsu.Location = new System.Drawing.Point(194, 75);
            this.txtCedulaUsu.Mask = "0-0000-0000";
            this.txtCedulaUsu.Name = "txtCedulaUsu";
            this.txtCedulaUsu.Size = new System.Drawing.Size(116, 20);
            this.txtCedulaUsu.TabIndex = 1;
            // 
            // dtpAnacimiento
            // 
            this.dtpAnacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAnacimiento.Location = new System.Drawing.Point(194, 120);
            this.dtpAnacimiento.Name = "dtpAnacimiento";
            this.dtpAnacimiento.Size = new System.Drawing.Size(116, 20);
            this.dtpAnacimiento.TabIndex = 2;
            // 
            // cmbPerfil
            // 
            this.cmbPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPerfil.FormattingEnabled = true;
            this.cmbPerfil.Items.AddRange(new object[] {
            "Administrator",
            "Supervisor",
            "Consultor"});
            this.cmbPerfil.Location = new System.Drawing.Point(194, 153);
            this.cmbPerfil.Name = "cmbPerfil";
            this.cmbPerfil.Size = new System.Drawing.Size(116, 21);
            this.cmbPerfil.TabIndex = 3;
            this.cmbPerfil.SelectedIndexChanged += new System.EventHandler(this.cmbPerfil_SelectedIndexChanged);
            // 
            // txtClaveUsu
            // 
            this.txtClaveUsu.Location = new System.Drawing.Point(194, 224);
            this.txtClaveUsu.Name = "txtClaveUsu";
            this.txtClaveUsu.PasswordChar = '*';
            this.txtClaveUsu.Size = new System.Drawing.Size(116, 20);
            this.txtClaveUsu.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cedula:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Fecha de Nacimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Perfil:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Usuario:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Clave";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(112, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ingresar Nuevo Usuario";
            // 
            // btnCancelarUsu
            // 
            this.btnCancelarUsu.Image = global::Proyeto.UI.Properties.Resources.cancel;
            this.btnCancelarUsu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarUsu.Location = new System.Drawing.Point(223, 270);
            this.btnCancelarUsu.Name = "btnCancelarUsu";
            this.btnCancelarUsu.Size = new System.Drawing.Size(87, 23);
            this.btnCancelarUsu.TabIndex = 7;
            this.btnCancelarUsu.Text = "Cancelar";
            this.btnCancelarUsu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarUsu.UseVisualStyleBackColor = true;
            this.btnCancelarUsu.Click += new System.EventHandler(this.btnCancelarUsu_Click);
            // 
            // btnAgregarUsu
            // 
            this.btnAgregarUsu.Image = global::Proyeto.UI.Properties.Resources.accept;
            this.btnAgregarUsu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarUsu.Location = new System.Drawing.Point(57, 270);
            this.btnAgregarUsu.Name = "btnAgregarUsu";
            this.btnAgregarUsu.Size = new System.Drawing.Size(87, 23);
            this.btnAgregarUsu.TabIndex = 6;
            this.btnAgregarUsu.Text = "Agregar";
            this.btnAgregarUsu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarUsu.UseVisualStyleBackColor = true;
            this.btnAgregarUsu.Click += new System.EventHandler(this.btnAgregarUsu_Click);
            // 
            // txtUsuarioUs
            // 
            this.txtUsuarioUs.Location = new System.Drawing.Point(194, 191);
            this.txtUsuarioUs.Name = "txtUsuarioUs";
            this.txtUsuarioUs.Size = new System.Drawing.Size(116, 20);
            this.txtUsuarioUs.TabIndex = 4;
            // 
            // IngresarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(390, 311);
            this.Controls.Add(this.txtUsuarioUs);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelarUsu);
            this.Controls.Add(this.btnAgregarUsu);
            this.Controls.Add(this.txtClaveUsu);
            this.Controls.Add(this.cmbPerfil);
            this.Controls.Add(this.dtpAnacimiento);
            this.Controls.Add(this.txtCedulaUsu);
            this.Controls.Add(this.txtNombreUsu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(406, 350);
            this.MinimumSize = new System.Drawing.Size(406, 350);
            this.Name = "IngresarUsuario";
            this.Text = "Agregar Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreUsu;
        private System.Windows.Forms.MaskedTextBox txtCedulaUsu;
        private System.Windows.Forms.DateTimePicker dtpAnacimiento;
        private System.Windows.Forms.ComboBox cmbPerfil;
        private System.Windows.Forms.TextBox txtClaveUsu;
        private System.Windows.Forms.Button btnAgregarUsu;
        private System.Windows.Forms.Button btnCancelarUsu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUsuarioUs;
    }
}