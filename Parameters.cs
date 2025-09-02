using System;

namespace PARAMETER
{
    public class Info
    {
        public static void InfoMain(string name, int age, string gender,string status, string address, string religion, string citizenship)
        {

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Status: {status}");
            Console.WriteLine($"Address: {address}");
            Console.WriteLine($"Religion: {religion}");
            Console.WriteLine($"Citizenship: {citizenship}\n");
          
        }
    }
}