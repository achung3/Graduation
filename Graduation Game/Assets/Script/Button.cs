using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Button : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void RestartGame_Lose()
    {
       
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void EndGame_Lose()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);
        SceneManager.LoadScene(0);
    }

    public void RestartGame_Win()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void EndGame_Win()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
        SceneManager.LoadScene(0);
    }
}
