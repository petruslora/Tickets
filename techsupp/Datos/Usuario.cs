using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace techsupp
{
    public class Usuario : Conexion
    {
        public string TipoUsuario { get; set; }

        public bool ValidarUsuario(string user, string password)
        {
            bool valido = false;
            Query = @"SELECT NombreUsuario, Contraseña from dbo.Tab_Usuarios 
                                 where NombreUsuario='" + user + "' and PWDCOMPARE('" + password + "', Contraseña) = 1";
            Comando = new SqlCommand(Query, AbrirBD());  // ejecuta el query

            Reader = Comando.ExecuteReader();  // asigna el resultado del select del command al reader
            if (Reader.HasRows == true)  // si el reader tiene valor de el select anterior el estatus es valido(true)
            {
                valido = true;
            }
            CerrarBD();
            return valido;
        }
        public Boolean TipoDeUsuario(string usuario)
        {
            Boolean admin = false;
            string query = "SELECT TipoUsuario FROM dbo.Tab_Usuarios where NombreUsuario = '" + usuario + "';";
            Comando = new SqlCommand(query, AbrirBD());
            Reader = Comando.ExecuteReader();
            if (Reader.Read())
            {
                TipoUsuario = Reader["TipoUsuario"].ToString();
            }
            CerrarBD(); //Cerramos la BD...
            if (TipoUsuario == "Administrador")
                admin = true;
            else
                admin = false;
            return admin;
        }
        public void CrearUsuario(string nombreDeUsuario, string nombreCompleto, string password, string tipoDeUsuario)
        {
            Query = (@"exec crear_Usuario @nombredeusuario, @nombrecompleto, @password, @tipodeusuario");
            Comando = new SqlCommand(Query, AbrirBD());
            Comando.Parameters.Add("@nombredeusuario", SqlDbType.VarChar).Value = nombreDeUsuario;
            Comando.Parameters.Add("@nombrecompleto", SqlDbType.VarChar).Value = nombreCompleto; ;
            Comando.Parameters.Add("@password", SqlDbType.VarChar).Value = password; ;
            Comando.Parameters.Add("@tipodeusuario", SqlDbType.VarChar).Value = tipoDeUsuario; ;
            try
            {
                int FilasAfectadas = Comando.ExecuteNonQuery();
                CerrarBD();
                if (FilasAfectadas > 0)
                {
                    MessageBox.Show("El usuario '" + nombreDeUsuario + "' ha sido creado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception) { MessageBox.Show("Ha ocurrido un error por favor intentelo de nuevo"); 
            }
        }
        public void EliminarUsuario(string usuarioActual)
        {
            try
            {
                if (MessageBox.Show("Esta seguro que quiere eliminar el usuario " + usuarioActual, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    Query = "EXEC eliminar_Usuario @Usuario;";

                    Comando = new SqlCommand(Query, AbrirBD());
                    Comando.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = usuarioActual;
                    int FilasAfectadas = Comando.ExecuteNonQuery();
                    AbrirBD();
                    if (FilasAfectadas > 0)
                        MessageBox.Show("El usuario " + usuarioActual.ToString() + " ha sido eliminado satisfactoriamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Debe seleccionar una fila para realizar esta operacion", "Error");
            }
        }
    }
}

