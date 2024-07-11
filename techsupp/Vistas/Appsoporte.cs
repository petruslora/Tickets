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
    public partial class Appsoporte : Form
    {
        private string UsuarioActual;
        private Datos datos = new Datos();
        private int Codigo;
        private string Fecha, Tecnico, Estado, Departamento, ProblemasCon, No_AF, Comentario;
        Usuario usuario = new Usuario();

        public Appsoporte(string usuarioActual)
        {
            InitializeComponent();
            this.UsuarioActual = usuarioActual; 
            // Altura de las filas del datagv1...
            DataGridViewRow row = this.datagv1.RowTemplate;
            row.Height = 24;
            ActualizarThisDataGrid();
        }
        private void appsoporte_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSA.Reportes' table. You can move, or remove it, as needed.
            //this.reportesTableAdapter.Fill(this.dSA.Reportes);
            this.lbl_usuarioactual.Text = datos.GetNombreDelUsuario(this.UsuarioActual);
            this.lbl_fecha.Text = this.dateTimePicker1.Text;
            this.dateTimePicker1.Hide();
            this.dateTimePicker2.Focus();
            TicketPendiente();
            if (usuario.TipoDeUsuario(this.UsuarioActual) == true)
            {
                this.editarToolStripMenuItem2.Enabled = true;
            }
            else
            {
                this.editarToolStripMenuItem2.Enabled = false;
            }
        }
        public void Ticket_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Cuando el formulario "Ticket" se cierre se ejecutara este codigo....
            ActualizarThisDataGrid();
        }
        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            new Busqueda_Avanzada(this.UsuarioActual).Show();
        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Hola, estas seguro que quieres salir?", "Seguro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void crearTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearTicket();
        }
        private void abrirTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearTicket();
        }
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            CrearTicket();
        }
        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CrearTicket();
        }
        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerTicket();
        }
        private void verToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            VerTicket();
        }
        private void datagv1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) // Evento DoubleClick del Data Grid...
        {
            VerTicket();
        }
        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditarTicket();
        }
        private void btn_Editar_Click(object sender, EventArgs e)
        {
            EditarTicket();
        }
        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarTicket();
        }
        private void eliminarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            EliminarTicket();
        }
        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EliminarTicket();
        }
        private void datagv1_MouseClick(object sender, MouseEventArgs e)
        {
            // Muestra la cantidad de filas seleccionadas...
            int i = Convert.ToInt32(this.datagv1.SelectedRows.Count);
            this.label2.Text = i.ToString() + " Seleccionadas";
        }
        private void nuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginNuevoUsuario();
        }
        private void administrarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Ver_Usuarios(this.UsuarioActual).Show();
        }
        private void actualizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Metodo que es como si le daria click al boton buscar...
            ActualizarThisDataGrid();
        }
        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hola, estas seguro que quieres salir?", "Seguro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void cambiarMiContraseñaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            new Editar_Usuario(this.UsuarioActual).Show();
        }
        private void filtroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Busqueda_Avanzada(this.UsuarioActual).Show();
        }
        private void appsoporte_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }     
        private void btn_quitar_filtro_Click(object sender, EventArgs e)
        {
            QuitarFiltro();
        }
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            new Busqueda_Avanzada(this.dateTimePicker2.Text, this.dateTimePicker3.Text, this.checkB_incluirfecha, this.checkB_Pendiente, this.cb_categoria.Text, this.tb_Buscar.Text).Show();
        }
        private void cb_categoria_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarThisDataGrid();
        }
        private void hoyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime thisDay = DateTime.Today;
            datos.ActualizarGrid(this.datagv1, "SELECT * FROM dbo.Reportes WHERE Fecha = '" + thisDay.ToString("d") + "' ORDER BY Codigo DESC");
            this.lbl_Filas.Text = datos.FilasMostradas("SELECT * FROM dbo.Reportes WHERE Fecha = '" + thisDay.ToString("d") + "' ORDER BY Codigo DESC").ToString() + " Filas";
            // Muestra la cantidad de filas seleccionadas...
            int i = Convert.ToInt32(this.datagv1.SelectedRows.Count);
            this.label2.Text = i.ToString() + " Seleccionadas";
        }
        private void TicketPendiente() // Avisa al tecnico los ticket que no se han cerrado cuando inicia sesion...
        {
            int i = Convert.ToInt32(datos.FilasMostradas("SELECT * FROM dbo.Reportes WHERE Estado = 'abierto' or Estado = 'en espera';"));
            if (i > 0)
            {
                MessageBox.Show("Hola, hay " + i + " Ticket que no se han cerrado. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void ActualizarThisDataGrid()
        {
            DateTime thisDay = DateTime.Today;
            datos.ActualizarGrid(this.datagv1, "SELECT * FROM dbo.Reportes ORDER BY Codigo DESC");
            // Actualiza la cantidad de filas mostradas...
            this.lbl_Filas.Text = datos.FilasMostradas("SELECT * FROM dbo.Reportes ORDER BY Codigo DESC;").ToString() + " Filas";
            // Muestra la cantidad de filas seleccionadas...
            int i = Convert.ToInt32(this.datagv1.SelectedRows.Count);
            this.label2.Text = i.ToString() + " Seleccionadas";
        }
        private void QuitarFiltro()
        {
            this.dateTimePicker2.Text = this.dateTimePicker1.Text;
            this.dateTimePicker3.Text = this.dateTimePicker1.Text;
            this.cb_categoria.Text = "No. Ticket";
            this.tb_Buscar.Text = "";
            this.checkB_incluirfecha.Checked = false;
            this.checkB_Pendiente.Checked = false;
        }
        private void editarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Reset_Pass reset_Pass = new Reset_Pass(this.UsuarioActual);
            reset_Pass.Show();
        }
        public void CrearTicket()
        {
            Crear_Ticket mostrar = new Crear_Ticket(this.UsuarioActual);
            // Esta Con esta linea llamamos el evento "FormClosed" antes de mostrar el formulario "Ticket".....
            mostrar.FormClosed += new FormClosedEventHandler(Ticket_FormClosed);
            mostrar.ShowDialog();
        }
        public void VerTicket()
        {
            try
            {
                Codigo = Convert.ToInt32(this.datagv1.CurrentRow.Cells[0].Value.ToString());
                Fecha = this.datagv1.CurrentRow.Cells[1].Value.ToString();
                Tecnico = this.datagv1.CurrentRow.Cells[2].Value.ToString();
                Estado = this.datagv1.CurrentRow.Cells[3].Value.ToString();
                Departamento = this.datagv1.CurrentRow.Cells[4].Value.ToString();
                ProblemasCon = this.datagv1.CurrentRow.Cells[5].Value.ToString();
                No_AF = this.datagv1.CurrentRow.Cells[6].Value.ToString();
                Comentario = this.datagv1.CurrentRow.Cells[7].Value.ToString();

                new Ver_Tickets(Codigo, Fecha, Tecnico, Estado, Departamento, ProblemasCon, No_AF, Comentario).Show(this.datagv1);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Debe seleccionar una fila para ver su contenido");
            }
        }
        public void EditarTicket()
        {
            try
            {
                Codigo = Convert.ToInt32(this.datagv1.CurrentRow.Cells[0].Value);
                Fecha = this.datagv1.CurrentRow.Cells[1].Value.ToString();
                Tecnico = this.datagv1.CurrentRow.Cells[2].Value.ToString();
                Estado = this.datagv1.CurrentRow.Cells[3].Value.ToString();
                Departamento = this.datagv1.CurrentRow.Cells[4].Value.ToString();
                ProblemasCon = this.datagv1.CurrentRow.Cells[5].Value.ToString();
                No_AF = this.datagv1.CurrentRow.Cells[6].Value.ToString();
                Comentario = this.datagv1.CurrentRow.Cells[7].Value.ToString();

                Editar_Ticket mostrar = new Editar_Ticket(Codigo, Fecha, Tecnico, Estado, Departamento, ProblemasCon, No_AF, Comentario);
                // Esta Con esta linea llamamos el evento "FormClosed" antes de mostrar el formulario "Ticket".....
                mostrar.FormClosed += new FormClosedEventHandler(Ticket_FormClosed);
                mostrar.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void EliminarTicket()
        {
            if (UsuarioActual == this.datagv1.CurrentRow.Cells[2].Value.ToString())
            { 
                new Tickets(Convert.ToInt32(this.datagv1.CurrentRow.Cells[0].Value)).EliminarTicket();
                ActualizarThisDataGrid();
            }
            else
                MessageBox.Show("Solo puedes eliminar los Tickets creados por ti...", "Error");
        }
        public void LoginNuevoUsuario()
        {
            new Login_Nuevo_Usuario(this.UsuarioActual).Show();
        }
    }
}
