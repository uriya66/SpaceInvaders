using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionInvaderBulletController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Invader" || collision.gameObject.tag == "Bullet")
        {
            // Ignored a collision between the Bullet or Invader and the game object that hold this script
            Physics2D.IgnoreCollision(collision.transform.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
        else
        {
            // Destroy the bullet
            Destroy(gameObject);
            // If you hit anything that isn't Wall destroy him
            if (collision.gameObject.tag != "Wall")
            {
                Destroy(collision.gameObject);
            }
        }
    }
}
