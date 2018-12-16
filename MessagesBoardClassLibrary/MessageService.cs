using System;
using System.Collections.Generic;
using System.Text;

namespace MessageBoardClassLibrary
{
   public class MessageService :IMessageService
    {
        private List<Post> posts;
        private static int nextId;

        public MessageService()
        {
            this.posts = new List<Post>();
        }

        // C = create
        public Post AddPost(string author, string message, DateTime postDate)
        {
            Post post = new Post(nextId++, author, message, postDate);
            posts.Add(post);
            return post;
        }

        // R = read
        public Post GetPostById(int id)
        {
            foreach (Post post in posts)
            {
                if (post.Id == id)
                {
                    return post;
                }
            }
            return null;
        }

        public List<Post> GetAllPosts()
        {
            return this.posts;
        }

        // U = update
        public void UpdatePost(int id,  string author, string newText, DateTime  newPostedDate)
        {
            Post post = GetPostById(id);
            if (post != null)
            {
                post.PostText = newText;
                post.PostedDate = newPostedDate;
            }
        }

        // D = delete
        public void DeletePost(int id)
        {
            Post post = GetPostById(id);
            if (post != null)
            {
                posts.Remove(post);
            }
        }
    }
}
