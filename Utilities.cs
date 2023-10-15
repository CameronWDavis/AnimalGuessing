using System;

namespace AnimalGuess
{

    public static class GameUtilities
    {

        private static Random random =  new Random(); 
        
        //function is used just to error check and see if the statement is true or false
        public static bool checkAnswer(string userGuess, Animal chosenAnimal)
            {
                return userGuess.Equals(chosenAnimal.Name, StringComparison.OrdinalIgnoreCase);
            }

        //function is used to get index
        public static Animal RandomIndex(Animal[] animals)
        {
            int index = random.Next(0,animals.Length); 
            return animals[index];
        }


        //returns the animals with that region
        public static Animal[] GetAnimalsForRegion(string region)
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
                      new Animal("dingo", "this one ate my baby"),
                      new Animal("platypus", "lays eggs but is a mammal"),
                      new Animal("emu", "Only animal Austrailia has declared war on"),
                    };
                case "Asia":
                    return new[]
                    {
                      new Animal("tiger", "fierce animal with stripes"),
                      new Animal("komodo dragon", "The world's heaviest lizard"),
                      new Animal("peacock", "famous for its colorful and fan-like tail display"),
                      new Animal("salamander", "a amphibian like lizzard"),
                      new Animal("panda", " primarily eats bamboo"),
                    };
                case "Europe":
                    return new[]
                    {
                      new Animal("fox", "A cunning and adaptable carnivore"),
                      new Animal("hedgehog", "a small nocturnal mammal covered in spines"),
                      new Animal("deer", "impressive antlers"),
                      new Animal("lynx", "wild cat with tufted ears"),
                      new Animal("owl", "bird wiht "),
                    };
                case "Antarctica":
                    return new[]
                    {
                      new Animal("penguin", "A cute sea bird"),
                      new Animal("walrus", "a large creature with tusks"),
                      new Animal("seal", "A sleek aquatic mammal"),
                      new Animal("narwhal", "Often called the 'unicorn of the sea"),
                      new Animal("orca", "a black and white apex predator"),
                    };
                default:
                    return new Animal[] { };
            }
        }


        //this function is used to print the menu of region and ask the user which area they would like to pick
        public static string PrintMenu()
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