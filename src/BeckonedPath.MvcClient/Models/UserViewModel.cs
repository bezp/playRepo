using BeckonedPath.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeckonedPath.MvcClient.Models
{
    public class UserViewModel : Users
    {
        public string PageTitle { get; }

        public UserViewModel()
        {
            PageTitle = "userviewmodel in mvcclient models---->";
        }


    }
}
