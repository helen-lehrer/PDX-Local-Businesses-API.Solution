using System; 
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PortlandLocalBusinesses.Models
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
	
    // public static List<Business> GetBusinesses()
    // {
    //   var apiCallTask = ApiHelper.GetAll();
    //   var result = apiCallTask.Result;

    //   JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
    //   List<Business> businessList = JsonConvert.DeserializeObject<List<Business>>(jsonResponse.ToString());

    //   return businessList;
    // }
  }
}