using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //Declaring variables
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 15;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnIntervals = 1.5f;


    // Start is called before the first frame update
    void Start()
    {
       //automating spawn animal
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnIntervals);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnRandomAnimal();
        }
    }
    void SpawnRandomAnimal()
    {
        //auto-generate spawn Objects at spawn positions
        int prefabsIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        Instantiate(animalPrefabs[prefabsIndex], spawnPos, animalPrefabs[prefabsIndex].transform.rotation);
    }
}
