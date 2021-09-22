using System;
using System.Collections.Generic;
using System.Text;

namespace HomeButlerV1
{
        class Menu
    {
        public string MenuName;
        public int MenuLevel;
        public List<string> MenuList;


        public Menu() { }
        public Menu(string menuName, int menuLevel)
        {
            MenuName = menuName;
            MenuLevel = menuLevel;
            MenuList = new List<string>();
        }

    }
}
/*

    
 
 */