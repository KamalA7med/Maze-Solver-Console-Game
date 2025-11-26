# Maze-Solver-Console-Game

A C# console-based maze game where the player navigates a dynamically generated maze. Obstacles are created using mathematical difficulty functions (Easy, Medium, Hard). The goal is to reach the exit while avoiding solid blocks.

---

## 🎮 Features
- User-defined **maze length and width**
- Choose **player symbol**
- Choose **block symbol**
- Three difficulty levels:
  - **Easy** → `(x + 2*y) % 9 == 0`
  - **Medium** → `(x*y + x + y) % 7 == 0`
  - **Hard** → `((x*x) ^ (y*y) ^ (x*y) ^ x ^ y) % 7 == 0`
- Maze border is automatically generated
- Dynamic exit generation
- Real-time keyboard movement using arrow keys
- Win detection when reaching the exit

---

## 📦 How It Works
1. The game asks the user for:
   - Player symbol  
   - Maze length  
   - Maze width  
   - Block symbol  
   - Difficulty level  

2. The maze is generated using obstacle formulas.

3. Player moves using:
4. ↑ Up
↓ Down
← Left
→ Right

4. The goal is to reach the cell containing **E** (Exit).

---

## 🧩 Code Structure
| File | Purpose |
|------|---------|
| `Program.cs` | Starts the game |
| `Game.cs` | Handles input, difficulty, movement, and game loop |
| `Maze.cs` | Generates maze grid + obstacles + borders |
| `Object.cs` | Represents every cell in the maze |
| `Player.cs` | Holds player position and movement |

---

## 🛠 Requirements
- .NET Framework or .NET SDK  
- C# compiler  
- Any IDE (Visual Studio, Rider, VS Code)

---



