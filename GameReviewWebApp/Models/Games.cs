using System;
using System.Collections.Generic;

namespace GameReviewWebApp.Models
{
    public class Games
    {
        public int GameID { get; set; }
        public string GameName { get; set; }
        public string AgeRating { get; set; }
        public string Genre { get; set; }
        public string Publisher { get; set; }
        public int ReleaseYear  { get; set; }
        
        public ICollection<FinalReview> FinalReview{ get; set; }
    }
}