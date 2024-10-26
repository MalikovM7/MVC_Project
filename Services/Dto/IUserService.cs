using Application.Dto;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Interfaces
{
    public interface IUserService
    {
         Task<User> Register(User model);
         Task<User> Login(LoginDto model);

         Task<ICollection<User>> GetAll();

         Task<User> Remove(int id);




    }
}
