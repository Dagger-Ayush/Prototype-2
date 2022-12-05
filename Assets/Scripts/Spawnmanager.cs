using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnmanager : MonoBehaviour
{
    public GameObject[] animalPrefabs; // array of gameobject (animals)
    private float spawnPosZ = 20; // spawn position of the animals
    private float spawnRangeX = 10.0f; // horizontal range of animals where they can spawn
    private float startDelay = 2.0f; // time delay before spawning the first animal
    private float spawnInterval = 1.5f; // time delay before the next animal spawns


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }


    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length); // selecting a random animal among the list
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ); // new random horizontal position for every next animal
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation); // creating the clone of the animals
    }
}
