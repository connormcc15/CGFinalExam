# CGFinalExam
Below is what I have done from the Practical Part of the final exam

Note: All shaders that I have created have in the SubShader Tags have had Universal Render Pipeline, changed to Universal Pipeline. This is something I remember I needed to fix when it came to unity6 projects in the past when making a build, so that my shaders are shown correctly.

PlayerMovement:
I made use of the starter project movement script on canvas. I did make an change to the original script by adding in a rigidbody and moving the vertical float value from the z position to the y position. I did these changes because when I tested in originally, unaltered, I found the movement weird and also no collision were happening. So I made the changes to the script to fix that issue. I also had to fix the sphere colliders on the dots in my scene as when I would collide with them, it would cause pac-man to move off course. All I did to fix this was make the colliders triggers.
<img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/d3b8bfc2-8efc-4387-a9e5-633a6f828e80" />
<img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/e5ba8bc5-dcca-4be8-b1ae-0bdcb229279c" />



Holograms: 
For Holograms, I applied them to the gate for the ghost box, and the dots. I made no changes to the hologram script as I felt there was no need to, I did however make two seperate materials so that the gate and dots look distinct. The dots I made a brighter yellow while the gate I made an orange yellow like colour. 
<img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/15aa1009-7c83-4bd2-a36b-ab01aeac81ff" />


Scrolling Texture:
For Scrolling Texture, 
<img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/26aee7d1-07cc-4e04-b657-d169017539d7" />


First Half Shader:
The Shader that I made from the first half of the course is RimLighting. In the image provided to us, the walls have a blue outline around them. I figured rim lighting would be the best to replicate but also graphically enhance the game is because I figured that by positioning the camera in the right spot, I can get a close replica look to the original picture while having it look distinct enough to be original. I did make a change to the rim lighting shader to achieve the look I wanted. What I did is I took the base and rim colours respectively, and multipled them together instead of adding them together. I made this change because before, the blue showing around the entire wall prominently and not for the outline around it.
<img width="1486" height="422" alt="image" src="https://github.com/user-attachments/assets/f5fee2fb-85cc-4365-aac1-8acd949aafb4" />

<img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/a89fc3b2-2999-45a4-8556-48b55446ab58" />


Second Half Shader:
The Shader that I made from the second half of the course is the MaterialVertexFragment Shader. I took the Material Vertex Fragment shader from canvas and made use of it for the backdrop of the game. I figured I'd make use of the this so that the backdrop stands out a bit more than just being a plain black backdrop. However, to achieve what I wanted it to look like, I needed to pass in a color through the half4 col so that I could alter what could the backdrop would be. Once that was done, I then played around with the inspector for that shader and then got the result you see at the bottom. I made the backdrop a darker blue because again, I wanted the backdrop to standout while not being a plain black.
<img width="1218" height="257" alt="image" src="https://github.com/user-attachments/assets/7d0461b6-1532-4482-88e5-7d39e894b4a0" />

<img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/94783cae-6c80-484f-be2e-79471ab5bb50" />

