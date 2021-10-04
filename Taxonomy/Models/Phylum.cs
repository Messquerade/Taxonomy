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
      Id = id
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
  }
}