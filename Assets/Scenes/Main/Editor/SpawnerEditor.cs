using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor (typeof (Spawner))]
public class SpawnerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        Spawner biomeSpawner = (Spawner)target;

        if(DrawDefaultInspector())
        {}

        if(GUILayout.Button("Generate"))
        {
            biomeSpawner.Spawn();
        }
    }
}
