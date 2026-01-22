# 🐦 Flappy Bird – Unity 2D Mobile Game

This project is a **Flappy Bird–style 2D mobile game** developed in Unity.  
It was my **first serious 2D mobile project**, built specifically with mobile devices in mind  
using a **9:16 portrait resolution** and touch-based controls.

Although the core idea is simple, I invested significant time into building a complete and polished experience by focusing on:

- UI systems  
- Audio management  
- Scene transitions  
- Prefab workflows  
- Script communication  
- Persistent data (high score)  
- Mobile-friendly UX design  

This project became my first real **full pipeline Unity experience**.

---

## 🧠 Project Story (What I Practiced & Learned)

This game was developed as a learning-focused project to understand how real mobile games are structured in Unity.

Even though it looks simple from the outside, most of the real work went into:

- Building UI with Unity Canvas  
- Managing audio states across scenes  
- Saving persistent data (high score)  
- Handling scene transitions  
- Creating prefab-based obstacles  
- Connecting scripts across systems  
- Designing a clean project structure  

More time was spent on **UI, audio, scene logic, persistence, and system architecture**  
than on basic player movement itself.

---

## 🎮 Scenes Overview

The project uses **two main scenes**:

### 🏠 Main Menu Scene
- Start Game button  
- Sound ON / OFF toggle  
- Visual icon changes based on sound state  
- Sound settings persist into the game scene  
- Clean mobile-style UI layout  

---

### 🎮 Game Scene
- Real-time score display  
- High score persistence (saved even after app closes)  
- Audio feedback for gameplay events  
- Prefab-based pipe spawning  
- Collision-based game over logic  

---

## 🚀 Features & Gameplay Systems

- 2D Flappy Bird–style movement  
- Mobile-first design (9:16 portrait resolution)  
- Two-scene architecture (Main Menu + Game)  
- Touch-based gameplay (mobile)  
- Keyboard & mouse support (desktop)  
- Sound ON / OFF system with persistent state  
- High score saved using persistent storage  
- Real-time score tracking  
- Sound effects:
  - Jump sound on every flap  
  - Coin sound every 10 pipes passed  
  - Death sound on collision  
- Prefab-based pipe generation  
- Multiple C# scripts with clear responsibilities  
- Canvas-based UI system  
- Button-driven interactions  
- Scene transition logic  
- Audio manager logic  
- Script-to-script communication  
- Clean Unity project structure  

---

## 🎮 Gameplay Logic Overview

- The game is primarily designed for **mobile touch input**  
- Player taps the screen to flap and stay in the air  
- Pipes spawn continuously as prefabs  
- Score increases for each pipe passed  
- Every 10 pipes → bonus coin sound effect  
- Collision with pipe or ground → Game Over  
- Touching the ceiling → bird is destroyed  
- High score is saved and displayed even after the app is closed  
- Sound settings persist across scenes  
- Player restarts the game from the Main Menu  

> Note:  
> The game does **not** include a pause system.  
> Each session is designed as a continuous arcade-style run.

---

## ⌨️ Controls

| Platform | Input | Action |
|----------|--------|--------|
| Mobile | Screen Tap | Flap |
| Desktop | Left Mouse Button | Flap |
| Desktop | Space | Flap |
| UI | Start Button | Start Game |
| UI | Sound Button | Toggle Sound |
| UI | Restart Button | Restart Game |

---

## 🧩 What I Focused On in This Project

- Unity Canvas & UI system  
- Button interactions  
- Scene transitions  
- Audio management & persistence  
- Prefab workflows  
- Script architecture  
- Game state handling  
- PlayerPrefs high-score system  
- Visual polish  
- Mobile UX flow  

---

## 🖼️ Gameplay Previews

### 🏠 Main Menu & Sound Settings  
<img src="Media/MainMenu.gif" width="300">

---

### 🔁 Restart Flow & Score Reset  
<img src="Media/RestartGame.gif" width="300">

---

### 💀 Game Over Screen & End Buttons  
<img src="Media/EndOfTheGameButtons.gif" width="300">

---

## 📺 Tools & Resources Used

- **Unity 2022.x (2D Mobile)**  
- **C# with Visual Studio**  
- Unity UI (Canvas, Buttons, Text)  
- Unity Audio System  
- Unity Scene Management  
- Unity Prefabs  
- Unity Asset Store (visuals & audio)  
- PlayerPrefs for persistent data  

---

## 📂 Project Structure

This repository includes the essential Unity folders:

- **Assets**  
- **Packages**  
- **ProjectSettings**  

Unity will automatically generate the remaining folders when opening the project.

---

## ▶️ How to Run the Project

1. Clone or download this repository  
2. Open **Unity Hub**  
3. Click **Open Project**  
4. Select the project folder  
5. Press **Play**  

---

## 📦 Playable Build

A downloadable mobile build (Android) will be added soon under the **Releases** tab.

---

## 👤 Author

**Eren Yusuf Can**  
Software Engineering Student  
Unity Game Developer (Junior)
