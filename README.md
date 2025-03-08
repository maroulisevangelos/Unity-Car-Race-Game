# Unity-Car-Race-Game
This project involves the implementation of a car racing game using Unity, harnessing its capabilities for graphics, sound, and animation. The game includes various features such as collecting coins, avoiding obstacles, and achieving the best possible lap time.

Features:

    Game Objective: Complete a lap as quickly as possible while collecting gold and bronze coins to achieve the highest score. Gold coins are worth 2 points and bronze coins are worth 1 point.
    
    Obstacles: Avoid falling lava rocks and internal track fences to successfully complete the lap.
    
    Random Coin Placement: Coins are randomly placed on the terrain with a 50% probability, making each playthrough unique.
    
    Player Controls: The car is controlled using arrow keys or W, S, A, D keys. The view can be changed with the keys 'c' and 'm' to switch between a front-facing view and a rear camera view.
    
    UI Elements: Includes a Main Menu, HUD, Pause Menu, Game Over screen, and Win screen with appropriate buttons for navigation and information display.

Implementation Details:

  Tools Used:
  
    Unity for game development.
    
    Visual Studio 2019 for C# code development.
  
  Execution Instructions:
  
    Download the project file from this link.
    
    Unzip the file and open the "Car Race Game-Project" folder in Unity Hub.
    
    Use the Build and Run feature in Unity to start the game.

Technical Aspects:

    Materials and Textures: Applied to various objects like rocks and the track.
    
    Shaders: Used for flags, poles, water, and lava effects.
    
    Physics: Implemented for car movement and flag wave simulation.
    
    Audio: Added background music, car engine sounds, and collision sounds.
    
    Particles: Used for fire effects on the car's exhaust, around the trophy, and the volcano.

Challenges Encountered:

    Time Measurement: Accurate time measurement was achieved using deltaTime to count seconds.
    
    Car Balance and Movement: Ensured realistic car physics by adjusting wheel colliders and suspension, and managing the car's center of mass.
    
    Best Score Maintenance: Managed using PlayerPrefs, with the best score resetting from the Main Menu.
    
    Coin Collection: Adjusted colliders to prevent multiple collision detections for a single coin.

Libraries Used:

    .NET Framework
    
    Unity Engine
    
    TextMesh Pro (TMPro)
