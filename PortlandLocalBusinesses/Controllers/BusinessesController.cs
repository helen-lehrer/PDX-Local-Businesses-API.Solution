using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortlandLocalBusinesses.Models;
using System.Linq;
using System;

namespace PortlandLocalBusinesses.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BusinessesController : ControllerBase
	{
		private readonly PortlandLocalBusinessesContext _db;

		public BusinessesController(PortlandLocalBusinessesContext db)
		{
			_db = db;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<Business>>> Get()
		{
			// IQueryable<Business> query = _db.Businesses.AsQueryable();

			// if (name != null)
			// {
			// 	query = query.Where(m => m.Name == name);
			// }

			// if (description != null)
			// {
			// 	query = query.Where(m => m.Description >= description);
			// }
			return await _db.Businesses.ToListAsync();
		}

		[HttpPost]
		public async Task<ActionResult<Business>> Post(Business business)
		{
			_db.Businesses.Add(business);
			await _db.SaveChangesAsync();
			return CreatedAtAction("Post", new {id = business.BusinessId}, business);
		}

		// [HttpGet("{id}")]
		// public async Task<ActionResult<Business>> GetBusiness(int id)
		// {
		// 	Business business = await _db.Businesses.FindAsync(id);
		// 	if (business == null)
		// 	{
		// 		return NotFound();
		// 	}
		// 	return CreatedAtAction(nameof(GetBusiness), new { id = business.BusinessId }, business);
		// }

		// [HttpPut("{id}")]
		// public async Task<IActionResult> Put(int id, Business business)
		// {
		// 	if (id != business.BusinessId)
		// 	{
		// 		return BadRequest();
		// 	}

		// 	_db.Entry(business).State = EntityState.Modified;

		// 	try
		// 	{
		// 		await _db.SaveChangesAsync();
		// 	}
		// 	catch(DbUpdateConcurrencyException)
		// 	{
		// 		if(!BusinessExists(id))
		// 		{
		// 			return NotFound();
		// 		}
		// 		else
		// 		{
		// 			throw;
		// 		}
		// 	}
		// 	return NoContent();
		// }

		// private bool BusinessExists(int id)
		// {
		// 	return _db.Businesses.Any(m => m.BusinessId == id);
		}
	}
