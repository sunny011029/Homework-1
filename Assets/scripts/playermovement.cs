using Unity.VisualScripting;
using UnityEngine;

public class playermovement : MonoBehaviour { 

    public enum Gamestate
    {
        PreGame,
        InGame,
    }

    // this is a reference to the rigidbody component called "rb"
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Start is called before the first frame update      
  
    // we maked this as "Fixed" Update because we
    // are using it to mess with physics.
    void FixedUpdate()
    {

        // Add a forward force 
        if (curGameState == Gamestate.)
        rb.AddForce(0, 0, forwardForce*Time.deltaTime); 

        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce*Time.deltaTime, 0, 0,ForceMode.VelocityChange);

        }
    
        if(Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce*Time.deltaTime, 0, 0,ForceMode.VelocityChange);

        }
        if (rb.position.y<-1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}