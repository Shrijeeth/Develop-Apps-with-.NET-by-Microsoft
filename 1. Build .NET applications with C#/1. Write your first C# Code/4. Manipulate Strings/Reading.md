# Manipulate strings

Text is one of the most common types of data in programming. In C#, text is represented as a string—a sequence of characters enclosed in double quotes. C# provides many built-in ways to manipulate and format strings.

## Programs in this folder

| File | Section | Type this | Prints |
| --- | --- | --- | --- |
| [Program1.cs](Program1.cs) | Concatenation (joining strings together) | nothing | `Hello, world!` |
| [Program2.cs](Program2.cs) | A better way: String interpolation | nothing | `Hello, Alex!` |
| [Program3.cs](Program3.cs) | A cleaner way to combine input and output | `Alex` | `Hello, Alex! Nice to meet you!` |
| [Program4.cs](Program4.cs) | Practical example | `alex` | `Welcome, ALEX!` after the prompt |

Run one by naming the file:

```bash
dotnet run Program1.cs
```

## Concatenation (joining strings together)

You can join two or more strings together into a single string using the `+` operator:

```csharp
string first = "Hello";
string last = "world";
string message = first + ", " + last + "!";
Console.WriteLine(message);
```

Output:

```output
Hello, world!
```

This is [Program1.cs](Program1.cs).

While concatenation works great for simple combinations, it can become messy when you try to mix variables, punctuation, and spaces together.

## A better way: String interpolation

A cleaner, modern way to combine strings and variables is with string interpolation. To create this kind of string, place a dollar sign (`$`) directly before your opening quote, and place any variable names inside curly braces `{}`:

```csharp
string name = "Alex";
Console.WriteLine($"Hello, {name}!");
```

Output:

```output
Hello, Alex!
```

This is [Program2.cs](Program2.cs).

### A cleaner way to combine input and output

String interpolation makes it easy to mix text with the value from `Console.ReadLine()`:

```csharp
string? name = Console.ReadLine();
Console.WriteLine($"Hello, {name}! Nice to meet you!");
```

This is much cleaner than concatenating with `+`. If the user types `Alex`, the screen shows:

```output
Alex
Hello, Alex! Nice to meet you!
```

This is [Program3.cs](Program3.cs). The variable is `string?` because `Console.ReadLine()` can return `null`.

> **Note**
>
> If you forget the `$` prefix, as in `Console.WriteLine("Hello, {name}")`, C# won't look inside the braces. It prints `Hello, {name}` on the screen.

## Common string methods

C# strings have many built-in methods for common operations. To use a method, type the value or variable name, a dot, and the method name followed by parentheses:

| Member | Kind | What it does | Example | Result |
| --- | --- | --- | --- | --- |
| `.ToUpper()` | Method | Converts text to uppercase | `"hello".ToUpper()` | `"HELLO"` |
| `.ToLower()` | Method | Converts text to lowercase | `"HELLO".ToLower()` | `"hello"` |
| `.Replace(old, new)` | Method | Swaps out specific characters | `"cat".Replace("c", "b")` | `"bat"` |
| `.Length` | Property | Returns the number of characters | `"Alex".Length` | `4` |

Two things to remember:

- `.Length` is a property, not a method, so it takes no parentheses. `"Alex".Length()` does not compile: `error CS1955: Non-invocable member 'string.Length' cannot be used like a method.`
- These methods return a **new** string. They never change the original. To keep the result, store it:

```csharp
string word = "hello";
word.ToUpper();               // result is thrown away
Console.WriteLine(word);      // hello

word = word.ToUpper();        // result is stored back in word
Console.WriteLine(word);      // HELLO
```

## Practical example

Here's how you might use these techniques together:

```csharp
Console.Write("What's your name? ");
string? name = Console.ReadLine();
string greeting = $"Welcome, {name?.ToUpper()}!";
Console.WriteLine(greeting);
```

If the user types `alex`, the screen shows:

```output
What's your name? alex
Welcome, ALEX!
```

This is [Program4.cs](Program4.cs).

Notice how `.ToUpper()` converted the user's input to uppercase, and string interpolation made it easy to combine everything together.

### Why name?.ToUpper() and not name.ToUpper()

`name` is a `string?`, so it may be `null`. Calling a method on `null` crashes the program, so with plain `name.ToUpper()` every build prints:

```output
warning CS8602: Dereference of a possibly null reference.
```

`?.` means "call the method only if the value is not `null`". With `name?.ToUpper()`, the warning goes away and the program cannot crash on that line.
