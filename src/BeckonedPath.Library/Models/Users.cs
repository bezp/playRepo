using System;
using System.Collections.Generic;

namespace BeckonedPath.Library.Models
{//=]
    public partial class Users
    {
        public Users()
        {
            CommunityComments = new HashSet<CommunityComments>();
            Communitys = new HashSet<Communitys>();
            EventComments = new HashSet<EventComments>();
            Events = new HashSet<Events>();
            Friends = new HashSet<Friends>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public string Event { get; set; }
        public string FutureEvent { get; set; }
        public string PastEvent { get; set; }
        public string Comment { get; set; }

        public ICollection<CommunityComments> CommunityComments { get; set; }
        public ICollection<Communitys> Communitys { get; set; }
        public ICollection<EventComments> EventComments { get; set; }
        public ICollection<Events> Events { get; set; }
        public ICollection<Friends> Friends { get; set; }
    }
}
