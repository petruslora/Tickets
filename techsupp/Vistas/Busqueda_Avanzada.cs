using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace techsupp
{
    public partial class Busqueda_Avanzada : Form
    {
        Usuario usuario = new Usuario();    
        private string ActiveUser;
        private Datos manipularDatos = new Datos(); 
        private Boolean Admin;
        private string Codigo, Fecha, Tecnico, Estado, Departamento, ProblemasCon, No_AF, Comentario;
        public Busqueda_Avanzada(string date1, string date2,CheckBox incluirFecha, CheckBox pendiente, string categoria, string tb_buscar)
        {
            InitializeComponent();
            this.dateTimePicker1.Text = date1;
            this.dateTimePicker2.Text = date2;
            this.checkB_Pendiente.Checked = pendiente.Checked;
            this.checkB_incluirfecha.Checked = incluirFecha.Checked;
            this.cb_categoria.Text = categoria;
            this.tb_Buscar.Text = tb_buscar; 
        }
        public Busqueda_Avanzada(string user)
        {
            InitializeComponent();
            this.ActiveUser = user;                
        }
        public Boolean TipoUsuario() // Este metodo evalua si el tipo de usuario que inicio sesion, si es admin o no.
        {
            Boolean tipousuario = usuario.TipoDeUsuario(this.ActiveUser);
            if (tipousuario)
            {
                this.eliminarToolStripMenuItem1.Enabled = true; // eliminar del dgv.
                Admin = true;
            }
            else
            {
                this.eliminarToolStripMenuItem1.Enabled = false; // eliminar del dgv.
                Admin = false;
            }
            return Admin;
        }
        private void Busqueda_avanzada_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSA.Reportes' table. You can move, or remove it, as needed.
            this.reportesTableAdapter.Fill(this.dSA.Reportes);
            this.dateTimePicker1.Focus();
            Buscar();
            
            // Altura de las filas del datagv1...
            DataGridViewRow rows = this.datagv1.RowTemplate;
            rows.Height = 24;

            TipoUsuario();
        }
        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerTicket();
        }
        
        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarTicket();
        }
        
        private void Editar_ticket_FormClosed(object sender, FormClosedEventArgs e)
        {
            Buscar();
        }
        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EliminarTicket();
        }
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
         Buscar();
        }
        
        private void tb_Buscar_KeyUp(object sender, KeyEventArgs e)
        {
            Buscar();
        }
        private void btn_quitar_filtro_Click_1(object sender, EventArgs e)
        {
            this.dateTimePicker1.Text = DateTime.Today.ToString();
            this.dateTimePicker2.Text = DateTime.Today.ToString();
            this.cb_categoria.Text = "No. Ticket";
            this.tb_Buscar.Text = "";
            this.checkB_incluirfecha.Checked = false;
            this.checkB_Pendiente.Checked = false;
        }
        private void datagv1_MouseClick_1(object sender, MouseEventArgs e)
        {
            // Muestra la cantidad de filas seleccionadas...
            int i = Convert.ToInt32(this.datagv1.SelectedRows.Count);
            this.label3.Text = i.ToString() + " Seleccionadas";
        }
        private void crearTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearTicket();
        }
        private void datagv1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            VerTicket();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        public void CrearTicket()
        {
            Crear_Ticket mostrar = new Crear_Ticket(this.ActiveUser);
            // Esta Con esta linea llamamos el evento "FormClosed" antes de mostrar el formulario "Ticket".....
            //mostrar.FormClosed += new FormClosedEventHandler(Ticket_FormClosed);
            mostrar.ShowDialog();
        }
        public void VerTicket()
        {
            try
            {
                Codigo = this.datagv1.CurrentRow.Cells[0].Value.ToString();
                Fecha = this.datagv1.CurrentRow.Cells[1].Value.ToString();
                Tecnico = this.datagv1.CurrentRow.Cells[2].Value.ToString();
                Estado = this.datagv1.CurrentRow.Cells[3].Value.ToString();
                Departamento = this.datagv1.CurrentRow.Cells[4].Value.ToString();
                ProblemasCon = this.datagv1.CurrentRow.Cells[5].Value.ToString();
                No_AF = this.datagv1.CurrentRow.Cells[6].Value.ToString();
                Comentario = this.datagv1.CurrentRow.Cells[7].Value.ToString();

                Ver_Tickets mostrar = new Ver_Tickets(Convert.ToInt32(Codigo), Fecha, Tecnico, Estado, Departamento, ProblemasCon, No_AF, Comentario);
                mostrar.Show(this.datagv1);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Debe seleccionar una fila para ver su contenido", "Error");
            }
        }
        public void EditarTicket()
        {
            try
            {
                Codigo = this.datagv1.CurrentRow.Cells[0].Value.ToString();
                Fecha = this.datagv1.CurrentRow.Cells[1].Value.ToString();
                Tecnico = this.datagv1.CurrentRow.Cells[2].Value.ToString();
                Estado = this.datagv1.CurrentRow.Cells[3].Value.ToString();
                Departamento = this.datagv1.CurrentRow.Cells[4].Value.ToString();
                ProblemasCon = this.datagv1.CurrentRow.Cells[5].Value.ToString();
                No_AF = this.datagv1.CurrentRow.Cells[6].Value.ToString();
                Comentario = this.datagv1.CurrentRow.Cells[7].Value.ToString();

                Editar_Ticket mostrar = new Editar_Ticket(Convert.ToInt32(Codigo), Fecha, Tecnico, Estado, Departamento, ProblemasCon, No_AF, Comentario);
                // Esta Con esta linea llamamos el evento "FormClosed" antes de mostrar el formulario "Ticket".....
                mostrar.FormClosed += new FormClosedEventHandler(Editar_ticket_FormClosed);
                mostrar.ShowDialog();

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Debe seleccionar una fila para editar su contenido", "Error");
            }
        }
        public void EliminarTicket()
        {
            new Tickets(Convert.ToInt32(this.datagv1.CurrentRow.Cells[0].Value)).EliminarTicket();
            Buscar();
        }
        public void Buscar()
        {
            if (this.checkB_incluirfecha.Checked == true && this.checkB_Pendiente.Checked == false)
            {
                switch (this.cb_categoria.Text)
                {
                    case "No. Ticket":
                        manipularDatos.ActualizarGrid(this.datagv1, "SELECT * FROM Reportes WHERE FECHA >='" + this.dateTimePicker1.Text + "' AND FECHA <= '" + this.dateTimePicker2.Text + "' AND Codigo LIKE '" + this.tb_Buscar.Text + "%' ORDER BY Codigo DESC;");

                        // Actualiza el numero de filas que muestra el datagrid...
                        this.lbl_Filas.Text = manipularDatos.FilasMostradas("SELECT * FROM Reportes WHERE FECHA >='" + this.dateTimePicker1.Text + "' AND FECHA <= '" + this.dateTimePicker2.Text + "' AND Codigo LIKE '" + this.tb_Buscar.Text + "%' ORDER BY Codigo DESC;").ToString() + " Filas";

                        break;
                    case "Tecnico":
                        manipularDatos.ActualizarGrid(this.datagv1, "SELECT * FROM DBO.Reportes WHERE FECHA >='" + this.dateTimePicker1.Text + "' AND FECHA <= '" + this.dateTimePicker2.Text + "' AND Tecnico LIKE '" + this.tb_Buscar.Text + "%' ORDER BY Codigo DESC;");

                        // Actualiza el numero de filas que muestra el datagrid...
                        this.lbl_Filas.Text = manipularDatos.FilasMostradas("SELECT * FROM DBO.Reportes WHERE FECHA >='" + this.dateTimePicker1.Text + "' AND FECHA <= '" + this.dateTimePicker2.Text + "' AND Tecnico LIKE '" + this.tb_Buscar.Text + "%' ORDER BY Codigo DESC;").ToString() + " Filas";

                        break;
                    case "Departamento":
                        manipularDatos.ActualizarGrid(this.datagv1, "SELECT * FROM DBO.Reportes WHERE FECHA >='" + this.dateTimePicker1.Text + "' AND FECHA <= '" + this.dateTimePicker2.Text + "' AND Departamento LIKE '" + this.tb_Buscar.Text + "%' ORDER BY Codigo DESC;");

                        // Actualiza el numero de filas que muestra el datagrid...
                        this.lbl_Filas.Text = manipularDatos.FilasMostradas("SELECT * FROM DBO.Reportes WHERE FECHA >='" + this.dateTimePicker1.Text + "' AND FECHA <= '" + this.dateTimePicker2.Text + "' AND Departamento LIKE '" + this.tb_Buscar.Text + "%' ORDER BY Codigo DESC;").ToString() + " Filas";
                        break;
                    case "Usuario":
                        manipularDatos.ActualizarGrid(this.datagv1, "SELECT * FROM DBO.Reportes WHERE FECHA >='" + this.dateTimePicker1.Text + "' AND FECHA <= '" + this.dateTimePicker2.Text + "' AND Usuario LIKE '" + this.tb_Buscar.Text + "%' ORDER BY Codigo DESC;");

                        // Actualiza el numero de filas que muestra el datagrid...
                        this.lbl_Filas.Text = manipularDatos.FilasMostradas("SELECT * FROM DBO.Reportes WHERE FECHA >='" + this.dateTimePicker1.Text + "' AND FECHA <= '" + this.dateTimePicker2.Text + "' AND Usuario LIKE '" + this.tb_Buscar.Text + "%' ORDER BY Codigo DESC;").ToString() + " Filas";
                        break;
                    case "Problemas con":
                        manipularDatos.ActualizarGrid(this.datagv1, "SELECT * FROM DBO.Reportes WHERE FECHA >='" + this.dateTimePicker1.Text + "' AND FECHA <= '" + this.dateTimePicker2.Text + "' AND [Problemas con] LIKE '" + this.tb_Buscar.Text + "%' ORDER BY Codigo DESC;");

                        // Actualiza el numero de filas que muestra el datagrid...
                        this.lbl_Filas.Text = manipularDatos.FilasMostradas("SELECT * FROM DBO.Reportes WHERE FECHA >='" + this.dateTimePicker1.Text + "' AND FECHA <= '" + this.dateTimePicker2.Text + "' AND [Problemas con] LIKE '" + this.tb_Buscar.Text + "%' ORDER BY Codigo DESC;").ToString() + " Filas";
                        break;

                    case "No a/f":
                        manipularDatos.ActualizarGrid(this.datagv1, "SELECT * FROM DBO.Reportes WHERE FECHA >='" + this.dateTimePicker1.Text + "' AND FECHA <= '" + this.dateTimePicker2.Text + "' AND [No a/f] LIKE '" + this.tb_Buscar.Text + "%' ORDER BY Codigo DESC;");

                        // Actualiza el numero de filas que muestra el datagrid...
                        this.lbl_Filas.Text = manipularDatos.FilasMostradas("SELECT * FROM DBO.Reportes WHERE FECHA >='" + this.dateTimePicker1.Text + "' AND FECHA <= '" + this.dateTimePicker2.Text + "' AND [No a/f] LIKE '" + this.tb_Buscar.Text + "%' ORDER BY Codigo DESC;").ToString() + " Filas";
                        break;

                    default:
                        manipularDatos.ActualizarGrid(this.datagv1, "SELECT * FROM DBO.Reportes WHERE FECHA >='" + this.dateTimePicker1.Text + "' AND FECHA <= '" + this.dateTimePicker2.Text + "' ORDER BY Codigo DESC;");
                        // Muestra la cantidad de filas que aparecen con la misma query de actualizar...
                        this.lbl_Filas.Text = manipularDatos.FilasMostradas("SELECT * FROM DBO.Reportes WHERE FECHA >='" + this.dateTimePicker1.Text + "' AND FECHA <= '" + this.dateTimePicker2.Text + "' ORDER BY Codigo DESC;").ToString() + " Filas";
                        break;
                } // Fin switch.....
            }
            else if (this.checkB_incluirfecha.Checked == false && this.checkB_Pendiente.Checked == false)
            {
                switch (this.cb_categoria.Text)
                {
                    case "No. Ticket":
                        manipularDatos.ActualizarGrid(this.datagv1, "SELECT * FROM Reportes WHERE Codigo LIKE '" + this.tb_Buscar.Text + "%' ORDER BY Codigo DESC;");
                        // Actualiza el numero de filas que muestra el datagrid...
                        this.lbl_Filas.Text = manipularDatos.FilasMostradas("SELECT * FROM Reportes WHERE Codigo LIKE '" + this.tb_Buscar.Text + "%' ORDER BY Codigo DESC;").ToString() + " Filas";

                        break;
                    case "Tecnico":
                        manipularDatos.ActualizarGrid(this.datagv1, "SELECT * FROM Reportes WHERE Tecnico LIKE '" + this.tb_Buscar.Text + "%' ORDER BY Codigo DESC;");
                        // Actualiza el numero de filas que muestra el datagrid...
                        this.lbl_Filas.Text = manipularDatos.FilasMostradas("SELECT * FROM Reportes WHERE Tecnico LIKE '" + this.tb_Buscar.Text + "%' ORDER BY Codigo DESC;").ToString() + " Filas";

                        break;

                    case "Departamento":
                        manipularDatos.ActualizarGrid(this.datagv1, "SELECT * FROM Reportes WHERE Departamento LIKE '" + this.tb_Buscar.Text + "%' ORDER BY Codigo DESC;");
                        // Actualiza el numero de filas que muestra el datagrid...
                        this.lbl_Filas.Text = manipularDatos.FilasMostradas("SELECT * FROM Reportes WHERE Departamento LIKE '" + this.tb_Buscar.Text + "%' ORDER BY Codigo DESC;").ToString() + " Filas";
                        break;

                    case "Usuario":
                        manipularDatos.ActualizarGrid(this.datagv1, "SELECT * FROM Reportes WHERE Usuario LIKE '" + this.tb_Buscar.Text + "%' ORDER BY Codigo DESC;");
                        // Actualiza el numero de filas que muestra el datagrid...
                        this.lbl_Filas.Text = manipularDatos.FilasMostradas("SELECT * FROM Reportes WHERE Usuario LIKE '" + this.tb_Buscar.Text + "%' ORDER BY Codigo DESC;").ToString() + " Filas";
                        break;

                    case "Problemas con":
                        manipularDatos.ActualizarGrid(this.datagv1, "SELECT * FROM Reportes WHERE [Problemas con] LIKE '" + this.tb_Buscar.Text + "%' ORDER BY Codigo DESC;");
                        // Actualiza el numero de filas que muestra el datagrid...
                        this.lbl_Filas.Text = manipularDatos.FilasMostradas("SELECT * FROM Reportes WHERE [Problemas con] LIKE '" + this.tb_Buscar.Text + "%' ORDER BY Codigo DESC;").ToString() + " Filas";
                        break;

                    case "No a/f":
                        manipularDatos.ActualizarGrid(this.datagv1, "SELECT * FROM Reportes WHERE [No a/f] LIKE '" + this.tb_Buscar.Text + "%' ORDER BY Codigo DESC;");
                        // Actualiza el numero de filas que muestra el datagrid...
                        this.lbl_Filas.Text = manipularDatos.FilasMostradas("SELECT * FROM Reportes WHERE [No a/f] LIKE '" + this.tb_Buscar.Text + "%' ORDER BY Codigo DESC;").ToString() + " Filas";
                        break;

                    default:
                        manipularDatos.ActualizarGrid(this.datagv1, "SELECT * FROM Reportes ORDER BY Codigo DESC;");
                        // Actualiza el numero de filas que muestra el datagrid...
                        this.lbl_Filas.Text = manipularDatos.FilasMostradas("SELECT * FROM Reportes ORDER BY Codigo DESC;").ToString() + " Filas";

                        break;
                } // Fin del segundo switch.....

            }
            else if (this.checkB_incluirfecha.Checked == false && this.checkB_Pendiente.Checked == true)
            {
                switch (this.cb_categoria.Text)
                {
                    case "No. Ticket":
                        manipularDatos.ActualizarGrid(this.datagv1, "SELECT * FROM Reportes WHERE (Estado = 'Abierto' or Estado = 'En espera') AND Codigo LIKE '" + this.tb_Buscar.Text + "%' ORDER BY Codigo DESC;");

                        // Actualiza el numero de filas que muestra el datagrid...
                        this.lbl_Filas.Text = manipularDatos.FilasMostradas("SELECT * FROM Reportes WHERE (Estado = 'Abierto' or Estado = 'En espera') AND Codigo LIKE '" + this.tb_Buscar.Text + "%' ORDER BY Codigo DESC;").ToString() + " Filas";

                        break;
                    case "Tecnico":
                        manipularDatos.ActualizarGrid(this.datagv1, "SELECT * FROM DBO.Reportes WHERE (Estado = 'Abierto' or Estado = 'En espera') AND Tecnico LIKE '" + this.tb_Buscar.Text + "%' ORDER BY Codigo DESC;");

                        // Actualiza el numero de filas que muestra el datagrid...
                        this.lbl_Filas.Text = manipularDatos.FilasMostradas("SELECT * FROM DBO.Reportes WHERE (Estado = 'Abierto' or Estado = 'En espera') AND Tecnico LIKE '" + this.tb_Buscar.Text + "%' ORDER BY Codigo DESC;").ToString() + " Filas";

                        break;
                    case "Departamento":
                        manipularDatos.ActualizarGrid(this.datagv1, "SELECT * FROM DBO.Reportes WHERE (Estado = 'Abierto' or Estado = 'En espera') AND Departamento LIKE '" + this.tb_Buscar.Text + "%' ORDER BY Codigo DESC;");

                        // Actualiza el numero de filas que muestra el datagrid...
                        this.lbl_Filas.Text = manipularDatos.FilasMostradas("SELECT * FROM DBO.Reportes WHERE (Estado = 'Abierto' or Estado = 'En espera') AND Departamento LIKE '" + this.tb_Buscar.Text + "%' ORDER BY Codigo DESC;").ToString() + " Filas";
                        break;
                    case "Usuario":
                        manipularDatos.ActualizarGrid(this.datagv1, "SELECT * FROM DBO.Reportes WHERE (Estado = 'Abierto' or Estado = 'En espera') AND Usuario LIKE '" + this.tb_Buscar.Text + "%' ORDER BY Codigo DESC;");

                        // Actualiza el numero de filas que muestra el datagrid...
                        this.lbl_Filas.Text = manipularDatos.FilasMostradas("SELECT * FROM DBO.Reportes WHERE (Estado = 'Abierto' or Estado = 'En espera') AND Usuario LIKE '" + this.tb_Buscar.Text + "%' ORDER BY Codigo DESC;").ToString() + " Filas";
                        break;
                    case "Problemas con":
                        manipularDatos.ActualizarGrid(this.datagv1, "SELECT * FROM DBO.Reportes WHERE (Estado = 'Abierto' or Estado = 'En espera') AND [Problemas con] LIKE '" + this.tb_Buscar.Text + "%' ORDER BY Codigo DESC;");

                        // Actualiza el numero de filas que muestra el datagrid...
                        this.lbl_Filas.Text = manipularDatos.FilasMostradas("SELECT * FROM DBO.Reportes WHERE (Estado = 'Abierto' or Estado = 'En espera') AND [Problemas con] LIKE '" + this.tb_Buscar.Text + "%' ORDER BY Codigo DESC;").ToString() + " Filas";
                        break;

                    case "No a/f":
                        manipularDatos.ActualizarGrid(this.datagv1, "SELECT * FROM DBO.Reportes WHERE (Estado = 'Abierto' or Estado = 'En espera') AND [No a/f] LIKE '" + this.tb_Buscar.Text + "%' ORDER BY Codigo DESC;");

                        // Actualiza el numero de filas que muestra el datagrid...
                        this.lbl_Filas.Text = manipularDatos.FilasMostradas("SELECT * FROM DBO.Reportes WHERE (Estado = 'Abierto' or Estado = 'En espera') AND [No a/f] LIKE '" + this.tb_Buscar.Text + "%' ORDER BY Codigo DESC;").ToString() + " Filas";
                        break;

                    default:
                        manipularDatos.ActualizarGrid(this.datagv1, "SELECT * FROM DBO.Reportes WHERE Estado = 'Abierto' or Estado = 'En espera' ORDER BY Codigo DESC;");
                        // Muestra la cantidad de filas que aparecen con la misma query de actualizar...
                        this.lbl_Filas.Text = manipularDatos.FilasMostradas("SELECT * FROM DBO.Reportes WHERE Estado = 'Abierto' or Estado = 'En espera' ORDER BY Codigo DESC;").ToString() + " Filas";
                        break;
                } // Fin switch.....

            }
            else if (this.checkB_incluirfecha.Checked == true && this.checkB_Pendiente.Checked == true)
            {
                switch (this.cb_categoria.Text)
                {
                    case "No. Ticket":
                        manipularDatos.ActualizarGrid(this.datagv1, "SELECT * FROM Reportes WHERE (FECHA >='" + this.dateTimePicker1.Text + "' AND FECHA <= '" + this.dateTimePicker2.Text + "') AND (Estado = 'Abierto' or Estado = 'En espera') AND Codigo LIKE '" + this.tb_Buscar.Text + "%' ORDER BY Codigo DESC;");

                        // Actualiza el numero de filas que muestra el datagrid...
                        this.lbl_Filas.Text = manipularDatos.FilasMostradas("SELECT * FROM Reportes WHERE (FECHA >='" + this.dateTimePicker1.Text + "' AND FECHA <= '" + this.dateTimePicker2.Text + "') AND (Estado = 'Abierto' or Estado = 'En espera') AND Codigo LIKE '" + this.tb_Buscar.Text + "%' ORDER BY Codigo DESC;").ToString() + " Filas";

                        break;
                    case "Tecnico":
                        manipularDatos.ActualizarGrid(this.datagv1, "SELECT * FROM DBO.Reportes WHERE (FECHA >='" + this.dateTimePicker1.Text + "' AND FECHA <= '" + this.dateTimePicker2.Text + "') AND (Estado = 'Abierto' or Estado = 'En espera') AND Tecnico LIKE '" + this.tb_Buscar.Text + "%' ORDER BY Codigo DESC;");

                        // Actualiza el numero de filas que muestra el datagrid...
                        this.lbl_Filas.Text = manipularDatos.FilasMostradas("SELECT * FROM DBO.Reportes WHERE (FECHA >='" + this.dateTimePicker1.Text + "' AND FECHA <= '" + this.dateTimePicker2.Text + "') AND (Estado = 'Abierto' or Estado = 'En espera') AND Tecnico LIKE '" + this.tb_Buscar.Text + "%' ORDER BY Codigo DESC;").ToString() + " Filas";

                        break;
                    case "Departamento":
                        manipularDatos.ActualizarGrid(this.datagv1, "SELECT * FROM DBO.Reportes WHERE (FECHA >='" + this.dateTimePicker1.Text + "' AND FECHA <= '" + this.dateTimePicker2.Text + "') AND (Estado = 'Abierto' or Estado = 'En espera') AND Departamento LIKE '" + this.tb_Buscar.Text + "%' ORDER BY Codigo DESC;");

                        // Actualiza el numero de filas que muestra el datagrid...
                        this.lbl_Filas.Text = manipularDatos.FilasMostradas("SELECT * FROM DBO.Reportes WHERE (FECHA >='" + this.dateTimePicker1.Text + "' AND FECHA <= '" + this.dateTimePicker2.Text + "') AND (Estado = 'Abierto' or Estado = 'En espera') AND Departamento LIKE '" + this.tb_Buscar.Text + "%' ORDER BY Codigo DESC;").ToString() + " Filas";
                        break;
                    case "Usuario":
                        manipularDatos.ActualizarGrid(this.datagv1, "SELECT * FROM DBO.Reportes WHERE (FECHA >='" + this.dateTimePicker1.Text + "' AND FECHA <= '" + this.dateTimePicker2.Text + "') AND (Estado = 'Abierto' or Estado = 'En espera') AND Usuario LIKE '" + this.tb_Buscar.Text + "%' ORDER BY Codigo DESC;");

                        // Actualiza el numero de filas que muestra el datagrid...
                        this.lbl_Filas.Text = manipularDatos.FilasMostradas("SELECT * FROM DBO.Reportes WHERE (FECHA >='" + this.dateTimePicker1.Text + "' AND FECHA <= '" + this.dateTimePicker2.Text + "') AND (Estado = 'Abierto' or Estado = 'En espera') AND Usuario LIKE '" + this.tb_Buscar.Text + "%' ORDER BY Codigo DESC;").ToString() + " Filas";
                        break;
                    case "Problemas con":
                        manipularDatos.ActualizarGrid(this.datagv1, "SELECT * FROM DBO.Reportes WHERE (FECHA >='" + this.dateTimePicker1.Text + "' AND FECHA <= '" + this.dateTimePicker2.Text + "') AND (Estado = 'Abierto' or Estado = 'En espera') AND [Problemas con] LIKE '" + this.tb_Buscar.Text + "%' ORDER BY Codigo DESC;");

                        // Actualiza el numero de filas que muestra el datagrid...
                        this.lbl_Filas.Text = manipularDatos.FilasMostradas("SELECT * FROM DBO.Reportes WHERE (FECHA >='" + this.dateTimePicker1.Text + "' AND FECHA <= '" + this.dateTimePicker2.Text + "') AND (Estado = 'Abierto' or Estado = 'En espera') AND [Problemas con] LIKE '" + this.tb_Buscar.Text + "%' ORDER BY Codigo DESC;").ToString() + " Filas";
                        break;

                    case "No a/f":
                        manipularDatos.ActualizarGrid(this.datagv1, "SELECT * FROM DBO.Reportes WHERE (FECHA >='" + this.dateTimePicker1.Text + "' AND FECHA <= '" + this.dateTimePicker2.Text + "') AND (Estado = 'Abierto' or Estado = 'En espera') AND [No a/f] LIKE '" + this.tb_Buscar.Text + "%' ORDER BY Codigo DESC;");

                        // Actualiza el numero de filas que muestra el datagrid...
                        this.lbl_Filas.Text = manipularDatos.FilasMostradas("SELECT * FROM DBO.Reportes WHERE (FECHA >='" + this.dateTimePicker1.Text + "' AND FECHA <= '" + this.dateTimePicker2.Text + "') AND (Estado = 'Abierto' or Estado = 'En espera') AND [No a/f] LIKE '" + this.tb_Buscar.Text + "%' ORDER BY Codigo DESC;").ToString() + " Filas";
                        break;

                    default:
                        manipularDatos.ActualizarGrid(this.datagv1, "SELECT * FROM DBO.Reportes WHERE (FECHA >='" + this.dateTimePicker1.Text + "' AND FECHA <= '" + this.dateTimePicker2.Text + "') AND (Estado = 'Abierto' or Estado = 'En espera') ORDER BY Codigo DESC;");
                        // Muestra la cantidad de filas que aparecen con la misma query de actualizar...
                        this.lbl_Filas.Text = manipularDatos.FilasMostradas("SELECT * FROM DBO.Reportes WHERE (FECHA >='" + this.dateTimePicker1.Text + "' AND FECHA <= '" + this.dateTimePicker2.Text + "') AND (Estado = 'Abierto' or Estado = 'En espera') ORDER BY Codigo DESC;").ToString() + " Filas";
                        break;
                } // Fin switch.....
            }  // Fin del if.....
            // Muestra la cantidad de filas seleccionadas...
            int i = Convert.ToInt32(this.datagv1.SelectedRows.Count);
            this.label3.Text = i.ToString() + " Seleccionadas";
            if (i == 0)
            {
                MessageBox.Show("Ningun resultado para esta busqueda", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
