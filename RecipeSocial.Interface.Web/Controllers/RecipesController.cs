using Microsoft.AspNetCore.Mvc;
using RecipeSocial.Domain.Services;

namespace RecipeSocial.Interface.Web.Controllers
{
    public class RecipesController
    {
        private ICommentService commentService;

        public RecipesController(ICommentService commentService)
        {
            this.commentService = commentService;
        }

        [HttpPost]
        public void Comment(int id, string comment)
        {
            int userId = 1;

            commentService.Comment(id, comment, userId);
        }
    }
}
