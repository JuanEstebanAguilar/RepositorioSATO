namespace Presentacion
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiaDeSeguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.turnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiaClínicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.atenciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagramaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesionalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trabajadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.investigaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.índiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stpNotificaciones = new System.Windows.Forms.StatusStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.pgbCarga = new System.Windows.Forms.ToolStripProgressBar();
            this.lblHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrReloj = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.tsbTurnos = new System.Windows.Forms.ToolStripButton();
            this.tsbPacientes = new System.Windows.Forms.ToolStripButton();
            this.tsbAtenciones = new System.Windows.Forms.ToolStripButton();
            this.tsbImprimir = new System.Windows.Forms.ToolStripButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ntfNotificadorVTNPrincipal = new System.Windows.Forms.NotifyIcon(this.components);
            this.flpAccesosDirectos = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.stpNotificaciones.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.flpAccesosDirectos.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.gestiónToolStripMenuItem1,
            this.investigaciónToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1069, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // gestiónToolStripMenuItem
            // 
            this.gestiónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.copiaDeSeguridadToolStripMenuItem});
            this.gestiónToolStripMenuItem.Image = global::Presentacion.Properties.Resources.icono_configurar_chico;
            this.gestiónToolStripMenuItem.Name = "gestiónToolStripMenuItem";
            this.gestiónToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.gestiónToolStripMenuItem.Text = "Administrar";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usuariosToolStripMenuItem.Image")));
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // copiaDeSeguridadToolStripMenuItem
            // 
            this.copiaDeSeguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarToolStripMenuItem,
            this.restaurarToolStripMenuItem});
            this.copiaDeSeguridadToolStripMenuItem.Name = "copiaDeSeguridadToolStripMenuItem";
            this.copiaDeSeguridadToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.copiaDeSeguridadToolStripMenuItem.Text = "Copia de seguridad";
            // 
            // generarToolStripMenuItem
            // 
            this.generarToolStripMenuItem.Name = "generarToolStripMenuItem";
            this.generarToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.generarToolStripMenuItem.Text = "Generar";
            // 
            // restaurarToolStripMenuItem
            // 
            this.restaurarToolStripMenuItem.Name = "restaurarToolStripMenuItem";
            this.restaurarToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.restaurarToolStripMenuItem.Text = "Restaurar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(133, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // gestiónToolStripMenuItem1
            // 
            this.gestiónToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.turnosToolStripMenuItem,
            this.toolStripSeparator2,
            this.pacientesToolStripMenuItem,
            this.toolStripSeparator3,
            this.atenciónToolStripMenuItem,
            this.diagramaciónToolStripMenuItem,
            this.personalToolStripMenuItem});
            this.gestiónToolStripMenuItem1.Name = "gestiónToolStripMenuItem1";
            this.gestiónToolStripMenuItem1.Size = new System.Drawing.Size(59, 20);
            this.gestiónToolStripMenuItem1.Text = "Gestión";
            // 
            // turnosToolStripMenuItem
            // 
            this.turnosToolStripMenuItem.Image = global::Presentacion.Properties.Resources.icono_turno_chico;
            this.turnosToolStripMenuItem.Name = "turnosToolStripMenuItem";
            this.turnosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.turnosToolStripMenuItem.Text = "Turnos";
            this.turnosToolStripMenuItem.Click += new System.EventHandler(this.turnosToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historiaClínicaToolStripMenuItem});
            this.pacientesToolStripMenuItem.Image = global::Presentacion.Properties.Resources.icono_paciente_chico;
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            this.pacientesToolStripMenuItem.Click += new System.EventHandler(this.pacientesToolStripMenuItem_Click);
            // 
            // historiaClínicaToolStripMenuItem
            // 
            this.historiaClínicaToolStripMenuItem.Image = global::Presentacion.Properties.Resources.icono_historiaclinica_chico;
            this.historiaClínicaToolStripMenuItem.Name = "historiaClínicaToolStripMenuItem";
            this.historiaClínicaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.historiaClínicaToolStripMenuItem.Text = "Historia clínica";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // atenciónToolStripMenuItem
            // 
            this.atenciónToolStripMenuItem.Image = global::Presentacion.Properties.Resources.icono_turno_grande;
            this.atenciónToolStripMenuItem.Name = "atenciónToolStripMenuItem";
            this.atenciónToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.atenciónToolStripMenuItem.Text = "Atención";
            // 
            // diagramaciónToolStripMenuItem
            // 
            this.diagramaciónToolStripMenuItem.Image = global::Presentacion.Properties.Resources.icono_diagramacion_chico;
            this.diagramaciónToolStripMenuItem.Name = "diagramaciónToolStripMenuItem";
            this.diagramaciónToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.diagramaciónToolStripMenuItem.Text = "Diagramación";
            this.diagramaciónToolStripMenuItem.Click += new System.EventHandler(this.diagramaciónToolStripMenuItem_Click);
            // 
            // personalToolStripMenuItem
            // 
            this.personalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profesionalesToolStripMenuItem,
            this.trabajadoresToolStripMenuItem});
            this.personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            this.personalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.personalToolStripMenuItem.Text = "Personal";
            // 
            // profesionalesToolStripMenuItem
            // 
            this.profesionalesToolStripMenuItem.Name = "profesionalesToolStripMenuItem";
            this.profesionalesToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.profesionalesToolStripMenuItem.Text = "Profesionales";
            this.profesionalesToolStripMenuItem.Click += new System.EventHandler(this.profesionalesToolStripMenuItem_Click);
            // 
            // trabajadoresToolStripMenuItem
            // 
            this.trabajadoresToolStripMenuItem.Name = "trabajadoresToolStripMenuItem";
            this.trabajadoresToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.trabajadoresToolStripMenuItem.Text = "Trabajadores";
            this.trabajadoresToolStripMenuItem.Click += new System.EventHandler(this.trabajadoresToolStripMenuItem_Click);
            // 
            // investigaciónToolStripMenuItem
            // 
            this.investigaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.procesarToolStripMenuItem});
            this.investigaciónToolStripMenuItem.Name = "investigaciónToolStripMenuItem";
            this.investigaciónToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.investigaciónToolStripMenuItem.Text = "Investigación";
            // 
            // procesarToolStripMenuItem
            // 
            this.procesarToolStripMenuItem.Name = "procesarToolStripMenuItem";
            this.procesarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.procesarToolStripMenuItem.Text = "Congresos";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarToolStripMenuItem,
            this.índiceToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.buscarToolStripMenuItem.Text = "Buscar";
            // 
            // índiceToolStripMenuItem
            // 
            this.índiceToolStripMenuItem.Name = "índiceToolStripMenuItem";
            this.índiceToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.índiceToolStripMenuItem.Text = "Índice";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // stpNotificaciones
            // 
            this.stpNotificaciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.pgbCarga,
            this.lblHora,
            this.lblFecha});
            this.stpNotificaciones.Location = new System.Drawing.Point(0, 657);
            this.stpNotificaciones.Name = "stpNotificaciones";
            this.stpNotificaciones.Size = new System.Drawing.Size(1069, 22);
            this.stpNotificaciones.TabIndex = 1;
            this.stpNotificaciones.Text = "statusStrip1";
            this.stpNotificaciones.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.stpNotificaciones_ItemClicked);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 20);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // pgbCarga
            // 
            this.pgbCarga.Name = "pgbCarga";
            this.pgbCarga.Size = new System.Drawing.Size(100, 16);
            // 
            // lblHora
            // 
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(0, 17);
            // 
            // lblFecha
            // 
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 17);
            // 
            // tmrReloj
            // 
            this.tmrReloj.Enabled = true;
            this.tmrReloj.Interval = 1000;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSalir,
            this.tsbTurnos,
            this.tsbPacientes,
            this.tsbAtenciones,
            this.tsbImprimir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1069, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbSalir
            // 
            this.tsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSalir.Image = ((System.Drawing.Image)(resources.GetObject("tsbSalir.Image")));
            this.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalir.Name = "tsbSalir";
            this.tsbSalir.Size = new System.Drawing.Size(23, 22);
            this.tsbSalir.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // tsbTurnos
            // 
            this.tsbTurnos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbTurnos.Image = global::Presentacion.Properties.Resources.icono_turno_chico;
            this.tsbTurnos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTurnos.Name = "tsbTurnos";
            this.tsbTurnos.Size = new System.Drawing.Size(23, 22);
            this.tsbTurnos.ToolTipText = "Turnos";
            this.tsbTurnos.Click += new System.EventHandler(this.tsbTurnos_Click);
            // 
            // tsbPacientes
            // 
            this.tsbPacientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPacientes.Image = global::Presentacion.Properties.Resources.icono_paciente_chico;
            this.tsbPacientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPacientes.Name = "tsbPacientes";
            this.tsbPacientes.Size = new System.Drawing.Size(23, 22);
            this.tsbPacientes.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // tsbAtenciones
            // 
            this.tsbAtenciones.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAtenciones.Image = global::Presentacion.Properties.Resources.icono_atencion_chico;
            this.tsbAtenciones.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAtenciones.Name = "tsbAtenciones";
            this.tsbAtenciones.Size = new System.Drawing.Size(23, 22);
            this.tsbAtenciones.ToolTipText = "Atención";
            // 
            // tsbImprimir
            // 
            this.tsbImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbImprimir.Image = global::Presentacion.Properties.Resources.icono_imprimir_chico;
            this.tsbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbImprimir.Name = "tsbImprimir";
            this.tsbImprimir.Size = new System.Drawing.Size(23, 22);
            this.tsbImprimir.ToolTipText = "Imprimir";
            // 
            // ntfNotificadorVTNPrincipal
            // 
            this.ntfNotificadorVTNPrincipal.BalloonTipText = "Presione aquí";
            this.ntfNotificadorVTNPrincipal.BalloonTipTitle = "SATO ejecutándose";
            this.ntfNotificadorVTNPrincipal.Text = "Para maximizar la aplicación, presione aquí.";
            this.ntfNotificadorVTNPrincipal.DoubleClick += new System.EventHandler(this.ntfNotificadorVTNPrincipal_DoubleClick);
            // 
            // flpAccesosDirectos
            // 
            this.flpAccesosDirectos.Controls.Add(this.button1);
            this.flpAccesosDirectos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpAccesosDirectos.Location = new System.Drawing.Point(0, 49);
            this.flpAccesosDirectos.Name = "flpAccesosDirectos";
            this.flpAccesosDirectos.Size = new System.Drawing.Size(1069, 608);
            this.flpAccesosDirectos.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Presentacion.Properties.Resources.icono_imprimir_grande;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 148);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Presentacion.Properties.Resources.Aero_Blue_Leaf_Wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1069, 679);
            this.Controls.Add(this.flpAccesosDirectos);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.stpNotificaciones);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestión SATO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Principal_Load);
            this.Resize += new System.EventHandler(this.frmPrincipal_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.stpNotificaciones.ResumeLayout(false);
            this.stpNotificaciones.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.flpAccesosDirectos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem turnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atenciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem investigaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem procesarToolStripMenuItem;
        private System.Windows.Forms.StatusStrip stpNotificaciones;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripProgressBar pgbCarga;
        private System.Windows.Forms.ToolStripStatusLabel lblHora;
        private System.Windows.Forms.ToolStripStatusLabel lblFecha;
        private System.Windows.Forms.Timer tmrReloj;
        private System.Windows.Forms.ToolStripMenuItem copiaDeSeguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historiaClínicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagramaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbTurnos;
        private System.Windows.Forms.ToolStripButton tsbPacientes;
        private System.Windows.Forms.ToolStripButton tsbAtenciones;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.ToolStripButton tsbImprimir;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesionalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trabajadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem índiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon ntfNotificadorVTNPrincipal;
        private System.Windows.Forms.FlowLayoutPanel flpAccesosDirectos;
        private System.Windows.Forms.Button button1;
    }
}

