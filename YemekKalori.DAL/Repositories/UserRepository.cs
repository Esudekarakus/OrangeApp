using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekKalori.DAL.Context;
using YemekKalori.Domain.Entities;

namespace YemekKalori.DAL.Repositories
{
    public class UserRepository
    {
        public UserRepository()
        {
            dbContext=new AppDbContext();
        }
        AppDbContext dbContext;

        // Login logic'İndfe kullanılacak
        public User GetUserByUsername(string username)
        {
            return dbContext.Users.FirstOrDefault(x => x.Username == username);
        }

        public User GetUserById(int userId) 
        {
            return dbContext.Users.FirstOrDefault(x => x.Id == userId);
        }
        public void Add(User user)
        {
            dbContext.Users.Add(user);
            dbContext.SaveChanges();

        }
        public void Update(User user)
        {
            user.Status = Domain.Enums.Status.Modified;
            user.ModifiedDate = DateTime.Now;
            dbContext.Users.Update(user);
            dbContext.SaveChanges();


        }
        public void DeleteUserByStatus(int id)
        {
            User user = dbContext.Users.FirstOrDefault(x => x.Id == id);
            user.Status = Domain.Enums.Status.Deleted;
            user.DeletedDate = DateTime.Now;
            dbContext.Update(user);
            dbContext.SaveChanges();
        }
        //kullanıcı kaydını silmek isterse
        public void Delete(int id) 
        {
            User user = dbContext.Users.FirstOrDefault(x => x.Id == id);
            dbContext.Users.Remove(user);
            dbContext.SaveChanges();

        }

        //tüm kullanıcıları admin için listelemek için
        public List <User> GetAll()
        {
            return dbContext.Users.ToList();
        }

        //standart kullanıcıları listelemek için

        //public List <User> GetStandartUsers()
        //{
        //    return dbContext.Users.Where(x=>x.Type==Domain.Enums.UserType.Standart).ToList();
        //}
        ////premium kullanıcıları listele

        //public List<User> GetPremiumUsers()
        //{
        //    return dbContext.Users.Where(x=>x.Type==Domain.Enums.UserType.Premium).ToList();
        //}

        ////adminleri listele

        //public List <User>GetAdmin()
        //{
        //    return dbContext.Users.Where(x=>x.Type==Domain.Enums.UserType.Admin).ToList();
        //}
        
        

        
    }
}
