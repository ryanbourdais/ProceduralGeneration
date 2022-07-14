using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor (typeof (TerrainGenerator))]
public class PerlinGeneratorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        TerrainGenerator terrainGen = (TerrainGenerator)target;
        
        if(DrawDefaultInspector())
        {
            if(terrainGen.autoUpdate)
            {
                terrainGen.GenerateTerrain();
            }
        }

        if(GUILayout.Button("Generate"))
        {
            terrainGen.GenerateTerrain();
        }
    }
}
