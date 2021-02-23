using System.Collections.Generic;
using csharp_vacation.Models;
using csharp_vacation.Services;
using Microsoft.AspNetCore.Mvc;

namespace csharp_vacation.Controllers
{

  [ApiController]
  [Route("api/[controller]")]
  class CruisesController : ControllerBase
  {
    private readonly CruisesService _cruisesService;
    public CruisesController(CruisesService cruisesService)
    {
      _cruisesService = cruisesService;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Cruise>> GetAll()
    {
      try
      {
        return Ok(_cruisesService.GetAll());
      }
      catch (System.Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    [HttpGet("{id}")]
    public ActionResult<Cruise> GetById()
    {
      try
      {
        return Ok(_cruisesService.GetById());
      }
      catch (System.Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    [HttpPost]
    public ActionResult<Cruise> Create()
    {
      try
      {
        return Ok(_cruisesService.Create());
      }
      catch (System.Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    [HttpPut("{id}")]
    public ActionResult<Cruise> Edit()
    {
      try
      {
        return Ok(_cruisesService.Edit());
      }
      catch (System.Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    [HttpDelete("{id}")]
    public ActionResult<Cruise> Delete()
    {
      try
      {
        return Ok(_cruisesService.Delete());
      }
      catch (System.Exception err)
      {
        return BadRequest(err.Message);
      }
    }
  }
}