# Collaborative Canvas: An Interactive Multi-User VR Space for Mesh Creation 
Author: Joseph Wu

A virtual reality application allows users to engage with 3D objects through actions such as grabbing and throwing, utilizing the VR controller for mesh modeling. The incorporation of a multiplayer mode enhances collaborative experiences, enabling players to interact, collaborate, and collectively explore 3D objects.

[![Video Demo](https://img.youtube.com/vi/<iframe width="560" height="315" src="https://www.youtube.com/embed/UvvgfI_CNDE?si=TMmJAP4eoXcQmfys" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share" allowfullscreen></iframe>/0.jpg)](https://www.youtube.com/watch?v=<iframe width="560" height="315" src="https://www.youtube.com/embed/UvvgfI_CNDE?si=TMmJAP4eoXcQmfys" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share" allowfullscreen></iframe>)


# User Narrative
In today's design teams, people often collaborate from different locations. It's crucial for them to work seamlessly together and have an efficient way of testing their ideas. This application provides the ability to create 3D models and collaborate in VR, improving the design process.

The main goal is to address the challenges in how designers typically work. Currently, they use drawings and various computer programs that don't communicate with each other. We aim to introduce a new type of computer program, known as virtual reality (VR) mesh modeling, to facilitate real-time collaboration among designers. The program is designed to simplify the collaborative process, facilitate discussions about designs, enable quick changes, and ensure inclusivity, allowing everyone to participate regardless of their level of expertise in 3D design.

# Problem and Solution
Problems:  
Users without 3D modeling software training encounter challenges:  
Lack of a straightforward method for mesh creation.  
Absence of a collaborative environment for 3D objects.  

Our solution includes:  
A multiplayer environment for effective collaboration.  
A dedicated VR app for mesh modeling, facilitating mesh creation and modification.  


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
   4.	Open the /multi-player Scene Scene
   5.	Build and run the project
   6.	Enjoy!


# Roadmap
 1.	Basic VR setup (Done)
 2.	Multiplayer environment setup (Done)
 3.	Capture all the controller buttons input (Done)
 4.	Grab, throw the Objects (Done)
 5.	Mesh modeling (Done)
 6.	Mesh modifying (Done)


# Potential Future Direction and Known Bugs
  - Currently limited to one mesh creation, but potential for multiples.
  - Ability to delete vertice.  
  - Possible scaling, transforming, and rotating of the mesh.  
  - Ability to change mesh color or apply different materials.  
  - Potential for adding UI, text, and voice for collaboration.  


# Acknowledgements
  Acknowledgments for third-party scripts are included within the scripts.  
  Normcore assets were purchased from the Unity Asset Store and modified by me.  
  Credit goes to @dilmerv for the GitHub code that helped capture all the controllers' input: https://github.com/dilmerv/XRInputExamples  
  Credit is given to the tutorial for setting up the multiplayer VR environment: https://www.youtube.com/playlist?list=PLa739g934GxzKAgp_VPAf4niwI68_5Jq2  
  

 
