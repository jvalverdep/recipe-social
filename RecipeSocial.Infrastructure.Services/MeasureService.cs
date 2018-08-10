using System;
using System.Collections.Generic;
using RecipeSocial.Domain.Database;
using RecipeSocial.Domain.Entities;
using RecipeSocial.Domain.Services;
namespace RecipeSocial.Infrastructure.Services
{
    public class MeasureService : IMeasureService
    {
        private readonly IRepository<Measure> measureRpository;
        
        public MeasureService(IRepository<Measure> repository)
        {
            measureRpository = repository;
        }

        public ICollection<Measure> GetMeasures()
        {
            return measureRpository.GetAll();
        }
    }
}
