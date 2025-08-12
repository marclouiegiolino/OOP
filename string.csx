// // try
// // {

// //     string firstName = "MARC LOUIEGI";
// //     string lastname = " B. OLINO";

// //     //CONCATENATION
// //     string fullname = firstName + " " + lastname;
// //     Console.WriteLine("  \n Concatenation");
// //     Console.WriteLine($"FULLNAME: {fullname} \n");

// //     //STRING INTERPOLATION
// //     Console.WriteLine("Interpolation");
// //     Console.WriteLine($"HELLO {firstName} {lastname}! \n");

// //     //LENGTH
// //     Console.WriteLine("Length");
// //     Console.WriteLine($"LENGTH OF FULL NAME: {fullname.Length} \n");

// //     //ToUpper and ToLower
// //     Console.WriteLine("ToUpper and ToLower");
// //     Console.WriteLine($"UPPERCASE: {fullname.ToUpper()} \n");
// //     Console.WriteLine($"LOWER CASE: {fullname.ToLower()} \n");

// //     //SUBSTRING
// //     Console.WriteLine("Substring");
// //     Console.WriteLine($"FIRST NAME (substring): {fullname.Substring(0, firstName.Length)} \n");

// //     //CONTAINS
// //     Console.WriteLine("Contains");
// //     Console.WriteLine($"DOES FULLNAME CONTAINS 'MARC'? {fullname.Contains("ART")} \n");

// //     //REPLACE
// //     Console.WriteLine("Replace");
// //     Console.WriteLine($"REPLACE 'MARC LOUIEGI' with 'MR.' : {fullname.Replace("MARC LOUIEGI", "MR.")} \n");

// // }
// // catch
// // {

// // }

// //String Interpolation

// try
// {
//     string name = "MARC LOUIEGI";
//     int age = 29;
//     string address = "BLK. 6 UPPER CASOY ST. GORDON HEIGHTS , OLONGAPO CITY";

//     //Basic String interpolation
//     Console.WriteLine($"HELLO , MY NAME IS {name}.");

//     //Interpolation multiple variable
//     Console.WriteLine($"I AM {age} YEARS OLD AND I LIVE IN {address}");

//     //Using expression inside interpolation

//     Console.WriteLine($"NEXT YEAR, I WILL BE{age + 1} YEARS OLD");

//     //Formating numbers
//     double price = 199.99;
//     Console.WriteLine($"The Price is Php{price:F2}");

//     //Date Formating
//     DateTime today = DateTime.Now;
//     Console.WriteLine($"Today is : {today:dddd, MMMM  dd yyyy}");
// }
// catch {

// }

try
{
    string message = "Hello, MARC LOUIEGI.................";

    //Access through each character

    Console.WriteLine($"First Character : {message[0]}");
    Console.WriteLine($"Last Character: {message[message.Length - 1 ]}");

    //Loop through each character
    Console.WriteLine("Characters in message:");
    foreach (char c in message)
    {
        Console.WriteLine(c);
    }

    //Find index of a character or substring
    int index = message.IndexOf("Marc Louiegi");
    Console.WriteLine($"Index of 'Marc Louiegi': {index}");

    //Check if string starts or ends with a specific substring
    Console.WriteLine($"Starts with 'Hello' : {message.StartsWith("Hello")}");
    Console.WriteLine($"Ends with '.' : {message.EndsWith(".")}");

    //Split string into words
    string[] words = message.Split(' ');
    Console.WriteLine("Words in message: ");
    foreach (string word in words)
    {
        Console.WriteLine(word);
    }




}
catch
{
    
}