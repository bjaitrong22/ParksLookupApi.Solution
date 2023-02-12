using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParksLookupApi.Models;

namespace ParksLookupApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ParksController: ControllerBase
  {
    private readonly ParksLookupApiContext _db;
    public ParksController(ParksLookupApiContext db)
    {
      _db = db;
    }

    //GET api/parks
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Park>>> Get()
    {
      return await _db.Parks.ToListAsync();
    }

    //Get: api/animals/4
    [HttpGet("{id}")]
    public async Task<ActionResult<Park>> GetPark(int id)
    {
      Park park = await _db.Parks.FindAsync(id);
    
      if (park == null)
      {
        return NotFound();
      }
      else
      {
        return park;
      }
    }
  }
}