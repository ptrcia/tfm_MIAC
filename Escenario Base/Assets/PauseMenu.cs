using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public static string Language = "ESP";

    public GameObject pauseMenuUI;
    private Button[] Buttons;

    void Start()
    {
        Buttons = this.GetComponentsInChildren<Button>(true);
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if (GameIsPaused)
            {
                Resume();

            }
            else
            {
                Pause();
            }

        }
    }

    public void ChangeToEnglish()
    {
        foreach (Button button in Buttons)
        {
            if (button.name == "QuitButton")
            {
                button.GetComponentInChildren<Text>().text = "Quit";
            }
            else if (button.name == "ResumeButton")
            {
                button.GetComponentInChildren<Text>().text = "Resume";
            }
            else if (button.name == "MenuButton")
            {
                button.GetComponentInChildren<Text>().text = "Menu";
            }
            else if (button.name == "Main Scene")
            {
                button.GetComponentInChildren<Text>().text = "Base Scene";
            }
            else if (button.name == "Scene 1")
            {
                button.GetComponentInChildren<Text>().text = "Scene 1";
            }
            else if (button.name == "Scene 2")
            {
                button.GetComponentInChildren<Text>().text = "Scene 2";
            }
            else if (button.name == "Scene 3")
            {
                button.GetComponentInChildren<Text>().text = "Scene 3";
            }
            else if (button.name == "Scene 4")
            {
                button.GetComponentInChildren<Text>().text = "Scene 4";
            }
            else if (button.name == "Scene 5")
            {
                button.GetComponentInChildren<Text>().text = "Scene 5";
            }
            else if (button.name == "Scene 6")
            {
                button.GetComponentInChildren<Text>().text = "Scene 6";
            }
            else if (button.name == "Scene 7")
            {
                button.GetComponentInChildren<Text>().text = "Scene 7";
            }
            else if (button.name == "Scene 8")
            {
                button.GetComponentInChildren<Text>().text = "Scene 8";
            }
         
        }
    }

    public void ChangeToSpanish()
    {
        foreach (Button button in Buttons)
        {

            if (button.name == "QuitButton")
            {
                button.GetComponentInChildren<Text>().text = "Quitar";
            }
            else if (button.name == "ResumeButton")
            {
                button.GetComponentInChildren<Text>().text = "Continuar";
            }
            else if (button.name == "MenuButton")
            {
                button.GetComponentInChildren<Text>().text = "Menú";
            }
            else if (button.name == "Main Scene")
            {
                button.GetComponentInChildren<Text>().text = "Escena Base";
            }
            else if (button.name == "Scene 1")
            {
                button.GetComponentInChildren<Text>().text = "Escena 1";
            }
            else if (button.name == "Scene 2")
            {
                button.GetComponentInChildren<Text>().text = "Escena 2";
            }
            else if (button.name == "Scene 3")
            {
                button.GetComponentInChildren<Text>().text = "Escena 3";
            }
            else if (button.name == "Scene 4")
            {
                button.GetComponentInChildren<Text>().text = "Escena 4";
            }
            else if (button.name == "Scene 5")
            {
                button.GetComponentInChildren<Text>().text = "Escena 5";
            }
            else if (button.name == "Scene 6")
            {
                button.GetComponentInChildren<Text>().text = "Escena 6";
            }
            else if (button.name == "Scene 7")
            {
                button.GetComponentInChildren<Text>().text = "Escena 7";
            }
            else if (button.name == "Scene 8")
            {
                button.GetComponentInChildren<Text>().text = "Escena 8";

            }

        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
    }
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
        Debug.Log("Loading menu...");
    }
    public void PlayGame()
    {
        Resume();
        SceneManager.LoadScene("Escenario Base");
    }
    public void PlayScene1()
    {
        Resume();
        SceneManager.LoadScene("Escenario1");
    }
    public void PlayScene2()
    {
        Resume();
        SceneManager.LoadScene("Escenario2");
    }
    public void PlayScene3()
    {
        Resume();
        SceneManager.LoadScene("Escenario3");
    }
    public void PlayScene4()
    {
        Resume();
        SceneManager.LoadScene("Escenario4");
    }
    public void PlayScene5()
    {
        Resume();
        SceneManager.LoadScene("Escenario5");
    }
    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }

    
}
