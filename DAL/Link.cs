using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Link
    {
        public int Id { get; set; }
        public string Url { get; set; }

        public int BusinessId { get; set; }
        public Business Business { get; set; }
    }
}
