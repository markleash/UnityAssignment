using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    [SerializeField] public GameObject turnManager;
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Cursor.visible = false;

    }
    
    public void HowToPlay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        Cursor.visible = true;
    }

    public void QuitGame()
    {
        Debug.Log("Thanks for playing");
        Application.Quit();
    }
}
