# DesignPatternsGame

Name: Jesse Viitanen
-------------------------------------------------------------------------------------------------

Game: A square is drifting around, gets hurt when touching evil particles and spins around when 
colliding with corners. Also eats shrooms that magically pop up.
-------------------------------------------------------------------------------------------------

Design patterns used:

1. Singleton,
In Player.cs. Used singleton to make the player a single instance that's easily accessible.
-------------------------------------------------------------------------------------------------

2. Dependency Injection,
Used almost everywhere to use properties from scripts and objects in other scripts.
-------------------------------------------------------------------------------------------------

3. Components,
Primarily used for the movement of the player using PhysicsComponent.cs and InputComponent.cs.
-------------------------------------------------------------------------------------------------

4. Factory,
Used in ShroomFactory.cs to create shrooms("potions") from Shroom.cs.
-------------------------------------------------------------------------------------------------
