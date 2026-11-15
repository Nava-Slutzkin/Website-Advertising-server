using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.data
{
    public class ProjectCategory
    {
        public int Id { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }

        public int CategoryId { get; set; }
        public BusinessCategory Category { get; set; }
    }
}
