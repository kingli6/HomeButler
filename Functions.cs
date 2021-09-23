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
        public string TempTitle;
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

            MenuActivities films = new MenuActivities("Films", 3);
            films.AddAllowedRooms(Room.LivingRoom);

            MenuActivities games = new MenuActivities("Games", 3);
            games.AddAllowedRooms(Room.LivingRoom);
            games.AddAllowedRooms(Room.StudyRoom);




            /*
             films
                all the rooms presented
                    kitchen
            user has his 4 choices
                
             
             */
            MenuActivities eatMenu = new MenuActivities("Eat", 3);
            eatMenu.AddAllowedRooms(Room.Kitchen);
            eatMenu.AddAllowedRooms(Room.LivingRoom);
            Functions eatDetails = eatMenu.GetNameLevelList();

            Menu healthMenu = new Menu("Health", 2);
            healthMenu.MenuList.Add("Eat");
            healthMenu.MenuList.Add("Rest");
            healthMenu.MenuList.Add("Back");
            Functions healthDetails = healthMenu.GetNameLevelList();
            /*
             Here will be things under Health
             
             */

            Menu studyMenu = new Menu("Education", 2);
            studyMenu.MenuList.Add("Maths");
            studyMenu.MenuList.Add("Science");
            studyMenu.MenuList.Add("Back");
            Functions studyDetails = studyMenu.GetNameLevelList();

            //MenuActivities 
            /*
             Here will be things under Studies
             
             */

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
                PrintMenu();
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
                                    //Movies, this should lead to room choice?
                                    break;
                                }
                            case 2:
                                {
                                    //Movies, this should lead to room choice?
                                    break;
                                }
                            case 3:
                                {   //Back
                                    menuTitle = mainMenuDetails.menuTitle;
                                    menuList = mainMenuDetails.menuList;
                                    menuLevel = 1;
                                    break;
                                }
                            default:
                                break;
                        }
                    }
                    else if (menuTitle == "Health")
                    {
                        switch (userInput)
                        {
                            case 1:
                                {
                                    menuTitle = eatDetails.menuTitle;
                                    menuList = eatDetails.menuList;
                                    menuLevel = 3;
                                    break;
                                }
                            case 2:
                                {
                                    //Rest
                                    break;
                                }
                            case 3:
                                {   //back
                                    menuTitle = mainMenuDetails.menuTitle;
                                    menuList = mainMenuDetails.menuList;
                                    menuLevel = 1;
                                    break;
                                }
                            default:
                                break;
                        }

                    }
                    else//its studies
                    {
                        switch (userInput)
                        {
                            case 1:
                                {   //Programming
                                    //menuTitle = eatDetails.menuTitle;
                                    //menuList = eatDetails.menuList;
                                    break;
                                }
                            case 2:
                                {
                                    //Read Book
                                    break;
                                }
                            case 3:
                                {   //back
                                    menuTitle = mainMenuDetails.menuTitle;
                                    menuList = mainMenuDetails.menuList;
                                    menuLevel = 1;
                                    break;
                                }
                            default:
                                break;
                        }

                    }
                }
                else//Menu level 3
                {
                    if (menuTitle == "Eat")
                    {
                        TempTitle = "Eat";
                        switch (userInput)
                        {
                            case 1:
                                {
                                //This should check if eat is available in kitchen
                                eatMenu.Rooms(1, eatMenu.AllowedRoom);
                                break;
                                }
                            case 2:
                                //this should check if eat is available in LivingRoom
                                eatMenu.Rooms(2, eatMenu.AllowedRoom);
                                break;
                            case 3:
                                //this should check if eat is available in bedroom
                                eatMenu.Rooms(3, eatMenu.AllowedRoom);
                                break;
                            case 4:
                                //this should check if eat is available in study
                                eatMenu.Rooms(4, eatMenu.AllowedRoom);
                                break;
                            default:
                                break;
                        }
                        /* Enum
                         *  Kitchen = 1,
                            LivingRoom = 2,
                            BedRoom = 3,
                            StudyRoom = 4*/

                    }
                    else if (menuTitle == "Sleep")
                    {
                        TempTitle = "Sleep";
                        switch (userInput)
                        {
                            case 1:
                                {
                                    //Checks if available in Bedroom
                                    //sleepMenu.Rooms();
                                    break;
                                }
                        }

                    }
                    else if (menuTitle == "Films")
                    {

                    }
                    else if (menuTitle == "Games")
                    {

                    }
                    else if (menuTitle == "Programming")
                    {
                        //In Livingroom
                    }
                    else if (menuTitle == "Read a book")
                    {
                        //In bedroom
                    }
                    else
                    {
                        //logic on going back so if user input is
                        if (userInput == 5)
                        {
                            menuTitle = TempTitle;
                        }
                    }

                    switch (userInput)
                    {
                        case 1:
                            {
                                //LivingRoom
                                break;
                            }
                        case 2:
                            {
                                //Kitchen
                                break;
                            }
                        case 3:
                            {
                                //Bedroom
                                break;
                            }
                        case 4:
                            {   //Back
                                
                               
                                break;
                            }
                        case 5:
                            {
                                //cheat sheet that records previous menu
                                menuTitle = mainMenuDetails.menuTitle;
                                menuList = mainMenuDetails.menuList;
                                menuLevel = 2;
                                break;
                            }
                        default:
                            break;
                    }

                }
            }

            
        }


        void PrintMenu()
        {
            if (menuLevel == 3)
                Console.WriteLine("Choose location");
            else
                Console.WriteLine(menuTitle);
            
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
//eatMenu.AllowedRoom.Add(Room.Kitchen);
//eatMenu.AllowedRoom.Add(Room.LivingRoom);//Trial. If we can have this in logic to print out another result.
//eatMenu.AllowedRoom.Add(Room.Back);