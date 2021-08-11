using MovieRent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRent.Repositories
{
    public interface IAddressRepository
    {
        void Add(Address address);
    }
}
