# Accept user input

Programs become truly powerful when they can interact with the people using them. C#'s `Console.ReadLine()` method lets you pause your program, wait for the user to type something, and capture that information.

## Programs in this folder

| File | Section | Type this | Prints |
| --- | --- | --- | --- |
| [Program1.cs](Program1.cs) | Using Console.ReadLine() | `Orange` | `Oh, I love Orange too!` |
| [Program2.cs](Program2.cs) | Add a space at the end of your prompt | `Orange` | `Oh, I love Orange too!` after the prompt |
| [Program3.cs](Program3.cs) | Console.ReadLine() always returns a string | `25` | `251` |
| [Program4.cs](Program4.cs) | Understanding data types | nothing | `26` then `251` |

Run one by naming the file:

```bash
dotnet run Program1.cs
```

Each file is a separate program. `dotnet run <file>` builds only the file you name, so the four files do not clash even though they sit in one folder.

## Using Console.ReadLine()

Think of the `Console.ReadLine()` method as a question prompt. When your program hits this line, it waits until the user types their answer and presses the Enter key before continuing.

To save the user's answer, you must "catch" it using a variable:

```csharp
string? favoriteColor = Console.ReadLine();
Console.WriteLine("Oh, I love " + favoriteColor + " too!");
```

In this code, `favoriteColor` is a variable (a container that holds a value). When you run this program, it waits for input. If the user types `Orange` and presses Enter, the screen shows:

```output
Orange
Oh, I love Orange too!
```

The first line is what the user typed. The second line is the program's output.

This is [Program1.cs](Program1.cs). When it starts, the terminal shows nothing and waits. That is the program waiting for you to type.

### Why string? and not string

`Console.ReadLine()` can return `null`, which means "no value at all". That happens when there is no more input to read, for example when input is piped from an empty file or the user presses Ctrl+D.

The `?` in `string?` tells the compiler "this variable may hold text or `null`". Without it, the code still runs, but every build prints:

```output
warning CS8600: Converting null literal or possible null value to non-nullable type.
```

## Add a space at the end of your prompt

To make the user input more readable, combine `Console.Write()` with `Console.ReadLine()`:

```csharp
Console.Write("What is your favorite color? ");
string? favoriteColor = Console.ReadLine();
Console.WriteLine("Oh, I love " + favoriteColor + " too!");
```

Notice the space at the end of the prompt: `"What is your favorite color? "`. Without it, the user's input would look glued to your text: `What is your favorite color?Orange`. Adding a space makes it clearer.

`Console.Write()` is used here, not `Console.WriteLine()`, so the cursor stays on the same line as the question.

This is [Program2.cs](Program2.cs).

## Understanding data types

Every value in C# has a data type, which tells the computer what kind of value it is. Some common data types are:

- **String (`string`)**: Text wrapped in quotes, like `"Blue"` or `"25"`. Even a number becomes text when it's inside quotes.
- **Integer (`int`)**: A whole number without quotes, like `25` or `100`. You can do math with these.

Why does this matter? C# treats these types differently, and the `+` operator shows it best:

| Code | Types | Result | What `+` did |
| --- | --- | --- | --- |
| `25 + 1` | `int` + `int` | `26` | Addition |
| `"25" + 1` | `string` + `int` | `251` | Joined the text `"25"` and the text `"1"` |

When either side of `+` is a string, C# converts the other side to text and joins them. It never does math on the text.

Both lines are in [Program4.cs](Program4.cs).

The other math operators have no meaning for text, so these do not compile:

```csharp
Console.WriteLine("25" - 1);   // error CS0019: Operator '-' cannot be applied to operands of type 'string' and 'int'
Console.WriteLine("25" * 2);   // error CS0019: Operator '*' cannot be applied to operands of type 'string' and 'int'
```

## Console.ReadLine() always returns a string

An essential rule to remember is that `Console.ReadLine()` always returns text (a `string`), even if the user types a number. For example:

```csharp
string? age = Console.ReadLine();
Console.WriteLine(age + 1); // No error, but type 25 and it prints 251, not 26
```

This is [Program3.cs](Program3.cs). If you run it and type `25`, the program won't print `26`. It prints:

```output
251
```

There is no error and no warning. C# joins the text `"25"` with the text `"1"`. This is a common beginner mistake, and it is harder to spot than a real error because the program runs and quietly gives a wrong answer.

To do math with user input, you'd need to convert the text to a number first—but that is covered later. For now, remember: whatever the user types is always treated as text.
