namespace parcial_Garcia_Maximiliano
{
    partial class FrmHechizos
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
            this.dvgLista = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvgLista)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgLista
            // 
            this.dvgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgLista.Location = new System.Drawing.Point(12, 22);
            this.dvgLista.Name = "dvgLista";
            this.dvgLista.RowTemplate.Height = 28;
            this.dvgLista.Size = new System.Drawing.Size(971, 262);
            this.dvgLista.TabIndex = 0;
            // 
            // FrmHechizos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 314);
            this.Controls.Add(this.dvgLista);
            this.Name = "FrmHechizos";
            this.Text = "LISTA DE HECHIZOS";
            this.Load += new System.EventHandler(this.FrmHechizos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgLista;
    }
}