using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStraightController : MonoBehaviour
{
    public Vector2 velocity;
    Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        // Get the rigidbody from the gameObject that holds the script
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidbody.velocity = velocity;
    }
}
 