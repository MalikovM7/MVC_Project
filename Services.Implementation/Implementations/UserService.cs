using Application.Dto;
using Application.Services.Interfaces;
using Domain.Models;
using Infrastrcuture.Repositories;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http.Authentication;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementations
{
    public class UserService : IUserService
    {

        private readonly IBaseRepository<User> _rep;

        public UserService(IBaseRepository<User> rep) { _rep = rep; }


        public async Task<ICollection<User>> GetAll()
        {

            try
            {

                var users = await _rep.GetAll().ToListAsync();

                return users;

            }

            catch (Exception ex)
            {
                throw new Exception("An error occurred while creating the service", ex);
            }

        }

        public async Task<User> Login(LoginDto model)
        {
            var users = _rep.GetAll().ToList();
           var user= await _rep.GetAll().FirstOrDefaultAsync(x=> x.Email == model.Email);

            if (user == null)
            {
                throw new HttpRequestException("Email not found", null, HttpStatusCode.NotFound);


            }

            if (model.Password != user.Password)
            {
                throw new HttpRequestException("Password not found", null, HttpStatusCode.NotFound);

            }

            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Email, model.Email)


            };
            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var authProperties = new AuthenticationProperties { AllowRefresh = true , IsPersistent=true};

            return user;

        }

        public async Task<User> Register(User model)
        {
           var user = new User();

            user.UserName = model.UserName;
            user.Email = model.Email;
            user.Password = model.Password;


            await _rep.Create(user);
            return user;
        }

        public async Task<User> Remove(int id)
        {

            try
            {
                var user = await _rep.GetAll().FirstOrDefaultAsync(x => x.Id == id);
                var rem = await _rep.Delete(user);

                return rem;

            }

            catch (Exception ex)
            {
                throw new Exception("An error occurred while creating the service", ex);
            }

        }

    }
}
