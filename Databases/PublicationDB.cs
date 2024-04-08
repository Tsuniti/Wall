//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//using Wall.Entities;
//using Microsoft.EntityFrameworkCore;

//namespace Wall.Databases;

//public class PublicationDB : DbContext
//{
//    private DbSet<Publication> _publications => Set<Publication>();
//    public PublicationDB() => Database.EnsureCreated();

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//    {
//        optionsBuilder.UseSqlite("Data Source=publications.db");

//    }

//    public IEnumerable<Publication> GetAllPublications() => _publications;

//    public Publication? GetPublicationById(Guid id) => _publications.FirstOrDefault(p => p.Id == id);

//    public void AddPublication(Publication Publication) => _publications.Add(Publication);


//}
