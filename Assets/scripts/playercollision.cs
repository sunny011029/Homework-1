using UnityEngine;

public class playercollision : MonoBehaviour
{
    public playermovement movement;
 
   void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        { 
       movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();

        }
    }
}
