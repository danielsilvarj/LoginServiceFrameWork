using LoginServiceFrameWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginServiceFrameWork.Repositories
{
    public class UserReposotiry
    {
        public List<User> ListUsers;
        public UserReposotiry()
        {
            ListUsers = new List<User>();
            ListUsers.Add(new User() { Username = "Daniel", Password = "Daniel" });
            ListUsers.Add(new User() { Username = "Joe", Password = "Joe" });
        }

        //public User GetUser(string username, string password)
        public User GetUser(string username)
        {
            try
            {
                return ListUsers.First(u => u.Username.ToLower() == username.ToLower());
            }
            catch (Exception)
            {

                return null;
            }

        }
    }
}