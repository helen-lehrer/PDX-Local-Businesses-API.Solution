using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PdxLocalBusinesses.Models;
using System.Linq;
using System;
using Microsoft.AspNetCore.Authorization;
using PdxLocalBusinesses.Repository;

namespace PdxLocalBusinesses.Controllers
{
  [Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class BusinessesController : ControllerBase
	{
		private readonly PdxLocalBusinessesContext _db;
    private readonly IJWTManagerRepository _jWTManager;

		public BusinessesController(PdxLocalBusinessesContext db, IJWTManagerRepository jWTManager)
		{
			_db = db;
      this._jWTManager = jWTManager;

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

    private bool BusinessExists(int id)
		{
			return _db.Businesses.Any(m => m.BusinessId == id);
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<Business>>> Get(string name)
		{
			IQueryable<Business> query = _db.Businesses.AsQueryable();

			if (name != null)
			{
				query = query.Where(m => m.Name == name);
			}

			return await query.ToListAsync();
		}

		[HttpPost]
		public async Task<ActionResult<Business>> Post(Business business)
		{
			_db.Businesses.Add(business);
			await _db.SaveChangesAsync();
			return CreatedAtAction(nameof(GetBusiness), new {id = business.BusinessId}, business);
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<Business>> GetBusiness(int id)
		{
			Business business = await _db.Businesses.FindAsync(id);
			if (business == null)
			{
				return NotFound();
			}
			return business;
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> Put(int id, Business business)
		{
			if (id != business.BusinessId)
			{
				return BadRequest();
			}

			_db.Entry(business).State = EntityState.Modified;

			try
			{
				await _db.SaveChangesAsync();
			}
			catch(DbUpdateConcurrencyException)
			{
				if(!BusinessExists(id))
				{
					return NotFound();
				}
				else
				{
					throw;
				}
			}
			return NoContent();
		}

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteBusiness(int id)
    {
      var business = await _db.Businesses.FindAsync(id);
      if (business == null)
      {
        return NotFound();
      }

      _db.Businesses.Remove(business);
      await _db.SaveChangesAsync();

      return NoContent();
    }
	}
}
