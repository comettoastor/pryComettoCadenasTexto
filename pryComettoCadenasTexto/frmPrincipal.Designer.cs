namespace pryComettoLP2SP2
{
    partial class frmPrincipal
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
            this.txtTextoA = new System.Windows.Forms.TextBox();
            this.lblTextoA = new System.Windows.Forms.Label();
            this.cmbTextoC = new System.Windows.Forms.ComboBox();
            this.btnComparar = new System.Windows.Forms.Button();
            this.mrcResultado = new System.Windows.Forms.GroupBox();
            this.lstResultado = new System.Windows.Forms.ListBox();
            this.lblTextoB = new System.Windows.Forms.Label();
            this.lblTextoC = new System.Windows.Forms.Label();
            this.txtTextoB = new System.Windows.Forms.TextBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.btnReemplazar = new System.Windows.Forms.Button();
            this.mrcResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTextoA
            // 
            this.txtTextoA.Location = new System.Drawing.Point(93, 45);
            this.txtTextoA.Name = "txtTextoA";
            this.txtTextoA.Size = new System.Drawing.Size(100, 20);
            this.txtTextoA.TabIndex = 0;
            this.txtTextoA.TextChanged += new System.EventHandler(this.txtTextoA_TextChanged);
            // 
            // lblTextoA
            // 
            this.lblTextoA.AutoSize = true;
            this.lblTextoA.Location = new System.Drawing.Point(43, 48);
            this.lblTextoA.Name = "lblTextoA";
            this.lblTextoA.Size = new System.Drawing.Size(44, 13);
            this.lblTextoA.TabIndex = 1;
            this.lblTextoA.Text = "Texto A";
            // 
            // cmbTextoC
            // 
            this.cmbTextoC.FormattingEnabled = true;
            this.cmbTextoC.Location = new System.Drawing.Point(93, 97);
            this.cmbTextoC.Name = "cmbTextoC";
            this.cmbTextoC.Size = new System.Drawing.Size(100, 21);
            this.cmbTextoC.TabIndex = 2;
            // 
            // btnComparar
            // 
            this.btnComparar.Location = new System.Drawing.Point(44, 161);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(75, 23);
            this.btnComparar.TabIndex = 3;
            this.btnComparar.Text = "Comparar";
            this.btnComparar.UseVisualStyleBackColor = true;
            // 
            // mrcResultado
            // 
            this.mrcResultado.Controls.Add(this.lstResultado);
            this.mrcResultado.Location = new System.Drawing.Point(46, 231);
            this.mrcResultado.Name = "mrcResultado";
            this.mrcResultado.Size = new System.Drawing.Size(147, 120);
            this.mrcResultado.TabIndex = 4;
            this.mrcResultado.TabStop = false;
            this.mrcResultado.Text = "Resultado";
            // 
            // lstResultado
            // 
            this.lstResultado.FormattingEnabled = true;
            this.lstResultado.Location = new System.Drawing.Point(6, 19);
            this.lstResultado.Name = "lstResultado";
            this.lstResultado.Size = new System.Drawing.Size(135, 95);
            this.lstResultado.TabIndex = 5;
            // 
            // lblTextoB
            // 
            this.lblTextoB.AutoSize = true;
            this.lblTextoB.Location = new System.Drawing.Point(43, 74);
            this.lblTextoB.Name = "lblTextoB";
            this.lblTextoB.Size = new System.Drawing.Size(44, 13);
            this.lblTextoB.TabIndex = 6;
            this.lblTextoB.Text = "Texto B";
            // 
            // lblTextoC
            // 
            this.lblTextoC.AutoSize = true;
            this.lblTextoC.Location = new System.Drawing.Point(43, 100);
            this.lblTextoC.Name = "lblTextoC";
            this.lblTextoC.Size = new System.Drawing.Size(44, 13);
            this.lblTextoC.TabIndex = 7;
            this.lblTextoC.Text = "Texto C";
            // 
            // txtTextoB
            // 
            this.txtTextoB.Location = new System.Drawing.Point(93, 71);
            this.txtTextoB.Name = "txtTextoB";
            this.txtTextoB.Size = new System.Drawing.Size(100, 20);
            this.txtTextoB.TabIndex = 9;
            this.txtTextoB.TextChanged += new System.EventHandler(this.txtTextoB_TextChanged);
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(44, 190);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(75, 23);
            this.btnConvertir.TabIndex = 10;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(125, 161);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(206, 162);
            this.txtBuscar.MaxLength = 1;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(27, 20);
            this.txtBuscar.TabIndex = 12;
            this.txtBuscar.Visible = false;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(256, 48);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 13;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(253, 74);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 14;
            this.lblFecha.Text = "Fecha";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(253, 92);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(30, 13);
            this.lblHora.TabIndex = 15;
            this.lblHora.Text = "Hora";
            // 
            // btnReemplazar
            // 
            this.btnReemplazar.Location = new System.Drawing.Point(125, 190);
            this.btnReemplazar.Name = "btnReemplazar";
            this.btnReemplazar.Size = new System.Drawing.Size(75, 23);
            this.btnReemplazar.TabIndex = 16;
            this.btnReemplazar.Text = "Reemplazar";
            this.btnReemplazar.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 383);
            this.Controls.Add(this.btnReemplazar);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.txtTextoB);
            this.Controls.Add(this.lblTextoC);
            this.Controls.Add(this.lblTextoB);
            this.Controls.Add(this.mrcResultado);
            this.Controls.Add(this.btnComparar);
            this.Controls.Add(this.cmbTextoC);
            this.Controls.Add(this.lblTextoA);
            this.Controls.Add(this.txtTextoA);
            this.Name = "frmPrincipal";
            this.Text = "Pruebas con Texto";
            this.mrcResultado.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTextoA;
        private System.Windows.Forms.Label lblTextoA;
        private System.Windows.Forms.ComboBox cmbTextoC;
        private System.Windows.Forms.Button btnComparar;
        private System.Windows.Forms.GroupBox mrcResultado;
        private System.Windows.Forms.ListBox lstResultado;
        private System.Windows.Forms.Label lblTextoB;
        private System.Windows.Forms.Label lblTextoC;
        private System.Windows.Forms.TextBox txtTextoB;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Button btnReemplazar;
    }
}

