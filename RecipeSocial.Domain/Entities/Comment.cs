﻿using RecipeSocial.Domain.Entities.Template;

namespace RecipeSocial.Domain.Entities
{
    public class Comment : Base
    {
        public int RecipeId { get; set; }

        public string Text { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
