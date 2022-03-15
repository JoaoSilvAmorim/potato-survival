using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform[] spawnPoints;
    [SerializeField] GameObject enemy;
    void Start()
    {
       InvokeRepeating("SpawnEnemies", 0.5f, 1.5f); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemies(){
        int index = Random.Range(0, spawnPoints.Length);
        Instantiate(enemy, spawnPoints[index].position, Quaternion.identity);
    }
}
