using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall.Entities
{
    public class Publication
    {
        public Guid Id { get; set; }
        public Guid AuthorId { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
    }
}
