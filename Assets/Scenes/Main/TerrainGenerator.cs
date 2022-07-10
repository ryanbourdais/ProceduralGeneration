
using UnityEngine;

public class TerrainGenerator : MonoBehaviour
{
    private int depth;

    private int width;
    private int height;

    private float scale;

    private float offsetZ = 0;
    private float offsetX = 0;
    private float _offsetX;
    private float _offsetY;
    private float offset = 7.9844f;
    private Terrain terrain;

    void Start() 
    {
        depth = PerlinGenerator.getDepth();
        width = PerlinGenerator.getWidth();
        height = PerlinGenerator.getHeight();
        scale = PerlinGenerator.getScale();

        if(scale != 8)
        {
            offset = offset * scale / 8;
        }

        offsetZ = this.transform.position.z / 513;
        offsetX = this.transform.position.x / 513;
        
        terrain = GetComponent<Terrain>();
        terrain.terrainData = GenerateTerrain(terrain.terrainData);
    }

private void Update()
{
     //terrain.terrainData = GenerateTerrain(terrain.terrainData);
}

    TerrainData GenerateTerrain (TerrainData terrainData)
    {
        terrainData.heightmapResolution = width + 1;

        terrainData.size = new Vector3 (width, depth, height);

        terrainData.SetHeights(0, 0, GenerateHeights());

        return terrainData;
    }

    float [,] GenerateHeights ()
    {
        float[,] heights = new float[width, height];
        for (int x = 0; x < width; x++)
        {
            for(int y = 0; y < height; y++)
            {
                heights[x,y] = CalculateHeight(x,y);
            }
        }
        return heights;
    }
    float CalculateHeight (int x, int y)
    {
        _offsetX = offsetZ * offset;
        _offsetY = offsetX * offset;
        float xCoord = (float)x / width * scale + _offsetX;
        float yCoord = (float)y / height * scale + _offsetY;

        return Mathf.PerlinNoise(xCoord, yCoord);
    }
}
