// the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

// TODO: Convert the if-elseif-else construct to a switch statement

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            break;
        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
            break;
        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            break;
        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "tbd";
            animalPersonalityDescription = "tbd";
            animalNickname = "tbd";
            break;
        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}

// display the top-level menu options
do
{

    Console.Clear();

    // foreach (string animal in ourAnimals) Console.WriteLine(animal);

    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
    Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
    Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
    Console.WriteLine(" 5. Edit an animal's age");
    Console.WriteLine(" 6. Edit an animal's personality description");
    Console.WriteLine(" 7. Display all cats with a specified characteristic");
    Console.WriteLine(" 8. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }

    // Console.WriteLine($"You selected menu option {menuSelection}.");
    // Console.WriteLine("Press the Enter key to continue");

    // // pause code execution
    // readResult = Console.ReadLine();

    switch (menuSelection)
    {
        case "1":
            // List all of our current pet information
            for (int i = 0; i < maxPets; i++)
            {
                // Check if data exists for this pet
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    for (int j = 0; j < 6; j++)
                    {
                        Console.WriteLine(ourAnimals[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Press Enter to return to the menu");
            Console.ReadLine();
            break;

        case "2":
            // Add a new animal friend to the ourAnimals array
            string anotherPet = "y";
            int petCount = 0;

            for (int i = 0; i < maxPets; i++)
            {
                // Check if data exists for this pet
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    petCount++;
                }
            }

            if (petCount < maxPets)
            {
                Console.WriteLine($"We currently have {petCount} pets that need homes.");
                Console.WriteLine($"We have room for {maxPets - petCount} more pets.");
            }

            while (anotherPet == "y" && petCount < maxPets)
            {
                // enter species data
                bool validEntry = false;
                do
                {
                    Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
                    readResult = Console.ReadLine();

                    if (readResult != null)
                    {
                        animalSpecies = readResult.ToLower();
                        validEntry = animalSpecies == "dog" || animalSpecies == "cat";
                    }

                } while (validEntry == false);


                // calculate animal ID
                animalID = animalSpecies[..1] + (petCount + 1).ToString();

                // get age
                do
                {
                    Console.WriteLine("Enter the pet's age (or '?' if unknown): ");
                    readResult = Console.ReadLine();

                    if (readResult != null)
                    {
                        animalAge = readResult;
                        validEntry = (animalAge == "?") || int.TryParse(animalAge, out _);
                    }

                } while (validEntry == false);

                // get physical description
                do
                {
                    Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken): ");
                    readResult = Console.ReadLine();

                    if (readResult != null)
                    {
                        animalPhysicalDescription = readResult;
                        animalPhysicalDescription = (animalPhysicalDescription == "") ? "tbd" : animalPhysicalDescription;
                    }

                } while (validEntry == false);

                // get personality description
                do
                {
                    Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level): ");
                    readResult = Console.ReadLine();

                    if (readResult != null)
                    {
                        animalPersonalityDescription = readResult;
                        animalPersonalityDescription = (animalPersonalityDescription == "") ? "tbd" : animalPersonalityDescription;
                    }

                } while (validEntry == false);


                // get nickname
                do
                {
                    Console.WriteLine("Enter a nickname for the pet: ");
                    readResult = Console.ReadLine();

                    if (readResult != null)
                    {
                        animalNickname = readResult;
                        animalNickname = (animalNickname == "") ? "tbd" : animalNickname;
                    }

                } while (validEntry == false);


                // store data
                ourAnimals[petCount, 0] = "ID #: " + animalID;
                ourAnimals[petCount, 1] = "Species: " + animalSpecies;
                ourAnimals[petCount, 2] = "Age: " + animalAge;
                ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
                ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
                ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;

                petCount++;

                // another pet?
                if (petCount < maxPets)
                {
                    Console.WriteLine("Do you want to add another pet? (y/n)");

                    do
                    {
                        if ((readResult = Console.ReadLine()) != null)
                        {
                            anotherPet = readResult.ToLower();
                        }

                    } while (anotherPet != "y" && anotherPet != "n");
                }
            }

            if (petCount >= maxPets)
            {
                Console.WriteLine($"We don't have room for any more pets. :(");
                Console.WriteLine("Press Enter to return to the menu");
                Console.ReadLine();
            }
            break;

        case "3":
            // Ensure animal ages and physical descriptions are complete
            // loop over each pet, find incomplete ones
            for (int i = 0; i < maxPets; i++)
            {
                // Check if data exists for this pet
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    // check if age is valid
                    if (ourAnimals[i, 2] == "Age: ?")
                    {
                        // if not, prompt for age
                        bool validEntry = false;

                        do
                        {
                            Console.WriteLine($"Enter an age for ID #: {ourAnimals[i, 0]}");
                            readResult = Console.ReadLine();

                            if (readResult != null)
                            {
                                animalAge = readResult;
                                validEntry = int.TryParse(animalAge, out _);
                            }

                        } while (validEntry == false);

                        // add to array
                        ourAnimals[i, 2] = animalAge;
                    }

                    // check if physical description is valid
                    if (ourAnimals[i, 4] == "Physical description: tbd")
                    {
                        // if not, prompt for description
                        bool validEntry = false;

                        do
                        {
                            Console.WriteLine($"Enter an physical description for ID #: {ourAnimals[i, 0]}");
                            readResult = Console.ReadLine();

                            if (readResult != null)
                            {
                                animalPhysicalDescription = readResult;
                                validEntry = animalPhysicalDescription != "";
                            }

                        } while (validEntry == false);

                        // add to array
                        ourAnimals[i, 4] = animalAge;
                    }
                }
            }

            Console.WriteLine("Age and physical description fields are complete for all of our friends.");
            Console.WriteLine("Press Enter to return to the menu");
            Console.ReadLine();
            break;

        case "4":
            // Ensure animal nicknames and personality descriptions are complete
            // loop over each pet, find incomplete ones
            for (int i = 0; i < maxPets; i++)
            {
                // Check if data exists for this pet
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    // check if nickname is valid
                    if (ourAnimals[i, 3] == "Nickname: tbd")
                    {
                        // if not, prompt for nickname
                        bool validEntry = false;

                        do
                        {
                            Console.WriteLine($"Enter a nickname for ID #: {ourAnimals[i, 0]}");
                            readResult = Console.ReadLine();

                            if (readResult != null)
                            {
                                animalNickname = readResult;
                                validEntry = animalNickname != "";
                            }

                        } while (validEntry == false);

                        // add to array
                        ourAnimals[i, 3] = animalAge;
                    }

                    // check if personality description is valid
                    if (ourAnimals[i, 5] == "Personality: tbd")
                    {
                        // if not, prompt for description
                        bool validEntry = false;

                        do
                        {
                            Console.WriteLine($"Enter an personality description for ID #: {ourAnimals[i, 0]}");
                            readResult = Console.ReadLine();

                            if (readResult != null)
                            {
                                animalPersonalityDescription = readResult;
                                validEntry = animalPersonalityDescription != "";
                            }

                        } while (validEntry == false);

                        // add to array
                        ourAnimals[i, 5] = animalAge;
                    }
                }
            }

            Console.WriteLine("Nickname and personality description fields are complete for all of our friends.");
            Console.WriteLine("Press Enter to return to the menu");
            Console.ReadLine();
            break;

        case "5":
            // Edit an animal's age
            Console.WriteLine("Coming Soon! [TBD]");
            Console.WriteLine("Press Enter to return to the menu");
            Console.ReadLine();
            break;

        case "6":
            // Edit an animal's personality description
            Console.WriteLine("Coming Soon! [TBD]");
            Console.WriteLine("Press Enter to return to the menu");
            Console.ReadLine();
            break;

        case "7":
            // Display all cats with a specified characteristic
            Console.WriteLine("Coming Soon! [TBD]");
            Console.WriteLine("Press Enter to return to the menu");
            Console.ReadLine();
            break;

        case "8":
            // Display all dogs with a specified characteristic
            Console.WriteLine("Coming Soon! [TBD]");
            Console.WriteLine("Press Enter to return to the menu");
            Console.ReadLine();
            break;

        default:
            break;


    }

} while (menuSelection != "exit");
