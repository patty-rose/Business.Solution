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


  }
}
