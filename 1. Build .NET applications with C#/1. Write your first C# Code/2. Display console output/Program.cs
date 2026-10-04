// Using Console.WriteLine()
Console.WriteLine("Hello, world!");

// Printing multiple items
// The first argument is a format string. With no {0} placeholder, "world!" is ignored.
Console.WriteLine("Hello", "world!");                 // Hello

Console.WriteLine("{0} {1}", "Hello", "world!");      // placeholders
Console.WriteLine("Hello" + " " + "world!");          // concatenation
string name = "world";
Console.WriteLine($"Hello {name}!");                  // string interpolation

// Using escape characters
Console.WriteLine("Line 1\nLine 2");
Console.WriteLine("Name:\tAlex");
Console.WriteLine("Path: C:\\Users");
Console.WriteLine("She said, \"Hi!\"");

// Console.Write() vs. Console.WriteLine()
Console.Write("Hello");
Console.Write(" ");
Console.Write("world!");
Console.WriteLine();                                  // end the line started by Write

Console.WriteLine("Hello");
Console.WriteLine(" ");
Console.WriteLine("world!");
