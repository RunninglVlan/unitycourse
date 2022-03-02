# Notes
## Section 3
Snow Boarder, 20 Lectures: [30](https://www.udemy.com/course/unitycourse/learn/lecture/28710868) - [49](https://www.udemy.com/course/unitycourse/learn/lecture/28711000)

## What's new
- [2D Sprite Shape](https://docs.unity3d.com/Packages/com.unity.2d.spriteshape@8.0) is a flexible and powerful world building Asset that features Sprite tiling along a shape's outline that automatically deforms and swaps Sprites based on the angle of the outline
  - Sprite Shapes comprise of two parts - the [Sprite Shape Profile](https://docs.unity3d.com/Packages/com.unity.2d.spriteshape@8.0/manual/SSProfile.html) Asset, and the [Sprite Shape Controller](https://docs.unity3d.com/Packages/com.unity.2d.spriteshape@8.0/manual/SSController.html) component.
  - Use _colliderOffset_ to resize the collider edges a bit
- There is an Asset Menu for creating _Dynamic Sprite_ which comes with Collider and RigidBody already added
- Use [Cinemachine](https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/index.html) to create Follow Camera
  - Set _Follow_ object (Body Target)
  - Choose [Framing Transposer](https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineBodyFramingTransposer.html) Body
    - Modify _Screen X_ if needed
- Use [Surface Effector 2D](https://docs.unity3d.com/2022.1/Documentation/Manual/class-SurfaceEffector2D.html) to make a conveyor belt out of your collider
  - Enable _usedByEffector_ on your collider
- To fix issue when sometimes a RigidBody passes through another Body, use _Continuous Collision Detection_ (but it uses more CPU)
