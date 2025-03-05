// See https://aka.ms/new-console-template for more information


// // Copying an Array
// int[] original = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
// int[] copied = new int[original.Length];
// for (int i = 0; i < original.Length; i++)
// {
//     copied[i] = original[i];
// }
// Console.Write("Original array: ");
// Console.WriteLine(string.Join(", ", original));
// Console.Write("Copied array: ");
// Console.WriteLine(string.Join(", ", copied));


// // Write a simple program that lets the user manage a list of elements. 
// Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
// List<string> items = new List<string>();
// while (true)
// {
//     string? line = Console.ReadLine();
//     string[] command = line.Split(" ", 2);
//
//     switch (command[0])
//     {
//         case "+": 
//             items.Add(command[1]);
//             break;
//         case "-":
//             items.Remove(command[1]);
//             break;
//         case "--":
//             items.Clear();
//             break;
//     }
//     
//     Console.Write("items: ");
//     Console.WriteLine(string.Join(", ", items));
// }


// // Write a method that calculates all prime numbers in given range and returns them as array of integers
// static int[] FindPrimesInRange(int startNum, int endNum)
// {
//     List<int> primes = new List<int>();
//     for (int i = startNum; i <= endNum; i++)
//     {
//         if (isPrime(i))
//         {
//             primes.Add(i);
//         }
//     }
//     return primes.ToArray();
// }
//
// static bool isPrime(int number)
// {
//     if (number < 2)
//     {
//         return false;
//     }
//     for (int i = 2; i * i <= number; i ++)
//     {
//         if (number % i == 0)
//         {
//             return false;
//         }
//     }
//     return true;
// }
//
// int[] primes = FindPrimesInRange(1, 100);
// Console.WriteLine(string.Join(", ", primes));


// // Rotate the array right k times and sum the obtained arrays after each rotation
// static int[] rotate(int[] array)
// {
//     int[] rotated = new int[array.Length];
//     rotated[0] = array[array.Length - 1];
//     for (int i = 1; i < array.Length; i++)
//     {
//         rotated[i] = array[i - 1];
//     }
//     return rotated;
// }
//
// int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
// int k = int.Parse(Console.ReadLine());
// int[] sum = new int[array.Length];
//
// for (int i = 0; i < k; i++)
// {
//     array = rotate(array);
//     for (int j = 0; j < array.Length; j++)
//     {
//         sum[j] += array[j];
//     }
// }
//
// Console.WriteLine(string.Join(" ", sum));


// // Write a program that finds the longest sequence of equal elements in an array of integers. 
// int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
// int maxStart = 0;
// int maxEnd = 0;
// int currStart = 0;
// int currEnd = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] == array[currEnd])
//     {
//         currEnd = i;
//     }
//     else
//     {
//         if (currEnd - currStart > maxEnd - maxStart)
//         {
//             maxStart = currStart;
//             maxEnd = currEnd;
//         }
//         currStart = i;
//         currEnd = i;
//     }
// }
//
// if (currEnd - currStart > maxEnd - maxStart)
// {
//     maxStart = currStart;
//     maxEnd = currEnd;
// }
//
// for (int i = maxStart; i <= maxEnd; i++)
// {
//     Console.Write(array[i] + " ");
// }


// // Write a program that finds the most frequent number in a given sequence of numbers. 
// int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
// Dictionary<int, int> dict = new Dictionary<int, int>();
// int mostFrequent = array[0];
// int maxFrequency = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (dict.ContainsKey(array[i]))
//     {
//         dict[array[i]]++;
//     }
//     else
//     {
//         dict.Add(array[i], 1);
//     }
//
//     if (dict[array[i]] > maxFrequency)
//     {
//         maxFrequency = dict[array[i]];
//         mostFrequent = array[i];
//     }
// }
//
// Console.WriteLine(mostFrequent);


// // Write a program that reads a string from the console, reverses its letters and prints the result back at the console. 
// // Write in two ways: 
// // * Convert the string to char array, reverse it, then convert it to string again. 
// string input = Console.ReadLine();
// char[] inputArray = input.ToCharArray();
// Array.Reverse(inputArray);
// string output = new string(inputArray);
// Console.WriteLine(output);
//
// // * Print the letters of the string in back direction (from the last to the first) in a for-loop. 
// string input = Console.ReadLine();
// for (int i = input.Length - 1; i >= 0; i--)
// {
//     Console.Write(input[i]);
// }


// // Write a program that reverses the words in a given sentence without changing the punctuation and spaces
// using System.Text;
//
// char[] separators = { ' ', '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '\"', '\'', '\\', '/', '!', '?' };
// string input = Console.ReadLine();
// string[] words = input!.Split(separators, StringSplitOptions.RemoveEmptyEntries);
// int curr = words.Length - 1;
// StringBuilder output = new StringBuilder();
// bool expectWord = true;
// for (int i = 0; i < input.Length; i++)
// {
//     if (Array.Exists(separators, x => x == input[i]))
//     {
//         output.Append(input[i]);
//         expectWord = true;
//     } else if (expectWord && curr >= 0)
//     {
//         output.Append(words[curr--]);
//         expectWord = false;
//     }
// }
// Console.WriteLine(output.ToString());


// // Write a program that extracts from a given text all palindromes. 
// static bool isPalindrome(string s)
// {
//     int left = 0;
//     int right = s.Length - 1;
//     while (left < right)
//     {
//         if (s[left] != s[right])
//         {
//             return false;
//         }
//         left++;
//         right--;
//     }
//     return true;
// }
//
// char[] separators = { ' ', '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '\"', '\'', '\\', '/', '!', '?' };
// string input = Console.ReadLine();
// string[] words = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
// HashSet<string> palindromes = new HashSet<string>();
// for (int i = 0; i < words.Length; i++)
// {
//     if (isPalindrome(words[i]))
//     {
//         palindromes.Add(words[i]);
//     }
// }
//
// Console.WriteLine(string.Join(", ", palindromes.OrderBy(s => s)));


// Write a program that parses an URL given in the following format:
// [protocol]://[server]/[resource]
string url = Console.ReadLine();
string protocol = "";
string server = "";
string resource = "";
if (url.Contains("://"))
{
    protocol = url.Split("://").First();
    url = url.Split("://").Last();
}

if (url.Contains("/"))
{
    server = url.Split("/").First();
    resource = url.Split("/").Last();
}
else
{
    server = url;
}
Console.WriteLine($"[protocol] = \"{protocol}\"");
Console.WriteLine($"[server] = \"{server}\"");
Console.WriteLine($"[resource] = \"{resource}\"");