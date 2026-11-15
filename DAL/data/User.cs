using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.data
{

    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public String Role { get; set; } 
        public string Password { get; set; }

        [InverseProperty("User")]
        public List<Review> Reviews { get; set; }

        [InverseProperty("BusinessOwner")]
        public List<Review> ReceivedReviews { get; set; }

        public List<ServiceOrder> ServiceOrders { get; set; }
    }
}