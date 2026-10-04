# Develop Apps with .NET by Microsoft

Notes and practice code while working through Microsoft's "Develop Apps with .NET" training on Microsoft Learn. Each unit has a reading written as study notes and one or more small C# programs you can run.

The code samples in the readings were run on the .NET 10 SDK. Where the course page and the real output differ, the reading shows the real output.

## Contents

### 1. Build .NET applications with C\#

#### 1. Write your first C# code

Course module: [Write your first C# code](https://learn.microsoft.com/en-us/training/modules/csharp-write-first/)

| Unit | Topic | Files |
| --- | --- | --- |
| [1. Introduction](1.%20Build%20.NET%20applications%20with%20C%23/1.%20Write%20your%20first%20C%23%20Code/1.%20Introduction) | What the module covers | Reading |
| [2. Display console output](1.%20Build%20.NET%20applications%20with%20C%23/1.%20Write%20your%20first%20C%23%20Code/2.%20Display%20console%20output) | `Console.WriteLine`, `Console.Write`, format placeholders, escape characters | Reading, 1 program |
| [3. Accept user input](1.%20Build%20.NET%20applications%20with%20C%23/1.%20Write%20your%20first%20C%23%20Code/3.%20Accept%20user%20input) | `Console.ReadLine`, `string` vs `int`, why `"25" + 1` is `251` | Reading, 4 programs |
| [4. Manipulate strings](1.%20Build%20.NET%20applications%20with%20C%23/1.%20Write%20your%20first%20C%23%20Code/4.%20Manipulate%20Strings) | Concatenation, string interpolation, `ToUpper`, `ToLower`, `Replace`, `Length` | Reading, 4 programs |
| [5. Exercise - Create a personalized greeting](1.%20Build%20.NET%20applications%20with%20C%23/1.%20Write%20your%20first%20C%23%20Code/5.%20Exercise%20-%20Create%20a%20Personalized%20Greeting) | Guided exercise: ask for a name, print a greeting | Reading, problem, solution |
| [6. Challenge - Interact with the user](1.%20Build%20.NET%20applications%20with%20C%23/1.%20Write%20your%20first%20C%23%20Code/6.%20Challenge%20-%20Interact%20with%20the%20user) | Challenge: ask two questions, combine the answers | Reading, problem, solution |

## What is in each unit folder

| File | Purpose |
| --- | --- |
| `Reading.md` | Study notes for the unit, with each code sample and its output |
| `Program.cs`, `Program1.cs`, `Program2.cs`, ... | One runnable program per example in the reading |
| `Problem.cs` | Starting outline for an exercise: comments only, no code yet |
| `Solution.cs` | A finished version of the exercise |

## Running the code

You need the [.NET 10 SDK](https://dotnet.microsoft.com/download) or later. The programs are single files with no project file, and running a single `.cs` file directly needs .NET 10.

Open a terminal in a unit folder and name the file you want to run:

```bash
cd "1. Build .NET applications with C#/1. Write your first C# Code/3. Accept user input"
dotnet run Program1.cs
```

Things to know:

- Plain `dotnet run` with no file name fails with "Couldn't find a project to run", because there is no `.csproj` in these folders.
- Some programs wait for you to type something and press Enter. If the terminal looks frozen, it is waiting for input.
- A `Problem.cs` that still holds only comments fails with `error CS5001`. That is expected. It builds once you add the first line of code.

## License

[MIT](LICENSE)
