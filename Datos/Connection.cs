using System.Data.SqlClient;

namespace Datos
{
    public class Connection
    {
        private SqlConnection db = new SqlConnection(
                "Data source=.; initial catalog=db_clinic; integrated security=true"
            );

        public SqlConnection DB()
        {
            return this.db;
        }
    }
}