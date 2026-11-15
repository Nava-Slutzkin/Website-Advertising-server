using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.data
{
    public class BusinessCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Business> Businesses { get; set; }
        public List<ProjectCategory> ProjectCategories { get; set; }
    }
}
