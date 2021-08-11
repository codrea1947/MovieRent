using MovieRent.Contexts;
using MovieRent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRent.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        private DatabaseContext _addresscontext;
        public AddressRepository(DatabaseContext addresscontext)
        {
            _addresscontext = addresscontext;
        }
        public void Add(Address address)
        {
            _addresscontext.Addresses.Add(address);
            _addresscontext.SaveChanges();
        }
    }
}
