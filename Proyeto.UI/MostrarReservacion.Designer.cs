namespace Proyeto.UI
{
    partial class MostrarReservacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MostrarReservacion));
            this.dgvMostrarReservacion = new System.Windows.Forms.DataGridView();
            this.btnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarReservacion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMostrarReservacion
            // 
            this.dgvMostrarReservacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarReservacion.Location = new System.Drawing.Point(48, 45);
            this.dgvMostrarReservacion.MaximumSize = new System.Drawing.Size(467, 350);
            this.dgvMostrarReservacion.MinimumSize = new System.Drawing.Size(467, 350);
            this.dgvMostrarReservacion.Name = "dgvMostrarReservacion";
            this.dgvMostrarReservacion.Size = new System.Drawing.Size(467, 350);
            this.dgvMostrarReservacion.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = global::Proyeto.UI.Properties.Resources.accept;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(219, 401);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(87, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // MostrarReservacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(565, 461);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvMostrarReservacion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(581, 500);
            this.MinimumSize = new System.Drawing.Size(581, 500);
            this.Name = "MostrarReservacion";
            this.Text = "Mostrar Reservacion";
            this.Load += new System.EventHandler(this.MostrarReservacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarReservacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMostrarReservacion;
        private System.Windows.Forms.Button btnAceptar;
    }
}