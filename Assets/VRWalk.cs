using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR;

public class VRWalk : MonoBehaviour
{
    public XRController xrController;
    public float speed = 1.0f;

    void Update()
    {
        Vector2 inputAxis;
        if (xrController.inputDevice.TryGetFeatureValue(CommonUsages.primary2DAxis, out inputAxis))
        {
            // Use the inputAxis to determine movement direction
            Vector3 movement = new Vector3(inputAxis.x, 0, inputAxis.y);
            movement = transform.TransformDirection(movement);
            movement *= speed * Time.deltaTime;

            // Apply movement to the XR Rig
            transform.parent.Translate(movement);
        }
    }
}
