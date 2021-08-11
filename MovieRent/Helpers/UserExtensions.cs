using MovieRent.DtoModels;
using MovieRent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRent.helpers
{
    public static class UserExtensions
    {
        public static User ToUser(this DtoUser userDto)
        {
            return new User
            {
                UserId = Guid.NewGuid(),
                FirstName = userDto.FirstName,
                LastName = userDto.LastName,
                Email = userDto.Email,
                DateJoined = DateTime.Now,
                BirthDate = userDto.BirthDate,
                Password = userDto.Password
            };
        }
    }
}
