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
	public class NeighborhoodsController : ControllerBase
	{
		private readonly PdxLocalBusinessesContext _db;

		public NeighborhoodsController(PdxLocalBusinessesContext db)
		{
			_db = db;
		}

    private bool NeighborhoodExists(int id)
		{
			return _db.Neighborhoods.Any(m => m.NeighborhoodId == id);
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<Neighborhood>>> Get(string name)
		{
      IQueryable<Neighborhood> query = _db.Neighborhoods.Include(g => g.Businesses).AsQueryable();

			if (name != null)
			{
				query = query.Where(m => m.Name == name);
			}
			return await query.ToListAsync();
		}

		[HttpPost]
		public async Task<ActionResult<Neighborhood>> Post(Neighborhood neighborhood)
		{
			_db.Neighborhoods.Add(neighborhood);
			await _db.SaveChangesAsync();
			return CreatedAtAction(nameof(GetNeighborhood), new {id = neighborhood.NeighborhoodId}, neighborhood);
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<IEnumerable<Neighborhood>>> GetNeighborhood(int id)
		{
      IQueryable<Neighborhood> neighborhood = _db.Neighborhoods.Include(n => n.Businesses).AsQueryable().Where(n => n.NeighborhoodId == id);
			if (neighborhood == null)
			{
				return NotFound();
			}
			return await neighborhood.ToListAsync();
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> Put(int id, Neighborhood neighborhood)
		{
			if (id != neighborhood.NeighborhoodId)
			{
				return BadRequest();
			}

			_db.Entry(neighborhood).State = EntityState.Modified;

			try
			{
				await _db.SaveChangesAsync();
			}
			catch(DbUpdateConcurrencyException)
			{
				if (!NeighborhoodExists(id))
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
    public async Task<IActionResult> Delete(int id)
    {
      var neighborhood = await _db.Neighborhoods.FindAsync(id);
      if (neighborhood == null)
      {
        return NotFound();
      }

      _db.Neighborhoods.Remove(neighborhood);
      await _db.SaveChangesAsync();

      return NoContent();
    }
	}
}