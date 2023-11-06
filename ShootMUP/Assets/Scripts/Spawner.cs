using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;

    [SerializeField]
    private List<GameObject> spawnedEnemies;
}
