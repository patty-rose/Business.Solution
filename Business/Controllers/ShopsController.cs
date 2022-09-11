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

    [HttpPost]
    public async Task<ActionResult<Shop>> Post(Shop shop)
    {
      _db.Shops.Add(shop);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetShop), new { id = shop.ShopId }, shop);
    }  

    [HttpGet("{id}")]
    public async Task<ActionResult<Shop>> GetShop(int id)
    {
      var shop = await _db.Shops.FindAsync(id);

      if (shop == null)
      {
          return NotFound();
      }

      return shop;
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Shop shop)
    {
      if (id != shop.ShopId)
      {
        return BadRequest();
      }

      _db.Entry(shop).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!ShopExists(id))
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

    private bool ShopExists(int id)
    {
      return _db.Shops.Any(entry => entry.ShopId == id);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteShop(int id)
    {
      var shop = await _db.Shops.FindAsync(id);
      if (shop == null)
      {
        return NotFound();
      }

      _db.Shops.Remove(shop);
      await _db.SaveChangesAsync();

      return NoContent();
    }

  }
}
