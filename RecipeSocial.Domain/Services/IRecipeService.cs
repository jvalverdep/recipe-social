<<<<<<< HEAD
﻿using System;
using RecipeSocial.Domain.Entities;
using System.Collections.Generic;
=======
﻿using RecipeSocial.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

>>>>>>> 2fca37766e6b9cb83e4c759ea7c6db315116e106
namespace RecipeSocial.Domain.Services
{
    public interface IRecipeService
    {
<<<<<<< HEAD
        Recipe GetRecipe(int id);
        IEnumerable<Recipe> GetRecipes();
        void InsertRecipe(Recipe recipe);
        void UpdateRecipe(Recipe recipe);
        void DeleteRecipe(int id);
        void CommentRecipe(int id, string comment, User user);
    }
}
=======
        ICollection<Recipe> GetRecipes();
        ICollection<Recipe> SearchRecipesByTag(string tag);
        Recipe GetRecipe(int id);

    }
}
>>>>>>> 2fca37766e6b9cb83e4c759ea7c6db315116e106
