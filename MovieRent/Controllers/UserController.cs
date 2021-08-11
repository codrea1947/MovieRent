using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MovieRent.DtoModels;
using MovieRent.Models;
using MovieRent.Repositories;
using MovieRent.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRent.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        public UserController(IUserService userService, SignInManager<User> signInManager, UserManager<User> userManager)
        {
            _userService = userService;
            _signInManager = signInManager;
            _userManager = userManager;
        }
        [HttpPost]
        [Route("Register")]
        [AllowAnonymous]
        public IActionResult Register (DtoUser dtoUser)
        {
            if (dtoUser is null)
            {
                throw new Exception("Request Data Null!");
            }
            try
            {
                _userService.RegisterUser(dtoUser);

            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            };

            return Ok();

        }
        [HttpPost]
        [Route("Login")]
        [AllowAnonymous]
       public IActionResult LogIn(DtoUserLogin dtoUserLogin)
        {
            var user = _userService.FindByEmail(dtoUserLogin.Email);

            if (user != null)
            {
                var signInResult = _signInManager.PasswordSignInAsync(user, dtoUserLogin.Password, true, false);

                if (signInResult.IsCompleted)
                {
                    return Ok();
                }
                else
                {
                    throw new Exception("Incorrect Password!");
                }
            }
            else
            {
                throw new Exception("Request Data Null!");
            }

            ;
        }
    }
}
