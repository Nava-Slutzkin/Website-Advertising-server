using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Review
    {
        public int Id { get; set; }
        public int Stars { get; set; }
        public string Text { get; set; }

        public int BusinessId { get; set; }
        public Business Business { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int BusinessOwnerId { get; set; }
        public User BusinessOwner { get; set; }
    }
}
