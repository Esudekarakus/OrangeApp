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

        public void UpdateUser(User user) 
        {
            repository.Update(user);
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

        public void AddStandartUser(User user) 
        {
            user.Status = Domain.Enums.Status.Added;
            user.CreatedDate = DateTime.Now;

            

            repository.Add(user);
        }

        public bool CheckUsernameExists(string username)
        {
            User user = repository.GetUserByUsername(username);
            if (user != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SignUp(User user)
        {
            
            user.CreatedDate = DateTime.Now;
            user.Status = Domain.Enums.Status.Added;

            repository.Add(user);
        }
    }
}
