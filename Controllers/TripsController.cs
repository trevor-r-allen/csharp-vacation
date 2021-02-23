using System.Collections.Generic;
using csharp_vacation.Models;
using csharp_vacation.Services;
using Microsoft.AspNetCore.Mvc;

namespace csharp_vacation.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  class TripsController : ControllerBase
  {
    private readonly TripsService _tripsService;
    public TripsController(TripsService tripsService)
    {
      _tripsService = tripsService;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Trip>> GetAll()
    {
      try
      {
        return Ok(_tripsService.GetAll());
      }
      catch (System.Exception err)
      {

        return BadRequest(err.Message);
      }
    }
    [HttpGet("{id}")]
    public ActionResult<Trip> GetById(int id)
    {
      try
      {
        return Ok(_tripsService.GetById(id));
      }
      catch (System.Exception err)
      {

        return BadRequest(err.Message);
      }
    }
    [HttpPost]
    public ActionResult<Trip> Create([FromBody] Trip newTrip)
    {
      try
      {
        return Ok(_tripsService.Create(newTrip));
      }
      catch (System.Exception err)
      {

        return BadRequest(err.Message);
      }
    }
    [HttpPut("{id}")]
    public ActionResult<Trip> Edit(int id, [FromBody] Trip editedTrip)
    {
      try
      {
        return Ok(_tripsService.Edit(id, editedTrip));
      }
      catch (System.Exception err)
      {

        return BadRequest(err.Message);
      }
    }
    [HttpDelete("{id}")]
    public ActionResult<Trip> Delete(int id)
    {
      try
      {
        return Ok(_tripsService.Delete(id));
      }
      catch (System.Exception err)
      {

        return BadRequest(err.Message);
      }
    }
  }
}