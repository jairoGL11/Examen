namespace Ejercicicio03
{
    partial class frmUsuario
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
            this.UsuariodataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariodataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UsuariodataGridView
            // 
            this.UsuariodataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsuariodataGridView.Location = new System.Drawing.Point(13, 13);
            this.UsuariodataGridView.Name = "UsuariodataGridView";
            this.UsuariodataGridView.Size = new System.Drawing.Size(563, 171);
            this.UsuariodataGridView.TabIndex = 0;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 202);
            this.Controls.Add(this.UsuariodataGridView);
            this.Name = "frmUsuario";
            this.Text = "Lista De Usuarios";
            this.Load += new System.EventHandler(this.UsuariosVista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsuariodataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView UsuariodataGridView;
    }
}