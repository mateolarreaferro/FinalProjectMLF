Design

^ The Unity session contain 4 different scenes:
- Lobby (3 different ‘doors’) that define the trajectory
- Lagartija Scene: contains song, video, and 4 covers.
- Maread@: contains three songs, three cubes and three different 'planes'
- Chat@ Scene: Still Empty (This will be implemented once the art is ready)

^Programs (included in Interaction Scripts):
- Activate object: Assigns properties such as rigid body to objects (for collision or gravitational purposes)
- Music Snapshot Switch: allows to play with the music (play, fades)
- PlayStinger: plays audio on trigger 
- Video Swapper: Changes video after collision with a sphere
- Scene: changes the scene (navigation of the program) 


^HOW DOES THE PROGRAM WORK:
Player Movement: This 'museum' uses an FPSController (Unity Prefab) to move with the computer arrows; in the future, the user/listener will move using teleportation in VR. 

Loby: The three 'doors' in the lobby have rigid bodies and triggers that collide when FPSController touches them (resulting in the opening of a new scene). Additionally, the lobby also has two spheres that define the videos displayed on the walls (mood): 
red sphere --> diziness
yellow sphere --> tide 
Additionally, this scene has a dynamic sky that is changes the amount and direction of the light depending on the time of the day. This is an asset from the Asset Store.
Finally, the lobby has two audio sources that play OnAwake(). These sources have 3D blend, change pitch and volume depending on the location of the Player.

Maread@: This scene consists of three bridges with its corresponding cubes. Each one of this cubes uses a script that plays sound. It allows the user to choose the song that he/she wants and then cross the bridge. 

Lagartij@: Contains the art but no interaction; it is working as a sample of how the other will eventually look. It also has a song playing onAwake() with spatial 3D audio. 

^Personal Decisions: 
Without doubt, this project was too ambitious for the short amount of time that was avaialable. A lot of that time was lost in things not related to scripts, things like lighting, general architecture, physics, and aesthetics consumed more time than what was expected. 
The purpose of this design is to show some of the elements that can be potentially used to accomplish a new way of experiencing an album; it shows some of the mechanics, interaction with objects, a general sense of the dynamics.
However, it still needs a lot of work....




