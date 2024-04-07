// See https://aka.ms/new-console-template for more information
using Logic;

Console.WriteLine("Hello, World!");


string inputString = "hey amol       how \nare  \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\nyou \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n? .....";

// Split the input string by whitespace and newline characters
string[] words = inputString.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);

// Join the words into a single string with a single space between each word
string formattedString = string.Join(" ", words);

// Print the formatted string
Console.WriteLine(formattedString);


// reverse string
//Console.WriteLine("Enter a string:");
//string input = Console.ReadLine();

//string reversedString = ReverseString(input);

//Console.WriteLine("Reversed string:");
//Console.WriteLine(reversedString);

//static string ReverseString(string input)
//{
//    char[] charArray = input.ToCharArray();
//    int start = 0;
//    int end = input.Length - 1;

//    while (start < end)
//    {

//        char temp = charArray[start];
//        charArray[start] = charArray[end];
//        charArray[end] = temp;
//        start++;
//        end--;
//    }

//    return new string(charArray);
//}


// Hello World == world hello

//Console.WriteLine("Enter a sentence:");
//string sentence = Console.ReadLine();

//string reversedSentence = ReverseSentence(sentence);

//Console.WriteLine("Reversed sentence:");
//Console.WriteLine(reversedSentence);

//static string ReverseSentence(string sentence)
//{
//    char[] charArray = sentence.ToCharArray();
//    ReverseArray(charArray, 0, charArray.Length - 1); // Reverse the entire sentence

//    int start = 0;
//    for (int end = 0; end < charArray.Length; end++)
//    {
//        if (charArray[end] == ' ')
//        {
//            ReverseArray(charArray, start, end - 1); // Reverse each word
//            start = end + 1;
//        }
//        else if (end == charArray.Length - 1)
//        {
//            ReverseArray(charArray, start, end); // Reverse the last word
//        }
//    }

//    return new string(charArray);
//}

//static void ReverseArray(char[] array, int start, int end)
//{
//    while (start < end)
//    {
//        char temp = array[start];
//        array[start] = array[end];
//        array[end] = temp;
//        start++;
//        end--;
//    }
//}


// count occourance character

//// Input string
//string inpu = "Hello World";

//// Dictionary to store character counts
//Dictionary<char, int> charCounts = new Dictionary<char, int>();

//// Count occurrences of each character
//foreach (char c in inpu)
//{
//    // Skip counting spaces
//    if (c == ' ')
//        continue;

//    // Increment count if character already exists in the dictionary
//    if (charCounts.ContainsKey(c))
//    {
//        charCounts[c]++;
//    }
//    // Otherwise, add character to dictionary with count 1
//    else
//    {
//        charCounts.Add(c, 1);
//    }
//}

//// Display character counts
//foreach (var pair in charCounts)
//{
//    Console.WriteLine($"Character '{pair.Key}' occurs {pair.Value} time(s).");
//}

//string input = "Hello World";
//var duplicates = input
//                    .GroupBy(c => c)
//                    .Where(g => g.Count() > 1)
//                    .Select(g => new { Character = g.Key, Count = g.Count() });

//Console.WriteLine("Duplicate characters in the string and their occurrences:");
//foreach (var item in duplicates)
//{
//    Console.WriteLine($"Character: {item.Character}, Count: {item.Count}");
//}


//string[] input1 = { "geeksforgeeks", "geeks", "geek", "geezer" };
//string[] input2 = { "apple", "ape", "april" };

//Console.WriteLine("Output 1: " + LongestCommonPrefix(input1));
//Console.WriteLine("Output 2: " + LongestCommonPrefix(input2));


//static string LongestCommonPrefix(string[] strings)
//{
//    if (strings == null || strings.Length == 0)
//        return "";

//    int minLength = strings.Min(s => s.Length);

//    for (int i = 0; i < minLength; i++)
//    {
//        char currentChar = strings[0][i];
//        if (strings.Any(s => s[i] != currentChar))
//            return strings[0].Substring(0, i);
//    }

//    return strings[0].Substring(0, minLength);
//}

//star pattern piramid

//for (int i = 1; i <= 5; i++)
//{
//    for (int j = 1; j <=9; j++)
//    {
//        if(j>=6-i && j<=4+i)
//        {
//            Console.Write("*");
//        }
//        else
//        {
//           Console.Write(" ");
//        }
//    }
//    Console.Write("\n");
//}

//// Usage
//Animal animal = new Dog(); // Allowed because Dog is a subclass of Animal
//animal.MakeSound();

//Singleton single = Singleton.GetSingleton();

//Singleton anima = Singleton.GetSingleton();

//string data = " ---Data--is-----Gold-";


//string[] parts = data.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
//string vv = string.Join(" ", parts);
//class Program
//{

#region inheritance section
// Accessing static variable and method of Parent class
Console.WriteLine(Parent.StaticVariable); // Output: 10
Parent.StaticMethod(); // Output: Static method in Parent

// Accessing static variable and method of Child class
Console.WriteLine(Child.StaticVariable); // Output: 10
Child.StaticMethod(); // Output: Static method in Parent


// Accessing static variable and method specific to Child class
Console.WriteLine(Child.AnotherStaticVariable); // Output: 20
Child.AnotherStaticMethod(); // Output: Another static method in Child

#endregion
Console.ReadLine();






