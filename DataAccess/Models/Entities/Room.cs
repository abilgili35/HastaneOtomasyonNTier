using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Entities
{
    public class Room:BaseClass
    {
        public int RoomNumber { get; set; }
        public int BuildingNumber { get; set; }
        public int FloorNumber { get; set; }

        public virtual Doctor Doctor { get; set; }
    }
}
