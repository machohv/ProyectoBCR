using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DAO_CONNECTION_STRING
    {
    
            private static SqlConnection CON;

            public static SqlConnection getConnectionInstance()
            {
                if (CON == null)
                {
                    CON = new SqlConnection(DataAccess.Properties.Settings.Default.ConnectionString);
                }
                return CON;
            

        }

    }
}
