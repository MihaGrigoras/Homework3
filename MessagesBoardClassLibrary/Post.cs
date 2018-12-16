using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace MessageBoardClassLibrary
{
    public class Post
    {
        // properties 
        public String Author { get; private set; }
        // additional properties we could use in addition to those requested in the requirements
        public int Id { get; set; }
        public String PostText { get;  set; }
        public DateTime PostedDate { get;  set; }
      

        //constructor
        public Post(int id, string author, string message, DateTime postedDate)
            
        {
            this.Id = id;
            this.Author = author;
            this.PostText = message;
            this.PostedDate = postedDate;
        }


    }
}
