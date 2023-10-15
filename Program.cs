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
            Animal[] animalArray = GetAnimalsForRegion(areaPlay);
            Animal animalChoice = RandomIndex(animalArray);

           //print statement for region will remove later
            Console.WriteLine("Would you like a hint?");
           string yesOrNo = Console.ReadLine();

            if(yesOrNo == "yes"){
                Console.WriteLine(animalChoice.Hint);
            }else{
                Console.WriteLine("Good Luck"); 
            }


        }

        static Animal RandomIndex(Animal[] animals)
        {
            int index = random.Next(0,animals.Length); 
            return animals[index];
        }

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
                        
                    }
                
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