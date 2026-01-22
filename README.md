# 🐦 Flappy Bird – Unity 2D Mobile Game

This project is a **Flappy Bird–style 2D mobile game** developed in Unity.  
It was my **first serious 2D mobile project**, and I focused not only on gameplay mechanics,  
but also on building a complete, polished mobile-game experience.

Although the core idea is simple, I invested a lot of time into:
UI systems, audio management, scene transitions, prefab workflows, and project structure.

This project became my first real **full pipeline Unity experience**.

---

## 🧠 Project Story (What I Practiced & Learned)

This game was built as a learning-focused project to understand how real mobile games are structured in Unity.

During development, I worked extensively on:

- UI systems (Canvas, buttons, anchors, layouts)
- Scene management (Main Menu → Game → Restart flow)
- Audio systems (SFX, background music, mute/unmute persistence)
- Script communication between systems
- Prefabs and procedural object spawning
- Project folder organization
- Mobile-style polish and UX details

Most of the challenge in this project was not player movement —  
but integrating **UI, audio, scenes, managers, prefabs, and persistent data** into a clean structure.

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
- Two-scene architecture (Main Menu + Game)
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

- Player taps / presses to flap and stay in the air  
- Pipes spawn continuously as prefabs  
- Score increases for each pipe passed  
- Every 10 pipes → bonus coin sound effect  
- Collision with pipe or ground → Game Over  
- Touching the ceiling → bird is destroyed  
- High score is saved and displayed  
- Player can restart from menu  

---

## ⌨️ Controls

| Input | Action |
|-------|--------|
| Space / Left Mouse Button | Flap |
| UI Button | Start Game |
| UI Button | Toggle Sound |
| UI Button | Restart |

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

## 🖼️ GIF Previews

### 🎬 Main Menu & Sound Toggle  
<img src="Media/menu-sound-toggle.gif" width="500">

### 🎮 Gameplay Loop  
<img src="Media/gameplay-loop.gif" width="500">

### 💥 Game Over & Restart  
<img src="Media/gameover-restart.gif" width="500">

---

## 📺 Tools & Resources Used

- **Unity 2022.x (2D)**
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

A downloadable Windows build will be added soon under the **Releases** tab.

---

## 👤 Author

**Eren Yusuf Can**  
Software Engineering Student  
Unity Game Developer (Junior)
