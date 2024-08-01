using System.Buffers.Text;
using System.Data.SqlTypes;
using System.Net.NetworkInformation;
using System.Text;
using System.Xml;

namespace StringManpulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1- Concatenation Combining two or more strings:
            string firstName = "John";
            string lastName = "Doe";
            string fullName = firstName + " " + lastName; // "John Doe"
            /*    
            string fullName = string.Concat(firstName, " ", lastName); // "John Doe"
            string fullName = $"{firstName} {lastName}"; // "John Doe"
            */

            //2- Substrings Extracting a part of a string: 
            string text = "Hello, World!";
            string subText = text.Substring(7, 5); // "World"

            //3- Length Getting the length of a string:
            int length = text.Length; // 13

            //4-  Replacing parts of a string:
            string testText = "Hello, World!";
            string newText = testText.Replace("World", "C#"); // "Hello, C#!"

            //5- Splitting a string into an array based on a delimiter:
            string fruitText = "apple,banana,orange";
            string[] fruits = fruitText.Split(','); // results - ["apple", "banana", "orange"]

            //6- Trimming Removing whitespace from the beginning and end of a string:
            string trimText = "   Hello, World!   ";
            string trimmedText = trimText.Trim(); // "Hello, World!"

            //7- Case Conversion Changing the case of a string:
            string convText = "Hello, World!";
            string upperText = convText.ToUpper(); // "HELLO, WORLD!"
            string lowerText = convText.ToLower(); // "hello, world!"

            //8- Contains, StartsWith, EndsWith. Checking for the presence of a substring or the start / end of a string:
            string conText = "Hello, World!";
            bool containsHello = conText.Contains("Hello"); // true
            bool startsWithHello = conText.StartsWith("Hello"); // true
            bool endsWithWorld = conText.EndsWith("World!"); // true

            //9- Format Strings Using string.Format or string interpolation for formatting: almost the same as number 1 with 
            string name = "John";
            int age = 30;
            //there are two methods of using this .
            string formattedString = string.Format("Name: {0}, Age: {1}", name, age); // "Name: John, Age: 30"
            string interpolatedString = $"Name: {name}, Age: {age}"; // "Name: John, Age: 30"

            //10- StringBuilder For more efficient string manipulation, especially with frequent modifications, StringBuilder is recommended
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello");
            sb.Append(", ");
            sb.Append("World!");
            string result = sb.ToString(); // "Hello, World!"


        }
    }
}
