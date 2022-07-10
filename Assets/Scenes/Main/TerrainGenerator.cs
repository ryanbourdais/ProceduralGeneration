
using UnityEngine;

public class TerrainGenerator : MonoBehaviour
{
    private int depth;

    private int width;
    private int height;
    private int octaves;
    private float persistance;
    private float lacunarity;
    private float scale;
    private int seed;

    private float worldOffset = 0;
    private float offsetZ = 0;
    private float offsetX = 0;
    public float _offsetX = 0f;
    public float _offsetZ = 0f;
    private float offset = 7.9844f;
    private float newoffset = 0f;
    private Terrain terrain;

    void Start() 
    {
        
        depth = PerlinGenerator.getDepth();
        width = PerlinGenerator.getWidth();
        height = PerlinGenerator.getHeight();
        scale = PerlinGenerator.getScale();
        persistance = PerlinGenerator.getPersistance();
        lacunarity = PerlinGenerator.getLacunarity();
        octaves = PerlinGenerator.getOctaves();
        worldOffset = PerlinGenerator.getWorldOffset();
        seed = PerlinGenerator.getSeed();
        
        terrain = GetComponent<Terrain>();
        terrain.terrainData = GenerateTerrain(terrain.terrainData);
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

        System.Random prng = new System.Random(seed);
        Vector2[] octaveOffsets = new Vector2[octaves];

        for(int i = 0; i < octaves; i++)
        {
            float offsetX = prng.Next(-100000, 100000) + worldOffset;
            float offsetZ = prng.Next(-100000, 100000) + worldOffset;
            octaveOffsets[i] = new Vector2(offsetX, offsetZ);
        }

        float maxNoiseHeight = float.MinValue;
        float minNoiseHeight = float.MaxValue;

        float halfWidth = width / 2f;
        float halfHeight = height / 2f;

        for (int x = 0; x < width; x++)
        {
            for(int y = 0; y < height; y++)
            {
                {
                    float amplitude = 1;
                    float frequency = 1;
                    float noiseHeight = 0;

                    for(int i = 0; i < octaves; i++)
                    {

                    float xCoord = ((float)x - halfWidth )/ scale * frequency + octaveOffsets[i].x + _offsetX;
                    float yCoord = ((float)y - halfHeight) / scale * frequency + octaveOffsets[i].y + _offsetZ;

                    float perlinValue = Mathf.PerlinNoise(xCoord, yCoord) * 2 - 1;
                    noiseHeight += perlinValue * amplitude;

                    amplitude *= persistance;
                    frequency *= lacunarity;
                    }
                    if(noiseHeight > maxNoiseHeight)
                    {
                        maxNoiseHeight = noiseHeight;
                    }
                    else if (noiseHeight < minNoiseHeight)
                    {
                        minNoiseHeight = noiseHeight;
                    }
                    heights[x,y] = noiseHeight;
                }
            }
        }
        for(int y = 0; y < height; y++)
        {
            for(int x = 0; x < width; x++)
            {   
                heights[x,y] = Mathf.InverseLerp(minNoiseHeight, maxNoiseHeight, heights[x,y]);
            }
        }
        return heights;
    }
}
