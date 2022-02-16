using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        // over here we're checking for collision with the obstacles, we can then add a script that 
        // disabels the movement or restarts the level.
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            Debug.Log("We hit an obsticle");
            FindObjectOfType<GameManager>().GameOver();
            
        }
        
    }
}
