// // Unit 2
// string[] pallets = { "B14", "A11", "B12", "A13" };

// // Sorting
// Console.WriteLine("Sorted...");
// Array.Sort(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// // Sorting in reverse
// Console.WriteLine("");
// Console.WriteLine("Reversed...");
// Array.Reverse(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }



// // Unit 3
// // Clear - Removing elements
// string[] pallets = { "B14", "A11", "B12", "A13" };
// Console.WriteLine("");

// // Clear replaces elements with null
// Console.WriteLine($"Before: {pallets[0]}");
// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"After: {pallets[0]}");

// // We can tell it's null because string methods cause an error
// // Console.WriteLine(pallets[0].ToLower());

// // To ensure safety, we can check for null first
// if (pallets[0] != null)
//     Console.WriteLine(pallets[0].ToLower());

// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }


// // Resize - change length of array
// Console.WriteLine("");

// // e.g., increasing length
// // Note: Resize uses `ref` keyword to pass an argument by reference
// Array.Resize(ref pallets, 6);
// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }


// // e.g., decreasing length
// Console.WriteLine("");
// Array.Resize(ref pallets, 3);
// Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }



// // Unit 4
// // Reverse a string by converting to array, then reversing the array
// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);

// // Convert back to string by making a new string object...
// string newvalue = new string(valueArray);
// Console.WriteLine(newvalue);

// // ...or by using the String Join method
// string newvalue2 = String.Join(", ", valueArray);
// Console.WriteLine(newvalue2);

// // The opposite of String Join is String Split
// string[] values = newvalue2.Split(", ");
// foreach (var val in values)
// {
//     Console.WriteLine(val);
// }



// // Unit 5
// string pangram = "The quick brown fox jumps over the lazy dog";
// string[] words = pangram.Split(" ");
// string[] new_words = new string[words.Length];
// int count = 0;

// foreach (var word in words) {
//     char[] word_array = word.ToCharArray();
//     Array.Reverse(word_array);
//     new_words[count++] = String.Join("", word_array);
// }

// string result = String.Join(" ", new_words);
// Console.WriteLine(result);



// Unit 7
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orderIDs = orderStream.Split(",");
Array.Sort(orderIDs);

foreach (var id in orderIDs)
{
    if (id.Length == 4)
        Console.WriteLine(id);
    else {
        Console.WriteLine(String.Format("{0, -7} - Error", id));
    }
}