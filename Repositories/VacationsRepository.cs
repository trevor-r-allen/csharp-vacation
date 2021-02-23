using System;
using System.Collections.Generic;
using System.Data;
using csharp_vacation.Models;
using Dapper;

namespace csharp_vacation.Repositories
{
  public class VacationsRepository
  {
    private readonly IDbConnection _db;

    public VacationsRepository(IDbConnection db)
    {
      _db = db;
    }

    internal IEnumerable<Vacation> GetAll()
    {
      string sql = "SELECT * FROM trips, cruises;";
      return _db.Query<Vacation>(sql);
    }
  }
}