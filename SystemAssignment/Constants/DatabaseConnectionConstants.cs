using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemAssignment.Constants
{
    public static class DatabaseConnectionConstants
    {
        public const string connectionString = "host=localhost;port=5432;username=postgres;password=admin;database=Bank-Data";
    }
}
