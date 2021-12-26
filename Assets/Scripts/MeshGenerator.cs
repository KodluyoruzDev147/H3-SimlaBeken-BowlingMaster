using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshGenerator : MonoBehaviour
{
    [SerializeField] private MeshCollider meshCollider;
    [SerializeField] private MeshFilter meshFilter;
    [SerializeField] private int xWidth, zWidth ;
    [SerializeField] private float xSpacing, zSpacing, yMaxHeight;

    private Mesh mesh;

    // Start is called before the first frame update
    void Start()
    {
        GenerateMesh();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void GenerateMesh()
    {

        //checks the mesh is empty or not, if it is empty it creates a new mesh
        if (mesh == null)
        {
            mesh = new Mesh();
            mesh.MarkDynamic();
            meshFilter.sharedMesh = mesh;
        }
        mesh.Clear();

        var vertexList = new List<Vector3>();
        var triangleList = new List<int>();

        Random.InitState(0);

        #region calculate vertex
        for (int z = 0; z < zWidth; z++)
        {
            for(int x = 0; x < xWidth; x++)
            {

                var xPos = x * xSpacing;
                var yPos = Random.Range(-yMaxHeight,yMaxHeight);
                var zPos = z * zSpacing;

                var vertexPos = new Vector3(xPos, yPos, zPos);
                vertexList.Add(vertexPos);
            }
        }
        #endregion

        #region calculate triagles
        for (int z = 0; z < zWidth - 1; z++)
        {
            for(int x = 0; x < xWidth - 1; x++)
            {
                var botL = x + (z * xWidth);
                var botR = botL + 1;
                var topL = botL + xWidth;
                var topR = topL + 1;

                int[] t1 = new int[] { botR, botL, topR };
                int[] t2 = new int[] { botL, topL, topR };

                triangleList.AddRange(t1);
                triangleList.AddRange(t2);

            }
        }
        #endregion 

        mesh.vertices = vertexList.ToArray();
        mesh.triangles = triangleList.ToArray();

        mesh.RecalculateNormals();

        meshCollider.sharedMesh = mesh;

    }
}
