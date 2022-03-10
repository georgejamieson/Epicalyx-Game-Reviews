using System;
using System.Collections.Generic;

namespace GameReviewWebApp.Models
{
    public class FinalReview
    {
        public int FinalReviewID { get; set; }
        public string Review { get; set; }
        public int FinalRating { get; set; }
        public int Genre { get; set; }
        public int Publisher { get; set; }
   

        public Games Games{ get; set; }
        public User User { get; set; }
    }
}