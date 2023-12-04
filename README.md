# Collaborative Canvas: An Interactive Multi-User VR Space for Mesh Creation 
Author: Joseph Wu

A virtual reality application allows users to engage with 3D objects through actions such as grabbing and throwing, utilizing the VR controller for mesh modeling. The incorporation of a multiplayer mode enhances collaborative experiences, enabling players to interact, collaborate, and collectively explore 3D objects.

# User Narrative
In today's design teams, people often collaborate from different locations. It's crucial for them to work seamlessly together and have an efficient way of testing their ideas. This application provides the ability to create 3D models and collaborate in VR, improving the design process.

The main goal is to address the challenges in how designers typically work. Currently, they use drawings and various computer programs that don't communicate with each other. We aim to introduce a new type of computer program, known as virtual reality (VR) mesh modeling, to facilitate real-time collaboration among designers. The program is designed to simplify the collaborative process, facilitate discussions about designs, enable quick changes, and ensure inclusivity, allowing everyone to participate regardless of their level of expertise in 3D design.


# Interface Description:
Interaction with 3D Object:
  •	Users can engage with 3D objects by pressing the left controller's grip button when in close proximity. Pressing the button allows them to grab the 3D object, and releasing it lets go. This interaction leverages the force and gravity from the velocity speed of the controller's movement, enabling actions like throwing and catching objects between users. The properties of the 3D sphere and objects are shared among all users, facilitating multiplayer interaction.
  
Interaction with Mesh:
  Creating a Continuous 3D Mesh:
  •	Using a VR controller, users can create a continuous 3D mesh by pressing the left trigger button. Constructing a mesh face requires three vertices. Pressing the trigger button on the left controller generates a vertex, accompanied by the creation of a sphere for visualization. Upon creating three vertices, a mesh face is automatically formed. To continue the mesh creation, users select two existing vertices by pressing the left controller's trigger button, and the third vertex completes the mesh, allowing the creation process to persist.

  Modifying the Vertices of a Continuous 3D Mesh:
  •	During the creation and discussion process, users may wish to modify the mesh. To achieve this, users can adjust the vertex position by pressing the left controller's grip button. The corresponding sphere moves in alignment with the controller's location. Upon releasing the button, the updated modified mesh is saved.
  


# Built With
  •	Unity 2019.4.15f1
  •	Oculus Integration Package Version 23.0
  •	Deployed to Oculus Quest 3
  •	Normcore Unity networking plugin (https://normcore.io/dashboard/app)


# How to use
   1.	Get the Oculus and Controller ready
   2.	Clone this repo
   3.	Open the project in Unity
   4.	Open the Multi-player scene
   5.	Build and run the project
   6.	Enjoy!
    

# Known Bugs
To be updated


# Roadmap
 1.	Basic VR setup (Done)
 2.	Multiplayer environment setup (Done)
 3.	Capture all the controller buttons input (Done)
 4.	Grab, throw the Objects (Done)
 5.	Mesh modeling (Done)
 6.	Mesh modifying (Done)


# Acknowledgements
  Acknowledgements of 3rd party scripts are in the scripts. 
  Normcore asset are purchased from Unity Asset Store and modified by me. 
  Credit to @dilmerv github code to help capturing all the controllers' input https://github.com/dilmerv/XRInputExamples
  Credit to the tutorial, setting up the multiplayer vr environment https://www.youtube.com/playlist?list=PLa739g934GxzKAgp_VPAf4niwI68_5Jq2
  Mixed Reality Toolkit is an open-source software development kit developed by Microsoft and modified by me.

 
