using System.Collections.Generic;
using UnityEngine;

public class MeshCreation : MonoBehaviour
{
    public GameObject leftController;
    public GameObject spherePrefab;
    public MeshFilter meshFilter;
    public Material NewSphereMaterial;
    public Material OldSphereMaterial;
    private Renderer currSphereRender;

    private List<Vector3> positionsList = new List<Vector3>();
    private Mesh mesh;
    private List<int> triangles = new List<int>();

    private int numOfLeftTrigger = 0;
    private int firstClosestPointIndex = -1;
    private int secondClosestPointIndex = -1;
    private int gripClosestVerticesIndex = -1;

    void Start()
    {
        // Initialize mesh
        mesh = new Mesh();
        meshFilter.mesh = mesh;
    }

    public void LeftTriggerClick()
    {
        if (leftController != null)
        {
            numOfLeftTrigger++;

            Vector3 controllerPosition = leftController.transform.position;

            if (numOfLeftTrigger % 3 == 0 || numOfLeftTrigger < 3)
            {
                AddPositionAndInstantiateSphere(controllerPosition);
            }

            UpdateMesh();

        }
        else
        {
            Debug.LogError("VR Controller is not assigned!");
        }
    }

    void UpdateMesh()
    {
        mesh.vertices = positionsList.ToArray();
        mesh.triangles = Triangulate(positionsList.ToArray());
        mesh.RecalculateNormals();
    }

    
    public void getVerticesIndex()
    {
        Vector3 controllerPosition = leftController.transform.position;
        gripClosestVerticesIndex = FindClosestPointIndex(positionsList.ToArray(), controllerPosition);

    }

    public void getVerticesIndexAndUpdate()
    {
        Vector3 controllerPosition = leftController.transform.position;
        positionsList[gripClosestVerticesIndex] = controllerPosition;
        UpdateMesh();
    }

    void AddPositionAndInstantiateSphere(Vector3 position)
    {
        positionsList.Add(position);
        Instantiate(spherePrefab, position, Quaternion.identity);
    }

    int[] Triangulate(Vector3[] points)
    {
        Vector3 controllerPosition = leftController.transform.position;
        int pointCount = points.Length;

        if (numOfLeftTrigger <= 3)
        {
            return UnityTriangulate(points);
        }
        else if (numOfLeftTrigger % 3 != 0)
        {
            UpdateClosestPointIndices(points, controllerPosition);
        }
        else if (numOfLeftTrigger % 3 == 0 && firstClosestPointIndex != -1 && secondClosestPointIndex != -1)
        {
            return CreateTrianglesWithClosestPoints(pointCount);
        }

        return triangles.ToArray();
    }

    
    int[] UnityTriangulate(Vector3[] points)
    {
        //List<int> triangles = new List<int>();
        for (int i = 0; i < points.Length - 2; i++)
        {
            triangles.Add(i);
            triangles.Add(i + 1);
            triangles.Add(i + 2);

            triangles.Add(i);
            triangles.Add(i + 2);
            triangles.Add(i + 1);
        }
        return triangles.ToArray();
    }

    void UpdateClosestPointIndices(Vector3[] points, Vector3 targetPoint)
    {
        if (firstClosestPointIndex == -1 && secondClosestPointIndex == -1)
        {
            firstClosestPointIndex = FindClosestPointIndex(points, targetPoint);
            
            //Find Sphere and Change Color
            FindAndChangeMaterial("MeshSphere", targetPoint);

        }
        else if (firstClosestPointIndex != -1 && secondClosestPointIndex == -1)
        {
            secondClosestPointIndex = FindClosestPointIndex(points, targetPoint);

            //Find Sphere and Change Color
            FindAndChangeMaterial("MeshSphere", targetPoint);
        }
    }

    int[] CreateTrianglesWithClosestPoints(int pointCount)
    {
        //List<int> triangles = new List<int>();

        triangles.Add(firstClosestPointIndex);
        triangles.Add(secondClosestPointIndex);
        triangles.Add(pointCount - 1);

        triangles.Add(firstClosestPointIndex);
        triangles.Add(pointCount - 1);
        triangles.Add(secondClosestPointIndex);

        firstClosestPointIndex = -1;
        secondClosestPointIndex = -1;

        return triangles.ToArray();
    }

    int FindClosestPointIndex(Vector3[] points, Vector3 targetPoint)
    {
        if (points == null || points.Length == 0)
        {
            Debug.LogError("Array of points is null or empty.");
            return -1;
        }

        int closestPointIndex = 0;
        float minDistance = Vector3.Distance(targetPoint, points[0]);

        for (int i = 1; i < points.Length; i++)
        {
            float distance = Vector3.Distance(targetPoint, points[i]);

            if (distance < minDistance)
            {
                minDistance = distance;
                closestPointIndex = i;
            }
        }

        return closestPointIndex;
    }

    void FindAndChangeMaterial(string tagToSearch, Vector3 targetPoint)
    {
        GameObject[] spheresToSearch = GameObject.FindGameObjectsWithTag(tagToSearch);

        foreach (GameObject sphere in spheresToSearch)
        {
            if (Vector3.Distance(sphere.transform.position, targetPoint) < 0.1f)
            {
                Renderer renderer = sphere.GetComponent<Renderer>();
                currSphereRender = renderer;
                if (renderer != null)
                {
                    renderer.material = NewSphereMaterial;
                }
            }
        }
    }

    public void ChangeSphereColorBack()
    {
        currSphereRender.material = OldSphereMaterial;
    }
}