namespace CapaDePresentacion
{
    partial class FormClientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxIdentificacion = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonEliminarClienteEF = new System.Windows.Forms.Button();
            this.buttonInsertarClienteEF = new System.Windows.Forms.Button();
            this.buttonActualizarClienteEF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 181);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dirección";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 225);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Teléfono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 275);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha de nacimiento";
            // 
            // textBoxIdentificacion
            // 
            this.textBoxIdentificacion.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdentificacion.Location = new System.Drawing.Point(222, 55);
            this.textBoxIdentificacion.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIdentificacion.Name = "textBoxIdentificacion";
            this.textBoxIdentificacion.Size = new System.Drawing.Size(290, 32);
            this.textBoxIdentificacion.TabIndex = 5;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(222, 96);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(290, 32);
            this.textBoxNombre.TabIndex = 6;
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDireccion.Location = new System.Drawing.Point(222, 181);
            this.textBoxDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(290, 32);
            this.textBoxDireccion.TabIndex = 7;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTelefono.Location = new System.Drawing.Point(222, 223);
            this.textBoxTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(290, 32);
            this.textBoxTelefono.TabIndex = 8;
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFecha.Location = new System.Drawing.Point(222, 269);
            this.dateTimePickerFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(290, 32);
            this.dateTimePickerFecha.TabIndex = 9;
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Location = new System.Drawing.Point(518, 50);
            this.dataGridViewClientes.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.RowHeadersWidth = 51;
            this.dataGridViewClientes.RowTemplate.Height = 24;
            this.dataGridViewClientes.Size = new System.Drawing.Size(594, 444);
            this.dataGridViewClientes.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(439, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(286, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "DATOS DE LOS USUARIOS";
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApellidos.Location = new System.Drawing.Point(222, 140);
            this.textBoxApellidos.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(290, 32);
            this.textBoxApellidos.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 139);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 27);
            this.label7.TabIndex = 15;
            this.label7.Text = "Apellidos";
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.Color.Navy;
            this.buttonSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSalir.Location = new System.Drawing.Point(1018, 6);
            this.buttonSalir.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(94, 40);
            this.buttonSalir.TabIndex = 17;
            this.buttonSalir.Text = "SALIR";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // buttonEliminarClienteEF
            // 
            this.buttonEliminarClienteEF.BackColor = System.Drawing.Color.Navy;
            this.buttonEliminarClienteEF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.buttonEliminarClienteEF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminarClienteEF.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarClienteEF.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEliminarClienteEF.Location = new System.Drawing.Point(364, 407);
            this.buttonEliminarClienteEF.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEliminarClienteEF.Name = "buttonEliminarClienteEF";
            this.buttonEliminarClienteEF.Size = new System.Drawing.Size(101, 40);
            this.buttonEliminarClienteEF.TabIndex = 14;
            this.buttonEliminarClienteEF.Text = "ELIMINAR";
            this.buttonEliminarClienteEF.UseVisualStyleBackColor = false;
            this.buttonEliminarClienteEF.Click += new System.EventHandler(this.buttonEliminarClienteEF_Click);
            // 
            // buttonInsertarClienteEF
            // 
            this.buttonInsertarClienteEF.BackColor = System.Drawing.Color.Navy;
            this.buttonInsertarClienteEF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.buttonInsertarClienteEF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsertarClienteEF.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertarClienteEF.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonInsertarClienteEF.Location = new System.Drawing.Point(59, 407);
            this.buttonInsertarClienteEF.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInsertarClienteEF.Name = "buttonInsertarClienteEF";
            this.buttonInsertarClienteEF.Size = new System.Drawing.Size(106, 40);
            this.buttonInsertarClienteEF.TabIndex = 12;
            this.buttonInsertarClienteEF.Text = "INSERTAR";
            this.buttonInsertarClienteEF.UseVisualStyleBackColor = false;
            this.buttonInsertarClienteEF.Click += new System.EventHandler(this.buttonInsertarClienteEF_Click);
            // 
            // buttonActualizarClienteEF
            // 
            this.buttonActualizarClienteEF.BackColor = System.Drawing.Color.Navy;
            this.buttonActualizarClienteEF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.buttonActualizarClienteEF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActualizarClienteEF.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActualizarClienteEF.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonActualizarClienteEF.Location = new System.Drawing.Point(191, 407);
            this.buttonActualizarClienteEF.Margin = new System.Windows.Forms.Padding(2);
            this.buttonActualizarClienteEF.Name = "buttonActualizarClienteEF";
            this.buttonActualizarClienteEF.Size = new System.Drawing.Size(152, 40);
            this.buttonActualizarClienteEF.TabIndex = 13;
            this.buttonActualizarClienteEF.Text = "ACTUALIZAR";
            this.buttonActualizarClienteEF.UseVisualStyleBackColor = false;
            this.buttonActualizarClienteEF.Click += new System.EventHandler(this.buttonActualizarClienteEF_Click);
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1127, 515);
            this.Controls.Add(this.buttonInsertarClienteEF);
            this.Controls.Add(this.buttonEliminarClienteEF);
            this.Controls.Add(this.buttonActualizarClienteEF);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.textBoxApellidos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewClientes);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxIdentificacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormClientes";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxIdentificacion;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxApellidos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonEliminarClienteEF;
        private System.Windows.Forms.Button buttonInsertarClienteEF;
        private System.Windows.Forms.Button buttonActualizarClienteEF;
    }
}

