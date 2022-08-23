namespace Administración_de_Empleados
{
    partial class Nuevo_Empleado
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
            this.lblnombrecompleto = new System.Windows.Forms.Label();
            this.lbldni = new System.Windows.Forms.Label();
            this.lbledad = new System.Windows.Forms.Label();
            this.lblcasado = new System.Windows.Forms.Label();
            this.lblsalario = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.cmbcasado = new System.Windows.Forms.ComboBox();
            this.txtsalario = new System.Windows.Forms.TextBox();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnombrecompleto
            // 
            this.lblnombrecompleto.AutoSize = true;
            this.lblnombrecompleto.Location = new System.Drawing.Point(54, 48);
            this.lblnombrecompleto.Name = "lblnombrecompleto";
            this.lblnombrecompleto.Size = new System.Drawing.Size(94, 13);
            this.lblnombrecompleto.TabIndex = 0;
            this.lblnombrecompleto.Text = "Nombre Completo:";
            // 
            // lbldni
            // 
            this.lbldni.AutoSize = true;
            this.lbldni.Location = new System.Drawing.Point(119, 89);
            this.lbldni.Name = "lbldni";
            this.lbldni.Size = new System.Drawing.Size(29, 13);
            this.lbldni.TabIndex = 1;
            this.lbldni.Text = "DNI:";
            // 
            // lbledad
            // 
            this.lbledad.AutoSize = true;
            this.lbledad.Location = new System.Drawing.Point(113, 134);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(35, 13);
            this.lbledad.TabIndex = 2;
            this.lbledad.Text = "Edad:";
            // 
            // lblcasado
            // 
            this.lblcasado.AutoSize = true;
            this.lblcasado.Location = new System.Drawing.Point(102, 179);
            this.lblcasado.Name = "lblcasado";
            this.lblcasado.Size = new System.Drawing.Size(46, 13);
            this.lblcasado.TabIndex = 3;
            this.lblcasado.Text = "Casado:";
            // 
            // lblsalario
            // 
            this.lblsalario.AutoSize = true;
            this.lblsalario.Location = new System.Drawing.Point(106, 225);
            this.lblsalario.Name = "lblsalario";
            this.lblsalario.Size = new System.Drawing.Size(42, 13);
            this.lblsalario.TabIndex = 4;
            this.lblsalario.Text = "Salario:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(166, 41);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(162, 20);
            this.txtnombre.TabIndex = 5;
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(166, 82);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(162, 20);
            this.txtdni.TabIndex = 6;
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(166, 127);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(162, 20);
            this.txtedad.TabIndex = 7;
            // 
            // cmbcasado
            // 
            this.cmbcasado.FormattingEnabled = true;
            this.cmbcasado.Items.AddRange(new object[] {
            "Sí",
            "No"});
            this.cmbcasado.Location = new System.Drawing.Point(166, 171);
            this.cmbcasado.Name = "cmbcasado";
            this.cmbcasado.Size = new System.Drawing.Size(162, 21);
            this.cmbcasado.TabIndex = 8;
            // 
            // txtsalario
            // 
            this.txtsalario.Location = new System.Drawing.Point(166, 218);
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.Size = new System.Drawing.Size(162, 20);
            this.txtsalario.TabIndex = 9;
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(107, 281);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 10;
            this.btnaceptar.Text = "&Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(243, 281);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 11;
            this.btncancelar.Text = "&Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // Nuevo_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 386);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.txtsalario);
            this.Controls.Add(this.cmbcasado);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.txtdni);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lblsalario);
            this.Controls.Add(this.lblcasado);
            this.Controls.Add(this.lbledad);
            this.Controls.Add(this.lbldni);
            this.Controls.Add(this.lblnombrecompleto);
            this.Name = "Nuevo_Empleado";
            this.Text = "Nuevo Empleado";
            this.Load += new System.EventHandler(this.Nuevo_Empleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnombrecompleto;
        private System.Windows.Forms.Label lbldni;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.Label lblcasado;
        private System.Windows.Forms.Label lblsalario;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.ComboBox cmbcasado;
        private System.Windows.Forms.TextBox txtsalario;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
    }
}