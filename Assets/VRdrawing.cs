using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class VRdrawing : MonoBehaviour
{
    public XRController drawingController;
    public GameObject drawingPrefab; // The prefab of the line or trail renderer

    private GameObject currentDrawing;

    private bool isDrawing = false;

    private void Update()
    {
        if (drawingController)
        {
            CheckForDrawingInput();
        }
    }

    private void CheckForDrawingInput()
    {
        // Check if the drawing button is pressed
        if (drawingController.inputDevice.TryGetFeatureValue(CommonUsages.triggerButton, out bool isDrawingButtonPressed))
        {
            if (isDrawingButtonPressed && !isDrawing)
            {
                StartDrawing();
            }
            else if (!isDrawingButtonPressed && isDrawing)
            {
                StopDrawing();
            }
        }
    }

    private void StartDrawing()
    {
        isDrawing = true;

        // Instantiate the drawing prefab
        currentDrawing = Instantiate(drawingPrefab, transform.position, transform.rotation, transform);
    }

    private void StopDrawing()
    {
        isDrawing = false;
        currentDrawing = null;
    }
}
