using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReportCard : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    int grade = 100;
    [SerializeField] Text gradeText;
    bool fell = false;
    [SerializeField] PlayerMovement pm; //this allows us to use the method created in another script

    //audio
    [SerializeField] AudioSource extraCreditSound;
    [SerializeField] AudioSource LiSound;
    [SerializeField] AudioSource fallSound;

    // Update is called once per frame
    void Update()
    {
        if (grade <= 0)
        {
            print("deathhhhhhh");
            Failed();
        }
        else if (grade > 0)
        {
            if (transform.position.y < -15f && !fell)
            {
                print("ahhhh I'm falling");
                fallSound.Play();
                Death();
            }
            
        }

        //cheatcode
        //0: add 50 extra points to the game
        if (Input.GetKeyDown("0"))
        {
            grade += 50;
            ChangeGradeText();
        }

        //1: take 50 points off the game
        if (Input.GetKeyDown("1"))
        {
            grade -= 50;
            ChangeGradeText();
        }
    }
    void ChangeGradeText()
    {
        gradeText.text = "Grade: " + grade;
        print(grade);
    }
    void Failed()
    {
        SceneManager.LoadScene(7); //once dead it takes it to the failed scene
    }

    void Death()
    {
        
        
        Invoke(nameof(ReloadLevel), 1.3f);
        fell = true;

    }

    /*private void OnCollisionEnter(Collision collision)
    {
        if (gameObject.name == "Lina" && !fell)
        {
            collision.gameObject.transform.position.y += Mathf.Lerp(41.35f, -8.04f, 9.27f);
            ReloadLevel();
        }
    }*/

        void ReloadLevel()
    {
        //transform.position.y = -8.04f;
        pm.resetPosition();
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name); //reload
        fell = false;
        grade -= 20;
        ChangeGradeText();
    }
    
    
    
    private void OnTriggerEnter(Collider other)
    {

            if (other.gameObject.name == "Assignment")
        {
            Destroy(other.gameObject);
            grade += 10;
            ChangeGradeText();
            extraCreditSound.Play();
        }
            else if(other.gameObject.name == "Li")
        {
            //lose grade
            Destroy(other.gameObject);
            grade -= 10;
            ChangeGradeText();
            LiSound.Play();
        }


    }

    

}
