using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public float respawnTime = 7.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(sharkWave());
    }

    private void spawnEnemy()
    {

        Instantiate(EnemyPrefab);
    }

    IEnumerator sharkWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }

    }

}
