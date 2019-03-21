# Notes
## Section 6
Laser Defender: [Lecture 84](https://www.udemy.com/unitycourse/learn/v4/t/lecture/11408002) - [Lecture 118](https://www.udemy.com/unitycourse/learn/v4/t/lecture/11736012)

## What's new
- [Input Manager](https://docs.unity3d.com/Manual/class-InputManager.html) has predefined input axes, e.g. Horizontal for X axis with LeftArrow and A as negative buttons
  - [Input.GetAxis(axisName)](https://docs.unity3d.com/ScriptReference/Input.GetAxis.html)
- Use [Time.deltaTime](https://docs.unity3d.com/ScriptReference/Time-deltaTime.html) to make the game frame rate independent
- [Camera.ViewportToWorldPoint(position)](https://docs.unity3d.com/ScriptReference/Camera.ViewportToWorldPoint.html), viewport has (0,0) and (1,1) boundaries
- Map out all the _core_ and _secondary_ features in the game, and the main _polish_ areas.
  - Core is the Minimum Viable Product. Then if people will really like the game, more features can be added.
  - Some features depend on each other (Not much use from Enemy Health without Player Shooting), some can be grouped (Player Movement and Shooting). Some of the polish areas can be implemented in the middle.
- [Quaternion](https://docs.unity3d.com/ScriptReference/Quaternion.html)s are used to represent rotations
- [Coroutines](https://docs.unity3d.com/Manual/Coroutines.html) are like functions that have the ability to pause execution and return control to Unity but then to continue where they left off on the following frame or after specified time
  - You can also `yield return` [Coroutine](https://docs.unity3d.com/ScriptReference/Coroutine.html)
- [Vector2.MoveTowards](https://docs.unity3d.com/ScriptReference/Vector2.MoveTowards.html)
- [Transform](https://docs.unity3d.com/ScriptReference/Transform.html) is enumerable
- [Header](https://docs.unity3d.com/ScriptReference/HeaderAttribute.html) can be added to separate and name inspector properties
  - [Space](https://docs.unity3d.com/ScriptReference/SpaceAttribute.html) just to separate them
- [Layer-based collision detection](https://docs.unity3d.com/Manual/LayerBasedCollision.html) can be used to control object collisions based on layers they are placed on.
- [Particle System](https://docs.unity3d.com/Manual/class-ParticleSystem.html) and its [main module](https://docs.unity3d.com/Manual/PartSysMainModule.html)
- _GameObject > Break Prefab Instance_ - for unlinking instance from Prefab
