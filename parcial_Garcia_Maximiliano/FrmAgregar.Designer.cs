namespace parcial_Garcia_Maximiliano
{
    partial class FrmAgregar
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCasa = new System.Windows.Forms.Label();
            this.cbxCasa = new System.Windows.Forms.ComboBox();
            this.gbxHechizos = new System.Windows.Forms.GroupBox();
            this.lblHechizos = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.dgvHechizos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbxHechizos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHechizos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(126, 71);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(235, 71);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(357, 26);
            this.txtNombre.TabIndex = 1;
            // 
            // lblCasa
            // 
            this.lblCasa.AutoSize = true;
            this.lblCasa.Location = new System.Drawing.Point(126, 125);
            this.lblCasa.Name = "lblCasa";
            this.lblCasa.Size = new System.Drawing.Size(46, 20);
            this.lblCasa.TabIndex = 2;
            this.lblCasa.Text = "Casa";
            // 
            // cbxCasa
            // 
            this.cbxCasa.FormattingEnabled = true;
            this.cbxCasa.Location = new System.Drawing.Point(235, 125);
            this.cbxCasa.Name = "cbxCasa";
            this.cbxCasa.Size = new System.Drawing.Size(357, 28);
            this.cbxCasa.TabIndex = 3;
            // 
            // gbxHechizos
            // 
            this.gbxHechizos.Controls.Add(this.lblHechizos);
            this.gbxHechizos.Controls.Add(this.btnSeleccionar);
            this.gbxHechizos.Controls.Add(this.dgvHechizos);
            this.gbxHechizos.Location = new System.Drawing.Point(27, 186);
            this.gbxHechizos.Name = "gbxHechizos";
            this.gbxHechizos.Size = new System.Drawing.Size(694, 358);
            this.gbxHechizos.TabIndex = 4;
            this.gbxHechizos.TabStop = false;
            this.gbxHechizos.Text = "Hechizos";
            // 
            // lblHechizos
            // 
            this.lblHechizos.AutoSize = true;
            this.lblHechizos.Location = new System.Drawing.Point(20, 291);
            this.lblHechizos.Name = "lblHechizos";
            this.lblHechizos.Size = new System.Drawing.Size(51, 20);
            this.lblHechizos.TabIndex = 2;
            this.lblHechizos.Text = "label3";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(271, 241);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(110, 40);
            this.btnSeleccionar.TabIndex = 1;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // dgvHechizos
            // 
            this.dgvHechizos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHechizos.Location = new System.Drawing.Point(14, 25);
            this.dgvHechizos.Name = "dgvHechizos";
            this.dgvHechizos.RowTemplate.Height = 28;
            this.dgvHechizos.Size = new System.Drawing.Size(674, 210);
            this.dgvHechizos.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(211, 550);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 50);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(404, 550);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 50);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // FrmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 630);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gbxHechizos);
            this.Controls.Add(this.cbxCasa);
            this.Controls.Add(this.lblCasa);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "FrmAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AGREGAR MAGO";
            this.Load += new System.EventHandler(this.FrmAgregar_Load);
            this.gbxHechizos.ResumeLayout(false);
            this.gbxHechizos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHechizos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCasa;
        private System.Windows.Forms.ComboBox cbxCasa;
        private System.Windows.Forms.GroupBox gbxHechizos;
        private System.Windows.Forms.Label lblHechizos;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DataGridView dgvHechizos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSalir;
    }
}