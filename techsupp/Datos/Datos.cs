using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace techsupp
{
    internal class Datos : Conexion
    {
        public int GetCodigoTicket()
        {
            Query = "SELECT Codigo FROM dbo.Reportes ORDER BY Codigo DESC;";
            Comando = new SqlCommand(Query, AbrirBD());
            Reader = Comando.ExecuteReader();
            int codigoUltimoTicket = 0;
            if (Reader.Read())
            {
                codigoUltimoTicket = Convert.ToInt32(Reader["Codigo"]);
            }
            int codigoTicket = codigoUltimoTicket + 1;
            CerrarBD();
            return codigoTicket;
        }
        public string GetNombreDelUsuario(string UsuarioActual) // Muestra el usuario que inicio sesion...
        {
            string UserFullName = "";
            Query = "EXEC select_nombreCompletoUsuario '" + UsuarioActual + "';";
            Comando = new SqlCommand(Query, AbrirBD());
            Reader = Comando.ExecuteReader();
            if (Reader.Read())
            {
                UserFullName = (Reader["NombreCompleto"].ToString());
            }
            CerrarBD();
            return UserFullName;
        }
        public int FilasMostradas(string query)
        {
            Comando = new SqlCommand(query, this.AbrirBD());
            Reader = Comando.ExecuteReader();
            int numeroDeFilas = 0;
            while (Reader.Read())
            {
                numeroDeFilas++;
            }
            CerrarBD();
            return numeroDeFilas;
        }
        public void EjecutarQuery(string query)
        {
            try
            {
                Comando = new SqlCommand(query, AbrirBD());
                int FilasAfectadas = Comando.ExecuteNonQuery();
                CerrarBD();
                if (FilasAfectadas == 0)
                {
                    MessageBox.Show("Ha ocurrido un error :( ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error por favor intentelo de nuevo");//"Ha ocurrido un error por favor intentelo de nuevo","Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
            }
        }
        public void ActualizarGrid(DataGridView dg, String Query)
        {
            AbrirBD();
            //crear DataSet
            MiDataSet = new DataSet();
            //Crear Adaptador de datos
            MiDataAdapter = new SqlDataAdapter(Query, BaseDeDatos);
            //LLenar el DataSet
            MiDataAdapter.Fill(MiDataSet, "Reportes");
            //Asignarle el valor adecuado a las propiedades del DataGrid
            dg.DataSource = MiDataSet;
            dg.DataMember = "Reportes";
            CerrarBD();
        }
    }
}
