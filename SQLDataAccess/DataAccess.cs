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

        public void insertPerson(string firstName, string lastName, string emailAddress, string phone)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnVal("Sample")))
            {
                List<Person> people = new List<Person>();
                people.Add(new Person { FirstName = firstName, LastName = lastName, EmailAddress = emailAddress, PhoneNumber = phone });
                connection.Execute("dbo.People_Insert @FirstName, @LastName, @EmailAddress, @PhoneNumber", people);
            }
        }
    }
}
