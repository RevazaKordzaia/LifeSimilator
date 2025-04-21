# LifeSimilator
## 🚀 Life Simulator Game (C# Console App)

Welcome to **Life Simulator**, a C# console-based simulation game where your goal is simple: **survive as long as you can**.  
Random life events—good or bad—come at you, and it's up to you to make the best of them. Can you handle the chaos of life?

### 🧠 About the Project

This is a beginner-level **C# OOP project** built with a modular architecture to practice concepts like:
- Classes & Enums
- Event-driven simulation
- File I/O for save/load system
- Clean code separation across services, models, and events

It's designed to show off my ability to **structure a scalable application** and apply software engineering fundamentals.

### 🎮 How to Play

1. Clone the repo
2. Build and run the project
3. Create your character
4. Survive randomly generated life events
5. Try to beat your previous score by surviving longer

```bash
git clone https://github.com/your-username/LifeSimulator.git
cd LifeSimulator
dotnet build
dotnet run
```

### 🧱 Features

✅ Character creation (name, age, nationality)  
✅ Save/Load system (persists your last game state)  
✅ Dynamic event system (health, job, finance, social life, and more!)  
✅ Car system and job progression  
✅ Random event generator (lottery, sickness, robbery, etc.)  
✅ Console UI feedback with survival stats
### 🔧 Technologies Used

- C# (.NET 8 / .NET Core)
- OOP Principles
- Console Application
- File I/O

### 📁 Project Structure

```bash
LifeSimulator/                           # Root folder of the project
├── Enums/                               # Enum definitions (Job, Nationality, Events)
│   ├── CarsEnum.cs                      # Enum for car types
│   ├── EventsEnum.cs                    # Enum for events
│   ├── JobEnum.cs                       # Enum for job types
│   ├── NationalityEnum.cs               # Enum for nationalities
│   ├── OptionsEnum.cs                   # Enum for different options
│   └── RobberyActionEnum.cs             # Enum for robbery actions
├── Events/                              # Event logic (Life, Finance, and Social events)
│   ├── FinanceEvents.cs                 # Finance related events (PayDay, GotRobbed)
│   ├── HealthEvents.cs                  # Health related events (GotSick, HadAccident)
│   ├── SocialEvents.cs                  # Social events (DateGirl, AdoptPet, etc.)
│   └── GenericEvents.cs                 # General event handlers (empty or shared events)
├── Models/                              # Core game models (Character, Job, Car models)
│   ├── CarModels/                       # Car-related models
│   │   ├── Car.cs                       # Model for car (e.g., Car properties)
│   │   ├── CarOwned.cs                  # Model for ownership of a car
│   │   └── CarStore.cs                  # Model for handling car purchases
│   ├── JobModels/                       # Job-related models
│   │   └── Job.cs                       # Job model (e.g., Job title, salary)
│   ├── ReusableMethods/                 # Reusable helper methods
│   │   ├── NumberOptionMethod.cs        # Helper method to handle numeric options
│   │   └── YesNoResponseMethod.cs       # Helper method for Yes/No responses
│   └── Common/                          # Common models (shared entities like metadata)
│       └── MetaData.cs                  # Metadata for the game (e.g., version info)
├── SaveLoad/                            # Handling game saves and loading game states
│   ├── GameData.cs                      # Class representing game data (e.g., save info)
│   └── SaveSystem.cs                    # System to handle saving and loading game states
├── Services/                            # Game services (game mechanics and features)
│   ├── CharacterService.cs              # Service for character logic (health, money, etc.)
│   ├── JobService.cs                    # Service for job logic (e.g., salary, career changes)
│   └── CarService.cs                    # Service for car-related logic (e.g., buying)
├── Interfaces/                          # Interface definitions
│   ├── ICarOwned.cs                     # Interface for car ownership behavior
│   ├── IJob.cs                          # Interface for job behavior
│   └── ISaveable.cs                     # Interface for save/load functionality (optional)
├── .gitignore                           # Git ignore file (to ignore unnecessary files/folders)
├── LifeSimulator.csproj                 # Project file for .NET
├── LifeSimulator.sln                    # Solution file for Visual Studio
├── Program.cs                           # Main game loop and entry point for the game
└── README.md                            # Documentation for your project


### 💡 Future Improvements

- Add GUI (WinForms or WPF)
- More detailed event interactions
- Achievements or stats tracking
- Multiplayer/leaderboard system

### 📣 Why I Built This

I'm learning C# and this project is my way to apply what I’ve learned and demonstrate:
- Clear code organization
- Realistic use of object-oriented design
- Ability to finish and polish a full small-scale game loop

This is my **first complete project**, and I'm proud of the journey so far.

### 🙋‍♂️ About Me

Hey! I'm a junior developer looking for opportunities to grow and contribute to real-world projects.  
I'm passionate about coding, problem-solving, and building fun stuff like this.  
Feel free to connect or give feedback!

📫 Reach me at: rezikordzaia@gmail.com   

### ⭐ If you like it, star it!

If you found this interesting or useful, a ⭐ would mean a lot!
