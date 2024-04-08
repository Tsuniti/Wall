//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//using Wall.Entities;
//using Microsoft.EntityFrameworkCore;

//namespace Wall.Databases;

//public class UsersDB : DbContext
//{
//    private DbSet<User> _users => Set<User>();
//    public UsersDB() => Database.EnsureCreated();

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//    {
//        optionsBuilder.UseSqlite("Data Source=users.db");

//    }

//    public IEnumerable<User> GetAllUsers() => _users;

//    public User? GetUserById(Guid id) => _users.FirstOrDefault(u => u.Id == id);
//    public User? GetUserByUsername(string username) => _users.FirstOrDefault(u => u.Username == username);


//    public void AddUser(User User) => _users.Add(User);


//}
