# Build your first app by using .NET

At the outset of this module, we assumed that you have experience writing a "Hello World" application by using C#. If you haven't, you might want to review this learning path's first module, [Write your first C# code](../../1.%20Write%20your%20first%20C%23%20Code).

For simplicity, we're going to rewrite the "Hello World" application, but this time, we take a .NET perspective and see what's happening behind the scenes.

## Build a basic app by using C\#

You can write and run this program on your own computer with the .NET SDK, or in a browser code editor. The browser-based C# Code Editor at `https://microsoftlearning.github.io/c-sharp-minor` is a way to try out small code examples without installing anything.

### Step 1 - Write the code

Type the following code sample into a file named `Program.cs`, or into the C# Code Editor:

```csharp
Console.WriteLine("Hello world!");
```

As you learned in the prerequisite module, "Hello world" is a simple and canonical code example that developers write to understand the basic syntax of new programming languages. You could learn a lot about the C# syntax from this simple example. For now, we use it to learn more about .NET specifically.

### Step 2 - Run the code

Run the program:

```bash
dotnet run Program.cs
```

In the C# Code Editor, select the Run button instead. If the entered C# code is correct, the words "Hello world!" appear:

```output
Hello world!
```

### What happens to the code you write?

That single line is a complete C# program. A file that starts straight away with instructions like this uses *top-level statements*, and the C# compiler wraps those instructions in a class and a method for you. A new project created with `dotnet new console` contains the same one-line style.

Written out in full, here's how the example looks:

```csharp
using System;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Hello world!");
  }
}
```

Both versions do the same thing. The short one leaves the surrounding code for the compiler to generate, which keeps small programs simple.

Focusing on that expanded view of the code, you can see a series of curly braces `{ }`. C# uses a pair of curly braces to define a *code block*. Different kinds of code blocks are used for different purposes.

The code `public static void Main()` including the set of curly braces, define a type of code block called a *method*. A method contains a grouping of code that works toward a single purpose or responsibility in your software system.

In this case, the method contains only one line of code, and its purpose is to display a message. Larger programs can have hundreds or thousands of methods.

Methods are organized inside other code blocks called classes. A *class* can contain one or more methods. All of the methods in a class have a related purpose in the system. The class in the preceding code is named `Program`.

In your line of code, `Console.WriteLine()` is *calling*, or running, the method `WriteLine()`. The method `WriteLine()` is contained in the class `Console`.

Where is this code? It's in the base class library. Actually, its full name is `System.Console.WriteLine()`. The opening line in the preceding code example is:

```csharp
using System;
```

`System` is a *namespace*, a named group of related classes. The line `using System;` tells the C# compiler that names in your code, such as `Console`, may come from the `System` namespace. That is why you can write `Console.WriteLine()` and leave out the word `System`.

The one-line version has no `using System;` and still works, because modern .NET projects add that line for you automatically. This feature is called *implicit usings*. With the feature turned off and no `using System;`, the compiler stops with:

```output
error CS0103: The name 'Console' does not exist in the current context
```

> **Note**
>
> Don't worry about C#-specific terms like method, class, System, and using. You can learn about those later. We'll focus right now on the process of compiling and executing your code.

### What happens to your code after you insert it into the Main() method?

The most important part of this exercise is what happens after the code you write is placed into a `Main()` method. When you use `dotnet run`, the whole process happens on your own computer.

1. A command to compile your new code invokes the C# compiler.
2. The C# compiler ensures your code can be compiled and is free from syntax errors. If it can't compile your code, the compiler stops and reports an error message. For example, leaving off the semicolon gives `error CS1002: ; expected`.
3. If the C# compiler succeeds, the .NET runtime opens the newly compiled .NET assembly. It looks for a method named `Main()` to begin running the instructions. The class that holds it is usually named `Program`, but any class name works.
4. Instruction by instruction, the .NET runtime evaluates each line of code. It runs the instruction and moves to the next line of code.
5. In this case, when the instruction to print the words "Hello world!" finishes, the running path continues to the next line but finds nothing. The path ends, and the .NET runtime removes the program from its memory. Meanwhile, the output from the `WriteLine()` instruction is written to your terminal, or to the Output pane in the browser editor.

The most important concepts to understand as you're getting started are the sequence of events in this process, and the basic division of responsibilities between a programming language, a compiler, and a runtime.
