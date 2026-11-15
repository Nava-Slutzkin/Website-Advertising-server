using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.data
{
    public class Business
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Images { get; set; }
        public string Video { get; set; }
        public decimal Price { get; set; }

        public int CategoryId { get; set; }
        public BusinessCategory Category { get; set; }

        public List<Link> Links { get; set; }
        public List<ServiceOrder> ServiceOrders { get; set; } // לוח שנה
        public List<Review> Reviews { get; set; }
    }
}
