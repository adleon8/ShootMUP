using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // -----VARIABLES-----
    public GameObject enemyPrefab;

    private float enemyInterval = 3.5f; // Time between enemies being spawned.


    private void Start()
    {
        StartCoroutine(spawnEnemy(enemyInterval, enemyPrefab));
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-4.5f, 4.5f), 9, 0), Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, enemy));
    }
}
