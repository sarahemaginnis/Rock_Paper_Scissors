//declare variables
Random random = new Random();
bool playAgain = true;
String player;
String computer;
String answer;
int playerPoints = 0;
int computerPoints = 0;

while(playAgain && playerPoints < 3 && computerPoints < 3)
{
    player = "";
    computer = "";
    answer = "";

    while(player != "ROCK" && player !="PAPER" && player != "SCISSORS")
    {
    Console.WriteLine("Enter ROCK, PAPER, or SCISSORS: ");
    player = Console.ReadLine();
    player = player.ToUpper();

    }
    
    switch(random.Next(1, 4))
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
    Console.WriteLine("Player: " + player);
    Console.WriteLine("Computer: " + computer);

    switch(player)
    {
        case "ROCK":
            if (computer == "ROCK")
            {
                Console.WriteLine("It's a draw!");
            } else if (computer == "PAPER")
            {
                computerPoints++;
                Console.WriteLine("You lose!");
            } else
            {
                playerPoints++;
                Console.WriteLine("You win!");
            }
            break;
        case "PAPER":
            if (computer == "ROCK")
            {
                playerPoints++;
                Console.WriteLine("You win!");
            }
            else if (computer == "PAPER")
            {
                Console.WriteLine("It's a draw!");
            }
            else
            {
                computerPoints++;
                Console.WriteLine("You lose!");
            }
            break;
        case "SCISSORS":
            if (computer == "ROCK")
            {
                computerPoints++;
                Console.WriteLine("You lose!");
            }
            else if (computer == "PAPER")
            {
                playerPoints++;
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }
            break;
    }
    Console.WriteLine("Current Score: ");
    Console.WriteLine("player: " + playerPoints + " computer: " + computerPoints);
    Console.Write("Would you like to play again (Y/N): ");
    answer = Console.ReadLine();
    answer = answer.ToUpper();

    if (answer == "Y")
    {
        playAgain = true;
    } else
    {
        playAgain = false;
    }
}
Console.WriteLine("Thanks for playing!");

Console.ReadKey();
