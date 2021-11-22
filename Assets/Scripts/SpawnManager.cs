using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject animalPrefab;
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
        SpawnPosition = RandomSpawnPosition();
        Instantiate(animalPrefab, SpawnPosition, animalPrefab.transform.rotation);
    }
}
