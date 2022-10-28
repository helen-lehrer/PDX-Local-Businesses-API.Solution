// using System; 
// using System.ComponentModel.DataAnnotations;
// using System.Collections.Generic;
// using Newtonsoft.Json;
// using Newtonsoft.Json.Linq;

// namespace PortlandLocalBusinesses.Models
// {
//   public class Message
//   {
//     public int MessageId { get; set; }
//     public string Title { get; set; }
//     public string Body { get; set; }
//     [DataType(DataType.Date)]
//     public DateTime Date { get; set; }
//     public string Author { get; set; }
//     public int GroupId { get; set; }
// 		// public Group Group { get; set; }
	

//     public static List<Message> GetMessages()
//     {
//       var apiCallTask = ApiHelper.GetAll();
//       var result = apiCallTask.Result;

//       JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
//       List<Message> messageList = JsonConvert.DeserializeObject<List<Message>>(jsonResponse.ToString());

//       return messageList;
//     }
//   }
// }