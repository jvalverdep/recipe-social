using RecipeSocial.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeSocial.Interface.Web.Controllers
{
    public class RecipesController
    {
        private CommentService commentService;

        public RecipesController(CommentService commentService)
        {
            this.commentService = commentService;
        }

        public void Comment(int id, string text)
        {
            commentService.Comment(id, text, 1);
        }
    }
}
