using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    public PowerUp powerUps;
    private void Update()
    {
        // Power ups enum.
        switch (powerUps)
        {
            case PowerUp.Blaster:
                Debug.Log("Blaster");
                break;
            case PowerUp.Spread:
                Debug.Log("Spread");
                
                break;
            case PowerUp.Shield:
                
                break;
            case PowerUp.None:
                break;
            default:
                break;
        }
    }
}

public enum PowerUp
{
    Blaster,
    Spread,
    Shield,
    None
}
