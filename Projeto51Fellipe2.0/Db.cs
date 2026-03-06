using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace Projeto51Fellipe2._0
{
    class Db
    {
        private const string stringconexao =

            "Server=localhost;Port=3306;Database=savora51 ;User ID=root;Password=";

        public static MySqlConnection Conecta()

        {
            return new MySqlConnection(stringconexao);
        }
    }
}
