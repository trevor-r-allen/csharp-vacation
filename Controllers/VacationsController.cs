using System.Collections.Generic;
using csharp_vacation.Models;
using csharp_vacation.Services;
using Microsoft.AspNetCore.Mvc;

namespace csharp_vacation.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  class VacationsController : ControllerBase
  {
    private readonly VacationsService _vacationsService;

    public VacationsController(VacationsService vacationsService)
    {
      _vacationsService = vacationsService;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Vacation>> GetAll()
    {
      try
      {
        var data = _vacationsService.GetAll();
        return Ok(data);
      }
      catch (System.Exception err)
      {

        return BadRequest(err.Message);
      }
    }
  }
}