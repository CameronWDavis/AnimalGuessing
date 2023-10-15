using System;

namespace AnimalGuess
{
    public class Program 
    {
          static void Main(string[] args)
        {
            //local variables 
            int numOfGuesses = 3; 
            string areaPlay = GameUtilities.PrintMenu();
            string guess; 
            bool hintValid = false; 
            Animal[] animalArray = GameUtilities.GetAnimalsForRegion(areaPlay);
            Animal animalChoice = GameUtilities.RandomIndex(animalArray);


            //print statement to start the game
            Console.WriteLine($"Good choice {areaPlay} is a great place to guess animals"); 
           

            //this iteration is to see if the user wants a hint, and check to see for valid input
            Console.Write("Would you like a hint? (yes/no): ");
            string yesOrNo = Console.ReadLine();

            while (!yesOrNo.Equals("yes", StringComparison.OrdinalIgnoreCase) && 
                !yesOrNo.Equals("no", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Please try again! Valid input is yes or no");
                    yesOrNo = Console.ReadLine();
                }

             if (yesOrNo.Equals("yes", StringComparison.OrdinalIgnoreCase))
                {
                Console.WriteLine(animalChoice.Hint);
                }
             else
                {
                Console.WriteLine("Good Luck");
                }

            //this is the statement that is the core mechanic of guessing the animals
            while(numOfGuesses != 0)
            {   
                 Console.WriteLine("Take a guess!");
                guess = Console.ReadLine();
                bool isCorrect = GameUtilities.checkAnswer(guess, animalChoice);
                if(isCorrect)
                {
                    break; 
                }
                else
                {
                    Console.WriteLine("Wrong guess again!"); 
                    numOfGuesses--; 
                }
            } 

            if(numOfGuesses == 0){
                Console.WriteLine($"better luck next time! The animal was {animalChoice.Name}");
            }else{
                Console.WriteLine("Congrats you win!!!"); 
            }

        }

    
}
}