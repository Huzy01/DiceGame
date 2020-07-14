using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
             {
                {
                    int iScore = 1;
                    char cAgain;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Welcome to Huzy's dice game, press enter to proceed");
                        Console.ReadLine();
                        Console.WriteLine("James Bond plays craps and the rules are: the player rolls two dice, a win is on a roll of 7 or 11, a loss is 2, 3 or 12");
                        Console.ReadLine();
                        Console.WriteLine("press enter to roll your first dice");
                        Console.ReadLine();
                        int iDiceThrow1 = 0;
                        Random randomNumber = new Random();
                        iDiceThrow1 = randomNumber.Next(1, 6);
                        Console.WriteLine("you have rolled" + " " + iDiceThrow1);
                        Console.ReadLine();
                         Console.WriteLine("press enter to roll your second dice");
                    Console.ReadLine();
                 int iDiceThrow2 = 0;
                    Random randomNumber2 = new Random();
                    iDiceThrow2 = randomNumber.Next(1, 6);
                 Console.WriteLine("you have rolled" + " " + iDiceThrow2);
                    Console.ReadLine();
                 int iTotal = 0;
                 iTotal = iDiceThrow1 + iDiceThrow2;
                 Console.WriteLine("both dice added together is" + " " + iTotal);
                     Console.ReadLine();

                if (iTotal == 7)
                {
                    Console.WriteLine("Congratulations! You Win");
                        Console.WriteLine(iScore + 1);
                }
                else if (iTotal == 11)
                {
                    Console.WriteLine("Congratulations! You Win");
                        Console.WriteLine(iScore + 1);
                    }
                else if (iTotal == 2)
                {
                    Console.WriteLine("You lost try again noob");
                }
                else if (iTotal == 3)
                {
                    Console.WriteLine("You lost try again noob");
                }
                else if (iTotal == 12)
                {
                    Console.WriteLine("You lost try again noob");
                }
                else
                {
                    Console.WriteLine("try again noob");
                }
                    Console.ReadLine();
                    Console.WriteLine("your current score is" + " " + iScore);
                    Console.ReadLine();
                     System.Threading.Thread.Sleep(1000);
                     Console.Write("would you like to play again select Y to play again or N to quit");
                      cAgain = char.Parse(Console.ReadLine());
                      cAgain = char.ToUpper(cAgain);

                } while (cAgain == 'Y');



                }
            }
        }
    }
}
