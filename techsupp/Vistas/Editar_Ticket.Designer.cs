namespace techsupp
{
    partial class Editar_Ticket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar_Ticket));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_editar = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_Tecnico = new System.Windows.Forms.TextBox();
            this.tb_noaf = new System.Windows.Forms.TextBox();
            this.tb_Departamento = new System.Windows.Forms.TextBox();
            this.cb_Problemascon = new System.Windows.Forms.ComboBox();
            this.cb_Estado = new System.Windows.Forms.ComboBox();
            this.lbl_Ticket = new System.Windows.Forms.Label();
            this.lbl_NoTicket = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_tecnico = new System.Windows.Forms.Label();
            this.tb_comentario = new System.Windows.Forms.TextBox();
            this.lbl_problemacon = new System.Windows.Forms.Label();
            this.lbl_comentario = new System.Windows.Forms.Label();
            this.Noaf = new System.Windows.Forms.Label();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.lbl_departamento = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(24, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Asegurese de estar editando el ticket correcto. Los campos marcados con * no se p" +
    "ueden editar.";
            // 
            // lbl_editar
            // 
            this.lbl_editar.AutoSize = true;
            this.lbl_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_editar.Location = new System.Drawing.Point(24, 22);
            this.lbl_editar.Name = "lbl_editar";
            this.lbl_editar.Size = new System.Drawing.Size(110, 20);
            this.lbl_editar.TabIndex = 20;
            this.lbl_editar.Text = "Editar Ticket";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.tb_Tecnico);
            this.GroupBox1.Controls.Add(this.tb_noaf);
            this.GroupBox1.Controls.Add(this.tb_Departamento);
            this.GroupBox1.Controls.Add(this.cb_Problemascon);
            this.GroupBox1.Controls.Add(this.cb_Estado);
            this.GroupBox1.Controls.Add(this.lbl_Ticket);
            this.GroupBox1.Controls.Add(this.lbl_NoTicket);
            this.GroupBox1.Controls.Add(this.lbl_date);
            this.GroupBox1.Controls.Add(this.btn_salir);
            this.GroupBox1.Controls.Add(this.btn_actualizar);
            this.GroupBox1.Controls.Add(this.lbl_fecha);
            this.GroupBox1.Controls.Add(this.lbl_tecnico);
            this.GroupBox1.Controls.Add(this.tb_comentario);
            this.GroupBox1.Controls.Add(this.lbl_problemacon);
            this.GroupBox1.Controls.Add(this.lbl_comentario);
            this.GroupBox1.Controls.Add(this.Noaf);
            this.GroupBox1.Controls.Add(this.lbl_estado);
            this.GroupBox1.Controls.Add(this.lbl_departamento);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(17, 80);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(495, 484);
            this.GroupBox1.TabIndex = 19;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Actualizar ticket";
            // 
            // tb_Tecnico
            // 
            this.tb_Tecnico.Location = new System.Drawing.Point(121, 91);
            this.tb_Tecnico.Name = "tb_Tecnico";
            this.tb_Tecnico.Size = new System.Drawing.Size(121, 21);
            this.tb_Tecnico.TabIndex = 22;
            this.tb_Tecnico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Tecnico_KeyPress);
            // 
            // tb_noaf
            // 
            this.tb_noaf.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tb_noaf.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_noaf.Location = new System.Drawing.Point(121, 264);
            this.tb_noaf.Name = "tb_noaf";
            this.tb_noaf.Size = new System.Drawing.Size(149, 21);
            this.tb_noaf.TabIndex = 2;
            this.tb_noaf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Departamento_KeyPress);
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
            "Omega",
            "Transportacion",
            "DIO",
            "Central",
            "Correspondencia",
            "Despacho",
            "Archivo Central",
            "Archivo Criminologico",
            "CICC",
            "DIMI",
            "Recursos Humanos",
            "CDI",
            "URT",
            "URTI",
            "Operaciones",
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
            "Personal",
            "AILA"});
            this.tb_Departamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tb_Departamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_Departamento.Location = new System.Drawing.Point(121, 173);
            this.tb_Departamento.Name = "tb_Departamento";
            this.tb_Departamento.Size = new System.Drawing.Size(149, 21);
            this.tb_Departamento.TabIndex = 2;
            this.tb_Departamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Departamento_KeyPress);
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
            this.cb_Problemascon.Location = new System.Drawing.Point(121, 221);
            this.cb_Problemascon.Name = "cb_Problemascon";
            this.cb_Problemascon.Size = new System.Drawing.Size(149, 23);
            this.cb_Problemascon.TabIndex = 3;
            // 
            // cb_Estado
            // 
            this.cb_Estado.FormattingEnabled = true;
            this.cb_Estado.Items.AddRange(new object[] {
            "Cerrado"});
            this.cb_Estado.Location = new System.Drawing.Point(121, 131);
            this.cb_Estado.Name = "cb_Estado";
            this.cb_Estado.Size = new System.Drawing.Size(121, 23);
            this.cb_Estado.TabIndex = 1;
            this.cb_Estado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_Estado_KeyPress);
            // 
            // lbl_Ticket
            // 
            this.lbl_Ticket.AutoSize = true;
            this.lbl_Ticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ticket.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Ticket.Location = new System.Drawing.Point(121, 30);
            this.lbl_Ticket.Name = "lbl_Ticket";
            this.lbl_Ticket.Size = new System.Drawing.Size(41, 15);
            this.lbl_Ticket.TabIndex = 21;
            this.lbl_Ticket.Text = "ticket";
            // 
            // lbl_NoTicket
            // 
            this.lbl_NoTicket.AutoSize = true;
            this.lbl_NoTicket.Location = new System.Drawing.Point(17, 30);
            this.lbl_NoTicket.Name = "lbl_NoTicket";
            this.lbl_NoTicket.Size = new System.Drawing.Size(66, 15);
            this.lbl_NoTicket.TabIndex = 20;
            this.lbl_NoTicket.Text = "*No. Ticket";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(121, 61);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(37, 15);
            this.lbl_date.TabIndex = 19;
            this.lbl_date.Text = "fecha";
            // 
            // btn_salir
            // 
            this.btn_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(206, 423);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 6;
            this.btn_salir.Text = "&Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar.Location = new System.Drawing.Point(121, 423);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_actualizar.TabIndex = 5;
            this.btn_actualizar.Text = "&Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.Location = new System.Drawing.Point(17, 61);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(49, 15);
            this.lbl_fecha.TabIndex = 18;
            this.lbl_fecha.Text = "*Fecha:";
            // 
            // lbl_tecnico
            // 
            this.lbl_tecnico.AutoSize = true;
            this.lbl_tecnico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tecnico.Location = new System.Drawing.Point(14, 94);
            this.lbl_tecnico.Name = "lbl_tecnico";
            this.lbl_tecnico.Size = new System.Drawing.Size(58, 15);
            this.lbl_tecnico.TabIndex = 18;
            this.lbl_tecnico.Text = "*Tecnico:";
            // 
            // tb_comentario
            // 
            this.tb_comentario.Location = new System.Drawing.Point(121, 301);
            this.tb_comentario.Multiline = true;
            this.tb_comentario.Name = "tb_comentario";
            this.tb_comentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_comentario.Size = new System.Drawing.Size(314, 102);
            this.tb_comentario.TabIndex = 4;
            // 
            // lbl_problemacon
            // 
            this.lbl_problemacon.AutoSize = true;
            this.lbl_problemacon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_problemacon.Location = new System.Drawing.Point(14, 225);
            this.lbl_problemacon.Name = "lbl_problemacon";
            this.lbl_problemacon.Size = new System.Drawing.Size(87, 15);
            this.lbl_problemacon.TabIndex = 2;
            this.lbl_problemacon.Text = "Problema con:";
            this.lbl_problemacon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_comentario
            // 
            this.lbl_comentario.AutoSize = true;
            this.lbl_comentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_comentario.Location = new System.Drawing.Point(14, 300);
            this.lbl_comentario.Name = "lbl_comentario";
            this.lbl_comentario.Size = new System.Drawing.Size(75, 15);
            this.lbl_comentario.TabIndex = 3;
            this.lbl_comentario.Text = "Descripción:";
            this.lbl_comentario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Noaf
            // 
            this.Noaf.AutoSize = true;
            this.Noaf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Noaf.Location = new System.Drawing.Point(14, 267);
            this.Noaf.Name = "Noaf";
            this.Noaf.Size = new System.Drawing.Size(42, 15);
            this.Noaf.TabIndex = 0;
            this.Noaf.Text = "No a/f:";
            this.Noaf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado.Location = new System.Drawing.Point(14, 135);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(48, 15);
            this.lbl_estado.TabIndex = 2;
            this.lbl_estado.Text = "Estado:";
            this.lbl_estado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_departamento
            // 
            this.lbl_departamento.AutoSize = true;
            this.lbl_departamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_departamento.Location = new System.Drawing.Point(14, 176);
            this.lbl_departamento.Name = "lbl_departamento";
            this.lbl_departamento.Size = new System.Drawing.Size(94, 15);
            this.lbl_departamento.TabIndex = 0;
            this.lbl_departamento.Text = "*Departamento:";
            this.lbl_departamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Editar_Ticket
            // 
            this.AcceptButton = this.btn_actualizar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_salir;
            this.ClientSize = new System.Drawing.Size(532, 679);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_editar);
            this.Controls.Add(this.GroupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(548, 752);
            this.MinimumSize = new System.Drawing.Size(548, 718);
            this.Name = "Editar_Ticket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Ticket";
            this.Load += new System.EventHandler(this.Editar_ticket_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_editar;
        internal System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.ComboBox cb_Problemascon;
        private System.Windows.Forms.ComboBox cb_Estado;
        private System.Windows.Forms.Label lbl_Ticket;
        private System.Windows.Forms.Label lbl_NoTicket;
        private System.Windows.Forms.Label lbl_date;
        internal System.Windows.Forms.Button btn_salir;
        internal System.Windows.Forms.Button btn_actualizar;
        internal System.Windows.Forms.Label lbl_fecha;
        internal System.Windows.Forms.Label lbl_tecnico;
        internal System.Windows.Forms.TextBox tb_comentario;
        internal System.Windows.Forms.Label lbl_problemacon;
        internal System.Windows.Forms.Label lbl_comentario;
        internal System.Windows.Forms.Label lbl_estado;
        internal System.Windows.Forms.Label lbl_departamento;
        private System.Windows.Forms.TextBox tb_Departamento;
        private System.Windows.Forms.TextBox tb_Tecnico;
        private System.Windows.Forms.TextBox tb_noaf;
        internal System.Windows.Forms.Label Noaf;
    }
}