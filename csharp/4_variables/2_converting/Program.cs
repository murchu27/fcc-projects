// Unit 2
// int first = 2;
// string second = "4";
// // int result = first + second;
// string result = first + second;
// Console.WriteLine(result);

// // Widening conversion - implicit conversion allowed
// int myInt = 3;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = myInt;
// Console.WriteLine($"decimal: {myDecimal}");

// // Narrowing conversion - implicit conversion not allowed
// decimal myDecimal = 3.14m;
// Console.WriteLine($"decimal: {myDecimal}");

// int myInt = (int)myDecimal;
// Console.WriteLine($"int: {myInt}");

// // ToString method
// int first = 5;
// int second = 7;
// string message = first.ToString() + second.ToString();
// Console.WriteLine(message);

// // Parse method
// string first_str = "5";
// string second_str = "7";
// int sum = int.Parse(first_str) + int.Parse(second_str);
// Console.WriteLine(sum);

// // Convert class
// string value1 = "5";
// string value2 = "7";
// int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
// Console.WriteLine(result);

// casting vs Convert with a narrowing conversion
// int value = (int)1.5m; // casting truncates
// Console.WriteLine(value);

// int value2 = Convert.ToInt32(1.5m); // converting rounds up (or down if appropriate, e.g., 1.49m)
// Console.WriteLine(value2);



// // Unit 3
// string value = "no";
// int parse_result = 0;

// if (int.TryParse(value, out parse_result)) {
//     Console.WriteLine($"Parse Result: {parse_result}");
// } else {
//     Console.WriteLine("Couldn't convert");
// }

// if (parse_result > 0)
//     Console.WriteLine($"Measurement (w/ offset): {50 + parse_result}");



// // Unit 4
// string[] values = { "12.3", "45", "ABC", "11", "DEF" };

// string message = "";
// decimal total = 0;
// decimal parse_result;

// foreach (var val in values)
// {
    
//     if (decimal.TryParse(val, out parse_result)) {
//         total += parse_result;
//     } else {
//         message += val;
//     }
// }

// Console.WriteLine($"Message: {message}");
// Console.WriteLine($"Total: {total}");



// Unit 6
int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

int result1 = Convert.ToInt32(value1 / value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");