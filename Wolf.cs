using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Wolf: IAnimal
    {


        public String Species { get; set; }
        public int Age { get; set; } 
        public String UniqueCharactersitics { get; set; }
        public int speed;
        



        public String RequestUniqueCharacteristic()
        {
            Console.WriteLine("How fast can it run (in km/h)?");
            speed = Convert.ToInt32(Console.ReadLine());
            UniqueCharactersitics = $" with a {speed} km/hr";
            return UniqueCharactersitics;

        }

        public String GetDescription()

        {
            String Descritpion = "contains"+ Age + "years old " + speed + UniqueCharactersitics;

            return Descritpion;

        }








    }
}
