using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace Taxonomy.Models
{
  public class Phylum
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public string Origin { get; set; }
    public string Zone { get; set; }
    public int Id { get; set; }

    public Phylum(string name, string description, string origin, string zone)
    {
      Name = name;
      Description = description;
      Origin = origin;
      Zone = zone;
    }
    
    public Phylum(string name, string description, string origin, string zone, int id)
    {
      Name = name;
      Description = description;
      Origin = origin;
      Zone = zone;
      Id = id;
    }

    public override bool Equals(System.Object otherPhylum)
    {
      if (!(otherPhylum is Phylum))
      {
        return false;
      }
      else
      {
        Phylum newPhylum = (Phylum) otherPhylum;
        bool idEquality = (this.Id == newPhylum.Id);
        bool nameEquality = (this.Name == newPhylum.Name);
        bool descriptionEquality = (this.Description == newPhylum.Description);
        bool originEquality = (this.Origin == newPhylum.Origin);
        bool zoneEquality = (this.Zone == newPhylum.Zone);
        return (idEquality && nameEquality && descriptionEquality && originEquality && zoneEquality);
      }
    }

    public static List<Phylum> GetAll()
    {
      List<Phylum> allPhylums = new List<Phylum> { };
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM phylums;";
      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
      while (rdr.Read())
      {
          int phylumId = rdr.GetInt32(0);
          string phylumName = rdr.GetString(1);
          string phylumDescription = rdr.GetString(2);
          string phylumOrigin = rdr.GetString(3);
          string phylumZone = rdr.GetString(4);
          Phylum newPhylum = new Phylum(phylumName, phylumDescription, phylumOrigin, phylumZone, phylumId);
          allPhylums.Add(newPhylum);
      }
      conn.Close();
      if (conn != null)
      {
          conn.Dispose();
      }
      return allPhylums;
    }
      
    public static void ClearAll()
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      var cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"DELETE FROM phylums;";
      cmd.ExecuteNonQuery();
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
    }
    
  }
}