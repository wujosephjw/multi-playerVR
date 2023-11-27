using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class VRdrawing : MonoBehaviour
{
    public GameObject meshPrefab; // The prefab for the mesh you want to draw
    //public XRController xrController;
    public InputHelpers.Button drawButton;
    public float activationThreshold = 0.1f;
    private bool isDrawing = false;
    public XRController leftController;
    public XRController rightController;


    void Start()
    {
        leftController = GetComponent<XRController>();
    }

    void Update()
    {
        CheckForDrawingInput();
    }

    void CheckForDrawingInput()
    {
        // Check if the trigger button is pressed
        if (CheckIfButtonDown(leftController))
        {
            StartDrawing();  
        }
        else
        {
            StopDrawing();
        }
    }

    public bool CheckIfButtonDown(XRController controller)
    {
        InputHelpers.IsPressed(controller.inputDevice, drawButton, out bool isPressed, activationThreshold);
        return isPressed;
    }

    void StartDrawing()
    {
        isDrawing = true;
        // Instantiate the mesh prefab or create your custom mesh generation logic
        // You might want to use XRGrabInteractable for better interaction control
        Instantiate(meshPrefab, leftController.transform.position, leftController.transform.rotation);
    }

    void StopDrawing()
    {
        isDrawing = false;
    }
}
