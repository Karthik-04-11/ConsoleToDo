# Console ToDo

A simple menu-driven to-do list application that runs in the terminal. Add tasks, view their status, delete individual or all tasks, and mark tasks as pending or completed.

## Requirements

- .NET 10 SDK

## Run the application

From the project directory, run:

```bash
dotnet run
```

To build without running:

```bash
dotnet build
```

## How to use

Choose an option from the menu:

1. **Add task** — enter a non-empty task title. New tasks start as pending.
2. **View tasks** — display each task and its current status.
3. **Delete task** — choose whether to delete all tasks or enter the number of one task to delete.
4. **Exit** — close the application.
5. **Update status of task** — choose a task and set its status to pending or completed.

Tasks are stored in memory, so they are cleared when the application exits.

## Project structure

- [`Program.cs`](./Program.cs) — displays the menu and routes the selected action.
- [`TaskUtil.cs`](./TaskUtil.cs) — implements task operations.
- [`ToDoItem.cs`](./ToDoItem.cs) — defines a task and its pending/completed status.
- [`ConsoleIO.cs`](./ConsoleIO.cs) — provides console input and output helpers.
