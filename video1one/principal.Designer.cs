namespace video1one
{
    partial class frminicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblholamundo = new System.Windows.Forms.Label();
            this.btnclic = new System.Windows.Forms.Button();
            this.btnocultar = new System.Windows.Forms.Button();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.lblmostrar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblholamundo
            // 
            this.lblholamundo.AutoSize = true;
            this.lblholamundo.Location = new System.Drawing.Point(85, 47);
            this.lblholamundo.Name = "lblholamundo";
            this.lblholamundo.Size = new System.Drawing.Size(94, 13);
            this.lblholamundo.TabIndex = 6;
            this.lblholamundo.Text = "Hola mundo visual";
            // 
            // btnclic
            // 
            this.btnclic.Location = new System.Drawing.Point(88, 72);
            this.btnclic.Name = "btnclic";
            this.btnclic.Size = new System.Drawing.Size(100, 23);
            this.btnclic.TabIndex = 5;
            this.btnclic.Text = "Hacer clic";
            this.btnclic.UseVisualStyleBackColor = true;
            this.btnclic.Click += new System.EventHandler(this.btnclic_Click);
            // 
            // btnocultar
            // 
            this.btnocultar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnocultar.Location = new System.Drawing.Point(88, 106);
            this.btnocultar.Name = "btnocultar";
            this.btnocultar.Size = new System.Drawing.Size(91, 23);
            this.btnocultar.TabIndex = 4;
            this.btnocultar.Text = "Ocultar";
            this.btnocultar.UseVisualStyleBackColor = true;
            this.btnocultar.Click += new System.EventHandler(this.btnocultar_Click);
            // 
            // btnmostrar
            // 
            this.btnmostrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmostrar.Location = new System.Drawing.Point(88, 151);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(91, 25);
            this.btnmostrar.TabIndex = 1;
            this.btnmostrar.Text = "Mostrar";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(244, 80);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 3;
            this.txtnombre.Text = "Ingresa  nombre";
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(386, 79);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.PasswordChar = '*';
            this.txtapellido.Size = new System.Drawing.Size(100, 20);
            this.txtapellido.TabIndex = 7;
            this.txtapellido.TextChanged += new System.EventHandler(this.txtapellido_TextChanged);
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Location = new System.Drawing.Point(568, 77);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(19, 13);
            this.lblmensaje.TabIndex = 8;
            this.lblmensaje.Text = "....";
            // 
            // btnguardar
            // 
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Location = new System.Drawing.Point(386, 126);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(100, 23);
            this.btnguardar.TabIndex = 9;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // lblmostrar
            // 
            this.lblmostrar.AutoSize = true;
            this.lblmostrar.Location = new System.Drawing.Point(571, 106);
            this.lblmostrar.Name = "lblmostrar";
            this.lblmostrar.Size = new System.Drawing.Size(0, 13);
            this.lblmostrar.TabIndex = 10;
            // 
            // frminicio
            // 
            this.AcceptButton = this.btnguardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1288, 435);
            this.Controls.Add(this.lblmostrar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.btnocultar);
            this.Controls.Add(this.btnclic);
            this.Controls.Add(this.lblholamundo);
            this.Name = "frminicio";
            this.Text = "Ventana principal";
            this.Load += new System.EventHandler(this.frminicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblholamundo;
        private System.Windows.Forms.Button btnclic;
        private System.Windows.Forms.Button btnocultar;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label lblmostrar;
    }
}

