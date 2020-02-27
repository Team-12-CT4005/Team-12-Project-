using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Allows for the scene loading functions within the build menu

public class MainMenu : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();// Quits the application
    }
    public void Begin()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);// increments the current scene index by one in this case going to the game start scene
    }
}

