using MilkteaForFree.DAL.Models;
using MilkteaForFree.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkteaForFree.Bll.UserService
{
    public class UserService
    {
        private UserRepository repository = new();

        public List<User> GetAll => repository.GetAll();

        public User? GetUser(int id) => repository.Get(id);

        public void Add(User user) => repository.Add(user);

        public void Update(User user) => repository.Update(user);

        public void Dellete(User user) => repository.Delete(user);
    }
}
