using PdxLocalBusinesses.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using PdxLocalBusinesses.Repository;

namespace PdxLocalBusinesses.Controllers
{
  [Authorize]
  [Route("api/[controller]")]
  [ApiController]  
  public class UsersController : ControllerBase
  {
    private readonly PdxLocalBusinessesContext _db;
    private readonly IJWTManagerRepository _jWTManager;

		public UsersController(PdxLocalBusinessesContext db, IJWTManagerRepository jWTManager)
		{
			_db = db;
      this._jWTManager = jWTManager;

		}

    [HttpGet]
    public List<string> Get()
    {
      //link to database
      var users = new List<string>
      {
        "Satinder Singh",
        "Amit Sarna",
        "Davin Jon"
      };

      return users;
    }

    [AllowAnonymous]
    [HttpPost]
    [Route("authenticate")]
    public IActionResult Authenticate(User usersdata)
    {
      var token = _jWTManager.Authenticate(usersdata);

      if (token == null)
      {
        return Unauthorized();
      }

      return Ok(token);
    }
  }
}