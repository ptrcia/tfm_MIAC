using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    //public GameObject Camera;

    public GameObject pauseMenuUI;
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Application.Quit();
            //SceneManager.LoadScene("Menu");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

            if (GameIsPaused)
            {
                Resume();
                
            }
            else
            {
                Pause();
                //camera.GetComponent<MouseLook>().enabled = false;  no se esto como va para desactivar
                //GameObject.Find("Camera").GetComponent<MouseLook>().enabled = false;
            }

        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
        Debug.Log("Loading menu...");
    }
    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}
