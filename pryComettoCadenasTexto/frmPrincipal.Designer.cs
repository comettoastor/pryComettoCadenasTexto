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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.txtTextoA = new System.Windows.Forms.TextBox();
            this.lblTextoA = new System.Windows.Forms.Label();
            this.btnComparar = new System.Windows.Forms.Button();
            this.lblTextoB = new System.Windows.Forms.Label();
            this.lblTextoC = new System.Windows.Forms.Label();
            this.txtTextoB = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.btnReemplazar = new System.Windows.Forms.Button();
            this.txtTextoC = new System.Windows.Forms.TextBox();
            this.txtTextoD = new System.Windows.Forms.TextBox();
            this.lblTextoD = new System.Windows.Forms.Label();
            this.txtTextoE = new System.Windows.Forms.TextBox();
            this.lblTextoE = new System.Windows.Forms.Label();
            this.txtIndice = new System.Windows.Forms.TextBox();
            this.btnIndice = new System.Windows.Forms.Button();
            this.lblTextoF = new System.Windows.Forms.Label();
            this.txtTextoF = new System.Windows.Forms.TextBox();
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
            // btnComparar
            // 
            this.btnComparar.Location = new System.Drawing.Point(199, 72);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(75, 23);
            this.btnComparar.TabIndex = 5;
            this.btnComparar.Text = "Comparar";
            this.btnComparar.UseVisualStyleBackColor = true;
            this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
            // 
            // lblTextoB
            // 
            this.lblTextoB.AutoSize = true;
            this.lblTextoB.Location = new System.Drawing.Point(43, 77);
            this.lblTextoB.Name = "lblTextoB";
            this.lblTextoB.Size = new System.Drawing.Size(44, 13);
            this.lblTextoB.TabIndex = 6;
            this.lblTextoB.Text = "Texto B";
            // 
            // lblTextoC
            // 
            this.lblTextoC.AutoSize = true;
            this.lblTextoC.Location = new System.Drawing.Point(386, 77);
            this.lblTextoC.Name = "lblTextoC";
            this.lblTextoC.Size = new System.Drawing.Size(44, 13);
            this.lblTextoC.TabIndex = 7;
            this.lblTextoC.Text = "Texto C";
            // 
            // txtTextoB
            // 
            this.txtTextoB.Location = new System.Drawing.Point(93, 74);
            this.txtTextoB.Name = "txtTextoB";
            this.txtTextoB.Size = new System.Drawing.Size(100, 20);
            this.txtTextoB.TabIndex = 3;
            this.txtTextoB.TextChanged += new System.EventHandler(this.txtTextoB_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(199, 43);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(280, 45);
            this.txtBuscar.MaxLength = 1;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(27, 20);
            this.txtBuscar.TabIndex = 2;
            this.txtBuscar.Visible = false;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(93, 177);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(100, 20);
            this.dtpFecha.TabIndex = 9;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(90, 201);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 14;
            this.lblFecha.Text = "Fecha";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(90, 215);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(30, 13);
            this.lblHora.TabIndex = 15;
            this.lblHora.Text = "Hora";
            // 
            // btnReemplazar
            // 
            this.btnReemplazar.Location = new System.Drawing.Point(199, 101);
            this.btnReemplazar.Name = "btnReemplazar";
            this.btnReemplazar.Size = new System.Drawing.Size(75, 23);
            this.btnReemplazar.TabIndex = 8;
            this.btnReemplazar.Text = "Reemplazar";
            this.btnReemplazar.UseVisualStyleBackColor = true;
            this.btnReemplazar.Click += new System.EventHandler(this.btnReemplazar_Click);
            // 
            // txtTextoC
            // 
            this.txtTextoC.Location = new System.Drawing.Point(280, 74);
            this.txtTextoC.Name = "txtTextoC";
            this.txtTextoC.Size = new System.Drawing.Size(100, 20);
            this.txtTextoC.TabIndex = 4;
            this.txtTextoC.TextChanged += new System.EventHandler(this.txtTextoC_TextChanged);
            // 
            // txtTextoD
            // 
            this.txtTextoD.Location = new System.Drawing.Point(93, 103);
            this.txtTextoD.Name = "txtTextoD";
            this.txtTextoD.Size = new System.Drawing.Size(100, 20);
            this.txtTextoD.TabIndex = 6;
            this.txtTextoD.TextChanged += new System.EventHandler(this.txtTextoD_TextChanged);
            // 
            // lblTextoD
            // 
            this.lblTextoD.AutoSize = true;
            this.lblTextoD.Location = new System.Drawing.Point(43, 106);
            this.lblTextoD.Name = "lblTextoD";
            this.lblTextoD.Size = new System.Drawing.Size(45, 13);
            this.lblTextoD.TabIndex = 19;
            this.lblTextoD.Text = "Texto D";
            // 
            // txtTextoE
            // 
            this.txtTextoE.Location = new System.Drawing.Point(280, 103);
            this.txtTextoE.Name = "txtTextoE";
            this.txtTextoE.Size = new System.Drawing.Size(100, 20);
            this.txtTextoE.TabIndex = 7;
            this.txtTextoE.TextChanged += new System.EventHandler(this.txtTextoE_TextChanged);
            // 
            // lblTextoE
            // 
            this.lblTextoE.AutoSize = true;
            this.lblTextoE.Location = new System.Drawing.Point(386, 106);
            this.lblTextoE.Name = "lblTextoE";
            this.lblTextoE.Size = new System.Drawing.Size(44, 13);
            this.lblTextoE.TabIndex = 21;
            this.lblTextoE.Text = "Texto E";
            // 
            // txtIndice
            // 
            this.txtIndice.Location = new System.Drawing.Point(280, 132);
            this.txtIndice.MaxLength = 1;
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.Size = new System.Drawing.Size(27, 20);
            this.txtIndice.TabIndex = 25;
            // 
            // btnIndice
            // 
            this.btnIndice.Location = new System.Drawing.Point(199, 130);
            this.btnIndice.Name = "btnIndice";
            this.btnIndice.Size = new System.Drawing.Size(75, 23);
            this.btnIndice.TabIndex = 23;
            this.btnIndice.Text = "Indice";
            this.btnIndice.UseVisualStyleBackColor = true;
            this.btnIndice.Click += new System.EventHandler(this.btnIndice_Click);
            // 
            // lblTextoF
            // 
            this.lblTextoF.AutoSize = true;
            this.lblTextoF.Location = new System.Drawing.Point(43, 135);
            this.lblTextoF.Name = "lblTextoF";
            this.lblTextoF.Size = new System.Drawing.Size(43, 13);
            this.lblTextoF.TabIndex = 24;
            this.lblTextoF.Text = "Texto F";
            // 
            // txtTextoF
            // 
            this.txtTextoF.Location = new System.Drawing.Point(93, 132);
            this.txtTextoF.Name = "txtTextoF";
            this.txtTextoF.Size = new System.Drawing.Size(100, 20);
            this.txtTextoF.TabIndex = 22;
            this.txtTextoF.TextChanged += new System.EventHandler(this.txtTextoF_TextChanged);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 243);
            this.Controls.Add(this.txtIndice);
            this.Controls.Add(this.btnIndice);
            this.Controls.Add(this.lblTextoF);
            this.Controls.Add(this.txtTextoF);
            this.Controls.Add(this.txtTextoE);
            this.Controls.Add(this.lblTextoE);
            this.Controls.Add(this.txtTextoD);
            this.Controls.Add(this.lblTextoD);
            this.Controls.Add(this.txtTextoC);
            this.Controls.Add(this.btnReemplazar);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtTextoB);
            this.Controls.Add(this.lblTextoC);
            this.Controls.Add(this.lblTextoB);
            this.Controls.Add(this.btnComparar);
            this.Controls.Add(this.lblTextoA);
            this.Controls.Add(this.txtTextoA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pruebas con Cadenas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTextoA;
        private System.Windows.Forms.Label lblTextoA;
        private System.Windows.Forms.Button btnComparar;
        private System.Windows.Forms.Label lblTextoB;
        private System.Windows.Forms.Label lblTextoC;
        private System.Windows.Forms.TextBox txtTextoB;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Button btnReemplazar;
        private System.Windows.Forms.TextBox txtTextoC;
        private System.Windows.Forms.TextBox txtTextoD;
        private System.Windows.Forms.Label lblTextoD;
        private System.Windows.Forms.TextBox txtTextoE;
        private System.Windows.Forms.Label lblTextoE;
        private System.Windows.Forms.TextBox txtIndice;
        private System.Windows.Forms.Button btnIndice;
        private System.Windows.Forms.Label lblTextoF;
        private System.Windows.Forms.TextBox txtTextoF;
    }
}

