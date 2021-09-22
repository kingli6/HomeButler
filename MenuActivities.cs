using System;
using System.Collections.Generic;
using System.Text;

namespace HomeButlerV1
{
    class MenuActivities : Menu, IRoom
    {
        public List<Room> AllowedRoom;
        public List<string> defaultRooms = new List<string> { "LivingRoom", "Kitchen", "BedRoom", "Back", };
        public MenuActivities(string menuName, int menuLevel)
        {
            MenuName = menuName;
            MenuLevel = menuLevel;
            AllowedRoom = new List<Room>();
        }
        void IRoom.AddRooms(Room roomName)
        {
            AllowedRoom.Add(roomName);
        }
    }
}
