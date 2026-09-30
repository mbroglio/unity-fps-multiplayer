# 🎮 3D First-Person Shooter — Multiplayer & Networking Project

[![Unity](https://img.shields.io/badge/Engine-Unity-black.svg?logo=unity&logoColor=white)](https://unity.com/)
[![C#](https://img.shields.io/badge/Language-C%23-239120.svg?logo=csharp&logoColor=white)](https://learn.microsoft.com/en-us/dotnet/csharp/)
[![Networking](https://img.shields.io/badge/Architecture-Authoritative_TCP%2FUDP-blue.svg)](https://learn.microsoft.com/en-us/dotnet/api/system.net.sockets)
[![Status](https://img.shields.io/badge/Type-High_School_Project-orange.svg)]()

> A 3D multiplayer first-person shooter game developed with **Unity** and **C#** during the 3rd year of high school, featuring a custom authoritative TCP/UDP networking stack and binary packet protocol built from scratch.

---

## 📋 Table of Contents
- [Overview](#-overview)
- [Key Features & Architecture](#-key-features--architecture)
  - [Custom Networking Stack](#1-custom-networking-stack)
  - [Player Controller & Physics](#2-player-controller--physics)
  - [Weapons & Combat Mechanics](#3-weapons--combat-mechanics)
- [Project Structure](#-project-structure)
- [Getting Started](#-getting-started)
- [Retrospective Notes](#-retrospective-notes)
- [Author](#-author)

---

## 🎯 Overview

This project was built during high school as a hands-on exploration of game development, computer graphics, and network programming. Instead of relying on commercial high-level networking solutions (such as Photon or Mirror), it implements a custom client-server socket protocol over raw **TCP and UDP** sockets in .NET/C#.

---

## 🛠️ Key Features & Architecture

### 1. Custom Networking Stack
- **Dual Transport Protocol**:
  - **TCP**: Reliable delivery for session handshake, player connections, and critical state synchronization (`Client.cs`).
  - **UDP**: Fast, low-latency transport for real-time player position, rotation, and input updates.
- **Binary Packet Serialization (`Packet.cs`)**:
  - Custom stream byte buffer supporting reading and writing of primitive types (integers, floats, booleans, strings) and Unity mathematics (`Vector3`, `Quaternion`).
  - Message framing with length prefixes and packet ID headers.
- **Thread Synchronization (`ThreadManager.cs`)**:
  - Safe thread dispatching to pass incoming socket thread data onto the Unity main thread.

### 2. Player Controller & Physics
- Physics-driven movement with Rigidbody / CharacterController logic (`PlayerMovement.cs`, `PlayerController.cs`).
- Sprinting, jumping, slope detection, and ground clamping.
- Dual-axis mouse look with camera smoothing and field of view adjustments.

### 3. Weapons & Combat Mechanics
- Raycast-based ballistics and hit registration (`Gun.cs`).
- Visual and audio effects: dynamic muzzle flashes, bullet impact particle systems, and sound effects.
- Health management and destroyable target entities (`Target.cs`).

---

## 🗂️ Project Structure

| Folder | Description |
| :--- | :--- |
| `3D First Person Shooter - Game/` | Game client build and standalone client assets |
| `3D First Person Shooter - Server/` | Dedicated multiplayer authoritative server project & shared C# codebase |
| `3D First Person Shooter - SinglePlayer/` | Offline single-player prototype |

---

## 🚀 Getting Started

### Prerequisites
- Unity 2019.4 LTS or compatible Unity Editor version
- Visual Studio or VS Code with C# development workload

### Running the Project
1. Clone the repository:
   ```bash
   git clone https://github.com/mbroglio/first_preson_shooter__high_school_project.git
   ```
2. Open Unity Hub and add `3D First Person Shooter - Server/` (or `Game/`) as a project.
3. Open `Assets/Scenes/Login.unity` or `Assets/Scenes/Player.unity`.
4. Press **Play** in the Unity Editor.

---

## 📌 Retrospective Notes

This was an early exploratory educational project created during high school. The architecture and code patterns reflect an eager learning phase into low-level socket programming and game mechanics.

---

## 👤 Author

Developed by **Matteo Broglio** (High School 3rd Year project).
