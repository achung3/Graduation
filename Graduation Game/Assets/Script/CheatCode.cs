using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheatCode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
}
