using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeshCreation : MonoBehaviour
{

    public GameObject leftController;
    public GameObject spherePrefab;
    public MeshFilter meshFilter;

    private List<Vector3> positionsList = new List<Vector3>();

    void Start()
    {
        Mesh mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
    }

    public void LeftTriggerClick()
    {
        // Check if the targetObject is not null
        if (leftController != null)
        {
            Vector3 controllerPosition = leftController.transform.position;

            positionsList.Add(controllerPosition);

            Instantiate(spherePrefab, controllerPosition, Quaternion.identity);



            if (positionsList.Count >= 3)
            {
               
                positionsList.Clear();
            }

        }

        else
        {
            Debug.LogError("VR Controller is not assigned!");
        }
        
    }

}
