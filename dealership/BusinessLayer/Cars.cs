using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Cars
    {
        [Key]
        public int Id { get; set; }
        [StringLength(20, MinimumLength = 1)]

        public string Model { get; set; }

        public Location Location { get; set; }
        public List<Client> Clients { get; set; }

        public Cars(string model, Location location)
        {
            Model = model;
            Location = location;

            Clients = new List<Client>();

        }

        private Cars()
        {
            Clients = new List<Client>();
        }


    }
}
