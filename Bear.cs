using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Bear:IAnimal
    {
        public String Species { get; set; }
        public int Age { get; set; }
        public String UniqueCharactersitics { get; set; }
        bool isGrizzly;
        public String bearBool;
        public String RequestUniqueCharacteristic()
        {
            do
            {
                Console.WriteLine("Is it a grizzly bear (true/false)");
                bearBool = Console.ReadLine();

                if (bearBool.Equals("true", StringComparison.CurrentCultureIgnoreCase))
                {

                    isGrizzly = true;
                }
                else if (bearBool.Equals("false", StringComparison.CurrentCultureIgnoreCase))
                {
                    isGrizzly = false;
                }
                else
                {
                    Console.WriteLine(" incorrect input ");
                    bearBool = null;
                }
                if (isGrizzly == true)
                {
                    UniqueCharactersitics = ", is grizzly bear ";

                }
                if (isGrizzly == false)
                {
                    UniqueCharactersitics = ", is non grizzly bear";
                }
            } while (bearBool == null);
            return UniqueCharactersitics;
        }
                public String GetDescription()
                {
                    String Descritpion = "contains a" + Age + "years old" + Species + UniqueCharactersitics;
                    return Descritpion;

                }
            

    
    }
}
