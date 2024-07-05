namespace techsupp
{
    partial class Crear_Ticket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crear_Ticket));
            this.lbl_reporte = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Tecnico = new System.Windows.Forms.TextBox();
            this.cb_Problemascon = new System.Windows.Forms.ComboBox();
            this.cb_Estado = new System.Windows.Forms.ComboBox();
            this.tb_af = new System.Windows.Forms.TextBox();
            this.tb_Departamento = new System.Windows.Forms.TextBox();
            this.dt_Picker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_Ticket = new System.Windows.Forms.Label();
            this.lbl_NoTicket = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_tecnico = new System.Windows.Forms.Label();
            this.tb_descripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_problemacon = new System.Windows.Forms.Label();
            this.lbl_comentario = new System.Windows.Forms.Label();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.lbl_departamento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_reporte
            // 
            this.lbl_reporte.AutoSize = true;
            this.lbl_reporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reporte.Location = new System.Drawing.Point(12, 19);
            this.lbl_reporte.Name = "lbl_reporte";
            this.lbl_reporte.Size = new System.Drawing.Size(106, 20);
            this.lbl_reporte.TabIndex = 18;
            this.lbl_reporte.Text = "Crear Ticket";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Los campos marcados con * son obligatorios";
            // 
            // tb_Tecnico
            // 
            this.tb_Tecnico.Location = new System.Drawing.Point(125, 141);
            this.tb_Tecnico.Name = "tb_Tecnico";
            this.tb_Tecnico.Size = new System.Drawing.Size(121, 20);
            this.tb_Tecnico.TabIndex = 24;
            this.tb_Tecnico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Tecnico_KeyPress);
            // 
            // cb_Problemascon
            // 
            this.cb_Problemascon.AutoCompleteCustomSource.AddRange(new string[] {
            "CPU",
            "Impresora",
            "Internet",
            "Monitor",
            "Mouse",
            "Proxy",
            "Saic",
            "Teclado",
            "UPS",
            "Otro"});
            this.cb_Problemascon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_Problemascon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cb_Problemascon.FormattingEnabled = true;
            this.cb_Problemascon.Items.AddRange(new object[] {
            "CPU",
            "Impresora",
            "Internet",
            "Monitor",
            "Mouse",
            "Proxy",
            "Saic",
            "Teclado",
            "UPS",
            "Disco Duro",
            "Memoria Ram",
            "Backup",
            "Hacer Backup",
            "Software",
            "Sistema Operativo",
            "Otro"});
            this.cb_Problemascon.Location = new System.Drawing.Point(125, 268);
            this.cb_Problemascon.Name = "cb_Problemascon";
            this.cb_Problemascon.Size = new System.Drawing.Size(158, 21);
            this.cb_Problemascon.TabIndex = 33;
            // 
            // cb_Estado
            // 
            this.cb_Estado.FormattingEnabled = true;
            this.cb_Estado.Items.AddRange(new object[] {
            "Abierto",
            "En espera"});
            this.cb_Estado.Location = new System.Drawing.Point(125, 180);
            this.cb_Estado.Name = "cb_Estado";
            this.cb_Estado.Size = new System.Drawing.Size(121, 21);
            this.cb_Estado.TabIndex = 25;
            this.cb_Estado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_Estado_KeyPress_1);
            // 
            // tb_af
            // 
            this.tb_af.AutoCompleteCustomSource.AddRange(new string[] {
            "Activos Fijos",
            "Academia",
            "Enlace Internacional",
            "Camara de cuentas",
            "Compras",
            "Contabilidad",
            "Planes y estrategias",
            "Juridica",
            "Omega",
            "Transporte de Drogas",
            "Transportacion",
            "DIO",
            "Central",
            "Correspondencia",
            "Despacho",
            "Escolta",
            "Fichas",
            "Poligrafo",
            "Archivo Central",
            "Armas",
            "Archivo Criminologico",
            "Casa de Gualdia",
            "Asuntos Internos",
            "CICC",
            "Sub direccion CICC",
            "DIMI",
            "Recursos Humanos",
            "Investigaciones",
            "CDI",
            "URT",
            "URTI",
            "Operaciones",
            "Equipo",
            "Reaccion a Denuncias",
            "Recepcion de Denuncias",
            "Libre acceso a la Informacion",
            "Suministro",
            "Planta",
            "Apoyo Tecnologico",
            "Inspector",
            "Dispensario Medico",
            "Combustible",
            "Inv. Financiera",
            "Financiera",
            "DTCN",
            "Contraloria",
            "Armas",
            "Personal",
            "AILA",
            "Muelle Caucedo",
            "Muelle Haina",
            "Ejecutivo",
            "Seguridad"});
            this.tb_af.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tb_af.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_af.Location = new System.Drawing.Point(125, 308);
            this.tb_af.Name = "tb_af";
            this.tb_af.Size = new System.Drawing.Size(93, 20);
            this.tb_af.TabIndex = 34;
            // 
            // tb_Departamento
            // 
            this.tb_Departamento.AutoCompleteCustomSource.AddRange(new string[] {
            "Activos Fijos",
            "Academia",
            "Enlace Internacional",
            "Camara de cuentas",
            "Compras",
            "Contabilidad",
            "Planes y estrategias",
            "Juridica",
            "Transportacion",
            "Central",
            "Correspondencia",
            "Archivo Central",
            "Recursos Humanos",
            "Libre acceso a la Informacion",
            "Suministro",
            "Planta",
            "Apoyo Tecnologico",
            "Inspector",
            "Dispensario Medico",
            "Combustible",
            "Financiera",
            "Contraloria",
            "Personal"});
            this.tb_Departamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tb_Departamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_Departamento.Location = new System.Drawing.Point(125, 222);
            this.tb_Departamento.Name = "tb_Departamento";
            this.tb_Departamento.Size = new System.Drawing.Size(158, 20);
            this.tb_Departamento.TabIndex = 30;
            this.tb_Departamento.TextChanged += new System.EventHandler(this.tb_Departamento_TextChanged);
            // 
            // dt_Picker1
            // 
            this.dt_Picker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Picker1.Location = new System.Drawing.Point(210, 79);
            this.dt_Picker1.Name = "dt_Picker1";
            this.dt_Picker1.Size = new System.Drawing.Size(97, 20);
            this.dt_Picker1.TabIndex = 43;
            // 
            // lbl_Ticket
            // 
            this.lbl_Ticket.AutoSize = true;
            this.lbl_Ticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ticket.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Ticket.Location = new System.Drawing.Point(125, 79);
            this.lbl_Ticket.Name = "lbl_Ticket";
            this.lbl_Ticket.Size = new System.Drawing.Size(41, 15);
            this.lbl_Ticket.TabIndex = 42;
            this.lbl_Ticket.Text = "ticket";
            // 
            // lbl_NoTicket
            // 
            this.lbl_NoTicket.AutoSize = true;
            this.lbl_NoTicket.Location = new System.Drawing.Point(20, 79);
            this.lbl_NoTicket.Name = "lbl_NoTicket";
            this.lbl_NoTicket.Size = new System.Drawing.Size(57, 13);
            this.lbl_NoTicket.TabIndex = 41;
            this.lbl_NoTicket.Text = "No. Ticket";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(125, 111);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(34, 13);
            this.lbl_date.TabIndex = 40;
            this.lbl_date.Text = "fecha";
            // 
            // btn_salir
            // 
            this.btn_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(207, 527);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 37;
            this.btn_salir.Text = "&Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Location = new System.Drawing.Point(125, 527);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 36;
            this.btn_guardar.Text = "&Enviar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click_1);
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.Location = new System.Drawing.Point(20, 111);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(44, 15);
            this.lbl_fecha.TabIndex = 38;
            this.lbl_fecha.Text = "Fecha:";
            // 
            // lbl_tecnico
            // 
            this.lbl_tecnico.AutoSize = true;
            this.lbl_tecnico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tecnico.Location = new System.Drawing.Point(20, 144);
            this.lbl_tecnico.Name = "lbl_tecnico";
            this.lbl_tecnico.Size = new System.Drawing.Size(58, 15);
            this.lbl_tecnico.TabIndex = 39;
            this.lbl_tecnico.Text = "*Tecnico:";
            // 
            // tb_descripcion
            // 
            this.tb_descripcion.Location = new System.Drawing.Point(125, 345);
            this.tb_descripcion.Multiline = true;
            this.tb_descripcion.Name = "tb_descripcion";
            this.tb_descripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_descripcion.Size = new System.Drawing.Size(314, 140);
            this.tb_descripcion.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "No a/f:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_problemacon
            // 
            this.lbl_problemacon.AutoSize = true;
            this.lbl_problemacon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_problemacon.Location = new System.Drawing.Point(20, 271);
            this.lbl_problemacon.Name = "lbl_problemacon";
            this.lbl_problemacon.Size = new System.Drawing.Size(95, 15);
            this.lbl_problemacon.TabIndex = 26;
            this.lbl_problemacon.Text = "* Problema con:";
            this.lbl_problemacon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_comentario
            // 
            this.lbl_comentario.AutoSize = true;
            this.lbl_comentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_comentario.Location = new System.Drawing.Point(20, 344);
            this.lbl_comentario.Name = "lbl_comentario";
            this.lbl_comentario.Size = new System.Drawing.Size(75, 15);
            this.lbl_comentario.TabIndex = 31;
            this.lbl_comentario.Text = "Descripción:";
            this.lbl_comentario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado.Location = new System.Drawing.Point(20, 184);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(56, 15);
            this.lbl_estado.TabIndex = 29;
            this.lbl_estado.Text = "* Estado:";
            this.lbl_estado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_departamento
            // 
            this.lbl_departamento.AutoSize = true;
            this.lbl_departamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_departamento.Location = new System.Drawing.Point(20, 224);
            this.lbl_departamento.Name = "lbl_departamento";
            this.lbl_departamento.Size = new System.Drawing.Size(97, 15);
            this.lbl_departamento.TabIndex = 23;
            this.lbl_departamento.Text = "* Departamento:";
            this.lbl_departamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Crear_Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(483, 621);
            this.Controls.Add(this.tb_Tecnico);
            this.Controls.Add(this.cb_Problemascon);
            this.Controls.Add(this.cb_Estado);
            this.Controls.Add(this.tb_af);
            this.Controls.Add(this.tb_Departamento);
            this.Controls.Add(this.dt_Picker1);
            this.Controls.Add(this.lbl_Ticket);
            this.Controls.Add(this.lbl_NoTicket);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.lbl_tecnico);
            this.Controls.Add(this.tb_descripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_problemacon);
            this.Controls.Add(this.lbl_comentario);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.lbl_departamento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_reporte);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(499, 660);
            this.MinimumSize = new System.Drawing.Size(499, 660);
            this.Name = "Crear_Ticket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Ticket";
            this.Load += new System.EventHandler(this.Reporte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_reporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Tecnico;
        private System.Windows.Forms.ComboBox cb_Problemascon;
        private System.Windows.Forms.ComboBox cb_Estado;
        private System.Windows.Forms.TextBox tb_af;
        private System.Windows.Forms.TextBox tb_Departamento;
        private System.Windows.Forms.DateTimePicker dt_Picker1;
        private System.Windows.Forms.Label lbl_Ticket;
        private System.Windows.Forms.Label lbl_NoTicket;
        private System.Windows.Forms.Label lbl_date;
        internal System.Windows.Forms.Button btn_salir;
        internal System.Windows.Forms.Button btn_guardar;
        internal System.Windows.Forms.Label lbl_fecha;
        internal System.Windows.Forms.Label lbl_tecnico;
        internal System.Windows.Forms.TextBox tb_descripcion;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label lbl_problemacon;
        internal System.Windows.Forms.Label lbl_comentario;
        internal System.Windows.Forms.Label lbl_estado;
        internal System.Windows.Forms.Label lbl_departamento;
    }
}