namespace KhalosBoutique.UI
{
    partial class frmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtIdUsuarioAdmi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cbxRolAdmi = new System.Windows.Forms.ComboBox();
            this.txtNombreAdmi = new System.Windows.Forms.TextBox();
            this.txtContraseñaAdmi = new System.Windows.Forms.TextBox();
            this.txtCuentaAdmi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.cbxRol = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtIdUsuarioAdmi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.cbxRolAdmi);
            this.groupBox1.Controls.Add(this.txtNombreAdmi);
            this.groupBox1.Controls.Add(this.txtContraseñaAdmi);
            this.groupBox1.Controls.Add(this.txtCuentaAdmi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.Color.HotPink;
            this.groupBox1.Location = new System.Drawing.Point(12, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 209);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar usuarios";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(461, 158);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(101, 32);
            this.btnLimpiar.TabIndex = 48;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(198, 158);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(101, 32);
            this.btnModificar.TabIndex = 47;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(331, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(101, 32);
            this.btnBuscar.TabIndex = 46;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtIdUsuarioAdmi
            // 
            this.txtIdUsuarioAdmi.Location = new System.Drawing.Point(138, 25);
            this.txtIdUsuarioAdmi.Name = "txtIdUsuarioAdmi";
            this.txtIdUsuarioAdmi.Size = new System.Drawing.Size(179, 26);
            this.txtIdUsuarioAdmi.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(46, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 44;
            this.label5.Text = "Id Usuario:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(331, 158);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(101, 32);
            this.btnEliminar.TabIndex = 43;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // cbxRolAdmi
            // 
            this.cbxRolAdmi.FormattingEnabled = true;
            this.cbxRolAdmi.Location = new System.Drawing.Point(481, 118);
            this.cbxRolAdmi.Name = "cbxRolAdmi";
            this.cbxRolAdmi.Size = new System.Drawing.Size(168, 28);
            this.cbxRolAdmi.TabIndex = 42;
            // 
            // txtNombreAdmi
            // 
            this.txtNombreAdmi.Location = new System.Drawing.Point(118, 73);
            this.txtNombreAdmi.Name = "txtNombreAdmi";
            this.txtNombreAdmi.Size = new System.Drawing.Size(199, 26);
            this.txtNombreAdmi.TabIndex = 41;
            // 
            // txtContraseñaAdmi
            // 
            this.txtContraseñaAdmi.Location = new System.Drawing.Point(481, 72);
            this.txtContraseñaAdmi.Name = "txtContraseñaAdmi";
            this.txtContraseñaAdmi.Size = new System.Drawing.Size(168, 26);
            this.txtContraseñaAdmi.TabIndex = 20;
            this.txtContraseñaAdmi.UseSystemPasswordChar = true;
            // 
            // txtCuentaAdmi
            // 
            this.txtCuentaAdmi.Location = new System.Drawing.Point(118, 120);
            this.txtCuentaAdmi.Name = "txtCuentaAdmi";
            this.txtCuentaAdmi.Size = new System.Drawing.Size(199, 26);
            this.txtCuentaAdmi.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(375, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Rol:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(375, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(46, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cuenta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(46, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nombre:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnInsertar);
            this.groupBox2.Controls.Add(this.cbxRol);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.btnVolver);
            this.groupBox2.Controls.Add(this.txtContraseña);
            this.groupBox2.Controls.Add(this.txtCuenta);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.ForeColor = System.Drawing.Color.HotPink;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 169);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar usuarios";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.Location = new System.Drawing.Point(331, 123);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(121, 29);
            this.btnInsertar.TabIndex = 43;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // cbxRol
            // 
            this.cbxRol.FormattingEnabled = true;
            this.cbxRol.Location = new System.Drawing.Point(481, 78);
            this.cbxRol.Name = "cbxRol";
            this.cbxRol.Size = new System.Drawing.Size(168, 28);
            this.cbxRol.TabIndex = 42;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(118, 34);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(199, 26);
            this.txtNombre.TabIndex = 41;
            // 
            // btnVolver
            // 
            this.btnVolver.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("btnVolver.Image")));
            this.btnVolver.Location = new System.Drawing.Point(715, 19);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(39, 39);
            this.btnVolver.TabIndex = 40;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(481, 32);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(168, 26);
            this.txtContraseña.TabIndex = 20;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(118, 81);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(199, 26);
            this.txtCuenta.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(375, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Rol:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(375, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Contraseña:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(39, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "Cuenta:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(39, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 20);
            this.label12.TabIndex = 12;
            this.label12.Text = "Nombre:";
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Location = new System.Drawing.Point(150, 402);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.Size = new System.Drawing.Size(487, 146);
            this.dgvUsuario.TabIndex = 8;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(781, 561);
            this.Controls.Add(this.dgvUsuario);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtIdUsuarioAdmi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cbxRolAdmi;
        private System.Windows.Forms.TextBox txtNombreAdmi;
        private System.Windows.Forms.TextBox txtContraseñaAdmi;
        private System.Windows.Forms.TextBox txtCuentaAdmi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.ComboBox cbxRol;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvUsuario;
    }
}

