using System;
using System.Collections.Generic;

namespace Zoo
{
    class AnimalDriver
    {
        public static List<IAnimal> Animals = new List<IAnimal>();
        private static bool isValid;

        public enum species
        {
                lion,
                bear,
                wolf,
        }
        static void Main(string[] args)
        {

            int NumberofAnimals;
            string AnimalSpeciesName;
           
            Console.WriteLine("How many animals will you like to add Lion/Bear/Wolf ?");
                NumberofAnimals = Convert.ToInt32(Console.ReadLine());

            for (int i=0; i< NumberofAnimals ; i++)
            {

                do
                {
                    Console.WriteLine("What is the animal species");
                    AnimalSpeciesName = Console.ReadLine().ToLower();
                    if (Enum.IsDefined(typeof(species), AnimalSpeciesName)){
                        isValid = true;
                    if (AnimalSpeciesName.Equals(species.lion.ToString()))
                    {
                        Lion Objlion = new Lion();
                        Animals.Add(Objlion);
                    }
                    if (AnimalSpeciesName.Equals(species.bear.ToString()))
                    {

                        Bear Objbear = new Bear();
                            Animals.Add(Objbear);
                    }

                if (AnimalSpeciesName.Equals(species.wolf.ToString()))
                {

                    Wolf Objwolf = new Wolf();
                    Animals.Add(Objwolf);
                }

                    }

                    else
                    {
                        isValid = false;
                        Console.WriteLine(" sorry invalid species, please enter either Lion/Bear/Wolf");
                    }
                } while (!isValid);

                   Animals[i].Species = AnimalSpeciesName;

                   Console.WriteLine("how old is it");
                   Animals[i].Age = Convert.ToInt32(Console.ReadLine());
                if (Animals[i] is IAnimal);
                {
                    Animals[i].UniqueCharactersitics = Animals[i].RequestUniqueCharacteristic();

                }


            }

            Console.WriteLine(Objwolf.getDesceription)
        }
    }
}
