
namespace TRABAJO_PROGRAMACIÓN
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.button1 = new System.Windows.Forms.Button();
            this.lblPrimerNombre = new System.Windows.Forms.Label();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.lblSegundoNombre = new System.Windows.Forms.Label();
            this.txtSegundoNombre = new System.Windows.Forms.TextBox();
            this.lblPrimerApellido = new System.Windows.Forms.Label();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.lblSegundoApellido = new System.Windows.Forms.Label();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.lblTipoIdentificacion = new System.Windows.Forms.Label();
            this.cboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.lblNumeroIdentificacion = new System.Windows.Forms.Label();
            this.txtNumeroIdentificacion = new System.Windows.Forms.TextBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblFechaDeNacimiento = new System.Windows.Forms.Label();
            this.dtpFechaDeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblDireccionDeResidencia = new System.Windows.Forms.Label();
            this.txtDireccionDeResidencia = new System.Windows.Forms.TextBox();
            this.lblTelefonoContacto = new System.Windows.Forms.Label();
            this.txtTelefonoContacto = new System.Windows.Forms.TextBox();
            this.lblNivelEscolaridad = new System.Windows.Forms.Label();
            this.cboNivelEscolaridad = new System.Windows.Forms.ComboBox();
            this.lblEPS = new System.Windows.Forms.Label();
            this.txtEPS = new System.Windows.Forms.TextBox();
            this.lblRegimen = new System.Windows.Forms.Label();
            this.lblCorreoElectrónico = new System.Windows.Forms.Label();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.lblContactoEnCasoDeEmergencia = new System.Windows.Forms.Label();
            this.txtContactoEnCasoDeEmergencia = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbxGenero = new System.Windows.Forms.ComboBox();
            this.cmbxregimen = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PowderBlue;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(253, 623);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(322, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "REGRESAR AL MENÚ PRINCIPAL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPrimerNombre
            // 
            this.lblPrimerNombre.AutoSize = true;
            this.lblPrimerNombre.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerNombre.Location = new System.Drawing.Point(62, 20);
            this.lblPrimerNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrimerNombre.Name = "lblPrimerNombre";
            this.lblPrimerNombre.Size = new System.Drawing.Size(110, 17);
            this.lblPrimerNombre.TabIndex = 1;
            this.lblPrimerNombre.Text = "Primer Nombre";
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimerNombre.Location = new System.Drawing.Point(205, 17);
            this.txtPrimerNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.ShortcutsEnabled = false;
            this.txtPrimerNombre.Size = new System.Drawing.Size(456, 22);
            this.txtPrimerNombre.TabIndex = 2;
            this.txtPrimerNombre.TextChanged += new System.EventHandler(this.txtPrimerNombre_TextChanged);
            this.txtPrimerNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrimerNombre_KeyPress);
            // 
            // lblSegundoNombre
            // 
            this.lblSegundoNombre.AutoSize = true;
            this.lblSegundoNombre.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoNombre.Location = new System.Drawing.Point(62, 54);
            this.lblSegundoNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSegundoNombre.Name = "lblSegundoNombre";
            this.lblSegundoNombre.Size = new System.Drawing.Size(126, 17);
            this.lblSegundoNombre.TabIndex = 3;
            this.lblSegundoNombre.Text = "Segundo Nombre";
            this.lblSegundoNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegundoNombre.Location = new System.Drawing.Point(205, 54);
            this.txtSegundoNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.ShortcutsEnabled = false;
            this.txtSegundoNombre.Size = new System.Drawing.Size(456, 22);
            this.txtSegundoNombre.TabIndex = 4;
            this.txtSegundoNombre.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtSegundoNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSegundoNombre_KeyPress);
            // 
            // lblPrimerApellido
            // 
            this.lblPrimerApellido.AutoSize = true;
            this.lblPrimerApellido.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerApellido.Location = new System.Drawing.Point(62, 99);
            this.lblPrimerApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(113, 17);
            this.lblPrimerApellido.TabIndex = 5;
            this.lblPrimerApellido.Text = "Primer Apellido";
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimerApellido.Location = new System.Drawing.Point(205, 97);
            this.txtPrimerApellido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.ShortcutsEnabled = false;
            this.txtPrimerApellido.Size = new System.Drawing.Size(456, 22);
            this.txtPrimerApellido.TabIndex = 6;
            this.txtPrimerApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrimerApellido_KeyPress);
            // 
            // lblSegundoApellido
            // 
            this.lblSegundoApellido.AutoSize = true;
            this.lblSegundoApellido.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoApellido.Location = new System.Drawing.Point(62, 144);
            this.lblSegundoApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSegundoApellido.Name = "lblSegundoApellido";
            this.lblSegundoApellido.Size = new System.Drawing.Size(129, 17);
            this.lblSegundoApellido.TabIndex = 7;
            this.lblSegundoApellido.Text = "Segundo Apellido";
            this.lblSegundoApellido.Click += new System.EventHandler(this.lblSegundoApellido_Click);
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegundoApellido.Location = new System.Drawing.Point(205, 144);
            this.txtSegundoApellido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.ShortcutsEnabled = false;
            this.txtSegundoApellido.Size = new System.Drawing.Size(456, 22);
            this.txtSegundoApellido.TabIndex = 8;
            this.txtSegundoApellido.TextChanged += new System.EventHandler(this.txtSegundoApellido_TextChanged);
            this.txtSegundoApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSegundoApellido_KeyPress);
            // 
            // lblTipoIdentificacion
            // 
            this.lblTipoIdentificacion.AutoSize = true;
            this.lblTipoIdentificacion.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoIdentificacion.Location = new System.Drawing.Point(62, 189);
            this.lblTipoIdentificacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoIdentificacion.Name = "lblTipoIdentificacion";
            this.lblTipoIdentificacion.Size = new System.Drawing.Size(134, 17);
            this.lblTipoIdentificacion.TabIndex = 9;
            this.lblTipoIdentificacion.Text = "Tipo Identificación";
            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoDocumento.FormattingEnabled = true;
            this.cboTipoDocumento.Items.AddRange(new object[] {
            "Cedula de cuidadania",
            "Tarjeta de identidad ",
            "Cedula extranjeria"});
            this.cboTipoDocumento.Location = new System.Drawing.Point(205, 187);
            this.cboTipoDocumento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.Size = new System.Drawing.Size(456, 25);
            this.cboTipoDocumento.TabIndex = 10;
            this.cboTipoDocumento.SelectedIndexChanged += new System.EventHandler(this.cboTipoDocumento_SelectedIndexChanged);
            // 
            // lblNumeroIdentificacion
            // 
            this.lblNumeroIdentificacion.AutoSize = true;
            this.lblNumeroIdentificacion.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroIdentificacion.Location = new System.Drawing.Point(62, 229);
            this.lblNumeroIdentificacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeroIdentificacion.Name = "lblNumeroIdentificacion";
            this.lblNumeroIdentificacion.Size = new System.Drawing.Size(182, 17);
            this.lblNumeroIdentificacion.TabIndex = 11;
            this.lblNumeroIdentificacion.Text = "Número de Identificación";
            // 
            // txtNumeroIdentificacion
            // 
            this.txtNumeroIdentificacion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroIdentificacion.Location = new System.Drawing.Point(253, 227);
            this.txtNumeroIdentificacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumeroIdentificacion.Name = "txtNumeroIdentificacion";
            this.txtNumeroIdentificacion.ShortcutsEnabled = false;
            this.txtNumeroIdentificacion.Size = new System.Drawing.Size(408, 22);
            this.txtNumeroIdentificacion.TabIndex = 12;
            this.txtNumeroIdentificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroIdentificacion_KeyPress);
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(62, 266);
            this.lblGenero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(59, 17);
            this.lblGenero.TabIndex = 13;
            this.lblGenero.Text = "Género";
            // 
            // lblFechaDeNacimiento
            // 
            this.lblFechaDeNacimiento.AutoSize = true;
            this.lblFechaDeNacimiento.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDeNacimiento.Location = new System.Drawing.Point(62, 309);
            this.lblFechaDeNacimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaDeNacimiento.Name = "lblFechaDeNacimiento";
            this.lblFechaDeNacimiento.Size = new System.Drawing.Size(156, 17);
            this.lblFechaDeNacimiento.TabIndex = 16;
            this.lblFechaDeNacimiento.Text = "Fecha de Nacimiento";
            // 
            // dtpFechaDeNacimiento
            // 
            this.dtpFechaDeNacimiento.CalendarFont = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaDeNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDeNacimiento.Location = new System.Drawing.Point(214, 309);
            this.dtpFechaDeNacimiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFechaDeNacimiento.Name = "dtpFechaDeNacimiento";
            this.dtpFechaDeNacimiento.Size = new System.Drawing.Size(151, 20);
            this.dtpFechaDeNacimiento.TabIndex = 17;
            this.dtpFechaDeNacimiento.ValueChanged += new System.EventHandler(this.dtpFechaDeNacimiento_ValueChanged);
            // 
            // lblDireccionDeResidencia
            // 
            this.lblDireccionDeResidencia.AutoSize = true;
            this.lblDireccionDeResidencia.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionDeResidencia.Location = new System.Drawing.Point(62, 349);
            this.lblDireccionDeResidencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDireccionDeResidencia.Name = "lblDireccionDeResidencia";
            this.lblDireccionDeResidencia.Size = new System.Drawing.Size(175, 17);
            this.lblDireccionDeResidencia.TabIndex = 18;
            this.lblDireccionDeResidencia.Text = "Dirección de Residencia";
            // 
            // txtDireccionDeResidencia
            // 
            this.txtDireccionDeResidencia.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionDeResidencia.Location = new System.Drawing.Point(253, 347);
            this.txtDireccionDeResidencia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDireccionDeResidencia.Name = "txtDireccionDeResidencia";
            this.txtDireccionDeResidencia.ShortcutsEnabled = false;
            this.txtDireccionDeResidencia.Size = new System.Drawing.Size(411, 22);
            this.txtDireccionDeResidencia.TabIndex = 19;
            // 
            // lblTelefonoContacto
            // 
            this.lblTelefonoContacto.AutoSize = true;
            this.lblTelefonoContacto.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoContacto.Location = new System.Drawing.Point(62, 389);
            this.lblTelefonoContacto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefonoContacto.Name = "lblTelefonoContacto";
            this.lblTelefonoContacto.Size = new System.Drawing.Size(133, 17);
            this.lblTelefonoContacto.TabIndex = 20;
            this.lblTelefonoContacto.Text = "Teléfono Contacto";
            // 
            // txtTelefonoContacto
            // 
            this.txtTelefonoContacto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoContacto.Location = new System.Drawing.Point(205, 389);
            this.txtTelefonoContacto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTelefonoContacto.Name = "txtTelefonoContacto";
            this.txtTelefonoContacto.ShortcutsEnabled = false;
            this.txtTelefonoContacto.Size = new System.Drawing.Size(456, 22);
            this.txtTelefonoContacto.TabIndex = 21;
            this.txtTelefonoContacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTelefonoContacto_KeyPress);
            // 
            // lblNivelEscolaridad
            // 
            this.lblNivelEscolaridad.AutoSize = true;
            this.lblNivelEscolaridad.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivelEscolaridad.Location = new System.Drawing.Point(63, 430);
            this.lblNivelEscolaridad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNivelEscolaridad.Name = "lblNivelEscolaridad";
            this.lblNivelEscolaridad.Size = new System.Drawing.Size(125, 17);
            this.lblNivelEscolaridad.TabIndex = 22;
            this.lblNivelEscolaridad.Text = "Nivel Escolaridad";
            // 
            // cboNivelEscolaridad
            // 
            this.cboNivelEscolaridad.FormattingEnabled = true;
            this.cboNivelEscolaridad.Items.AddRange(new object[] {
            "Preescolar",
            "Educación básica primaria ",
            "Básica secundaria",
            "Educación media"});
            this.cboNivelEscolaridad.Location = new System.Drawing.Point(205, 430);
            this.cboNivelEscolaridad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboNivelEscolaridad.Name = "cboNivelEscolaridad";
            this.cboNivelEscolaridad.Size = new System.Drawing.Size(456, 21);
            this.cboNivelEscolaridad.TabIndex = 23;
            // 
            // lblEPS
            // 
            this.lblEPS.AutoSize = true;
            this.lblEPS.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEPS.Location = new System.Drawing.Point(63, 468);
            this.lblEPS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEPS.Name = "lblEPS";
            this.lblEPS.Size = new System.Drawing.Size(30, 17);
            this.lblEPS.TabIndex = 24;
            this.lblEPS.Text = "EPS";
            // 
            // txtEPS
            // 
            this.txtEPS.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEPS.Location = new System.Drawing.Point(205, 468);
            this.txtEPS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEPS.Name = "txtEPS";
            this.txtEPS.ShortcutsEnabled = false;
            this.txtEPS.Size = new System.Drawing.Size(456, 22);
            this.txtEPS.TabIndex = 25;
            this.txtEPS.TextChanged += new System.EventHandler(this.textEPS_TextChanged);
            this.txtEPS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEPS_KeyPress);
            // 
            // lblRegimen
            // 
            this.lblRegimen.AutoSize = true;
            this.lblRegimen.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegimen.Location = new System.Drawing.Point(63, 502);
            this.lblRegimen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegimen.Name = "lblRegimen";
            this.lblRegimen.Size = new System.Drawing.Size(69, 17);
            this.lblRegimen.TabIndex = 26;
            this.lblRegimen.Text = "Régimen";
            // 
            // lblCorreoElectrónico
            // 
            this.lblCorreoElectrónico.AutoSize = true;
            this.lblCorreoElectrónico.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoElectrónico.Location = new System.Drawing.Point(63, 541);
            this.lblCorreoElectrónico.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCorreoElectrónico.Name = "lblCorreoElectrónico";
            this.lblCorreoElectrónico.Size = new System.Drawing.Size(134, 17);
            this.lblCorreoElectrónico.TabIndex = 29;
            this.lblCorreoElectrónico.Text = "Correo Electrónico";
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoElectronico.Location = new System.Drawing.Point(205, 535);
            this.txtCorreoElectronico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.ShortcutsEnabled = false;
            this.txtCorreoElectronico.Size = new System.Drawing.Size(456, 22);
            this.txtCorreoElectronico.TabIndex = 30;
            // 
            // lblContactoEnCasoDeEmergencia
            // 
            this.lblContactoEnCasoDeEmergencia.AutoSize = true;
            this.lblContactoEnCasoDeEmergencia.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactoEnCasoDeEmergencia.Location = new System.Drawing.Point(64, 573);
            this.lblContactoEnCasoDeEmergencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContactoEnCasoDeEmergencia.Name = "lblContactoEnCasoDeEmergencia";
            this.lblContactoEnCasoDeEmergencia.Size = new System.Drawing.Size(239, 17);
            this.lblContactoEnCasoDeEmergencia.TabIndex = 31;
            this.lblContactoEnCasoDeEmergencia.Text = "Contacto en caso de emergencia";
            // 
            // txtContactoEnCasoDeEmergencia
            // 
            this.txtContactoEnCasoDeEmergencia.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactoEnCasoDeEmergencia.Location = new System.Drawing.Point(326, 573);
            this.txtContactoEnCasoDeEmergencia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtContactoEnCasoDeEmergencia.Name = "txtContactoEnCasoDeEmergencia";
            this.txtContactoEnCasoDeEmergencia.ShortcutsEnabled = false;
            this.txtContactoEnCasoDeEmergencia.Size = new System.Drawing.Size(338, 22);
            this.txtContactoEnCasoDeEmergencia.TabIndex = 32;
            this.txtContactoEnCasoDeEmergencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContactoEnCasoDeEmergencia_KeyPress);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(740, 295);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(91, 90);
            this.btnGuardar.TabIndex = 33;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightBlue;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(730, 451);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(116, 34);
            this.btnCancelar.TabIndex = 34;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cmbxGenero
            // 
            this.cmbxGenero.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxGenero.FormattingEnabled = true;
            this.cmbxGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbxGenero.Location = new System.Drawing.Point(171, 264);
            this.cmbxGenero.Margin = new System.Windows.Forms.Padding(2);
            this.cmbxGenero.Name = "cmbxGenero";
            this.cmbxGenero.Size = new System.Drawing.Size(456, 25);
            this.cmbxGenero.TabIndex = 35;
            this.cmbxGenero.SelectedIndexChanged += new System.EventHandler(this.cmbxGenero_SelectedIndexChanged);
            // 
            // cmbxregimen
            // 
            this.cmbxregimen.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxregimen.FormattingEnabled = true;
            this.cmbxregimen.Items.AddRange(new object[] {
            "Contributivo",
            "Subsidiado"});
            this.cmbxregimen.Location = new System.Drawing.Point(205, 500);
            this.cmbxregimen.Margin = new System.Windows.Forms.Padding(2);
            this.cmbxregimen.Name = "cmbxregimen";
            this.cmbxregimen.Size = new System.Drawing.Size(456, 25);
            this.cmbxregimen.TabIndex = 36;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(912, 681);
            this.Controls.Add(this.cmbxregimen);
            this.Controls.Add(this.cmbxGenero);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtContactoEnCasoDeEmergencia);
            this.Controls.Add(this.lblContactoEnCasoDeEmergencia);
            this.Controls.Add(this.txtCorreoElectronico);
            this.Controls.Add(this.lblCorreoElectrónico);
            this.Controls.Add(this.lblRegimen);
            this.Controls.Add(this.txtEPS);
            this.Controls.Add(this.lblEPS);
            this.Controls.Add(this.cboNivelEscolaridad);
            this.Controls.Add(this.lblNivelEscolaridad);
            this.Controls.Add(this.txtTelefonoContacto);
            this.Controls.Add(this.lblTelefonoContacto);
            this.Controls.Add(this.txtDireccionDeResidencia);
            this.Controls.Add(this.lblDireccionDeResidencia);
            this.Controls.Add(this.dtpFechaDeNacimiento);
            this.Controls.Add(this.lblFechaDeNacimiento);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.txtNumeroIdentificacion);
            this.Controls.Add(this.lblNumeroIdentificacion);
            this.Controls.Add(this.cboTipoDocumento);
            this.Controls.Add(this.lblTipoIdentificacion);
            this.Controls.Add(this.txtSegundoApellido);
            this.Controls.Add(this.lblSegundoApellido);
            this.Controls.Add(this.txtPrimerApellido);
            this.Controls.Add(this.lblPrimerApellido);
            this.Controls.Add(this.txtSegundoNombre);
            this.Controls.Add(this.lblSegundoNombre);
            this.Controls.Add(this.txtPrimerNombre);
            this.Controls.Add(this.lblPrimerNombre);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "DATOS PERSONALES";

            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPrimerNombre;
        private System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.Label lblSegundoNombre;
        private System.Windows.Forms.TextBox txtSegundoNombre;
        private System.Windows.Forms.Label lblPrimerApellido;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.Label lblSegundoApellido;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.Label lblTipoIdentificacion;
        private System.Windows.Forms.ComboBox cboTipoDocumento;
        private System.Windows.Forms.Label lblNumeroIdentificacion;
        private System.Windows.Forms.TextBox txtNumeroIdentificacion;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblFechaDeNacimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaDeNacimiento;
        private System.Windows.Forms.Label lblDireccionDeResidencia;
        private System.Windows.Forms.TextBox txtDireccionDeResidencia;
        private System.Windows.Forms.Label lblTelefonoContacto;
        private System.Windows.Forms.TextBox txtTelefonoContacto;
        private System.Windows.Forms.Label lblNivelEscolaridad;
        private System.Windows.Forms.ComboBox cboNivelEscolaridad;
        private System.Windows.Forms.Label lblEPS;
        private System.Windows.Forms.TextBox txtEPS;
        private System.Windows.Forms.Label lblRegimen;
        private System.Windows.Forms.Label lblCorreoElectrónico;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.Label lblContactoEnCasoDeEmergencia;
        private System.Windows.Forms.TextBox txtContactoEnCasoDeEmergencia;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cmbxGenero;
        private System.Windows.Forms.ComboBox cmbxregimen;
    }
}