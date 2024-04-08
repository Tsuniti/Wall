using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Wall.Entities;
namespace Wall.Databases;

public class UserToPublicationsDB : DbContext
{
    private DbSet<User> _users => Set<User>();
    private DbSet<Publication> _publications => Set<Publication>();

    public UserToPublicationsDB() => Database.EnsureCreated();

    protected override void OnModelCreating(ModelBuilder modelBuilder) // в этом не уверен, если не работает - снесу
    {
        modelBuilder.Entity<User>()
            .HasIndex(u => u.username)
            .IsUnique();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=UserToPublications.db");

    }

    public IEnumerable<User> GetAllUsers() => _users;
    public IEnumerable<Publication> GetAllPublications() => _publications;

    public User? GetUserById(Guid id) => _users.FirstOrDefault(u => u.id == id);

    public Publication? GetPublicationById(Guid id) => _publications.FirstOrDefault(p => p.id == id);


    public void AddUser(User User) => _users.Add(User);

    public void AddPublication(Publication Publication) => _publications.Add(Publication);
}
