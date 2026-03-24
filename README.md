# TransportInfo - MVP Architecture Showcase

A demo application built to explore and showcase the benefits of the **Model-View-Presenter (MVP)** design pattern in software development. The main focus is managing route and city information while keeping business logic completely decoupled from the user interface.

---

## Project Architecture

This project implements the **Passive View** variant of MVP. The idea is that the View is completely "dumb" — it has no processing logic whatsoever. It only displays data received from the Presenter and forwards user events back to it.

### Core Components

- **Model** — Handles data (the `City` class) and persistence logic (saving/loading from `cities.txt`).
- **View (IView)** — An interface that defines the communication contract. Any UI implementation must implement this interface.
- **Presenter** — The "brain" of the application. It mediates between Model and View, keeping them completely independent from each other.

---

## UI Decoupling (Multiple Views)

To demonstrate the real power of this architecture, the app supports two completely different interfaces **without changing a single line of code** in the Model or Presenter:

1. **ConsoleView** — A classic command-line interface, useful for quick processing and debugging.
2. **FormView (WinForms)** — A graphical interface that includes:
   - Dynamic menu system (User / Administrator roles)
   - Visual city management (Add/Delete with "dimmed" elements for access restriction)
   - Route calculation between cities using geographic coordinates
---

##  Features

- **Decoupled architecture** — Swapping the UI doesn't affect any business logic
- **City management** — Add, delete, and list cities from a text-based database
- **Route calculation** — Compute distances and transport info between cities
- **UI security** — Input validation and role-based access control in WinForms

---

## Tech Stack

- C# / .NET
- Windows Forms (WinForms)
- Git / GitHub
