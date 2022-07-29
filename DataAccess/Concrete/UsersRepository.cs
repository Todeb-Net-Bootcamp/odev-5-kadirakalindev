using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class UsersRepository : IUserRepository
    {
        public Users CrateUser(Users user)
        {
            using (var userDbContext = new UsersDbContext())
            {
                userDbContext.User.Add(user);
                userDbContext.SaveChanges();
                return user;
            }
        }

        public void DeleteUser(int id)
        {
            using (var userDbContext = new UsersDbContext())
            {
                var deletedUser = GetUserById(id);
                userDbContext.User.Remove(deletedUser);
                userDbContext.SaveChanges();
            }
        }

        public List<Users> GetAllUsers()
        {
            using (var userDbContext = new UsersDbContext())
            {
                return userDbContext.User.ToList();
            }
        }

        public Users GetUserById(int id)
        {
            using (var userDbContext = new UsersDbContext())
            {
                return userDbContext.User.Find(id);
            }
        }

        public Users UpdateUser(Users user)
        {
            using (var userDbContext = new UsersDbContext())
            {
                userDbContext.User.Update(user);
                return user;
            }
        }
    }
}
