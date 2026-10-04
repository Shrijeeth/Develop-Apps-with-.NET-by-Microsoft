# Display console output

The most fundamental thing a program can do is communicate with you. In C#, you display output to the console using the `Console.WriteLine()` method.

## Using Console.WriteLine()

The `Console.WriteLine()` method outputs text to the console. You call it by passing the text you want to display inside parentheses, enclosed in double quotes:

```csharp
Console.WriteLine("Hello, world!");
```

Output:

```output
Hello, world!
```

To run it locally:

```bash
dotnet run Program.cs
```

### Double quotes are required

In C#, text (a `string`) must always be enclosed in double quotes (`"`). Single quotes (`'`) are for exactly one character (a `char`), such as `'A'`, so they won't work for text. Make sure you use the straight quotes (`"`) and not curly quotes.

### The semicolon is important

Notice the semicolon (`;`) at the end of the line. In C#, every statement must end with a semicolon. It tells the compiler you've finished the instruction.

## Printing multiple items

`Console.WriteLine()` does **not** join comma-separated values, and it does not insert spaces between them. When you pass more than one argument, the first argument is a **format string** and the remaining arguments fill its numbered placeholders `{0}`, `{1}`, and so on.

If the format string has no placeholders, the extra arguments are silently ignored:

```csharp
Console.WriteLine("Hello", "world!");
```

Output:

```output
Hello
```

There are three correct ways to print several items on one line.

### 1. Placeholders (composite formatting)

```csharp
Console.WriteLine("{0} {1}", "Hello", "world!");
```

### 2. Concatenation with `+`

```csharp
Console.WriteLine("Hello" + " " + "world!");
```

### 3. String interpolation with `$`

```csharp
string name = "world";
Console.WriteLine($"Hello {name}!");
```

All three print:

```output
Hello world!
```

Things to remember:

- You write the spaces yourself. C# never adds them.
- Placeholder numbers are positions, starting at 0. `{0}` is the first value after the format string.
- An extra value with no placeholder is dropped. A placeholder with no value, such as `{1}` when only one value is passed, throws a `FormatException` when the program runs.
- String interpolation is the style most modern C# code uses.

## Using escape characters

Sometimes you need more control over formatting—like starting a new line, adding a tab space, or including quotation marks inside your text. You can't just press Enter or Tab inside your quotes. Instead, C# uses **escape characters**, which are special combinations that start with a backslash (`\`):

| Escape sequence | What it does | Example | Output |
| --- | --- | --- | --- |
| `\n` | Moves text to a new line | `Console.WriteLine("Line 1\nLine 2");` | `Line 1` then `Line 2` on the next line |
| `\t` | Adds a tab space | `Console.WriteLine("Name:\tAlex");` | `Name:    Alex` |
| `\\` | Prints a literal backslash | `Console.WriteLine("Path: C:\\Users");` | `Path: C:\Users` |
| `\"` | Prints a double quote | `Console.WriteLine("She said, \"Hi!\"");` | `She said, "Hi!"` |

Make sure to use the backslash (`\`) and not the forward slash (`/`).

## Console.Write() vs. Console.WriteLine()

There's another method called `Console.Write()` that works similarly to `Console.WriteLine()`, but with one important difference:

- `Console.WriteLine()` adds a line break at the end, moving the next output to a new line
- `Console.Write()` prints to the current line without adding a line break

Example:

```csharp
Console.Write("Hello");
Console.Write(" ");
Console.Write("world!");
```

Output:

```output
Hello world!
```

If you used `Console.WriteLine()` instead, the output would be three lines. The middle line is not empty: it holds the single space.

```output
Hello
 
world!
```
