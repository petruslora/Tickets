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
    public partial class Ver_Usuarios : Form
    {
        private string UsuarioActual; //atributo para esta clase...
        Datos datos = new Datos();
        Usuario usuario = new Usuario();
        public Ver_Usuarios(string usuarioActual)
        {
            InitializeComponent();
            UsuarioActual = usuarioActual;
            //datos.ActualizarGrid(this.dgridv, "SELECT IdUsuario, NombreUsuario, NombreCompleto, TipoUsuario FROM dbo.Tab_Usuarios ORDER BY IdUsuario");
        }
        private void Ver_Usuarios_Load(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            datos.ActualizarGrid(this.DATAGRID, "SELECT IdUsuario, NombreUsuario, NombreCompleto, TipoUsuario FROM dbo.Tab_Usuarios ORDER BY IdUsuario");
        }
        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nuevo_Usuario mostrar = new Nuevo_Usuario();
            // Esta Con esta linea llamamos el evento "FormClosed" antes de mostrar el formulario "Ticket".....
            mostrar.FormClosed += new FormClosedEventHandler(Nuevo_usuario_FormClosed);
            mostrar.ShowDialog();
        }
        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usuario.EliminarUsuario(UsuarioActual);
        }
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            this.dgridv.Refresh();
            datos.ActualizarGrid(this.dgridv, "SELECT IdUsuario, NombreUsuario, NombreCompleto, TipoUsuario FROM dbo.Tab_Usuarios ORDER BY IdUsuario");
        }
        private void Nuevo_usuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.dgridv.Refresh();
            datos.ActualizarGrid(this.dgridv, "SELECT IdUsuario, NombreUsuario, NombreCompleto, TipoUsuario FROM dbo.Tab_Usuarios ORDER BY IdUsuario");
        }
    }
}
