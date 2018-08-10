using RecipeSocial.Domain.Database;
using RecipeSocial.Domain.Entities;
using RecipeSocial.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeSocial.Infrastructure.Services
{
    public class CommentService : ICommentService
    {
        IRepository<Comment> repository;
        public CommentService(IRepository<Comment> repository)
        {
            this.repository = repository;
        }
        public void Comment(int id, string text, int userId)
        {
            Comment comment = new Comment
            {
                RecipeId = id,
                Text = text,
                UserId = userId
            };

            repository.Add(comment);
        }
    }
}
