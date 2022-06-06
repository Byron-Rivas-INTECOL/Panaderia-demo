using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace InterfazImpresora.Datos
{
    public class ConexionBd
    {
        public static SqlConnectionStringBuilder builder;
        public static void ArranqueDb()
        {
            builder = new SqlConnectionStringBuilder
            {
                DataSource = "localhost",/*"DESKTOP-JMFP74O",*/
                UserID = "NodeRedUser",/*"sa",*/
                Password = "intecol.123",/*"12345",*/
                InitialCatalog = "INDUMIL"

            };
        }
          
    }
}
