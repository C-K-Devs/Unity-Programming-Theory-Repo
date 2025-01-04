# Object Collector Game

## Overview
Object Collector is a simple and interactive Unity game that demonstrates the **four pillars of Object-Oriented Programming (OOP)** through gameplay mechanics. The game uses basic Unity objects like cubes, spheres, and planes to create a playable and fun experience while showcasing OOP principles such as:

- **Abstraction**
- **Encapsulation**
- **Inheritance**
- **Polymorphism**

## Gameplay
You control a **sphere (the Player)**, which moves around a plane and collects different types of **cubes (Collectibles)**. Each collectible has unique behaviors that affect the player, making the gameplay dynamic and engaging.

### Player Objectives
- Collect cubes scattered across the plane.
- Utilize the effects of collectibles to enhance gameplay.

## Features
### 1. **Abstraction**
- A base `Collectible` class is created to define the shared behavior of all collectible objects.
- This class abstracts the unnecessary details, focusing on higher-level behavior.

### 2. **Encapsulation**
- The player's speed is controlled using encapsulated properties in the `PlayerController` class.
- This ensures the speed value is clamped within a valid range and protected from misuse.

### 3. **Inheritance**
- Different types of collectibles, such as `HealthCollectible` and `SpeedBoostCollectible`, inherit from the base `Collectible` class.
- These child classes add their unique functionality to the base class.

### 4. **Polymorphism**
- The `OnCollect()` method in the `Collectible` base class is overridden in child classes to implement specific behaviors for each type of collectible.

## Controls
- Use **WASD** or **Arrow Keys** to move the player (sphere) around the plane.

## How to Run the Game
1. Clone the repository.
2. Open the project in Unity 2022.3.5f LTS.
3. Press **Play** in the Unity Editor to start the game.

---
Enjoy the game and explore how Object-Oriented Programming principles bring it to life!

