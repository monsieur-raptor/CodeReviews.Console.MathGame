# Math Game

A simple, interactive console-based mathematics game built using C# and .NET. This project is part of my learning journey.

## Project Overview

This application challenges users with basic arithmetic problems (Addition, Subtraction, Multiplication, and Division). It was developed to practice the fundamental building blocks of C# and clean coding principles.

### Key Features
* Four Operations: Choose between Addition, Subtraction, Multiplication, and Division.
* Division problems always result in integer answers
* Score Tracking: The application keeps track of correct answers during a session.
* Game History: Users can view a log of their previous games to track progress.
* Input Validation: Ensures the application does not crash on invalid user inputs.

## Learning Objectives

The primary goal of this project was to move beyond "Hello World" and implement:
* Logic and Loops: Handling user menus and game repetitions.
* Collections: Using Lists to store and retrieve game history.
* String Manipulation: Formatting output for a better user experience.
* Coding Standards: Following C# naming conventions and keeping the Main method clean.

## Technologies Used
* Language: C#
* Framework: .NET 10
* IDE: Visual Studio

## How to Run
1. Clone this repository:

   ```sh
   git clone git@github.com:monsieur-raptor/CodeReviews.Console.MathGame.git
   cd MathGame.monsieur-raptor
   ```

2. Build and run the application from CLI:

   ```sh
   dotnet build
   dotnet run
   ```

3. Follow the on-screen prompts to start playing.

---

## Instructions
1. Run the application.
2. Choose an arithmetic operation from the menu:
   - A for Addition
   - S for Subtraction
   - M for Multiplication
   - D for Division
   - R for playing with a random arithmetic operation
   - V to View Game History
   - Q to Exit
3. Solve the presented math problem and input your answer.
4. Receive immediate feedback on your answer.
5. Choose to play again or exit.

---

## Additional challenges

```
[x] Apply DRY principles
[x] Create a 'Random Game' option where the players will be presented with questions from random operations
[ ] Implement levels of difficulty
[ ] Add a timer to track how long the user takes to finish the game
```


---
*Created as part of [The CSharp Academy](https://www.thecsharpacademy.com/) curriculum.*
