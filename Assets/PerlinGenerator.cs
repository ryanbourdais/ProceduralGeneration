using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerlinGenerator : MonoBehaviour
{
    public static randomTerrain randomTerrain = new randomTerrain(20, 513, 513, 8f);

    public static int getDepth() 
    {
        return randomTerrain.Depth;
    }

    public static int getWidth()
    {
        return randomTerrain.Width;
    }

    public static int getHeight()
    {
        return randomTerrain.Height;
    }

    public static float getScale()
    {
        return randomTerrain.Scale;
    }
}
public class randomTerrain
{
    public int Depth { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public float Scale { get; set; }

    public randomTerrain(int depth, int width, int height, float scale)
    {
        Depth = depth;
        Width = width;
        Height = height;
        Scale = scale;
    }
}