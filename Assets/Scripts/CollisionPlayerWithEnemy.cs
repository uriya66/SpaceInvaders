using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionPlayerWithEnemy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Invader")
        {
            // Destroy player (as he hold this script)
            Destroy(gameObject);
            // Destroy enemy as he is the one the play collides with in this case
            Destroy(collision.gameObject);
        }
    }

    private void OnDisable()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
