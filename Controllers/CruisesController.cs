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
    public ActionResult<Cruise> GetById(int id)
    {
      try
      {
        return Ok(_cruisesService.GetById(id));
      }
      catch (System.Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    [HttpPost]
    public ActionResult<Cruise> Create([FromBody] Cruise newCruise)
    {
      try
      {
        return Ok(_cruisesService.Create(newCruise));
      }
      catch (System.Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    [HttpPut("{id}")]
    public ActionResult<Cruise> Edit(int id, [FromBody] Cruise editedCruise)
    {
      try
      {
        return Ok(_cruisesService.Edit(id, editedCruise));
      }
      catch (System.Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    [HttpDelete("{id}")]
    public ActionResult<Cruise> Delete(int id)
    {
      try
      {
        return Ok(_cruisesService.Delete(id));
      }
      catch (System.Exception err)
      {
        return BadRequest(err.Message);
      }
    }
  }
}