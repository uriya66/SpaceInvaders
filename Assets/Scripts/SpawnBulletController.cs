using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBulletController : MonoBehaviour
{
    public GameObject bullet;
    public float interval = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("shootBullet", interval, interval);
    }

    private void shootBullet()
    {
        GameObject g = Instantiate(bullet, transform.position, Quaternion.identity);
    }
}
