# CoffeeShopSimulator

**CoffeeShopSimulator** is a simple WPF desktop game written in C#.  
The player manages a small coffee shop and tries to earn $100 within 10 in-game days.  
The project demonstrates component-based programming, UI development in WPF, and clean separation between logic and interface.

---

## Game Overview

In **Dream Café**, the player acts as a coffee shop manager who must balance production costs, customer demand, and daily taxes.

Each day the player:
- chooses how many cups of coffee to prepare,
- serves a random number of visitors,
- pays daily taxes,
- deals with spoiled coffee and limited funds.

Depending on performance, the player can reach one of three endings:
- **A** – success (goal achieved),  
- **B** – neutral (business survives),  
- **C** – failure (bankruptcy).

---

## Features

- Simple economic simulation (profit, costs, taxes, spoiled goods)  
- Typewriter-style story narration  
- Local save system (`GameRecords.txt`)  
- Background music with automatic looping  
- Multiple WPF windows (menu, gameplay, results)  
- Input validation and player nickname saving  

---

## Project Structure

```
CoffeeShopSimulator/
│
├── App.xaml
├── App.xaml.cs
├── App.config
│
├── Core/ # Game logic and data layer
│ ├── GameSession.cs # Main gameplay logic
│ ├── GameRecord.cs # Data model for saved results
│ └── GameDataService.cs # File-based storage for records
│
├── Views/ # All WPF windows and UI
│ ├── MainWindow.xaml(.cs) # Main menu
│ ├── GameplayWindow.xaml(.cs) # Gameplay scene
│ ├── ResultsWindow.xaml(.cs) # End-game screen
│ └── ExitDialog.xaml(.cs) # Exit confirmation
│
├── Resources/
│ ├── Audio/
│ │ └── Fade_Out.mp3 # Background music
│ ├── Images/
│ │ ├── menu_background.png
│ │ ├── gameplay_background.png
│ │ ├── final_background.png
│ │ └── instruction.png
|
├── Screenshots/
│ ├── Menu.png
│ ├── Instruction.png
│ ├── GamePlay.png
│ ├── Results.png
│ └── History.png
│
├── .gitignore
└── README.md
```

---

## How to Run

1. Open the solution `CoffeeShopSimulator.sln` in **Visual Studio**.  
2. Make sure the target framework is **.NET Framework 4.8**.  
3. Ensure all resources (images, audio) have `Copy to Output Directory → Copy if newer`.  
4. Run the project (F5).  

To change background music, edit this line in `App.xaml.cs`:

```
mediaPlayer.Open(new Uri("Resources/Audio/Fade_Out.mp3", UriKind.Relative));
```
and replace it with your desired file name.

## Music Credit

Background music:
“**Fade Out**” — Squire Tuck


Source: Free Music Archive (https://freemusicarchive.org/music/Squire_Tuck/Fade_Out)

License: CC BY 4.0 (https://creativecommons.org/licenses/by/4.0/)

## Technologies Used

- C# (.NET Framework 4.8)

- Windows Presentation Foundation (WPF)

- XAML UI

## Author

**Ali Khudaimuratov**

Bachelor student, Czech University of Life Sciences (CZU FEM)

Course: Component Software Engineering


## Screenshots

### Main Menu
![Main Menu](/Screenshots/Menu.PNG)

### Instruction
![Results Screen](/Screenshots/Instruction.PNG)

### Gameplay
![Gameplay](/Screenshots/GamePlay.PNG)

### Results
![Results Screen](/Screenshots/Results.PNG)

### History
![Results Screen](/Screenshots/History.PNG)
