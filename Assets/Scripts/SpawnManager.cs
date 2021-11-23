using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public Vector3 SpawnPosition = new Vector3(0, 0, 25);

    public float xRange = 15f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimal", 2, 1.5f);
    }
   
    public Vector3 RandomSpawnPosition()
    {
        float randomx = Random.Range(-xRange, xRange);
        return new Vector3(randomx, 0, 25);
    }

    public void SpawnAnimal()
    {
        int randomIdex = Random.Range(0, animalPrefabs.Length);
        SpawnPosition = RandomSpawnPosition();
        Instantiate(animalPrefabs[randomIdex], SpawnPosition, animalPrefabs[randomIdex].transform.rotation);
    }
}
