using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Inventory
{
   public class DataAccess
    {
        public List<Person> GetPeople(string lastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Inventory")))
            {
                var output = connection.Query<Person>($"Select * from People Where LastName = '{lastName}'").ToList();
                return output;


                //Sample Changes
            }
        }
    }
}
