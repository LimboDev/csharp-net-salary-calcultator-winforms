namespace GianniCavalieri_Lab1
{
    partial class CalculadoraSalarioNeto
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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbCedula = new System.Windows.Forms.Label();
            this.lbSalarioBruto = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtSalarioBruto = new System.Windows.Forms.TextBox();
            this.lbSeguroSocial = new System.Windows.Forms.Label();
            this.lbSeguroEducativo = new System.Windows.Forms.Label();
            this.lbSalarioNeto = new System.Windows.Forms.Label();
            this.btCalcular = new System.Windows.Forms.Button();
            this.btCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.SystemColors.Control;
            this.lbTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTitulo.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(226, 65);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(408, 36);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Calculadora de Salario Neto";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbNombre.Location = new System.Drawing.Point(39, 143);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(240, 20);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Ingresar nombre del empleado:";
            // 
            // lbCedula
            // 
            this.lbCedula.AutoSize = true;
            this.lbCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCedula.Location = new System.Drawing.Point(39, 201);
            this.lbCedula.Name = "lbCedula";
            this.lbCedula.Size = new System.Drawing.Size(129, 20);
            this.lbCedula.TabIndex = 2;
            this.lbCedula.Text = "Ingresar cédula:";
            // 
            // lbSalarioBruto
            // 
            this.lbSalarioBruto.AutoSize = true;
            this.lbSalarioBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbSalarioBruto.Location = new System.Drawing.Point(39, 266);
            this.lbSalarioBruto.Name = "lbSalarioBruto";
            this.lbSalarioBruto.Size = new System.Drawing.Size(241, 20);
            this.lbSalarioBruto.TabIndex = 3;
            this.lbSalarioBruto.Text = "Ingresar salario bruto mensual:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Snow;
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNombre.Location = new System.Drawing.Point(326, 137);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(204, 26);
            this.txtNombre.TabIndex = 4;
            // 
            // txtCedula
            // 
            this.txtCedula.BackColor = System.Drawing.Color.Snow;
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCedula.Location = new System.Drawing.Point(326, 195);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(204, 26);
            this.txtCedula.TabIndex = 5;
            // 
            // txtSalarioBruto
            // 
            this.txtSalarioBruto.BackColor = System.Drawing.Color.Snow;
            this.txtSalarioBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSalarioBruto.Location = new System.Drawing.Point(326, 260);
            this.txtSalarioBruto.Name = "txtSalarioBruto";
            this.txtSalarioBruto.Size = new System.Drawing.Size(204, 26);
            this.txtSalarioBruto.TabIndex = 6;
            // 
            // lbSeguroSocial
            // 
            this.lbSeguroSocial.AutoSize = true;
            this.lbSeguroSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbSeguroSocial.Location = new System.Drawing.Point(554, 143);
            this.lbSeguroSocial.Name = "lbSeguroSocial";
            this.lbSeguroSocial.Size = new System.Drawing.Size(0, 20);
            this.lbSeguroSocial.TabIndex = 7;
            // 
            // lbSeguroEducativo
            // 
            this.lbSeguroEducativo.AutoSize = true;
            this.lbSeguroEducativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbSeguroEducativo.Location = new System.Drawing.Point(554, 201);
            this.lbSeguroEducativo.Name = "lbSeguroEducativo";
            this.lbSeguroEducativo.Size = new System.Drawing.Size(0, 20);
            this.lbSeguroEducativo.TabIndex = 8;
            // 
            // lbSalarioNeto
            // 
            this.lbSalarioNeto.AutoSize = true;
            this.lbSalarioNeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbSalarioNeto.Location = new System.Drawing.Point(554, 266);
            this.lbSalarioNeto.Name = "lbSalarioNeto";
            this.lbSalarioNeto.Size = new System.Drawing.Size(0, 20);
            this.lbSalarioNeto.TabIndex = 9;
            // 
            // btCalcular
            // 
            this.btCalcular.BackColor = System.Drawing.Color.Gainsboro;
            this.btCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btCalcular.Location = new System.Drawing.Point(379, 324);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(100, 35);
            this.btCalcular.TabIndex = 10;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = false;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // btCerrar
            // 
            this.btCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btCerrar.Location = new System.Drawing.Point(379, 365);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(100, 35);
            this.btCerrar.TabIndex = 12;
            this.btCerrar.Text = "Cerrar";
            this.btCerrar.UseVisualStyleBackColor = false;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // CalculadoraSalarioNeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(866, 450);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.lbSalarioNeto);
            this.Controls.Add(this.lbSeguroEducativo);
            this.Controls.Add(this.lbSeguroSocial);
            this.Controls.Add(this.txtSalarioBruto);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbSalarioBruto);
            this.Controls.Add(this.lbCedula);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbTitulo);
            this.Name = "CalculadoraSalarioNeto";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbCedula;
        private System.Windows.Forms.Label lbSalarioBruto;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtSalarioBruto;
        private System.Windows.Forms.Label lbSeguroSocial;
        private System.Windows.Forms.Label lbSeguroEducativo;
        private System.Windows.Forms.Label lbSalarioNeto;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Button btCerrar;
    }
}

