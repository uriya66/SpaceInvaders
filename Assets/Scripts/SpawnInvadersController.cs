using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInvadersController : MonoBehaviour
{
    public GameObject invader1;
    public GameObject invader2;
    public GameObject invader3;
    public float interval = 4;
    public float startInterval = 1;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnInvader", startInterval, interval);
    }

    private void SpawnInvader()
    {
        float myRan = Random.value;

        if(myRan < 0.2)
        {
            // Spawns invader 1 in 20% of the time
            GameObject g = Instantiate(invader1, transform.position, Quaternion.identity);
        }
        else if (myRan < 0.4)
        {
            // Spawns invader 2 in 20% of the time
            GameObject g = Instantiate(invader2, transform.position, Quaternion.identity);
        }
        else if (myRan < 0.8)
        {
            // Spawns invader 3 in 20% of the time
            GameObject g = Instantiate(invader3, transform.position, Quaternion.identity);
        }
        else
        {
            // Spawn nothing in 40% of the time
        }
    }
}

