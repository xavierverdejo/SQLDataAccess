using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace SQLDataAccess
{
    public class DataAccess
    {
        public List<Person> getPeopleByLastName(string lastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnVal("Sample")))
            {
                var output =  connection.Query<Person>("dbo.People_GetByLastName @LastName", new { LastName = lastName}).ToList();
                return output;
            }
        }
    }
}
