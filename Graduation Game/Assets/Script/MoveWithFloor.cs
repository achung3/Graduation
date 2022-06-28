using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithFloor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //check for collision so that when Lina is on the moving floor she moves with the floor
    private void OnCollisionEnter(Collision collision)
    {
        //checking if it collides with Lina
        if (collision.gameObject.name == "Lina")
        {
            collision.gameObject.transform.SetParent(transform); //change parent so that Lina's position matches the floor she's on
        }
    }

    //check for collision so that when Lina is off the moving floor she doesn't continue to move with the floor
    private void OnCollisionExit(Collision collision)
    {
        
        if (collision.gameObject.name == "Lina")
        {
            collision.gameObject.transform.SetParent(null);
        }
    }
}
