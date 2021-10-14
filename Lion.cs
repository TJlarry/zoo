using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Lion :IAnimal
    {

        public String Species { get; set; }
        public int Age { get; set; }
        public String UniqueCharactersitics {get; set; }
        String maneColour;


        public String RequestUniqueCharacteristic()
        {
            Console.WriteLine("What colour is its mane?");
              maneColour= Console.ReadLine();
            UniqueCharactersitics = $" with a {maneColour} name";
            return UniqueCharactersitics;
               
        }

        public String GetDescription()

        {
            String Descritpion = $" conatains a {Age} -year old system withh a {maneColour}";
            return Descritpion;
           
        }






    }
}
