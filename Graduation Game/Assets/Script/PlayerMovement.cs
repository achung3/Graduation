using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    Rigidbody rb;
    //this will allow us to change this in unity
    [SerializeField] float movementSpeed = 2.5f;
    [SerializeField] float jumpHeight = 6f;
    [SerializeField] Transform jumpCheck;
    [SerializeField] LayerMask floor;

    //audio
    [SerializeField] AudioSource jumpSound;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //want to move the player anytime during the game
        //jump
        if (Input.GetKeyDown("space") && JumpChecked())
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpHeight, rb.velocity.z);
            jumpSound.Play();
        }
        //forward
        if (Input.GetKey("up") || Input.GetKey("w"))
        {
            rb.velocity = new Vector3(-movementSpeed, rb.velocity.y, rb.velocity.z);

        }

        //backward
        if (Input.GetKey("down") || Input.GetKey("s"))
        {

            rb.velocity = new Vector3(movementSpeed, rb.velocity.y, rb.velocity.z);
       
        }
        //right
        if (Input.GetKey("right") || Input.GetKey("d"))
        {
           
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, movementSpeed);
   
        }

        //left
        if (Input.GetKey("left") || Input.GetKey("a"))
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, -movementSpeed);
     
        }


        //cheatcode
        //#2-9 changing into different screens
        //2: Main Screen
        if (Input.GetKeyDown("2"))
        {
            SceneManager.LoadScene(0);
        }

        //3: Instruction
        if (Input.GetKeyDown("3"))
        {
            SceneManager.LoadScene(1);
        }

        //4: Level 1
        if (Input.GetKeyDown("4"))
        {
            SceneManager.LoadScene(2);
        }

        //5: Level 2
        if (Input.GetKeyDown("5"))
        {
            SceneManager.LoadScene(3);
        }

        //6: Passed
        if (Input.GetKeyDown("6"))
        {
            SceneManager.LoadScene(4);
        }

        //7: Failed
        if (Input.GetKeyDown("7"))
        {
            SceneManager.LoadScene(5);
        }

        //8: Exlanation_1
        if (Input.GetKeyDown("8"))
        {
            SceneManager.LoadScene(6);
        }

        //9: Exlanation_2
        if (Input.GetKeyDown("9"))
        {
            SceneManager.LoadScene(7);
        }



    }

    bool JumpChecked()
    {
        return Physics.CheckSphere(jumpCheck.position, .1f, floor);
    }

    //reseting the postion for when the player dies
    public void resetPosition()
    {
        transform.position = new Vector3(41.35f, -8.04f, 9.27f);
    }
}
