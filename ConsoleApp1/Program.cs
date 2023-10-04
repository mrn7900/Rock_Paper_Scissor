using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Rock = "Rock";
            string Paper = "Paper";
            string Scissor = "Scissor";
            
            int computerscore = 0 , userscore = 0 , winscore = 3 ;
            
            Console.WriteLine("Game has started , Enter a Num:");
            
            while (computerscore<=winscore && userscore <= winscore)
            {
                Console.WriteLine("Rock = 1");
                
                Console.WriteLine("Paper = 2");
                
                Console.WriteLine("Scissor= 3");

                string Userchoice = Console.ReadLine();

                string Computerchoice = "";

                int RandomNum = new Random().Next(1, 3);

                switch (RandomNum)
                {
                    case 1:
                        Computerchoice = Rock;
                        break;
                    case 2:
                        Computerchoice = Paper;
                        break;
                    case 3:
                        Computerchoice = Scissor;
                        break;

                }
                if (Userchoice!= "1" && Userchoice != "2" && Userchoice != "3" )
                {
                    Console.WriteLine("Enter an other num:");
                    Userchoice=Console.ReadLine();
                }
                else
                {
                    switch (Userchoice)
                    {
                        case "1":
                            Userchoice = Rock;
                            break;
                        case "2":
                            Userchoice = Paper;
                            break;
                        case "3":
                            Userchoice = Scissor;
                            break;

                    }
                    Console.WriteLine("User choice = " + Userchoice);
                    Console.WriteLine("Computer choice = " + Computerchoice);

                    if (Computerchoice == Userchoice)
                    {
                        Console.WriteLine("draw");
                    }
                    else if (Computerchoice == Rock && Userchoice == Paper)
                    {
                        userscore++;
                    }
                    else if (Computerchoice == Rock && Userchoice == Scissor)
                    {
                        computerscore++;
                    }
                    else if (Computerchoice == Paper && Userchoice == Scissor)
                    {
                        userscore++;
                    }
                    else if (Computerchoice == Paper && Userchoice == Rock)
                    {
                        computerscore++;
                    }
                    else if (Computerchoice == Scissor && Userchoice == Paper)
                    {
                        computerscore++;
                    }
                    else if (Computerchoice == Scissor&& Userchoice == Rock)
                    {
                        userscore++;
                    }

                }

            }
            if (userscore>computerscore)
            {
                Console.WriteLine("user won");
            }
            else
            {
                Console.WriteLine("computer won");
            }
        }
    }
}
