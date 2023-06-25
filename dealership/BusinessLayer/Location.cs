using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Location
    {

        [Key]
        public int Id { get; set; }

        [StringLength(20, MinimumLength = 1, ErrorMessage = "first name should be at least 1 character")]
        public string Name { get; set; }

        public List<Cars> Cars { get; set; }


        public Location(string name)
        {
            Name = name;


            Cars = new List<Cars>();
        }
        private Location()
        {
            Cars= new List<Cars>();
        }

        public override string ToString()
        {
            return $"{Name}";
        }

    }
}
