using System;
using System.Collections.Generic;
using csharp_vacation.Models;
using csharp_vacation.Repositories;

namespace csharp_vacation.Services
{
  public class VacationsService
  {
    private readonly VacationsRepository _vacationsRepository;

    public VacationsService(VacationsRepository vacationsRepository)
    {
      _vacationsRepository = vacationsRepository;
    }

    internal IEnumerable<Vacation> GetAll()
    {
      return _vacationsRepository.GetAll();
    }
  }
}