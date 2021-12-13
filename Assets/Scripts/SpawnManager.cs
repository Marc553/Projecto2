using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private Vector3 SpawnPosition;
    private float xRange = 15f;
    private float startTmie = 2;
    private float repeatRate = 1.5f;
    private float spawnZ = 25;
    private float randomX;
    private int randomIdex;
    void Start()
    {
        InvokeRepeating("SpawnAnimal", startTmie, repeatRate);
    }
   
    public Vector3 RandomSpawnPosition()
    {
        randomX = Random.Range(-xRange, xRange);
        return new Vector3(randomX, 0, spawnZ);
    }

    public void SpawnAnimal()
    {
         randomIdex = Random.Range(0, animalPrefabs.Length); //numero entre 0 y maximo numero d objetos d mi "animalPrefabs
        SpawnPosition = RandomSpawnPosition();
        Instantiate(animalPrefabs[randomIdex], SpawnPosition, animalPrefabs[randomIdex].transform.rotation);
    }
}
