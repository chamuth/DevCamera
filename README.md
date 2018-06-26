# DevCamera
**DevCamera** can be used as a Photo Mode for your game made in Unity. DevCamera allows you to take screenshots, free roam in the game world in FPS mode and freeze time.

# Get Started with DevCamera
1. First create a new camera object in the game environment and attach the DevCamera script to it.
2. Set the Main UI to the User Interface that you'd want to hide when the player enters the Photo Mode.
3. Set the Game Camera to the camera that is actively rendering the game (or the FPS Camera of the player)
4. And done!

# Controls
|Key  | Task | Description |
|----|--|-------|
|`F3`  |Toggle Photo Mode  | Enables or disables the Photo Mode camera and freezes the time in the game engine |
|`W` `A` `S` `D`  |FPS Movement  | Use WASD to move, forward, left, backwards, and right in the game environment|
|`Left Shift`|Run| Increase the speed of the FPS Movements in Photo Mode.
|`Mouse Look` |FPS Look | Use the mouse to Look at things in the game environment |
|`X` | Take Screenshots | Take screenshots and save them on `Screenshots` directory, which is created (if doesn't exist) in the project directory |
|`Scroll Wheel`|Change FOV | Change the Field of View of the Photo Mode Camera. Use scroll up to increase and scroll down to decrease the Field of View. |
|`R`| Reset FOV | Resets Field of View back to 60 (default value)|
|`C`|Toggle Projection Mode| Toggle the projection mode of the Photo Mode camera between Orthographic Projection and Perspective Projection. |

# Screenshots
Screenshots are saved in as `PNG` files in the `Screenshots` directory of the project root directory.

# Contributions
This is a very simple project. Feel free to change anything and make your own versions and User Interface Integrations to the project. :D 
