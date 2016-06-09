using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ExplosionSpawner : MonoBehaviour {
    public GameObject ObjectToSpawn;
    public int RushNumber = 10;

    // esto es como un array en esteroides XD
    // porque no necesitas declarar su tamaño antes de usarlo
    public List<GameObject> SpawnedObjects; 

    void Start () {
        SpawnedObjects = new List<GameObject>();
    }

    void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Spawn();
        }
    }

    public void Spawn () {
        for (int i=0; i<RushNumber; i++) {
            GameObject lastSpawned;
            lastSpawned = Instantiate(ObjectToSpawn);
            lastSpawned.transform.position = transform.position;
            SpawnedObjects.Add(lastSpawned);
        }
    }
}
