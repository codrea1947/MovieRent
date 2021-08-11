using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MovieRent.DtoModels;
using MovieRent.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRent.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddressController : Controller
    {
        private readonly IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }
        [HttpPost]
        [Route("AddAddress")]
        [AllowAnonymous]
        public IActionResult AddAddress(DtoAddress dtoAdress)
        {
            if (dtoAdress == null)
            {
                throw new Exception("Request Data Null!");
            }
            try
            {
                _addressService.AddAddress(dtoAdress);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            };
            return Ok();
        }
    }
}
