using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationLesson1.Lib
{
    public class RoomService
    {
        ModelEntity db = new ModelEntity();
        public bool AddRoomProperties(RoomProperty roomProperty) 
        {
            try
            {
                db.RoomProperty.Add(roomProperty);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
