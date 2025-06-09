# 🧮 Project1 – Geometry, Calculator & Rock Paper Scissors App

**Project1** is a C# web application built with ASP.NET Core that allows users to perform calculations on geometric shapes, use a basic calculator, and play Rock, Paper, Scissors against the computer. All operations are stored in a database, with support for editing and soft deletion.

---

## 💼 Tech Stack

- C#
- ASP.NET Core
- Entity Framework Core
- SQL Server (or compatible database)
- MVC (Model-View-Controller) Pattern
- Dependency Injection

---

## 🚀 Features

### 📐 Geometry Calculations
- Calculate perimeter and area for various shapes
- Save all calculations to the database
- Edit previous calculations
- Perform **soft delete** (non-destructive deletion)

### ✂️ Rock, Paper, Scissors Game
- Play against the computer
- Automatically stores and displays results/statistics

### ➕ Calculator
- Choose operation type, input two numbers, and get the result
- Save all operations in the database
- Edit existing operations
- Perform **soft delete** on any entry

---

## 🧩 Architecture Overview

### ✅ ASP.NET Core & Entity Framework
- ASP.NET Core is used for the backend logic and routing
- EF Core handles data persistence and querying

### ✅ MVC Pattern
- Separates concerns between data (Model), presentation (View), and logic (Controller)

### ✅ Dependency Injection (DI)
- All services are injected for improved testability and loose coupling

---

## 📁 Project Structure

├── Data/ --> Database context and data classes
├── Shapes/ --> Geometry calculation logic
├── RockPaperScissors/ --> Game logic and result tracking
├── Calcylator/ --> Basic calculator functionality
├── Controllers/ --> ASP.NET MVC controllers
└── Views/ --> Razor views (UI templates)

---

## 💾 Installation

1. **Clone the repository**
   git clone https://github.com/your-username/projekt1.git
   cd projekt1
