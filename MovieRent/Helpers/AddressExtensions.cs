using MovieRent.DtoModels;
using MovieRent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRent.Helpers
{
    public static class AddressExtensions
    {
        public static Address ToAddress(this DtoAddress dtoAddress)
        {
            return new Address
            {

                Country = dtoAddress.Country,
                State = dtoAddress.State,
                City = dtoAddress.City,
                Street = dtoAddress.Street,
                PostalCode = dtoAddress.PostalCode,
                //UserId = userId
            };
           
        }
    }
}
