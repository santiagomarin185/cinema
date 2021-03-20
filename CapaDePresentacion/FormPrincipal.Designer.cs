namespace CapaDePresentacion
{
    partial class FormPrincipal
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
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.panelDeFormularios = new System.Windows.Forms.Panel();
            this.panelMenuLateral = new System.Windows.Forms.Panel();
            this.tabControlMenu = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageInicio = new System.Windows.Forms.TabPage();
            this.iconButtonSalir = new FontAwesome.Sharp.IconButton();
            this.iconInicio = new FontAwesome.Sharp.IconPictureBox();
            this.tabPagAdministacion = new System.Windows.Forms.TabPage();
            this.buttonEmpleados = new FontAwesome.Sharp.IconButton();
            this.buttonClientes = new FontAwesome.Sharp.IconButton();
            this.iconAdministracion = new FontAwesome.Sharp.IconPictureBox();
            this.tabSelectorMenu = new MaterialSkin.Controls.MaterialTabSelector();
            this.MOVIES = new System.Windows.Forms.TabPage();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.buttonMascotas = new FontAwesome.Sharp.IconButton();
            this.PanelPrincipal.SuspendLayout();
            this.panelMenuLateral.SuspendLayout();
            this.tabControlMenu.SuspendLayout();
            this.tabPageInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconInicio)).BeginInit();
            this.tabPagAdministacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconAdministracion)).BeginInit();
            this.MOVIES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelPrincipal.Controls.Add(this.panelDeFormularios);
            this.PanelPrincipal.Controls.Add(this.panelMenuLateral);
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 51);
            this.PanelPrincipal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(873, 476);
            this.PanelPrincipal.TabIndex = 0;
            // 
            // panelDeFormularios
            // 
            this.panelDeFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDeFormularios.Location = new System.Drawing.Point(150, 0);
            this.panelDeFormularios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelDeFormularios.Name = "panelDeFormularios";
            this.panelDeFormularios.Size = new System.Drawing.Size(723, 476);
            this.panelDeFormularios.TabIndex = 1;
            // 
            // panelMenuLateral
            // 
            this.panelMenuLateral.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelMenuLateral.Controls.Add(this.tabControlMenu);
            this.panelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLateral.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMenuLateral.Name = "panelMenuLateral";
            this.panelMenuLateral.Size = new System.Drawing.Size(150, 476);
            this.panelMenuLateral.TabIndex = 0;
            // 
            // tabControlMenu
            // 
            this.tabControlMenu.Controls.Add(this.tabPageInicio);
            this.tabControlMenu.Controls.Add(this.tabPagAdministacion);
            this.tabControlMenu.Controls.Add(this.MOVIES);
            this.tabControlMenu.Depth = 0;
            this.tabControlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMenu.Location = new System.Drawing.Point(0, 0);
            this.tabControlMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControlMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControlMenu.Name = "tabControlMenu";
            this.tabControlMenu.SelectedIndex = 0;
            this.tabControlMenu.Size = new System.Drawing.Size(150, 476);
            this.tabControlMenu.TabIndex = 0;
            // 
            // tabPageInicio
            // 
            this.tabPageInicio.BackColor = System.Drawing.Color.MidnightBlue;
            this.tabPageInicio.Controls.Add(this.iconButtonSalir);
            this.tabPageInicio.Controls.Add(this.iconInicio);
            this.tabPageInicio.Location = new System.Drawing.Point(4, 22);
            this.tabPageInicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageInicio.Name = "tabPageInicio";
            this.tabPageInicio.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageInicio.Size = new System.Drawing.Size(142, 450);
            this.tabPageInicio.TabIndex = 0;
            this.tabPageInicio.Text = "INICIO";
            // 
            // iconButtonSalir
            // 
            this.iconButtonSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButtonSalir.FlatAppearance.BorderSize = 0;
            this.iconButtonSalir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.iconButtonSalir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.iconButtonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSalir.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSalir.ForeColor = System.Drawing.Color.White;
            this.iconButtonSalir.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.iconButtonSalir.IconColor = System.Drawing.Color.White;
            this.iconButtonSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSalir.Location = new System.Drawing.Point(2, 411);
            this.iconButtonSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconButtonSalir.Name = "iconButtonSalir";
            this.iconButtonSalir.Size = new System.Drawing.Size(138, 37);
            this.iconButtonSalir.TabIndex = 1;
            this.iconButtonSalir.Text = "SALIR";
            this.iconButtonSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSalir.UseVisualStyleBackColor = true;
            this.iconButtonSalir.Click += new System.EventHandler(this.iconButtonSalir_Click);
            // 
            // iconInicio
            // 
            this.iconInicio.BackColor = System.Drawing.Color.MidnightBlue;
            this.iconInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconInicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconInicio.IconChar = FontAwesome.Sharp.IconChar.Film;
            this.iconInicio.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconInicio.IconSize = 110;
            this.iconInicio.Location = new System.Drawing.Point(2, 2);
            this.iconInicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconInicio.Name = "iconInicio";
            this.iconInicio.Size = new System.Drawing.Size(138, 110);
            this.iconInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconInicio.TabIndex = 0;
            this.iconInicio.TabStop = false;
            // 
            // tabPagAdministacion
            // 
            this.tabPagAdministacion.BackColor = System.Drawing.Color.MidnightBlue;
            this.tabPagAdministacion.Controls.Add(this.buttonEmpleados);
            this.tabPagAdministacion.Controls.Add(this.buttonClientes);
            this.tabPagAdministacion.Controls.Add(this.iconAdministracion);
            this.tabPagAdministacion.Location = new System.Drawing.Point(4, 22);
            this.tabPagAdministacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPagAdministacion.Name = "tabPagAdministacion";
            this.tabPagAdministacion.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPagAdministacion.Size = new System.Drawing.Size(142, 450);
            this.tabPagAdministacion.TabIndex = 1;
            this.tabPagAdministacion.Text = "ADMINISTRACIÓN";
            // 
            // buttonEmpleados
            // 
            this.buttonEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEmpleados.FlatAppearance.BorderSize = 0;
            this.buttonEmpleados.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmpleados.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmpleados.ForeColor = System.Drawing.Color.White;
            this.buttonEmpleados.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.buttonEmpleados.IconColor = System.Drawing.Color.White;
            this.buttonEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonEmpleados.Location = new System.Drawing.Point(2, 170);
            this.buttonEmpleados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEmpleados.Name = "buttonEmpleados";
            this.buttonEmpleados.Size = new System.Drawing.Size(138, 58);
            this.buttonEmpleados.TabIndex = 2;
            this.buttonEmpleados.Text = "Empleados";
            this.buttonEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEmpleados.UseVisualStyleBackColor = true;
            // 
            // buttonClientes
            // 
            this.buttonClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonClientes.FlatAppearance.BorderSize = 0;
            this.buttonClientes.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonClientes.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClientes.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClientes.ForeColor = System.Drawing.Color.White;
            this.buttonClientes.IconChar = FontAwesome.Sharp.IconChar.UserAstronaut;
            this.buttonClientes.IconColor = System.Drawing.Color.White;
            this.buttonClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonClientes.Location = new System.Drawing.Point(2, 112);
            this.buttonClientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonClientes.Name = "buttonClientes";
            this.buttonClientes.Size = new System.Drawing.Size(138, 58);
            this.buttonClientes.TabIndex = 1;
            this.buttonClientes.Text = "Usuarios";
            this.buttonClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonClientes.UseVisualStyleBackColor = true;
            this.buttonClientes.Click += new System.EventHandler(this.buttonClientes_Click);
            // 
            // iconAdministracion
            // 
            this.iconAdministracion.BackColor = System.Drawing.Color.MidnightBlue;
            this.iconAdministracion.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconAdministracion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconAdministracion.IconChar = FontAwesome.Sharp.IconChar.Pager;
            this.iconAdministracion.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconAdministracion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconAdministracion.IconSize = 110;
            this.iconAdministracion.Location = new System.Drawing.Point(2, 2);
            this.iconAdministracion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconAdministracion.Name = "iconAdministracion";
            this.iconAdministracion.Size = new System.Drawing.Size(138, 110);
            this.iconAdministracion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconAdministracion.TabIndex = 0;
            this.iconAdministracion.TabStop = false;
            // 
            // tabSelectorMenu
            // 
            this.tabSelectorMenu.BaseTabControl = this.tabControlMenu;
            this.tabSelectorMenu.Depth = 0;
            this.tabSelectorMenu.Location = new System.Drawing.Point(150, 28);
            this.tabSelectorMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabSelectorMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSelectorMenu.Name = "tabSelectorMenu";
            this.tabSelectorMenu.Size = new System.Drawing.Size(441, 19);
            this.tabSelectorMenu.TabIndex = 1;
            // 
            // MOVIES
            // 
            this.MOVIES.BackColor = System.Drawing.Color.MidnightBlue;
            this.MOVIES.Controls.Add(this.iconButton1);
            this.MOVIES.Controls.Add(this.buttonMascotas);
            this.MOVIES.Controls.Add(this.iconPictureBox1);
            this.MOVIES.Location = new System.Drawing.Point(4, 22);
            this.MOVIES.Name = "MOVIES";
            this.MOVIES.Padding = new System.Windows.Forms.Padding(3);
            this.MOVIES.Size = new System.Drawing.Size(142, 450);
            this.MOVIES.TabIndex = 2;
            this.MOVIES.Text = "MOVIES";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.iconPictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Video;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 110;
            this.iconPictureBox1.Location = new System.Drawing.Point(3, 3);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(136, 110);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox1.TabIndex = 1;
            this.iconPictureBox1.TabStop = false;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.TicketAlt;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(3, 171);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(136, 58);
            this.iconButton1.TabIndex = 10;
            this.iconButton1.Text = "Reservas";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // buttonMascotas
            // 
            this.buttonMascotas.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMascotas.FlatAppearance.BorderSize = 0;
            this.buttonMascotas.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonMascotas.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonMascotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMascotas.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMascotas.ForeColor = System.Drawing.Color.White;
            this.buttonMascotas.IconChar = FontAwesome.Sharp.IconChar.Film;
            this.buttonMascotas.IconColor = System.Drawing.Color.White;
            this.buttonMascotas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonMascotas.Location = new System.Drawing.Point(3, 113);
            this.buttonMascotas.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMascotas.Name = "buttonMascotas";
            this.buttonMascotas.Size = new System.Drawing.Size(136, 58);
            this.buttonMascotas.TabIndex = 9;
            this.buttonMascotas.Text = "Peliculas";
            this.buttonMascotas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMascotas.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 528);
            this.Controls.Add(this.tabSelectorMenu);
            this.Controls.Add(this.PanelPrincipal);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormPrincipal";
            this.Text = "MENU PRINCIPAL";
            this.PanelPrincipal.ResumeLayout(false);
            this.panelMenuLateral.ResumeLayout(false);
            this.tabControlMenu.ResumeLayout(false);
            this.tabPageInicio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconInicio)).EndInit();
            this.tabPagAdministacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconAdministracion)).EndInit();
            this.MOVIES.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Panel panelDeFormularios;
        private System.Windows.Forms.Panel panelMenuLateral;
        private MaterialSkin.Controls.MaterialTabControl tabControlMenu;
        private System.Windows.Forms.TabPage tabPageInicio;
        private System.Windows.Forms.TabPage tabPagAdministacion;
        private MaterialSkin.Controls.MaterialTabSelector tabSelectorMenu;
        private FontAwesome.Sharp.IconButton iconButtonSalir;
        private FontAwesome.Sharp.IconPictureBox iconInicio;
        private FontAwesome.Sharp.IconButton buttonEmpleados;
        private FontAwesome.Sharp.IconButton buttonClientes;
        private FontAwesome.Sharp.IconPictureBox iconAdministracion;
        private System.Windows.Forms.TabPage MOVIES;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton buttonMascotas;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}