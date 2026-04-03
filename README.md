# Pentaliza – C# Windows Forms Game

A simple **Pentaliza (5×5 Tic-Tac-Toe style)** desktop game built using **C#** and **Windows Forms** in **Visual Studio**.

The project includes **two game modes**:
- Player vs Player
- Player vs Computer

---

## Game Overview

Pentaliza is a board game played on a **5×5 grid**.  
Players place **X** and **O** on the board trying to align **five identical symbols** in a row.

The game automatically detects:

- Horizontal wins
- Vertical wins
- Diagonal wins
- Draw situations

When a game ends, the board resets automatically.

---

## Game Modes

### Player vs Player
Implemented in **Form1**.

- Two players play on the same computer.
- Players take turns placing **X** and **O**.
- The game detects a win or draw and resets the board.

### Player vs Computer
Implemented in **Form2**.

- The human player plays as **X**.
- The computer plays as **O**.
- The computer selects a **random available cell** on the board.
- After each move the game checks for a win or draw.

---

## Game Logic

The board is implemented using **25 buttons** arranged in a **5×5 grid**.

The game logic includes:

- Turn control using a boolean flag
- Checking for winning combinations:
  - Rows
  - Columns
  - Main diagonal
  - Secondary diagonal
- Detecting draw conditions
- Resetting the board after a completed game

---

## User Interface

The application uses **Windows Forms** and includes:

- 25 clickable buttons for the game board
- Labels showing the next player's turn
- Message boxes announcing the winner or a draw

---

## Technologies Used

- C#
- .NET Framework
- Windows Forms
- Visual Studio

---

## How to Run

1. Clone the repository

```bash
git clone https://github.com/mikegialelis/Pentaliza
```
2. Open the project in Visual Studio
3. Run the project with F5
