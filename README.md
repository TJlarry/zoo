# Zoo project in C Sharp
The Zookeepers need a system to keep track of all their animals. They need to be able to enter all their animals into the system in a way that allows them to identify and locate them. This requires identifying them by species, age and one characteristic unique to their species.
There are three cages and the user must input information about the animal in each one. After accepting input for all three cages, the program should output the contents of each cage in a way that exposes all the information about that animal.
The program should accept the following species: Lion, Bear, Wolf.
Define classes for the Lion, Bear, and Wolf species that all implement the Animal interface. All Animals should have an int field for age and a String field for species. Each species of animal should have its own unique field defined: String maneColour for Lions, int speed for Wolves, and bool isGrizzly for Bears. They should also define two methods:
RequestUniqueCharacteristic() which outputs a string asking for a value to store in the specific animal’s unique characteristic and stores it in the appropriate field (maneColour, speed, or isGrizzly)
GetDescription() which outputs a short sentence that includes all the animal’s info.
Store all the Animals in a list of animals (List<Animal>) and iterate through the list to output all the animals after input is received.
