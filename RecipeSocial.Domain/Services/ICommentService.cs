using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeSocial.Domain.Services
{
    public interface ICommentService
    {
        void Comment(int id, string text, int userId);
    }
}
