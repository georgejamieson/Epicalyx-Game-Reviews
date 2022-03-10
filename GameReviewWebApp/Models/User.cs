using System;
using System.Collections.Generic;

namespace GameReviewWebApp.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public int Age { get; set; }
       public int  ProfilePic { get; set; }

        public ICollection<FinalReview> FinalReview { get; set; }
    }
}
