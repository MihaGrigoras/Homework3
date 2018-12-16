using System;
using System.Collections.Generic;
using System.Text;

namespace MessageBoardClassLibrary
{
    public interface IMessageService
    {
        Post AddPost(string author, string message, DateTime postedDate);

        Post GetPostById(int id);

        List<Post> GetAllPosts();

        void UpdatePost(int id, string author, string text, DateTime newPostedDate);

        void DeletePost(int id);
    }
}
