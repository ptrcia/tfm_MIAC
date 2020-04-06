using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public void PlayGame()
    {
        CheckPauseState();
        SceneManager.LoadScene("Escenario Base");
    }
    public void PlayScene1() 
    {
        CheckPauseState();
        SceneManager.LoadScene("Escenario1");
    }
    public void PlayScene2()
    {
        CheckPauseState();
        SceneManager.LoadScene("Escenario2");
    }
    public void PlayScene3()
    {
        CheckPauseState();
        SceneManager.LoadScene("Escenario3");
    }
    public void PlayScene4()
    {
        CheckPauseState();
        SceneManager.LoadScene("Escenario4");
    }
    public void PlayScene5()
    {
        CheckPauseState();
        SceneManager.LoadScene("Escenario5");
    }

    public void QuitGame ()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void CheckPauseState()
    {
        if (PauseMenu.GameIsPaused == true)
        {
            Time.timeScale = 1f;
            PauseMenu.GameIsPaused = false;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }

}
