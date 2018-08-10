using RecipeSocial.Domain.Entities;
using RecipeSocial.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeSocial.Interface.Web.ViewModels
{
    public class IndexViewModel
    {
        public ICollection<Recipe> generalRecipeList { get; set; }
        public ICollection<Recipe> topList { get; set; }
    }
}
