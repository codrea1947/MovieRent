using MovieRent.DtoModels;
using MovieRent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRent.Services
{
    public interface IAddressService
    {
        public void AddAddress(DtoAddress address);
    }
}
