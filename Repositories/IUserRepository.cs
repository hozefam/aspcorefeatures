using System.Collections.Generic;
using Accountant.Api.Models;

namespace Accountant.Api.Repositories
{
    public interface IUserRepository
    {
         User GetUser(string name);

         IEnumerable<User> GetAll();
    }
}