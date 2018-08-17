using System;
using System.Collections.Generic;

namespace BeckonedPath.Library.Models
{
    public partial class Friends
    {
        public int FriendId { get; set; }
        public int UserId { get; set; }
        public int AnotherFriend { get; set; }

        public Users User { get; set; }
    }
}
