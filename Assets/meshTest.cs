using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meshTest : MonoBehaviour
{
    void Start()
    {
        Mesh mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;

        Vector3[] vertices = new Vector3[30];
        Vector2[] uv = new Vector2[30];
        int[] triangles = new int[30];

        vertices[0] = new Vector3(0, 0, 0);
        vertices[1] = new Vector3(0, 1, 0);
        vertices[2] = new Vector3(1, 1, 0);

        triangles[0] = 0;
        triangles[1] = 1;
        triangles[2] = 2;

        mesh.vertices = vertices;
        mesh.uv = uv;
        mesh.triangles = triangles;

    }

}
