using System;
using System.Collections.Generic;
using System.Text;

namespace MessageBoardClassLibrary
{
   public class Board
    {
        private IMessageService messageService;

        public Board(IMessageService messageService)
        {
            this.messageService = messageService;

        }
        // C - create
        public void AddPost(string author, string message, DateTime postDate)
        {
            messageService.AddPost(author, message, postDate);
        }

        // R - read
        public Post GePostById(int id)
        {
            return messageService.GetPostById(id);
        }

        public List<Post> GetAllPosts()
        {
            return messageService.GetAllPosts();
        }
    }


}







       

