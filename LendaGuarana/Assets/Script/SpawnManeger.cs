using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManeger : MonoBehaviour
{       
    [SerializeField] Transform[] spawnPoints;
    [SerializeField] GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemies", 0.5f, 1.5f);
    }

    // Update is called once per frame
       

    void SpawnEnemies(){
        int index = Random.Range(0, spawnPoints.Length);
        Instantiate(enemy, spawnPoints[index].position, Quaternion.identity);
    }
}
