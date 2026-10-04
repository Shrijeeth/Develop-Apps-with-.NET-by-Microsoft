# Exercise - Create a personalized greeting

In this exercise, you write a C# program that asks for the user's name and displays a personalized greeting. You practice using the `Console.WriteLine()` method to display output, the `Console.ReadLine()` method to collect user input, and string interpolation to format a custom message.

This exercise takes approximately 15 minutes.

## Programs in this folder

| File | What it is |
| --- | --- |
| [Problem.cs](Problem.cs) | The starting outline: three comments and no code yet |
| [Solution.cs](Solution.cs) | The finished program |

Work in [Problem.cs](Problem.cs) and run it by naming the file:

```bash
dotnet run Problem.cs
```

The same code also runs in the online C# editor at `https://microsoftlearning.github.io/c-sharp-minor`, which has a code editor pane on top and an output console below. No installation is needed there.

## Set up your program

Before writing any logic, start from a set of guiding comments. These comments act as an outline for your program. Each one marks where a specific piece of code belongs:

```csharp
// Display a welcome message

// Ask for the user's name

// Display a personalized greeting
```

Remember, comments are ignored by C# when the program runs. They're just there to help you organize your code.

A file that holds only comments has nothing to run, so running [Problem.cs](Problem.cs) at this point fails with:

```output
error CS5001: Program does not contain a static 'Main' method suitable for an entry point
```

That error goes away as soon as you add the first line of real code.

## Display a welcome message

The first thing your program should do is greet the user when it starts. You use the `Console.WriteLine()` method to display a message on the screen.

1. Add the following line beneath the `// Display a welcome message` comment:

    ```csharp
    Console.WriteLine("Welcome to the greeting program!");
    ```

2. Run the program.

3. Check the output. You should see:

    ```output
    Welcome to the greeting program!
    ```

If nothing appears, make sure the code is typed exactly as shown, including the quotes, parentheses, and semicolon.

## Ask for the user's name

Now you add code that pauses the program and asks for the user's name. You use `Console.Write()` to display a prompt without moving to a new line, and `Console.ReadLine()` to wait for the user to type a response.

1. Beneath the `// Ask for the user's name` comment, add the following lines:

    ```csharp
    Console.Write("What is your name? ");
    string? name = Console.ReadLine();
    ```

    The first line displays the prompt `What is your name?` in the console. The second line waits for the user to type a response and stores whatever they type into a variable called `name`. The type is `string?` because `Console.ReadLine()` can return `null`.

2. Run the program again.

3. When `What is your name?` appears, type your name, then press Enter.

The program finishes after you enter your name, but it doesn't say anything yet. You fix that in the next step.

## Display a personalized greeting

Now you use the `name` variable to build a personalized message. You do this with string interpolation, a technique that lets you embed variable values directly inside a string by prefixing the string with `$` and wrapping variable names in curly braces `{}`.

1. Beneath the `// Display a personalized greeting` comment, add the following line:

    ```csharp
    Console.WriteLine($"Hello, {name}! It's great to meet you.");
    ```

2. Run the program, enter your name when prompted, and press Enter.

3. You should see output similar to:

    ```output
    Welcome to the greeting program!
    What is your name? Alex
    Hello, Alex! It's great to meet you.
    ```

## The complete program

Your complete program should now look like this. It is the same as [Solution.cs](Solution.cs):

```csharp
// Display a welcome message
Console.WriteLine("Welcome to the greeting program!");

// Ask for the user's name
Console.Write("What is your name? ");
string? name = Console.ReadLine();

// Display a personalized greeting
Console.WriteLine($"Hello, {name}! It's great to meet you.");
```

Run the program one more time and confirm the output matches what you entered. For example:

```output
Welcome to the greeting program!
What is your name? Alex
Hello, Alex! It's great to meet you.
```
