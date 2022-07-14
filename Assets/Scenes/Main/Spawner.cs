using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private GameObject objectToSpawn;
    public GameObject[] objectsToSpawn;
    public float spawnRange = 256;
    public float itemsToSpawn = 1000;
    private float positionX;
    private float positionZ;
    private int objectToSpawnIndex = 0;
    private float spawnerPositionX;
    private float spawnerPositionZ;

    void Start()
    {
       Spawn();
    }

    public void Spawn()
    {
        spawnerPositionX = this.transform.position.x;
        spawnerPositionZ = this.transform.position.z;
        
       for(int i = 0; i < itemsToSpawn; i++)
        {
            objectToSpawnIndex = Random.Range(0, objectsToSpawn.Length);

            objectToSpawn = objectsToSpawn[objectToSpawnIndex];

            positionX = Random.Range(-spawnRange + spawnerPositionX ,spawnRange + spawnerPositionX);
            positionZ = Random.Range(-spawnRange + spawnerPositionZ,spawnRange + spawnerPositionZ);

            Instantiate(objectToSpawn, new Vector3(positionX, this.transform.position.y, positionZ), Quaternion.identity);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 0.1f);
        Gizmos.DrawCube(transform.position, new Vector3(spawnRange * 2, .1f, spawnRange * 2));
    }
}
