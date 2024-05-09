# Simple TODO List Console Application

This C# application provides a basic command-line interface for managing a personal TODO list. Users can add, view, and remove tasks through simple text commands.

## Features

- **View TODOs**: Display all the tasks currently in your TODO list.
- **Add a new TODO**: Add a new task to your TODO list ensuring that each entry is unique and non-empty.
- **Remove a TODO**: Remove a task from your TODO list by specifying its number.

## Setup

To run this application, you need:
- .NET SDK installed on your machine. You can download it from [Microsoft's official .NET download page](https://dotnet.microsoft.com/download).

### Installation Steps

1. Clone the repository or download the source code.
2. Navigate to the project directory in your terminal.
3. Run the application using the command:
   ```
   dotnet run
   ```

## Usage

When you start the application, it will greet you with a "Hello!" message and present you with the following options:

```
What do you want to do?
[S]ee all TODOs
[A]dd a new TODO
[R]emove a TODO
[E]xit
```

### Navigating the Menu

- Type `S` and press Enter to see all your TODOs.
- Type `A` and press Enter to add a new TODO. Follow the prompts to enter a description for your new TODO.
- Type `R` and press Enter to remove a TODO. You will then need to select the index of the TODO you wish to remove.
- Type `E` and press Enter to exit the application.

Each option is case-insensitive, meaning you can enter `s`, `a`, `r`, or `e` in lowercase.

## Error Handling

- The application ensures that TODO descriptions are not empty and are unique within your list.
- If you try to remove a TODO and either input an invalid number or an empty response, the application will prompt you to try again.

Feel free to modify and expand this application as needed. Enjoy managing your tasks more efficiently!

---