﻿using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace CoolCat.Core.Repositories
{
    public class Command
    {
        public Command()
        {

        }

        public Command(string sql, List<MySqlParameter> parameters)
        {
            Sql = sql;
            Parameters = parameters;
        }

        public string Sql { get; set; }

        public List<MySqlParameter> Parameters { get; set; } = new List<MySqlParameter>();
    }
}
