using System;

namespace _3._Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            /*\n to print code on a new line*/
            Console.WriteLine("I am working at \n 9ine");
            /*using \ to use double quotes in string*/
            Console.WriteLine("I am working at \n \"9ine\" ");

            /*Storing string in a variable*/
            string Name = "Son Goku";
            Console.WriteLine(Name);

            /*Concatenation*/
            Console.WriteLine("Hii I am in first line and " + " You are in second line");
            //Also you can concat like this,
            Console.WriteLine("Hii I am {0}(firstValue) and I am {1}(Secodn Val) years old",Name,age);
            /*To find the length of the characters in a string*/
            string YourName = "Son Goku San!";
            Console.WriteLine("The no. of characters YourName has "+YourName.Length);

            /*Converting All the characters to upper case */
            Console.WriteLine(YourName.ToUpper());

            /*Converting All the characters to Lower case */
            Console.WriteLine(YourName.ToLower());

            /*To check a substring or string which is present inside of a string*/
            Console.WriteLine(YourName.Contains("son"));
            /*Returns True or False value and It is case sensitive*/

            /*To access perticular Characters in a string */
            Console.WriteLine(YourName[0]);
            Console.WriteLine(YourName[1]);
            Console.WriteLine(YourName[2]);
            /*here [0] [1] [2] are the index of the string */

            /*To find index of the perticular Character */
            Console.WriteLine(YourName.IndexOf("Goku"));
            Console.WriteLine(YourName.IndexOf('o'));
            /*if not present in a string it returns -1 */

            /*To grab word in a string */
            Console.WriteLine(YourName.Substring(4));
            Console.WriteLine(YourName.Substring(4,5));
            /*here the second argument is no. of characters after the index*/


        }
    }
}
