using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekKalori.DAL.Repositories;
using YemekKalori.Domain.Entities;

namespace YemekKalori.BLL.Services
{
    public class UserService
    {
        public UserService()
        {
            repository = new UserRepository();
        }

        UserRepository repository;

        public User GetUserByUsername(string username)
        {
            return repository.GetUserByUsername(username);
        }

        public User GetById(int userId) 
        {
            return repository.GetUserById(userId);
        }

        public void Delete(int userId) 
        {
            User user = repository.GetUserById(userId);
            user.Status = Domain.Enums.Status.Deleted;
            user.DeletedDate = DateTime.Now;
            repository.Update(user);
        }

        public void UpdatePassword(int userId, string password)
        {
            User user = GetById(userId);
            user.Password = password;
            repository.Update(user);
        }

        public User UserLogin(string username, string password)
        {
            User user = repository.GetUserByUsername(username);
            if (user == null) 
            {
                throw new Exception("Kullanıcı bulunamadı.");
                
            }
            if (!user.VerifyPassword(password)) 
            {
                throw new Exception("Yanlış şifre.");
            }

            return user;
        }
    }
}
