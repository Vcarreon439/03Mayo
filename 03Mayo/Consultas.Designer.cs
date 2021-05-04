
namespace _03Mayo
{
    partial class frmConsultas
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
            this.rTxtBxDescripcion = new System.Windows.Forms.RichTextBox();
            this.lblPrecio2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rTxtBxDescripcion
            // 
            this.rTxtBxDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rTxtBxDescripcion.Location = new System.Drawing.Point(78, 57);
            this.rTxtBxDescripcion.Name = "rTxtBxDescripcion";
            this.rTxtBxDescripcion.ReadOnly = true;
            this.rTxtBxDescripcion.Size = new System.Drawing.Size(152, 96);
            this.rTxtBxDescripcion.TabIndex = 24;
            this.rTxtBxDescripcion.Text = "";
            // 
            // lblPrecio2
            // 
            this.lblPrecio2.AutoSize = true;
            this.lblPrecio2.Location = new System.Drawing.Point(78, 164);
            this.lblPrecio2.Name = "lblPrecio2";
            this.lblPrecio2.Size = new System.Drawing.Size(63, 13);
            this.lblPrecio2.TabIndex = 23;
            this.lblPrecio2.Text = "**************";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(155, 185);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Precio";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(9, 57);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 20;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(59, 15);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(171, 20);
            this.txtCodigo.TabIndex = 18;
            // 
            // frmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(247, 220);
            this.Controls.Add(this.rTxtBxDescripcion);
            this.Controls.Add(this.lblPrecio2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmConsultas";
            this.Text = "Consultas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTxtBxDescripcion;
        private System.Windows.Forms.Label lblPrecio2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}