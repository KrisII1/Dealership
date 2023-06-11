using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Client
    {
        [Key]
        public int ID { get; set; }

        [StringLength(30, MinimumLength = 1)]
        public string FirstName { get; set; }

        [StringLength(30, MinimumLength = 1)]
        public string LastName { get; set; }

        [Range(18, 100)]
        public int Age { get; set; }

        [StringLength(100, MinimumLength = 1)]
        public string Email { get; set; }

        public List<Cars> Cars { get; set; }

        public Client(string firstname, string lastname, int age, string email)
        {
            FirstName= firstname;
            LastName=lastname;
            Age=age;
            Email=email;  

            Cars = new List<Cars>();
        }

        private Client()
        {
            Cars = new List<Cars>();
        }
    }
}
