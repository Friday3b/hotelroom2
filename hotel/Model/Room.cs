using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelData.Model
{
    public class Room:BaseEntity
    {
        public int roomNum { get; set; } 

        public int ?roomCount { get; set; }
        public bool ?roomCondition { get; set; }
        
    }
}
