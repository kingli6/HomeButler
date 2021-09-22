using System;
using System.Collections.Generic;
using System.Text;

namespace HomeButlerV1
{
    class Functions
    {
        List<string> menuList = new List<string>();
        string menuTitle;
        int menuLevel;
        char userInput;
        bool continueProgram = true;

        public void RunProgram()
        {
            //could be cool to initiate everything from a file.
            Menu mainMenu = new Menu("HomeButler", 1);
            mainMenu.MenuList.Add("Entertainment");
            mainMenu.MenuList.Add("Body");
            mainMenu.MenuList.Add("Studies");
            mainMenu.MenuList.Add("Exit Program");

            menuList = mainMenu.MenuList;
            menuTitle = mainMenu.MenuName;
            menuLevel = mainMenu.MenuLevel;




            while (continueProgram)
            {
                Console.Clear();

                PrintMenu();
                userInput = UserChoice();
                LogicMethod();
                

            }
        }

        private void LogicMethod()
        {
            Menu EntertainmentMenu = new Menu("Entertainment", 2);
            EntertainmentMenu.MenuList.Add("Films");
            EntertainmentMenu.MenuList.Add("Games");
            EntertainmentMenu.MenuList.Add("Back");

            Menu HealthMenu = new Menu("Health", 2);
            HealthMenu.MenuList.Add("Eat");
            HealthMenu.MenuList.Add("Rest");
            HealthMenu.MenuList.Add("Back");

            Menu StudyMenu = new Menu("Study", 2);
            StudyMenu.MenuList.Add("Read Book");
            StudyMenu.MenuList.Add("Learn C#");
            StudyMenu.MenuList.Add("Back");

            MenuActivities EatMenu = new MenuActivities("Eat", 3);
            EatMenu.AllowedRoom.Add(Room.Kitchen);
            EatMenu.AllowedRoom.Add(Room.LivingRoom);//Trial. If we can have this in logic to print out another result.
            EatMenu.AllowedRoom.Add(Room.Back);


            switch (menuLevel)
            {
                //Main menu Level 1
                case 1:
                    {//If user chooses 4(Switch Off), The program stops. else we move menuLevel to 2
                        if (userInput == '4')
                        {
                            continueProgram = false;
                            Console.WriteLine("Going to sleep");
                            break;
                        }
                        else
                            menuLevel = 2;

                        //Userchoices from Level 1 menu
                        if (userInput == '1')
                        {
                            menuTitle = EntertainmentMenu.MenuName;
                            menuList = EntertainmentMenu.MenuList;
                        }
                        else if (userInput == '2')
                        {
                            menuTitle = HealthMenu.MenuName;
                            menuList = HealthMenu.MenuList;
                        }
                        else
                        {
                            menuTitle = StudyMenu.MenuName;
                            menuList = StudyMenu.MenuList;
                        }
                        break;
                    }
                //Second meny Level 2 (Inside Entertainment, body, studies)
                case 2:
                    {
                        if (menuTitle == "Entertainment")
                        {
                            switch (userInput)
                            {
                                case '1':
                                    {
                                        //Films
                                        break;
                                    }
                                case '2':
                                    {
                                        //Games
                                        break;
                                    }
                                case '3':
                                    {
                                        //goBack
                                        break;
                                    }

                                default:
                                    break;
                            }

                        }
                        else if (menuTitle == "Body")
                        {
                            switch (userInput)
                            {
                                case '1':
                                    {
                                        //Eat
                                        break;
                                    }
                                case '2':
                                    {
                                        //Rest
                                        break;
                                    }
                                case '3':
                                    {
                                        //goBack
                                        break;
                                    }

                                default:
                                    break;
                            }

                        }
                        else
                        {
                            //else menu is study
                            switch (userInput)
                            {
                                case '1':
                                    {
                                        //Read Book
                                        break;
                                    }
                                case '2':
                                    {
                                        //C# Programming
                                        break;
                                    }
                                case '3':
                                    {
                                        //goBack
                                        break;
                                    }

                                default:
                                    break;
                            }
                        }
                        break;
                    }
                //Thrid menu Level 3 (all activities)
                case 3:
                    {

                        break;
                    }

                default:
                    break;
            }
        }

        private char UserChoice()
        {
            return char.Parse(Console.ReadLine());
        }

        private void PrintMenu()
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
    }
}
