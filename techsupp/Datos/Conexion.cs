using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using techsupp.Properties;
using System.Configuration;
using System.Configuration.Provider;

namespace techsupp
{
    public class Conexion
    {
        public SqlDataReader Reader { get; set; }
        public SqlConnection BaseDeDatos { get; set; }
        public SqlCommand Comando { get; set; }
        public string Query { get; set; }
        public DataSet MiDataSet { get; set; }
        public SqlDataAdapter MiDataAdapter { get; set; }

        public SqlConnection AbrirBD() // Abre la BD 
        {
            string connetionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            BaseDeDatos = new SqlConnection(connetionString.ToString());
            BaseDeDatos.Open();
            return BaseDeDatos; 
        }
        public void CerrarBD() // Cierra la BD.....
        {   
            BaseDeDatos.Close();
        }
        public void EjecutarQuery(string query)
        {
            try { 
            Comando= new SqlCommand(query, AbrirBD());
            int FilasAfectadas = Comando.ExecuteNonQuery();
            CerrarBD();
            if (FilasAfectadas == 0)
            {
                MessageBox.Show("Ha ocurrido un error :( ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            } catch (Exception) {
                MessageBox.Show("Ha ocurrido un error por favor intentelo de nuevo");//"Ha ocurrido un error por favor intentelo de nuevo","Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
            }
        }
    }
}
