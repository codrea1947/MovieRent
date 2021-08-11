using MovieRent.Contexts;
using MovieRent.DtoModels;
using MovieRent.helpers;
using MovieRent.Models;
using MovieRent.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRent.Services
{
    public class UserService : IUserService
    {
        public readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void RegisterUser(DtoUser dtoUser)
        {
           if (dtoUser == null)
              throw new Exception("You cannot add null user.");
            
           var user = _userRepository.FindUserByEamil(dtoUser.Email);
            
           if (user == null)
              throw new Exception("There is an user for this email.");

            _userRepository.Add(UserExtensions.ToUser(dtoUser));
        }

        public User FindByEmail(string email)
        {
            return _userRepository.FindUserByEamil(email);
        }
        public void LogInUser(DtoUserLogin dtoUserLogin)
        {

        }
    }
}
