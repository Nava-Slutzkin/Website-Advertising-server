using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.data
{
    public class ServiceOrder
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public int BusinessId { get; set; }
        public Business Business { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int LocationId { get; set; }
        public Location Location { get; set; }

    }
}
