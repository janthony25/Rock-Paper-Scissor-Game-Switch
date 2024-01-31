using System;

namespace RockPaperScissors
{
    public class Program
    {
        static void Main(string[] args )
        {
            Random rnd = new Random();
            bool playAgain = true;
            string player;
            string computer;
            string response;

            while (playAgain) 
            {
                player =  "";
                computer = "";
                response = "";

                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.Write("Enter ROCK, PAPER or SCISSORS: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();

                    switch (rnd.Next(1, 4))
                    {
                        case 1:
                            computer = "ROCK";
                            break;

                        case 2:
                            computer = "PAPER";
                            break;

                        case 3:
                            computer = "SCISSORS";
                            break;
                    }


                    Console.WriteLine($"You chose: {player}");
                    Console.WriteLine($"Computer: {computer}");

                    switch (player)
                    {
                        case "ROCK":
                            if (computer == "ROCK")
                            {
                                Console.WriteLine("DRAW!");
                            }
                            else if (computer == "PAPER")
                            {
                                Console.WriteLine("You Lose!");
                            }
                            else
                            {
                                Console.WriteLine("YOU WIN!");
                            }
                            break;

                        case "PAPER":
                            if (computer == "ROCK")
                            {
                                Console.WriteLine("YOU WIN");
                            }
                            else if (computer == "PAPER")
                            {
                                Console.WriteLine("DRAW");
                            }
                            else
                            {
                                Console.WriteLine("You Lose!");
                            }
                            break;



                        case "SCISSORS":
                            if (computer == "ROCK")
                            {
                                Console.WriteLine("You Lose!");
                            }
                            else if (computer == "PAPER")
                            {
                                Console.WriteLine("YOU WIN!");
                            }
                            else
                            {
                                Console.WriteLine("DRAW!");
                            }
                            break;
                    } // end switch player

                    Console.WriteLine("Do you want to play again? (Y/N): ");
                    response = Console.ReadLine();
                    response.ToUpper();

                    if (response == "Y")
                    {
                        playAgain = true;
                    }
                    else if (response == "N")
                    {
                        playAgain = false;
                    }
                }

                Console.WriteLine("Thanks for playing!");


            }
        

        }
    }
}