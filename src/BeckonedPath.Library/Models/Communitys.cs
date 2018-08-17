using System;
using System.Collections.Generic;

namespace BeckonedPath.Library.Models
{
    public partial class Communitys
    {
        public Communitys()
        {
            CommunityComments = new HashSet<CommunityComments>();
            Events = new HashSet<Events>();
        }

        public int CommunityId { get; set; }
        public int UserId { get; set; }

        public Users User { get; set; }
        public ICollection<CommunityComments> CommunityComments { get; set; }
        public ICollection<Events> Events { get; set; }
    }
}
