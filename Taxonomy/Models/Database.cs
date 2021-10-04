using System;
using MySql.Data.MySqlClient;
using Taxonomy;

namespace Taxonomy.Models
{
  public class DB
  {
    public static MySqlConnection Connection()
    {
      MySqlConnection conn = new MySqlConnection(DBConfiguration.ConnectionString);
      return conn;
    }
  }
}