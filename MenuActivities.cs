﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HomeButlerV1
{
    class MenuActivities : Menu, IRoom
    {
        public List<string> defaultRooms = new List<string> { "Kitchen", "LivingRoom","BedRoom", "StudyRoom", "Back", };
        public List<Room> AllowedRoom;
        // list<string> defaultrooms = enum class
        public MenuActivities(string menuName, int menuLevel)
        {
            MenuName = menuName;
            MenuLevel = menuLevel;
            AllowedRoom = new List<Room>();
            //AllowedRoom = new List<Room>();
        }
        public void AddAllowedRooms(Room roomName)
        {
            AllowedRoom.Add(roomName);
        }

        public new Functions GetNameLevelList()
        {
            Functions result = new Functions();
            result.menuTitle = MenuName;
            result.menuLevel = MenuLevel;
            result.menuList = defaultRooms;
            return result;
        }

       public void Rooms (int userinput, List<Room> allowedRooms) 
        {
            
            // 1-3 if he types 1 == kitchen
            if (userinput == 1)
            {
                if (allowedRooms.Contains(Room.Kitchen))
                {
                    Console.WriteLine("I have prepared it in the kitchen");
                }
                else
                {
                    Console.WriteLine("That room is not available for that activity");
                }
                Console.ReadLine();
                //he means Livingroom
            }
            if (userinput == 2)
            {
                if (allowedRooms.Contains(Room.LivingRoom))
                {
                    Console.WriteLine("I have prepared it in the living room");
                }
                else
                {
                    Console.WriteLine("That room is not available for that activity");
                }
                Console.ReadLine();
            }
            if (userinput == 3)
            {
                if (allowedRooms.Contains(Room.BedRoom))
                {
                    Console.WriteLine("I have prepared it in the bedroom");
                }
                else
                {
                    Console.WriteLine("That room is not available for that activity");
                }
                Console.ReadLine();
            }
            if (userinput == 4)
            {
                if (allowedRooms.Contains(Room.StudyRoom))
                {
                    Console.WriteLine("I have prepared it in the bedroom");
                }
                else
                {
                    Console.WriteLine("That room is not available for that activity");
                }
                Console.ReadLine();
            }
        }
    }
}

//void IRoom.AddRooms(Room roomName)
//{
//    AllowedRoom.Add(roomName);
//}

/*
 * the activities chosen rooms
    
    what the user chooses   Intiger 1. LivingRoom", 2. "Kitchen", 3."BedRoom", "Back"
        kitchen 
 * 
 switch statement with different level responses


Enum class

method()
{films.list.add(enum.kitchen.)


printMenu(){
films.list
}
 */