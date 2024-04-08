using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall.Entities
{
    public class Publication
    {
        public Guid id { get; set; }
        [StringLength(512)]
        public string message { get; set; }
        public DateTime date { get; set; }
        public Guid userId { get; set; }
        public User User { get; set; }
    }
}
