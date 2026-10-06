
// We ask the young man about the variables that got reset.
Console.WriteLine("What kind of thing are we talking about?");

/* 
 * He takes a moment to gather his thoughts and remembers something.
 This helps you understand what variables are.
*/

string a = Console.ReadLine();

// The object had a strange name so you ask for a description
Console.WriteLine("How would you describe it? Big? Azure? Tattered");
// He answers you
string b = Console.ReadLine();
string c = "of Doom";
string d = "3000";

// Your response from
Console.WriteLine("The " +
        b + " " +
        a + " " +
        c + " " +
        d + "!");


/* I also used whitespace better.
 * I'd use better variable names though.
 * Alphabetical letters are not descriptive.
 * a: Type
 * b: Description
 * c: Doom
 * d: version
 */