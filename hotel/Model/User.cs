using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelData.Model
{
    public class User : BaseEntity
    {

        
        public string? Name { get; set; } 
        public string? Surname { get; set; }
        public string ? Email { get; set; } 

        public string ?PhoneNumber { get; set; }
        
        public string ?IdentityCard { get; set; }
        public string ? BirthDay { get; set; }  

        public string ? Gender { get; set; }

        public Room ? Room { get; set; }






    }
}
