using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnLogic : MonoBehaviour
{

    public GameObject enemyObj;
    bool canSpawn = true;
    float enemySpawnTime = 1.0f;
    float boundaryLimits_X = 35.0f;
    float startingY = 18.0f;

    float randomX = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemyTimer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator spawnEnemyTimer()
    {
        while (canSpawn == true)
        {
            spawnEnemy();
            yield return new WaitForSeconds(enemySpawnTime);
        }

    }

    void spawnEnemy()
    {
        randomX = Random.Range(-boundaryLimits_X, boundaryLimits_X);

        Instantiate(enemyObj, new Vector3(randomX, startingY, 0), Quaternion.identity);
    }

}
