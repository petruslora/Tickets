namespace techsupp
{
    partial class Reset_Pass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reset_Pass));
            this.lbl_pass = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.gb_idatos = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_Usuario = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.tb_confirm = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dSA = new techsupp.DSA();
            this.tabUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tab_UsuariosTableAdapter = new techsupp.DSATableAdapters.Tab_UsuariosTableAdapter();
            this.gb_idatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabUsuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_pass.Location = new System.Drawing.Point(12, 143);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(75, 13);
            this.lbl_pass.TabIndex = 12;
            this.lbl_pass.Text = "Contraseña:";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_user.Location = new System.Drawing.Point(13, 48);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(54, 13);
            this.lbl_user.TabIndex = 11;
            this.lbl_user.Text = "Usuario:";
            // 
            // gb_idatos
            // 
            this.gb_idatos.Controls.Add(this.label7);
            this.gb_idatos.Controls.Add(this.label6);
            this.gb_idatos.Controls.Add(this.cb_Usuario);
            this.gb_idatos.Controls.Add(this.lbl_pass);
            this.gb_idatos.Controls.Add(this.label2);
            this.gb_idatos.Controls.Add(this.lbl_user);
            this.gb_idatos.Controls.Add(this.btn_cancelar);
            this.gb_idatos.Controls.Add(this.btn_entrar);
            this.gb_idatos.Controls.Add(this.tb_confirm);
            this.gb_idatos.Controls.Add(this.tb_pass);
            this.gb_idatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_idatos.Location = new System.Drawing.Point(26, 24);
            this.gb_idatos.Name = "gb_idatos";
            this.gb_idatos.Size = new System.Drawing.Size(315, 292);
            this.gb_idatos.TabIndex = 13;
            this.gb_idatos.TabStop = false;
            this.gb_idatos.Text = "Editar usuario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(14, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(231, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "(La contraseña debe tener 6 o más caracteres).";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(12, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(280, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ingrese la contraseña nueva para el usuario seleccionado";
            // 
            // cb_Usuario
            // 
            this.cb_Usuario.DataSource = this.tabUsuariosBindingSource;
            this.cb_Usuario.DisplayMember = "NombreUsuario";
            this.cb_Usuario.FormattingEnabled = true;
            this.cb_Usuario.Location = new System.Drawing.Point(16, 64);
            this.cb_Usuario.Name = "cb_Usuario";
            this.cb_Usuario.Size = new System.Drawing.Size(121, 21);
            this.cb_Usuario.TabIndex = 1;
            this.cb_Usuario.ValueMember = "NombreUsuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(12, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Confirmar:";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(96, 236);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 5;
            this.btn_cancelar.Text = "&Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_entrar
            // 
            this.btn_entrar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_entrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrar.Location = new System.Drawing.Point(15, 236);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(75, 23);
            this.btn_entrar.TabIndex = 4;
            this.btn_entrar.Text = "&Editar";
            this.btn_entrar.UseVisualStyleBackColor = false;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // tb_confirm
            // 
            this.tb_confirm.Location = new System.Drawing.Point(15, 208);
            this.tb_confirm.Name = "tb_confirm";
            this.tb_confirm.PasswordChar = '*';
            this.tb_confirm.Size = new System.Drawing.Size(145, 20);
            this.tb_confirm.TabIndex = 3;
            this.tb_confirm.UseSystemPasswordChar = true;
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(15, 159);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.PasswordChar = '*';
            this.tb_pass.Size = new System.Drawing.Size(145, 20);
            this.tb_pass.TabIndex = 2;
            this.tb_pass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(39, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Seleccione el usuario que desea editar";
            // 
            // dSA
            // 
            this.dSA.DataSetName = "DSA";
            this.dSA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabUsuariosBindingSource
            // 
            this.tabUsuariosBindingSource.DataMember = "Tab_Usuarios";
            this.tabUsuariosBindingSource.DataSource = this.dSA;
            // 
            // tab_UsuariosTableAdapter
            // 
            this.tab_UsuariosTableAdapter.ClearBeforeFill = true;
            // 
            // Reset_Pass
            // 
            this.AcceptButton = this.btn_entrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelButton = this.btn_cancelar;
            this.ClientSize = new System.Drawing.Size(369, 342);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gb_idatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reset_Pass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar una Contraseña";
            this.Load += new System.EventHandler(this.Resetpass_Load);
            this.gb_idatos.ResumeLayout(false);
            this.gb_idatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabUsuariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.GroupBox gb_idatos;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_confirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Usuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private DSA dSA;
        private System.Windows.Forms.BindingSource tabUsuariosBindingSource;
        private DSATableAdapters.Tab_UsuariosTableAdapter tab_UsuariosTableAdapter;
    }
}