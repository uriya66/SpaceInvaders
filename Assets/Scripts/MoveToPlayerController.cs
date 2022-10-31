using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPlayerController : MonoBehaviour
{
    public float speed = 1;


    // Start is called before the first frame update
    void Start()
    {
        // Finding the player based on his tag name 
        GameObject gameObject = GameObject.FindWithTag("Player");
        // If the Player still alive
        if (gameObject != null)
        {
            // Transform.position position of the gameobject that holds this script
            // GameObject.transform.posiition will gameobject that is our player
            Vector2 playerPosition = (gameObject.transform.position - transform.position).normalized;
            GetComponent<Rigidbody2D>().velocity = playerPosition * speed;
        }
    }

}
