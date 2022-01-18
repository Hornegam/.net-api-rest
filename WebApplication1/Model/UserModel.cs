using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace WebApplication1.Model
{
    public class UserModel
    {
        SqliteConnection connection;
        public UserModel()
        {
            DB_Connection db_connection = new DB_Connection();
            this.connection = db_connection.Connection();
        }

        public IUser GetUserById(String id)
        {
            IUser user = new IUser();

            var command = this.connection.CreateCommand();
            command.CommandText = $"SELECT * FROM user_table WHERE id = '{id}'";

            var reader = command.ExecuteReader();

            user = GetUserByIdReader(reader);

            return user;
        }

        private IUser GetUserByIdReader(SqliteDataReader data)
        {
            IUser user = new IUser();

            while (data.Read())
            {
                user.id = data.GetInt32(0);
                user.name = data.GetString(1);
                user.age = data.GetInt32(2);
                user.CreditCard = data.GetString(3);
                user.CVV = data.GetString(4);
                user.token = data.GetString(5);
                user.email = data.GetString(6);
                user.password = data.GetString(7);
            }


            return user;
        }

    }
}
