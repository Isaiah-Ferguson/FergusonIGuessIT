﻿//ISAIAH KEITH FERGUSON
//10/17/2022
//Guess it!!

string custom = "";
string guess = "";
int num = 0;
bool input = true;
string program = ""; 
bool trueG = true;
int trueGuess = 0;
int trueInt1 = 0;
int trueInt2 = 0;

while (input == true)
{
    Console.WriteLine("Lets play a little game!");
    Console.WriteLine("Please chose your difficulty please type 'Easy' 'Medium' 'Hard' or 'Custom'");
    string difficulty = Console.ReadLine().ToLower();


int easyGuesses = 0;
int mediumGuesses = 0;
int hardGuesses = 0;
int customguess =0;

    if (difficulty == "easy")
    {
    Random rndnum = new Random();
    num = rndnum.Next(1,10);
    while (trueGuess != num)
    {
        Console.WriteLine("guess the number between 1 and 10!");
        guess = (Console.ReadLine());

        trueG = Int32.TryParse(guess, out trueGuess);
        easyGuesses ++;
        if (trueGuess == 0)
        {
                Console.WriteLine("that is not an integer.");
            break;
        }
    Console.WriteLine(trueGuess);
        if (trueGuess > num)
        {
            Console.WriteLine("Your number is too high! guess again");
        }
        if (trueGuess < num)
        {
            Console.WriteLine("Your guess is too low! Guess again");
        } else if (trueGuess == num)
        {
            Console.WriteLine("You win! Nice job on guessing " + num);
            Console.WriteLine($"It took you {easyGuesses} guesses");
        }
    }
}

if (difficulty == "custom")
{
    Random rndnum = new Random();
    Console.WriteLine("Please enter a number:");
    string num1 = (Console.ReadLine());

        trueG = Int32.TryParse(num1, out trueInt1);
        


    Console.WriteLine("Please enter a number that is greater than your 1st number");
    string num2 = (Console.ReadLine());
trueG = Int32.TryParse(num2, out trueInt2);

    num = rndnum.Next(trueInt1,trueInt2);
    while (trueGuess != num)
    {
        if (trueInt1 == 0 || trueInt2 == 0)
        {
            Console.WriteLine("that is not an integer.");
            break;
        }

        Console.WriteLine($"guess the number between {num1} and {num2}!");
        guess = (Console.ReadLine());
        trueG = Int32.TryParse(guess, out trueGuess);
        
        if (trueGuess == 0)
        {
            Console.WriteLine("that is not an integer.");
            break;
        }
customguess ++;
        if (trueGuess > num)
        {
            Console.WriteLine("Your number is too high! guess again");
        }
        if (trueGuess < num)
        {
            Console.WriteLine("Your guess is too low! Guess again");
        } else if (trueGuess == num)
        {
            Console.WriteLine("You win! Nice job on guessing " + num);
            Console.WriteLine($"It took you {customguess} guesses");
        }
}
}

if (difficulty == "medium")
{
    Random rndnum = new Random();
    num = rndnum.Next(1,50);
    while (trueGuess != num)
    {
        Console.WriteLine("guess the number between 1 and 50!");
        guess = (Console.ReadLine());
        trueG = Int32.TryParse(guess, out trueGuess);
        
        if (trueGuess == 0)
        {
            Console.WriteLine("that is not an integer.");
            break;
        }
        mediumGuesses ++;

        if (trueGuess > num)
        {
            Console.WriteLine("Your number is too high! guess again");
        }
        if (trueGuess < num)
        {
            Console.WriteLine("Your guess is too low! Guess again");
        } else if (trueGuess == num)
        {
            Console.WriteLine("You win! Nice job on guessing " + num);
            Console.WriteLine($"It took you {mediumGuesses} guesses");
        }
}
}

if (difficulty == "hard")
{
    Random rndnum = new Random();
    num = rndnum.Next(1,100);
    while (trueGuess != num)
    {
        Console.WriteLine("guess the number between 1 and 100!");
        guess = (Console.ReadLine());
        trueG = Int32.TryParse(guess, out trueGuess);
        
        if (trueGuess == 0)
        {
            Console.WriteLine("that is not an integer.");
            break;
        }
        hardGuesses ++;

        if (trueGuess > num)
        {
            Console.WriteLine("Your number is too high! guess again");
        }
        if (trueGuess < num)
        {
            Console.WriteLine("Your guess is too low! Guess again");
        } else if (trueGuess == num)
        {
            Console.WriteLine("You win! Nice job on guessing " + num);
            Console.WriteLine($"It took you {hardGuesses} guesses");
        }
    }

}Console.WriteLine("Please Type 'End' to end the program or press 'enter' to play again");
    program = Console.ReadLine().ToLower();
    if (program == "end")
    {
        input = false;
    }
    
}