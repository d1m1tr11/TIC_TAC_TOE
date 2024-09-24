using System;
using System.Reflection.Metadata.Ecma335;
using System.Threading;
namespace TIC_TAC_TOE
{
    class Program
    {
        //Variables
        static string[] arr = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        static int player = 1; //romeli motamashe tamashobs
        static int choice; //romel ujras irchevs motamashe
        static int status; //game status, 0 = playing, 1 = winner, 2 = tie


        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Player 1 - X & Player 2 - O");
                Console.WriteLine();
                if (player % 2 == 0)
                {
                    Console.WriteLine("Player 2 turn");
                }
                else
                {
                    Console.WriteLine("Player 1 turn");
                }
                Console.WriteLine();

                Board();

                int.TryParse(Console.ReadLine(), out choice);

                if (choice > 0 && choice < 10)
                {

                    if (arr[choice] != "X" && arr[choice] != "O")
                    {

                        if (player % 2 == 0)
                        {
                            arr[choice] = "O";
                            player++;
                        }
                        else
                        {
                            arr[choice] = "X";
                            player++;
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Sorry {choice}, is already marked {arr[choice]}.");
                        Console.WriteLine("TRY AGAIN");
                        Thread.Sleep(1000);
                    }

                    status = CheckWin();
                }

                else 
                { 
                    Console.WriteLine("TRY 1 - 9:");
                    Thread.Sleep(1000);
                }
                             


            }
            
            while (status == 0);



            if (status == 1)
            {
                Console.WriteLine();
                Console.WriteLine($"Player {player%2 + 1} Won!");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Its Tie!");
            }
            Console.WriteLine();

        }


        //Creating Board Method
        private static void Board()
        {
            Console.WriteLine(" _________________ ");
            Console.WriteLine("|     |     |     |");
            Console.WriteLine($"|  {arr[1]}  |  {arr[2]}  |  {arr[3]}  |");
            Console.WriteLine("|_____|_____|_____|");
            Console.WriteLine("|     |     |     |");
            Console.WriteLine($"|  {arr[4]}  |  {arr[5]}  |  {arr[6]}  |");
            Console.WriteLine("|_____|_____|_____|");
            Console.WriteLine("|     |     |     |");
            Console.WriteLine($"|  {arr[7]}  |  {arr[8]}  |  {arr[9]}  |");
            Console.WriteLine("|_____|_____|_____|");
        }


        //Creating Checking Win Method
        private static int CheckWin()
        {
            //Winning Condition For Rows
            if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                return 1;
            }

            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                return 1;
            }

            else if (arr[6] == arr[7] && arr[7] == arr[8])
            {
                return 1;
            }


            //Winning Condition For Columns
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                return 1;
            }

            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return 1;
            }

            else if (arr[3] == arr[6] && arr[6] == arr[9])
            {
                return 1;
            }


            //Winning For Diagonal
            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                return 1;
            }
            else if (arr[3] == arr[5] && arr[5] == arr[7])
            {
                return 1;
            }



            // all sels filled up its TIE
            else if (arr[1] != "1" && arr[2] != "2" && arr[3] != "3" && arr[4] != "4" && arr[5] != "5" && arr[6] != "6" && arr[7] != "7" && arr[8] != "8" && arr[9] != "9")
            {
                return 2;
            }

            //we are playing
            else
            {
                return 0;
            }
        }

    }
}