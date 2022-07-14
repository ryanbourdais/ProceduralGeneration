// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;




// public class PerlinGenerator : MonoBehaviour
// {

//     public static randomTerrain randomTerrain = new randomTerrain(20, 513, 513, 8f, 0.5f, 2f, 4, 0f, 0);

//     public int depth = 20;
//     public int width = 513; 
//     public int height = 513;
//     public float scale = 8;
//     public float persistance = .5f;
//     public float lacunarity = 2f;
//     public int octaves =  4;
//     public float worldOffset = 0f;
//     public int seed = 0;
//     public Terrain terrain;

//     void Awake()
//     {
//         setValues();
//     }

//     public void setValues()
//     {
//         randomTerrain.Depth = depth;
//         randomTerrain.Width = width;
//         randomTerrain.Height = height;
//         randomTerrain.Scale = scale;
//         randomTerrain.Persistance = persistance;
//         randomTerrain.Lacunarity = lacunarity;
//         randomTerrain.Octaves = octaves;
//         randomTerrain.WorldOffset = worldOffset;
//         randomTerrain.Seed = seed;
//         randomTerrain.Terrain = terrain;
//     }

//     public static int getDepth() 
//     {
//         return randomTerrain.Depth;
//     }

//     public static int getWidth()
//     {
//         return randomTerrain.Width;
//     }

//     public static int getHeight()
//     {
//         return randomTerrain.Height;
//     }

//     public static float getScale()
//     {
//         return randomTerrain.Scale;
//     }
//     public static float getPersistance()
//     {
//         return randomTerrain.Persistance;
//     }
//     public static float getLacunarity()
//     {
//         return randomTerrain.Lacunarity;
//     }
//     public static int getOctaves()
//     {
//         return randomTerrain.Octaves;
//     }
//     public static float getWorldOffset()
//     {
//         return randomTerrain.WorldOffset;
//     }
//     public static int getSeed()
//     {
//         return randomTerrain.Seed;
//     }
//     public static Terrain getTerrain()
//     {
//         return randomTerrain.Terrain;
//     }
// }
// public class randomTerrain
// {
//     public int Depth { get; set; }
//     public int Width { get; set; }
//     public int Height { get; set; }
//     public float Scale { get; set; }
//     public float Persistance { get; set; }
//     public float Lacunarity { get; set; }
//     public int Octaves { get; set; }
//     public float WorldOffset { get; set; }
//     public int Seed { get; set; }
//     public Terrain Terrain { get; set; }

//     public randomTerrain(int depth, int width, int height, float scale, float persistance, float lacunarity, int octaves, float worldOffset, int seed, Terrain terrain = null)
//     {
//         Depth = depth;
//         Width = width;
//         Height = height;
//         Scale = scale;
//         Persistance = persistance;
//         Lacunarity = lacunarity;
//         Octaves = octaves;
//         WorldOffset = worldOffset;
//         Seed = seed;
//         Terrain = terrain;
//     }
// }