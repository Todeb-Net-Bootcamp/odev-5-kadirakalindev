using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface IUserService
    {
        List<Users> GetAllUsers();
        Users GetUserById(int id);
        Users CrateUser(Users user);
        Users UpdateUser(Users user);
        void DeleteUser(int id);
    }
}
