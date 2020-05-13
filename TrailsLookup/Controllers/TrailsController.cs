using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TrailsLookup.Models;
using Microsoft.AspNetCore.Cors;

namespace TrailsLookup.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class TrailsController : ControllerBase
  {
    private readonly TrailsLookupContext _db;

    public TrailsController(TrailsLookupContext db)
    {
      _db = db;
    }

    // GET 'api/trails'
    [EnableCors("MyPolicy")]
    [HttpGet]
    public ActionResult<IEnumerable<Trail>> Get(string name)
    {
      var query = _db.Trails.AsQueryable();
      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }
      List<Trail> trailList = query.ToList();
      return trailList;
    }

    // GET 'api/trails/{id}'
    [EnableCors("MyPolicy")]
    [HttpGet("{id}")]
    public ActionResult<Trail> Get(int id)
    {
      return _db.Trails.FirstOrDefault(entry => entry.TrailId == id);
    }
  }
}