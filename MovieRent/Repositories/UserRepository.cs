using MovieRent.Contexts;
using MovieRent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRent.Repositories
{
    public class UserRepository :  IUserRepository
    {
        private DatabaseContext _usercontext;

        public UserRepository(DatabaseContext context)
        {
            _usercontext = context;
        }

        public void Add(User user)
        {
            
            _usercontext.Users.Add(user);
            _usercontext.SaveChanges();
        }

        public User FindUserByEamil(string email)
        {
            return _usercontext.Users.FirstOrDefault(u => u.Email == email);

        }
    }
}
