using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeButlerV1
{
    public class Functions
    {
        public List<string> menuList = new List<string>();
        public string menuTitle;
        public int menuLevel;
        int userInput;
        bool continueProgram = true;
        List<string> roomList = new List<string> { "LivingRoom", "Kitchen", "BedRoom", "Back", };

        public void RunProgram()
        {
            Menu mainMenu = new Menu("HomeButler", 1);
            mainMenu.MenuList.Add("Entertainment");
            mainMenu.MenuList.Add("Health");
            mainMenu.MenuList.Add("Studies");
            mainMenu.MenuList.Add("Exit Program");
            Functions mainMenuDetails = mainMenu.GetNameLevelList();

            Menu entertainmentMenu = new Menu("Entertainment", 2);
            entertainmentMenu.MenuList.Add("Films");
            entertainmentMenu.MenuList.Add("Games");
            entertainmentMenu.MenuList.Add("Back");
            Functions entertainmentDetails = entertainmentMenu.GetNameLevelList();

            Menu healthMenu = new Menu("Health", 2);
            healthMenu.MenuList.Add("Eat");
            healthMenu.MenuList.Add("Rest");
            healthMenu.MenuList.Add("Back");
            Functions healthDetails = healthMenu.GetNameLevelList();

            Menu studyMenu = new Menu("Study", 2);
            studyMenu.MenuList.Add("Read Book");
            studyMenu.MenuList.Add("Learn C#");
            studyMenu.MenuList.Add("Back");
            Functions studyDetails = studyMenu.GetNameLevelList();

            MenuActivities eatMenu = new MenuActivities("Eat", 3);
            eatMenu.AllowedRoom.Add(Room.Kitchen);
            eatMenu.AllowedRoom.Add(Room.LivingRoom);//Trial. If we can have this in logic to print out another result.
            eatMenu.AllowedRoom.Add(Room.Back);

            bool oneTimeuseBool = true;
            //to make the print function work for the first time, we are using
            //this bool to apply values to needed fields
            while (continueProgram)
            {
                Console.Clear();
                if (oneTimeuseBool)
                {
                    menuTitle = mainMenuDetails.menuTitle;
                    menuLevel = mainMenuDetails.menuLevel;
                    menuList = mainMenuDetails.menuList;
                }
                PrintMenu(menuTitle, menuList);
                userInput = UserChoice();
                MenuLogic();


            }
            void MenuLogic()
            {
                if (menuLevel == 1)
                {
                    menuLevel = 2;
                    oneTimeuseBool = false;
                    //turning it off since the user determines from now on.
                    switch (userInput)
                    {
                        case 1:
                            {
                                menuTitle = entertainmentDetails.menuTitle; 
                                menuList = entertainmentDetails.menuList;
                                break;
                            }
                        case 2:
                            {
                                menuTitle = healthDetails.menuTitle;
                                menuList = healthDetails.menuList;
                                break;
                            }
                        case 3:
                            {
                                menuTitle = studyDetails.menuTitle;
                                menuList = studyDetails.menuList;
                                break;
                            }
                        case 4:
                            {
                                continueProgram = false;
                                Console.WriteLine("Going to Sleep");
                                break;
                            }
                        default:
                            break;
                    }
                }
                else if (menuLevel == 2)
                {
                    //We are using the menuTitle to indicate where we are
                    if (menuTitle == "Entertainment")
                    {
                        switch (userInput)
                        {
                            case 1:
                                {
                                    // 
                                    break;
                                }
                            case 2:
                                {
                                    break;
                                }
                            case 3:
                                {
                                    break;
                                }
                            default:
                                break;
                        }
                    }
                    else if (menuTitle == "Health")
                    {

                    }
                    else//its studies
                    {

                    }
                }
            }

            
        }


        void PrintMenu(string menuTitle, List<string> menuList)
        {
            Console.WriteLine(menuTitle);//make this text bigger
            int i = 1;
            foreach (var item in menuList)
            {
                Console.WriteLine($"{i}.{item}");
                i++;
            }
            Console.Write("Please Choose: ");
        }

        private int UserChoice()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}
