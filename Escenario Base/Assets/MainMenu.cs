using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public static class GlobalVariables
{
    public static string language = "english";
}

public class MainMenu : MonoBehaviour
{

    private Button[] Buttons;
    private TextMeshProUGUI[] Labels;

    public GameObject mainMenu;
    public GameObject optionsMenu;
    public GameObject scenesMenu;
    public GameObject aboutMenu;


    void Start()
    {
        Buttons = this.GetComponentsInChildren<Button>(true);
        Labels = this.GetComponentsInChildren<TextMeshProUGUI>(true);

        if (GlobalVariables.language == "english")
        {
            ChangeToEnglish();
        } else
        {
            ChangeToSpanish();
        }

        ShowMenuAction();

    }

    public void ShowOptionsAction()
    {
        optionsMenu.SetActive(true);
        mainMenu.SetActive(false);

        if (GlobalVariables.language == "english")
        {
            ChangeToEnglish();
        }
        else
        {
            ChangeToSpanish();
        }

    }

    public void ShowScenesAction()
    {
        scenesMenu.SetActive(true);
        mainMenu.SetActive(false);

        if (GlobalVariables.language == "english")
        {
            ChangeToEnglish();
        }
        else
        {
            ChangeToSpanish();
        }

    }

    public void ShowAboutAction()
    {
        aboutMenu.SetActive(true);
        mainMenu.SetActive(false);

        if (GlobalVariables.language == "english")
        {
            ChangeToEnglish();
        }
        else
        {
            ChangeToSpanish();
        }

    }

    public void ShowMenuAction()
    {
        optionsMenu.SetActive(false);
        scenesMenu.SetActive(false);
        aboutMenu.SetActive(false);
        mainMenu.SetActive(true);

        if (GlobalVariables.language == "english")
        {
            ChangeToEnglish();
        }
        else
        {
            ChangeToSpanish();
        }

    }

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

    public void ChangeToEnglish()
    {
        foreach (Button button in Buttons)
        {
            bool state = button.IsActive();

            if (state && button.name == "Button Play")
            {
                button.GetComponentInChildren<TextMeshProUGUI>().text = "Play";
            }
            else if (state && button.name == "Button Scenes")
            {
                button.GetComponentInChildren<TextMeshProUGUI>().text = "Scenes";
            }
            else if (state && button.name == "Button Options")
            {
                button.GetComponentInChildren<TextMeshProUGUI>().text = "Options";
            }
            else if (state && button.name == "Button About")
            {
                button.GetComponentInChildren<TextMeshProUGUI>().text = "About";
            }
            else if (state && button.name == "Button Quit")
            {
                button.GetComponentInChildren<TextMeshProUGUI>().text = "Quit";
            }
            else if (state && button.name == "Button Back")
            {
                button.GetComponentInChildren<TextMeshProUGUI>().text = "Back";
            }
            else if (state && button.name == "Button Scene Hub")
            {
                button.GetComponentInChildren<TextMeshProUGUI>().text = "Main Scene";
            }
            else if (state && button.name == "Button Scenes (1)")
            {
                button.GetComponentInChildren<TextMeshProUGUI>().text = "Scene 1";
            }
            else if (state && button.name == "Button Scenes (2)")
            {
                button.GetComponentInChildren<TextMeshProUGUI>().text = "Scene 2";
            }
            else if (state && button.name == "Button Scenes (3)")
            {
                button.GetComponentInChildren<TextMeshProUGUI>().text = "Scene 3";
            }
            else if (state && button.name == "Button Scenes (4)")
            {
                button.GetComponentInChildren<TextMeshProUGUI>().text = "Scene 4";
            }
            else if (state && button.name == "Button Scenes (5)")
            {
                button.GetComponentInChildren<TextMeshProUGUI>().text = "Scene 5";
            }

        }

        foreach (TextMeshProUGUI label in Labels)
        {

            bool state = label.IsActive();

            if (state && label.name == "Titulo")
            {
                label.text = "In these four walls";
            }
            else if (state && label.name == "Menu")
            {
                label.text = "Menu";
            }
            else if (state && label.name == "Volume")
            {
                label.text = "Volume";
            }
            else if (state && label.name == "Options")
            {
                label.text = "Options";
            }
            else if (state && label.name == "Scenes")
            {
                label.text = "Scenes";
            }
            else if (state && label.name == "About Project")
            {
                label.text = "In these four walls: \"The consequences of the glitch in the interactive virtual environment\"\n\nMaster Final Project\nMaster's Degree in Art and Creation Research\nComplutense University Of Madrid\n\n\nCreated by Patricia S. Gracia Artero 2020";
            }
            else if (state && label.name == "More Info")
            {
                label.text = "More information: patriciagraciaartero@gmail.com";
            }

        }

        GlobalVariables.language = "english";

    }

    public void ChangeToSpanish()
    {

        foreach (Button button in Buttons)
        {
            bool state = button.IsActive();

            if (state && button.name == "Button Play")
            {
                button.GetComponentInChildren<TextMeshProUGUI>().text = "Empezar";
            }
            else if (state && button.name == "Button Options")
            {
                button.GetComponentInChildren<TextMeshProUGUI>().text = "Opciones";
            }
            else if (state && button.name == "Button Scenes")
            {
                button.GetComponentInChildren<TextMeshProUGUI>().text = "Escenas";
            }
            else if (state && button.name == "Button About")
            {
                button.GetComponentInChildren<TextMeshProUGUI>().text = "Sobre";
            }
            else if (state && button.name == "Button Quit")
            {
                button.GetComponentInChildren<TextMeshProUGUI>().text = "Salir";
            }
            else if (state && button.name == "Button Back")
            {
                button.GetComponentInChildren<TextMeshProUGUI>().text = "Atrás";
            }
            else if (state && button.name == "Button Scene Hub")
            {
                button.GetComponentInChildren<TextMeshProUGUI>().text = "Escenario Base";
            }
            else if (state && button.name == "Button Scenes (1)")
            {
                button.GetComponentInChildren<TextMeshProUGUI>().text = "Escena 1";
            }
            else if (state && button.name == "Button Scenes (2)")
            {
                button.GetComponentInChildren<TextMeshProUGUI>().text = "Escena 2";
            }
            else if (state && button.name == "Button Scenes (3)")
            {
                button.GetComponentInChildren<TextMeshProUGUI>().text = "Escena 3";
            }
            else if (state && button.name == "Button Scenes (4)")
            {
                button.GetComponentInChildren<TextMeshProUGUI>().text = "Escena 4";
            }
            else if (state && button.name == "Button Scenes (5)")
            {
                button.GetComponentInChildren<TextMeshProUGUI>().text = "Escena 5";
            }

        }

        foreach (TextMeshProUGUI label in Labels)
        {

            bool state = label.IsActive();

            if (state && label.name == "Titulo")
            {
                label.text = "En estas cuatro paredes";
            }
            else if (state && label.name == "Menu")
            {
                label.text = "Menu";
            }
            else if (state && label.name == "Volume")
            {
                label.text = "Volumen";
            }
            else if (state && label.name == "Options")
            {
                label.text = "Opciones";
            }
            else if (state && label.name == "Scenes")
            {
                label.text = "Escenas";
            }
            else if (state && label.name == "About Project")
            {
                label.text = "En estas cuatro paredes: \"Las consecuencias del glitch en el entorno virtual interactivo\"\n\nProyecto Fin de Máster\nMáster en Investigación en Arte y Creación Universidad Complutense Madrid\n\n\nRealizado por Patricia S. Gracia Artero 2020";
            }
            else if (state && label.name == "More Info")
            {
                label.text = "Más información: patriciagraciaartero@gmail.com";
            }

        }

        GlobalVariables.language = "spanish";

    }

}
