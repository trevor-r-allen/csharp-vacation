using System;
using csharp_vacation.Models;
using csharp_vacation.Repositories;

namespace csharp_vacation.Services
{
  public class CruisesService
  {
    private readonly CruisesRepository _cruisesRepository;

    public CruisesService(CruisesRepository cruisesRepository)
    {
      _cruisesRepository = cruisesRepository;
    }

    internal object GetAll()
    {
      throw new NotImplementedException();
    }

    internal object GetById(int id)
    {
      throw new NotImplementedException();
    }

    internal object Create(Cruise newCruise)
    {
      throw new NotImplementedException();
    }

    internal object Edit(int id, Cruise editedCruise)
    {
      throw new NotImplementedException();
    }

    internal object Delete(int id)
    {
      throw new NotImplementedException();
    }
  }
}