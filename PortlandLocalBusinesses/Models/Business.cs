using System; 
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PortlandLocalBusinesses.Models
{
  public class Business
  {
    public int BusinessId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string PhoneNumber { get; set; }
    public int NeighborhoodId { get; set; }
		// public Neighborhood Neighborhood { get; set; }
	
    public static List<Business> GetBusinesses()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Business> businessList = JsonConvert.DeserializeObject<List<Business>>(jsonResponse.ToString());

      return businessList;
    }
  }
}