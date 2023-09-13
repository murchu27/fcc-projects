// // Unit 2
// Random random = new Random();
// int current = random.Next(1, 11);

// do
// {
//     current = random.Next(1, 11);
//     if (current >= 8) continue;
//     Console.WriteLine(current);
// } while (current != 7);


// // while (current >= 3)
// // {
// //     Console.WriteLine(current);
// //     current = random.Next(1, 11);
// // }
// // Console.WriteLine($"Last number: {current}");



// // Unit 3
// int hero = 10;
// int monster = 10;

// Random random = new Random();

// do {
//     // Hero attacks
//     int hero_atk = random.Next(1, 11);
//     monster -= hero_atk;

//     Console.WriteLine($"Monster took {hero_atk} damage; {monster} health remaining");
//     if (monster <= 0) continue;

//     // Monster attacks
//     int monster_atk = random.Next(1, 11);
//     hero -= monster_atk;

//     Console.WriteLine($"Hero took {monster_atk} damage; {hero} health remaining");
// } while (hero > 0 && monster > 0);

// string winner = (hero > 0) ? "Hero" : "Monster";
// Console.WriteLine($"The winner is: {winner}");



// // Unit 5-1
// string? readResult;
// int numericValue;
// Console.WriteLine("Enter an integer between 5 and 10:");

// bool check1 = false;
// bool check2 = false;

// do
// {
//     readResult = Console.ReadLine();

//     check1 = int.TryParse(readResult, out numericValue);

//     if (!check1) {
//         Console.WriteLine("Not a number, try again!");
//         continue;
//     }
    
//     check2 = numericValue >= 5 && numericValue <= 10;

//     if (!check2) {
//         Console.WriteLine("Please choose a number between 5 and 10!");
//         continue;
//     }

// } while (!check1 || !check2);

// Console.WriteLine("Thanks!");



// // Unit 5-2
// Console.WriteLine("Please type one of the following - Administrator, Manager, User:");
// string? user_input;

// do {
//     user_input = Console.ReadLine();

//     if (user_input == null) continue;

//     user_input = user_input.Trim().ToLower();

// } while (user_input != "administrator" && user_input != "manager" && user_input != "user");

// Console.WriteLine("Thanks!");



// Unit 5-3
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int periodLocation;

foreach (string myString in myStrings) {
    periodLocation = myString.IndexOf(".");
    int start = 0;

    while (periodLocation != -1) {
        Console.WriteLine(myString[start..periodLocation].TrimStart());

        start = periodLocation + 1;
        periodLocation = myString.IndexOf(".", start);
    }

    Console.WriteLine(myString[start..].TrimStart());
}