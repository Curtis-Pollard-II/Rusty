
bool playing = true;
List<string> possibleInputs = new List<string> {"rock", "paper", "scissors"};

do 
{
Console.WriteLine("Welcome");
Console.WriteLine("Input one of of the following words: rock , paper , or scissors");

Random rand = new Random();
int randomIndex = rand.Next(0, possibleInputs.Count -1);
string computerPlay = possibleInputs[randomIndex];
bool won = false;


string? userInput = "";
userInput = Console.ReadLine();

if (userInput == computerPlay){
    Console.BackgroundColor = ConsoleColor.Yellow;
    Console.WriteLine( "you both played: " + computerPlay + "Try again");
    }

if ((userInput == "rock") && (computerPlay == "scissors")) {
    Console.BackgroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine( "You Win! The computer played:" + computerPlay);
    won = true;
}

if ((userInput == "paper") && (computerPlay == "scissors")) {
    Console.BackgroundColor = ConsoleColor.DarkRed;
    Console.WriteLine( "You Lose! The computer played:" + computerPlay);
    won = false;
}

if ((userInput == "Rock") && (computerPlay == "paper")) {
    Console.BackgroundColor = ConsoleColor.DarkRed;
    Console.WriteLine( "You Lose! The computer played:" + computerPlay);
    won = false;
}

if ((userInput == "scissors") && (computerPlay == "rock")) {
    Console.BackgroundColor = ConsoleColor.DarkRed;
   Console.WriteLine( "You Lose! The computer played:" + computerPlay);
    won = false;
}

if ((userInput == "paper") && (computerPlay == "rock")) {
    Console.BackgroundColor = ConsoleColor.DarkRed;
    Console.WriteLine( "You Win! The computer played:" + computerPlay);
    won = true;
}


} while (playing);

// bool validInput = false;
// if (userInput = possibleInputs)
//         {validInput == true;}
//             else { validInput == false; }




