using NelnetProgrammingExercise.Models;
using System;
using System.Linq;

namespace NelnetProgrammingExercise
{
    class Program
    {
        private static PersonModel[] People;
        private static PetModel[] Pets;

        #region Initialization

        private static void SetupObjects()
        {
            People = new PersonModel[]
            {
                new PersonModel()
                {
                    Name = "Dalinar",
                    PreferredClassification = PetClassification.Mammal,
                    PreferredType = PetType.Snake,
                    PreferredWeight = PetWeight.Medium
                },
                new PersonModel()
                {
                    Name = "Kaladin",
                    PreferredClassification = PetClassification.Bird,
                    PreferredType = PetType.Goldfish,
                    PreferredWeight = PetWeight.ExtraSmall
                }
            };

            Pets = new PetModel[]
            {
                new PetModel()
                {
                    Name = "Garfield",
                    Weight = findWeightClass(20.0),
                    Classification = PetClassification.Mammal,
                    Type = PetType.Cat
                },
                new PetModel()
                {
                    Name = "Odie",
                    Weight = findWeightClass(15.0),
                    Classification = PetClassification.Mammal,
                    Type = PetType.Dog
                },
                new PetModel()
                {
                    Name = "Peter Parker",
                    Weight = findWeightClass(0.5),
                    Classification = PetClassification.Arachnid,
                    Type = PetType.Spider
                },
                new PetModel()
                {
                    Name = "Kaa",
                    Weight = findWeightClass(25.0),
                    Classification = PetClassification.Reptile,
                    Type = PetType.Snake
                },
                new PetModel()
                {
                    Name = "Nemo",
                    Weight = findWeightClass(0.5),
                    Classification = PetClassification.Fish,
                    Type = PetType.Goldfish
                },
                new PetModel()
                {
                    Name = "Alpha",
                    Weight = findWeightClass(0.1),
                    Classification = PetClassification.Fish,
                    Type = PetType.Betta
                },
                new PetModel()
                {
                    Name = "Splinter",
                    Weight = findWeightClass(0.5),
                    Classification = PetClassification.Mammal,
                    Type = PetType.Rat
                },
                new PetModel()
                {
                    Name = "Coco",
                    Weight = findWeightClass(6.0),
                    Classification = PetClassification.Bird,
                    Type = PetType.Parrot
                },
                new PetModel()
                {
                    Name = "Tweety",
                    Weight = findWeightClass(0.05),
                    Classification = PetClassification.Bird,
                    Type = PetType.Canary
                }
            };
        }

        #endregion

        private static PetWeight findWeightClass (double weight)
        {
            if (weight > 0 & weight <= 1.0) {
                return PetWeight.ExtraSmall;
            } else if (weight > 1.0 & weight <= 5.0) {
                return PetWeight.Small;
            } else if (weight > 5.0 & weight <= 15.0) {
                return PetWeight.Medium;
            } else if (weight > 15.0 & weight <= 30.0) {
                return PetWeight.Large;
            } else if (weight > 30.0) {
                return PetWeight.ExtraLarge;
            } else {
                throw new System.ArgumentException("Invalid Weight", "weight");
            }
        }

        private static string IsGood(PersonModel person, PetModel pet)
        {
            return person.PreferredClassification == pet.Classification || person.PreferredType == pet.Type
                ? "good"
                : "bad";
        }

        static void Main(string[] args)
        {
            SetupObjects();

            foreach(PersonModel person in People) {
                Console.WriteLine(string.Format("Pets for {0}:", person.Name));

                foreach(PetModel pet in Pets)
                {
                    Console.WriteLine(string.Format("{0} would be a {1} pet.", pet.Name, IsGood(person, pet)));
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
