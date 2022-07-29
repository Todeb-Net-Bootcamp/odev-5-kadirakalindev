﻿using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserRepository _userRepository;
        public UserManager()
        {
            _userRepository = new UsersRepository();
        }
        public Users CrateUser(Users user)
        {
            return _userRepository.CrateUser(user);
        }

        public void DeleteUser(int id)
        {
            _userRepository.DeleteUser(id);
        }

        public List<Users> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        public Users GetUserById(int id)
        {
            return _userRepository.GetUserById(id);
        }

        public Users UpdateUser(Users user)
        {
            return _userRepository.UpdateUser(user);
        }
    }
}
