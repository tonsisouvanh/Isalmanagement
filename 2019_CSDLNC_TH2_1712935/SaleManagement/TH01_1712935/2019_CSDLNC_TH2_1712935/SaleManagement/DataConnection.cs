using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagement
{
    class DataConnection
    {
        string constr = @"Data Source=.\SQLEXPRESS;Initial Catalog=iSaleManagement;Integrated Security=True";
        public SqlConnection getConnect()
        {
            return new SqlConnection(constr);
        }
    }
}
