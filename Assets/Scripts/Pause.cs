using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{   
    public static bool gameIsPaused;
    void PauseGame()
    {
        if(gameIsPaused)
        {
            Time.timeScale = 0f;
        }
        else 
        {
            Time.timeScale = 1;
        }
    }
    void ResumeGame ()
    {
        Time.timeScale = 1;
    }
    
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            gameIsPaused = !gameIsPaused;
            PauseGame();
        }
        
        else if (Input.GetKeyDown(KeyCode.Escape) && gameIsPaused)
        {
            ResumeGame();
        }
    }
}
