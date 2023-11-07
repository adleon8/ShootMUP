using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tester : MonoBehaviour
{
    // -----POWERUPS-----
    [SerializeField]
    private float randomPowerUp;

    public GameObject blasterPrefab;
    public GameObject spreadPrefab;
    private void Start()
    {
        int randomPower = RandomPowerUp();
        Debug.Log(randomPower);
        
        if (randomPower == 0)
        {
            Instantiate(blasterPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        }
        if (randomPower == 1)
        {
            Instantiate(spreadPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        }
        
    }

    public int RandomPowerUp()
    {
        return Random.Range(0, 5);
    }


}
