using System;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program() 
{
    static string restart_game;
    static bool Isendgame = false;
    static bool IsContinue = true;
    static int Guess_count = 0;
    public static void Main() 
    {
        int SecNum = 100;
        int Guesses = 0;
        int attempts = 5;

        Console.WriteLine("*********Welcome to Number Guess Game****************** ");

        Console.WriteLine("********* Guess Number from 1 to 1000 ****************** ");

        while (IsContinue)
        {
            
            while (!Isendgame)
            {
                Console.WriteLine($"Enter Your {Guess_count + 1} Guess");
                Guesses = Convert.ToInt16(Console.ReadLine());

                //if (Guesses <= 1000 && Guesses >= 0)
                //{
                if (SecNum == Guesses)
                {
                    Console.WriteLine("Congrats. You are Guess is Correct!");
                    Console.WriteLine("You Win the game. Do you want to start Again? if Yes press Y and if NO press no.");
                    restart_game = Console.ReadLine();
                    RestartGame(restart_game);
                }
                else
                {
                    //initial_value++;
                    Console.WriteLine($"Opps. You are Guess is Wrong! You have {4-Guess_count++} chances left");
                    
                    if (Guess_count == 5) 
                    {
                        Console.WriteLine("Game Over");
                        Console.WriteLine("You Chances is end.Do you want to start Again ? if Yes press Y and if NO press no.");
                        string restart_game = Console.ReadLine();
                        RestartGame(restart_game);
                    }
                }
                //}
                //else
                //{
                //    Console.WriteLine("Your Guess is not in the Suggested Range");
                //}
            }
        }
    }
    public static void RestartGame(string checkrestart)
    {
        if (checkrestart.ToLower().Contains('y'))
        {
            //Isendgame = true;
            IsContinue = true;
        }
        else
        {
            Isendgame = true;
            IsContinue = false;

        }
        Guess_count = 0;

    }

}

class Guess_the_number() 
{ 
    public static void Number()
    {
        


    }

}
