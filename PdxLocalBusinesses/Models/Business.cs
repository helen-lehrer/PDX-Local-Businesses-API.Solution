using System; 
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PdxLocalBusinesses.Models
{
  public class Business
  {
    public int BusinessId { get; set; }
    [Required]
    [StringLength(50)]
    public string Name { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    public string PhoneNumber { get; set; }
    public int NeighborhoodId { get; set; }
    [JsonIgnore]
		public Neighborhood Neighborhood { get; set; }
  }
}