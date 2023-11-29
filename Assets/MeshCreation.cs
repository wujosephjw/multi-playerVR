using System.Collections.Generic;
using UnityEngine;

public class MeshCreation : MonoBehaviour
{
    public GameObject leftController;
    public GameObject spherePrefab;
    public MeshFilter meshFilter;

    private List<Vector3> positionsList = new List<Vector3>();
    private Mesh mesh;

    void Start()
    {
        InitializeMesh();
    }

    void InitializeMesh()
    {
        mesh = new Mesh();
        meshFilter.mesh = mesh;
    }

    void UpdateMesh()
    {
        mesh.vertices = positionsList.ToArray();
        TriangulateMesh();
    }

    void TriangulateMesh()
    {
        // Triangulate the points using Unity's built-in function
        mesh.triangles = Triangulate(positionsList.ToArray());
        mesh.RecalculateNormals();
    }

    public void LeftTriggerClick()
    {
        if (leftController != null)
        {
            Vector3 controllerPosition = leftController.transform.position;
            positionsList.Add(controllerPosition);

            if (spherePrefab != null)
            {
                //Instantiate(spherePrefab, controllerPosition, Quaternion.identity);
            }

            UpdateMesh();
        }
        else
        {
            Debug.LogError("VR Controller is not assigned!");
        }
    }

    // Triangulation using Unity's built-in method
    int[] Triangulate(Vector3[] points)
    {
        List<int> indices = new List<int>();
        int pointCount = points.Length;

        // Triangulate the points
        for (int i = 0; i < pointCount - 2; i++)
        {
            indices.Add(i);
            indices.Add(i + 1);
            indices.Add(i + 2);

            // Choose any two vertices of the current face to be the same as any two vertices of the previous face
            indices.Add(i);
            indices.Add(i + 2);
            indices.Add(i + 1);
        }

        return indices.ToArray();
    }
}