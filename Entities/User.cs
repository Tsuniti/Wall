using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
namespace Wall.Entities;

[Index(nameof(username), IsUnique = true)]
public class User
{
    public Guid id { get; set; } = Guid.NewGuid();

    [StringLength(16, MinimumLength = 3)]
    public string username { get; set; }

    [StringLength(32, MinimumLength = 8)]
    public string password { get; set; }

    public List<Publication> Publications { get; set; } = new List<Publication>();
    

}
