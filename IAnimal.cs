using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    interface IAnimal
    {
        public String Species { get; set; }
        public int Age { get; set; }
        public String UniqueCharactersitics { get; set; }


        public string RequestUniqueCharacteristic();
        public string GetDescription();
    }
}

