using System;

namespace HomeButlerV1
{
    class Program
    {
        static void Main(string[] args)
        {
            var cc = new ConsoleCompanion();
            Functions x = new Functions();
            x.RunProgram();
        }
    }
}
/*
 
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
                                        menuTitle = mainMenu.MenuName;
                                        menuList = mainMenu.MenuList;
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
                                case '1':
                                    {
                                        menuTitle = EatMenu.MenuName;
                                        menuList = EatMenu.defaultRooms;

                                        break;
                                    }
                                case '2':
                                    {
                                        //Rest
                                        break;
                                    }
                                case '3':
                                    {
                                        menuTitle = mainMenu.MenuName;
                                        menuList = mainMenu.MenuList;
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
                                        menuTitle = mainMenu.MenuName;
                                        menuList = mainMenu.MenuList;
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
 
 */