using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomVolcanoRocks : MonoBehaviour
{

    public GameObject volcanoRockPrefab;

    void Start()
    {
        InvokeRepeating("SpawnVolcanoRock", 0f, 0.17f);
    }

    void SpawnVolcanoRock()
    {
        Vector3 randomSpawnPosition = new Vector3(Random.Range(0, 501),Random.Range(100,151), Random.Range(0, 1001));
        Instantiate(volcanoRockPrefab, randomSpawnPosition, Quaternion.identity);
    }
}
