// See https://aka.ms/new-console-template for more information

using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Timers;

Console.WriteLine("Hello, World!");

string aFriend = "Maira";
Console.WriteLine("Hello " + aFriend);

// El metodo moderno agreando un $ al inicio del string, sele conoce como string interpolation:
Console.WriteLine($"Hello {aFriend}");

string firstFriend = "Maria";
string secondFriend = "Sergio";

Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letter.");
Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");



Console.WriteLine("\n");

// Trim
string greeting = "          Paco            ";
Console.WriteLine($"[{greeting}]");

string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = trimmedGreeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");

Console.WriteLine("\n");
// Search and replace text in strings
string sayHello = "Hello World";
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hello", "Greetings");
Console.WriteLine(sayHello);

Console.WriteLine("\n");
Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());

// Contians
string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.Contains("goodbye"));
Console.WriteLine(songLyrics.Contains("greetings"));

// StartWith
Console.WriteLine(songLyrics.StartsWith("You"));
Console.WriteLine(songLyrics.EndsWith("goodbye"));

// Immutbility of strings
string s1 ="A string is more ";
string s2 ="than the sum of its chars.";

// Concatenate s1 and s2. This actually creates a new
// string object and stores it in s1, releasing the
// reference to the original object.

s1 +=s2 ;
Console.WriteLine(s1);

string str1 = "Hello ";
string str2 = str1;

str1 += "World";
Console.WriteLine(str2);
Console.WriteLine(str1);

string title = "\"The \u00C6olean Harp\", by Samuel Taylor Coleridge";
Console.WriteLine(title);

string text = @"My pensive SARA ! thy soft cheek reclined
Thus on mine arm, most soothing sweet it is 
To sit beside our Cot..";
Console.WriteLine(text);

string quote = @"Her name was ""Sara.""";
Console.WriteLine(quote);


string singleLine = """Feiends say "hello" has they pass by.""";
Console.WriteLine(singleLine);

string multiLine = """
"Hello World!" is a typically the first program someone writes.
""";
Console.WriteLine(multiLine);

string embeddedXML = """
       <element attr = "content">
           <body style="normal">
               Here is the main text
           </body>
           <footer>
               Excerpts from "An amazing story"
           </footer>
       </element >
       """;
Console.WriteLine(embeddedXML);

string rawStringLiteralDelimiter = """"
Raw string literals are delimited
by a string of at least three double quotes,
like this: """
"""";

Console.WriteLine(rawStringLiteralDelimiter);