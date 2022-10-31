using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Here we get wether A or D was pressed (or left and right arrow keys) 
        float horizontalInput = Input.GetAxis("Horizontal");
        // Here we get wether S or W was pressed (or bottom and top arrow keys) 
        float VerticalInput = Input.GetAxis("Vertical");

        Vector2 direction = new Vector2(horizontalInput, VerticalInput);

        // normalized means that no matter which direction, we're moving the direction as length of one
        rigidbody.velocity = direction.normalized * speed;
    }
}
