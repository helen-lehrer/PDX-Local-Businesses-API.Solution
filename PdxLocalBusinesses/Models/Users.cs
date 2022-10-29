using System; 
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

public class User
{
  public int UserId { get; set; }
	public string Name { get; set; }
	public string Password { get; set; }
}