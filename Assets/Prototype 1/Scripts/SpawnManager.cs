using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.InputSystem;


public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs; // array of animal prefabs that can be spawned
     
    private float spawnRangeX = 10; // range to spawn animal within game bounds
    private float spawnPosZ = 30; // Z spawn position
    private float startDelay = 2; // delay before animals start spawning
    private float spawnInterval = 1.5f; // time between animals spawning
 



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        

        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval); // always calls SpawnRandomAnimal. starts after delay and repeats every spawn interval
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal() // Spawns a random animal to run down the screen
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length); // picks random animal prefab

        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ); // finds spawn position. ramdom x wth with fixed Y & Z points

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation); // spawn 
    }
}
