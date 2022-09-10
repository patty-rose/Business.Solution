using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Business.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class ShopsController : ControllerBase
  {
    private readonly ILogger<ShopsController> _logger;
    private readonly BusinessContext _db;

    public ShopsController(ILogger<ShopsController> logger, BusinessContext db)
    {
      _logger = logger;
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Shop>>> Get(string name, string shopType, string typeCategory)
    {
      var query = _db.Shops.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }
      if (shopType != null)
      {
        query = query.Where(entry => entry.ShopType == shopType);
      }
      if (typeCategory != null)
      {
        query = query.Where(entry => entry.TypeCategory == typeCategory);
      }
      
      return await query.ToListAsync();
    }

  }
}
