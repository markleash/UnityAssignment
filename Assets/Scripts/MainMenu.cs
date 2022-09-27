using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    [SerializeField] public GameObject turnManager;
    public void PlayGame()
    {
        SceneManager.LoadScene("PostPrototype");
        Cursor.visible = false;

    }
    
    public void HowToPlay()
    {
        SceneManager.LoadScene("HTP");
        Cursor.visible = true;
    }

    public void QuitGame()
    {
        Debug.Log("Thanks for playing");
        Application.Quit();
    }
}
