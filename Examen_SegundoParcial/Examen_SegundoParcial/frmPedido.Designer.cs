namespace Ejercicicio03
{
    partial class frmPedido
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.IdPedidTextBox = new System.Windows.Forms.TextBox();
            this.NombreClienTextBox = new System.Windows.Forms.TextBox();
            this.CdgProductoTextBox = new System.Windows.Forms.TextBox();
            this.CantidTextBox = new System.Windows.Forms.TextBox();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.DescpTextBox = new System.Windows.Forms.TextBox();
            this.PedidoGridView1 = new System.Windows.Forms.DataGridView();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PedidoGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo del Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Id Pedido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(326, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Descripcion";
            // 
            // IdPedidTextBox
            // 
            this.IdPedidTextBox.Enabled = false;
            this.IdPedidTextBox.Location = new System.Drawing.Point(130, 21);
            this.IdPedidTextBox.Name = "IdPedidTextBox";
            this.IdPedidTextBox.Size = new System.Drawing.Size(100, 20);
            this.IdPedidTextBox.TabIndex = 6;
            // 
            // NombreClienTextBox
            // 
            this.NombreClienTextBox.Enabled = false;
            this.NombreClienTextBox.Location = new System.Drawing.Point(130, 54);
            this.NombreClienTextBox.Name = "NombreClienTextBox";
            this.NombreClienTextBox.Size = new System.Drawing.Size(100, 20);
            this.NombreClienTextBox.TabIndex = 7;
            // 
            // CdgProductoTextBox
            // 
            this.CdgProductoTextBox.Enabled = false;
            this.CdgProductoTextBox.Location = new System.Drawing.Point(130, 112);
            this.CdgProductoTextBox.Name = "CdgProductoTextBox";
            this.CdgProductoTextBox.Size = new System.Drawing.Size(100, 20);
            this.CdgProductoTextBox.TabIndex = 9;
            this.CdgProductoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CodigoProductoTextBox_KeyPress);
            // 
            // CantidTextBox
            // 
            this.CantidTextBox.Enabled = false;
            this.CantidTextBox.Location = new System.Drawing.Point(130, 86);
            this.CantidTextBox.Name = "CantidTextBox";
            this.CantidTextBox.Size = new System.Drawing.Size(100, 20);
            this.CantidTextBox.TabIndex = 8;
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Enabled = false;
            this.TotalTextBox.Location = new System.Drawing.Point(130, 138);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.TotalTextBox.TabIndex = 10;
            // 
            // DescpTextBox
            // 
            this.DescpTextBox.Enabled = false;
            this.DescpTextBox.Location = new System.Drawing.Point(403, 86);
            this.DescpTextBox.Name = "DescpTextBox";
            this.DescpTextBox.Size = new System.Drawing.Size(147, 20);
            this.DescpTextBox.TabIndex = 11;
            // 
            // PedidoGridView1
            // 
            this.PedidoGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PedidoGridView1.Location = new System.Drawing.Point(2, 222);
            this.PedidoGridView1.Name = "PedidoGridView1";
            this.PedidoGridView1.ReadOnly = true;
            this.PedidoGridView1.Size = new System.Drawing.Size(653, 180);
            this.PedidoGridView1.TabIndex = 12;
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(223, 178);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(75, 23);
            this.NuevoButton.TabIndex = 1;
            this.NuevoButton.Text = "NUEVO";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click_1);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Enabled = false;
            this.GuardarButton.Location = new System.Drawing.Point(351, 178);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 23);
            this.GuardarButton.TabIndex = 11;
            this.GuardarButton.Text = "GUARDAR";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(352, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Precio";
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.Enabled = false;
            this.PrecioTextBox.Location = new System.Drawing.Point(403, 115);
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.Size = new System.Drawing.Size(147, 20);
            this.PrecioTextBox.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(427, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Datos Del Producto";
            // 
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 402);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PrecioTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.PedidoGridView1);
            this.Controls.Add(this.DescpTextBox);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.CantidTextBox);
            this.Controls.Add(this.CdgProductoTextBox);
            this.Controls.Add(this.NombreClienTextBox);
            this.Controls.Add(this.IdPedidTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPedido";
            this.Text = "Vista De Pedidos";
            this.Load += new System.EventHandler(this.PedidoVista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PedidoGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IdPedidTextBox;
        private System.Windows.Forms.TextBox NombreClienTextBox;
        private System.Windows.Forms.TextBox CdgProductoTextBox;
        private System.Windows.Forms.TextBox CantidTextBox;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.TextBox DescpTextBox;
        private System.Windows.Forms.DataGridView PedidoGridView1;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox PrecioTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}