using System;

namespace AnimalGuess
{
    public class Program 
    {
        private static Random random =  new Random(); 
          static void Main(string[] args)
        {
            //local variables 
            int numOfGuesses = 3; 
            string areaPlay = PrintMenu();
            string guess; 
            Animal[] animalArray = GetAnimalsForRegion(areaPlay);
            Animal animalChoice = RandomIndex(animalArray);

            Console.WriteLine($"Good choice {areaPlay} is a great place to guess animals"); 
           //print statement for region will remove later
            Console.WriteLine("Would you like a hint?");
           string yesOrNo = Console.ReadLine();

            if(yesOrNo == "yes"){
                Console.WriteLine(animalChoice.Hint);
            }else{
                Console.WriteLine("Good Luck"); 
            }


            while(numOfGuesses != 0)
            {   
                Console.WriteLine("Take a guess!");
                guess = Console.ReadLine();
                bool checkAgain = checkAnswer(guess,animalChoice);
                if(checkAgain == true){
                    break; 
                }else{
                    numOfGuesses = numOfGuesses - 1; 
                }
            } 

            if(numOfGuesses == 0){
                Console.WriteLine($"better luck next time! The animal was {animalChoice.Name}");
            }else{
                Console.WriteLine("Congrats you win!!!"); 
            }

        }


        //function is used to check answer 
        static bool checkAnswer(string answer, Animal animal)
        {
            bool check = false; 
            if(answer == animal.Name)
            {
                check = true;
                
            }else{
                check = false; 
            }

            return check; 
        }
        //function is used to get index
        static Animal RandomIndex(Animal[] animals)
        {
            int index = random.Next(0,animals.Length); 
            return animals[index];
        }


        //returns the animals with that region
        static Animal[] GetAnimalsForRegion(string region)
        {
            switch (region)
            {
                case "Africa":
                    return new[] 
                    {
                        new Animal("lion", "The king of the jungle"),
                        new Animal("giraffe", "Is known for its long neck"),
                        new Animal("elephant", "Has a long trunk and tusks"),
                        new Animal("zebra", "Black and white stripes"),
                        new Animal("hippopotamus", "Large underwater creature"),
                    };
                case "South America":
                    return new[] 
                    {
                        new Animal("jaguar", "predator with spots"),
                        new Animal("sloth", "very slow creature"),
                        new Animal("piranha", "aggresivve fish in the rivers"),
                        new Animal("llama", "known for its wool"),
                        new Animal("toucan", "bird with large beek"),
                    };
                case "North America":
                    return new[]
                    {
                      new Animal("grizzly", "Has sharp claws for digging and catching food"),
                      new Animal("eagle", "associated with freedom"),
                      new Animal("raccoon", "masked face and clever"),
                      new Animal("bison", "large shaggy-haried beast"),
                      new Animal("coyote", "a cunning tricker of a animal"),
                    };
                case "Australia":
                    return new[]
                    {
                      new Animal("kangaroo", "very hoppy choice "),
                      new Animal("koala", "eats eucalyptus leaves"),
                      new Animal("raccoon", "masked face and clever"),
                      new Animal("bison", "large shaggy-haried beast"),
                     
                default:
                    return new Animal[] { };
            }
        }


        //this function is used to print the menu of region and ask the user which area they would like to pick
        static string PrintMenu()
        { 
            Console.WriteLine("======= Animal Guessing Game =======");
            Console.WriteLine("Which region would you like to pick?");
            Console.WriteLine("1. Africa");
            Console.WriteLine("2. South America");
            Console.WriteLine("3. North America");
            Console.WriteLine("4. Australia");
            Console.WriteLine("5. Asia");
            Console.WriteLine("6. Europe");
            Console.WriteLine("7. Antarctica");
            Console.WriteLine();
            Console.Write("Enter the number of your choice: ");

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 7)
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 7.");
                Console.Write("Enter the number of your choice: ");
            }

            switch (choice)
            {
                case 1: return "Africa";
                case 2: return "South America";
                case 3: return "North America";
                case 4: return "Australia";
                case 5: return "Asia";
                case 6: return "Europe";
                case 7: return "Antarctica";
                default: return string.Empty;
            }

        }
    }
    
}