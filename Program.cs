

using ConsoleApp1;
using ConsoleApp1.clase8;
using System.Data;
using System.Data.SqlClient;

class Program
{    static void Main(string[] args)
    {
        SqlConnectionStringBuilder conecctionbuilder = new();
        conecctionbuilder.DataSource = "DAVID-LAPTOP";
        conecctionbuilder.InitialCatalog = "SistemaGestion";
        conecctionbuilder.IntegratedSecurity = true;
        var cs = conecctionbuilder.ConnectionString;

        using (SqlConnection connection = new SqlConnection(cs))
        {
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Insert into Usuarios (id, Nombre, Apellido, NombreUsuario, Contraseña, Mail)" +
                                "values " +
                                "(121212, 'juan', 'torres', '@Juan', 'asdasdsa', 'juan@gmail.com');";

            // valorId =  Convert.ToInt32(cmd.ExecuteScalar());
            cmd.ExecuteNonQuery();
            

            connection.Close();
        }
    }
}