using System;
using System.Collections.Generic;

namespace BeckonedPath.Library.Models
{
    public partial class CommunityComments
    {
        public int CommunityCommentId { get; set; }
        public string Description { get; set; }
        public int CommunityId { get; set; }
        public int? UserId { get; set; }

        public Communitys Community { get; set; }
        public Users User { get; set; }
    }
}
