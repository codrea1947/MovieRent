using MovieRent.DtoModels;
using MovieRent.Helpers;
using MovieRent.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRent.Services
{
    public class AddressService : IAddressService
    {
        public readonly IAddressRepository _addressRepository;

        public AddressService(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }

        public void AddAddress(DtoAddress dtoAddress)
        {
            if (dtoAddress == null)
            {
                throw new Exception("You cannot add null address.");
            }

            _addressRepository.Add(AddressExtensions.ToAddress(dtoAddress));
        }
    }
}
