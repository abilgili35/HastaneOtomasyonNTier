using DataAccess.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Seeds
{
    public class RoomSeed
    {
        public static List<Room> Rooms = new List<Room>()
        {
            new Room{ID=1,BuildingNumber=11,FloorNumber=2,RoomNumber=101,CreatedDate=DateTime.Now,IsActive=true},
            new Room{ID=2,BuildingNumber=21,FloorNumber=3,RoomNumber=203,CreatedDate=DateTime.Now,IsActive=true},
            new Room{ID=4,BuildingNumber=31,FloorNumber=1,RoomNumber=207,CreatedDate=DateTime.Now,IsActive=true},
           

        };
    }
}
