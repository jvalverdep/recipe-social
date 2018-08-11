using System;
using RecipeSocial.Domain.Entities;
using System.Collections.Generic;
namespace RecipeSocial.Domain.Services
{
    public interface IMeasureService
    {
        ICollection<Measure> GetMeasures();
    }
}
