using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.InputSystem;


public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs;
    public InputAction spawnAction;
    private float spawnRangeX = 10;
    private float spawnPosZ = 30;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
 



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnAction.Enable();

        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
