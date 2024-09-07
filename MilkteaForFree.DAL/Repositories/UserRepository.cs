using MilkteaForFree.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkteaForFree.DAL.Repositories
{
    public class UserRepository
    {
         private MilkteaContext _context;

        public void Add(User user)
        {
            _context = new MilkteaContext();
            _context.Users.Add(user);
            _context.SaveChanges();

        }

        public User? Get(int id) 
        {
            _context = new();
            return _context.Users.Find(id);
        }

        public List<User> GetAll() 
        { 
            _context = new();
            return _context.Users.ToList();
        }
        
        public void Delete(User user)
        {
            _context = new();
            _context.Remove(user);
            _context.SaveChanges();
        }

        public void Update(User user)
        {
            _context = new();
            _context.Users.Update(user);
            _context.SaveChanges();
        }
    }
}
