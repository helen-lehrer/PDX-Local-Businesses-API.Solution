// using System.Threading.Tasks;

// namespace PortlandLocalBusinesses.Models
// {
// 	class ApiHelper
// 	{
// 		public static async Task<string> GetAll()
// 		{
// 			RestClient client = new RestClient("http://localhost:5000/api");
// 			RestRequest request = new RestRequest($"businesses", Method.GET);
// 			var response = await client.ExecuteAsyncTask(request);
// 			return response.Content;
// 		}
// 	}
// }