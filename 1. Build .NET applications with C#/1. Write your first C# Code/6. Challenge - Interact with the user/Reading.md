# Challenge - Interact with the user

You've learned the basics of C# console output, user input, and string manipulation. In this exercise, you put it all together by writing a program that asks the user two questions and combines their answers into a single personalized message.

This exercise takes approximately 15 minutes.

## Programs in this folder

| File | What it is |
| --- | --- |
| [Problem.cs](Problem.cs) | The starting outline: three comments and no code yet |
| [Solution.cs](Solution.cs) | One finished program to compare against |

Work in [Problem.cs](Problem.cs) and run it by naming the file:

```bash
dotnet run Problem.cs
```

The same code also runs in the online C# editor at `https://microsoftlearning.github.io/c-sharp-minor`, which has a code editor pane on top and an output console below. No installation is needed there.

## Set up your program

Before writing any logic, start from a set of guiding comments. These comments act as an outline for your program. Each one marks where a specific piece of code belongs:

```csharp
// Ask for the user's name

// Ask for the user's age

// Display a personalized message that includes both pieces of information
```

Remember, comments are ignored by C# when the program runs. They're just there to help you organize your code.

A file that holds only comments has nothing to run, so [Problem.cs](Problem.cs) fails with `error CS5001` until you add the first line of real code.

## Ask for the user's name

1. Beneath the `// Ask for the user's name` comment, add code that:

    - Uses `Console.Write()` to display the prompt `What is your name?` (remember the space before the closing quote, so the user's answer doesn't run into the prompt)
    - Uses `Console.ReadLine()` to read the user's response into a variable named `name`

2. Run the code so far, and type your name when prompted.

If you get stuck, look back at how you asked for the user's name in the Create a personalized greeting exercise.

## Ask for the user's age

1. Beneath the `// Ask for the user's age` comment, add code that:

    - Uses `Console.Write()` to display the prompt `How old are you?`
    - Uses `Console.ReadLine()` to read the user's response into a variable named `age`

2. Run the program again, and answer both prompts when asked.

`Console.ReadLine()` always returns a string, even if the user types a number. That's fine for this exercise. You can use the `age` variable directly inside a string interpolation without converting it to a number first.

Declare both variables as `string?`, not `string`, because `Console.ReadLine()` can return `null`.

## Display a personalized message

1. Beneath the `// Display a personalized message that includes both pieces of information` comment, add a `Console.WriteLine()` statement that uses string interpolation (`$"..."`) to combine the `name` and `age` variables into a single message.

2. Run your program and check that the output looks similar to this, using the name and age you entered:

    ```output
    What is your name? Sam
    How old are you? 25
    Hello, Sam! You are 25 years old.
    ```

If you get an error, check that you have double quotes around each piece of text, a semicolon at the end of each statement, and that `Console`, `Write`, `WriteLine`, and `ReadLine` are capitalized correctly. C# is case-sensitive, so `console.writeline("hi");` fails with:

```output
error CS0103: The name 'console' does not exist in the current context
```

## Verify your solution

Compare your program to the example below, which is the same as [Solution.cs](Solution.cs). Your code doesn't need to match exactly. There are many ways to write a program that works correctly, but the behavior should be the same.

```csharp
// Ask for the user's name
Console.Write("What is your name? ");
string? name = Console.ReadLine();

// Ask for the user's age
Console.Write("How old are you? ");
string? age = Console.ReadLine();

// Display a personalized message that includes both pieces of information
Console.WriteLine($"Hello, {name}! You are {age} years old.");
```
