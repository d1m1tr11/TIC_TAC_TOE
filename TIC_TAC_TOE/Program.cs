using System;
using System.Threading;
namespace TIC_TAC_TOE
{
    class Program
    {
        //Variables
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
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
                    Console.WriteLine("Player 1 turn");
                }
                else
                {
                    Console.WriteLine("player 2 turn");
                }
                Console.WriteLine();

                Board();

            }
            while (true);
           

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
        private static void CheckWin()
        {

        }

    }
}