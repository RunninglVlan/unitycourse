# Notes
## Game genre references
Article on the theme: [Gamasutra's _Breaking Down Breakout: System And Level Design For Breakout-style Games_
](https://www.gamasutra.com/view/feature/1630/breaking_down_breakout_system_and_.php). Mentioned games with interesting features:
- Extensive motion on majority of game objects: [Ricochet Lost Worlds by _Reflexive Entertainment_](https://www.youtube.com/watch?v=oGUtn_Nbt3Q)
- High-fidelity physics/motion simulation: [BreakQuest by _Nurium Games_](https://www.youtube.com/watch?v=HXO01PVrIPc)
- Particle effects, paddle construction: [LEGO Bricktopia! by _Large Animal Games_](https://www.youtube.com/watch?v=-KRUdpRUDgU)
- Moving beyond blocks, 3D graphics: [Magic Ball 3 by _Alawar_](https://www.youtube.com/watch?v=kQd2H3Mn83o)
- Narrative and multi-level objectives: [Funkiball Adventure by _Funkitron_](https://www.youtube.com/watch?v=Gb9T6JlGmYs)
- Humor: [Jardinains 2 by _Magic Chopstick Games_](https://www.youtube.com/watch?v=1MTf2WhYcno)
- Advanced trajectory controllers: [PaperBall by _e-giraffa_](https://www.youtube.com/watch?v=LkS_eBxwFAY)

Cool game I played in school: [Brick Breaker Revolution by _Digital Chocolate_](https://www.youtube.com/watch?v=dudbMGjex5A)

## What's new
- [Colliders 2D](https://docs.unity3d.com/Manual/Collider2D.html) for detecting [collisions and triggers](https://docs.unity3d.com/Manual/CollidersOverview.html)
- [Rigidbody 2D](https://docs.unity3d.com/Manual/class-Rigidbody2D.html) for physics simulation
  - [.velocity](https://docs.unity3d.com/ScriptReference/Rigidbody2D-velocity.html) of type [Vector2](https://docs.unity3d.com/ScriptReference/Vector2.html)
- [Physics Material 2D](https://docs.unity3d.com/Manual/class-PhysicsMaterial2D.html) for controlling friction and bounce of colliders
- [Mathf.Clamp](https://docs.unity3d.com/ScriptReference/Mathf.Clamp.html) for setting lower and upper bounds of the value
- [Destroy](https://docs.unity3d.com/ScriptReference/Object.Destroy.html) game objects or their components
- Use [Prefab](https://docs.unity3d.com/Manual/Prefabs.html) as a template for copies of object
- [AudioSource](https://docs.unity3d.com/Manual/class-AudioSource.html) and its [supported audio formats](https://docs.unity3d.com/Manual/AudioFiles.html)
  - [AudioSource.PlayClipAtPoint](https://docs.unity3d.com/ScriptReference/AudioSource.PlayClipAtPoint.html) for playing AudioClip at a given position
- [Time.timeScale](https://docs.unity3d.com/ScriptReference/Time-timeScale.html) for manipulating overall game time - fast/slow
- [Execution Order of Event Functions](https://docs.unity3d.com/Manual/ExecutionOrder.html)
- [Instantiate](https://docs.unity3d.com/ScriptReference/Object.Instantiate.html) game objects
- [Tag](https://docs.unity3d.com/Manual/Tags.html) your game objects to group and distinguish them
