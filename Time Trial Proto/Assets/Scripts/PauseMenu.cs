using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    LevelHandler levelHandler;

    void Start()
    {
        levelHandler = FindObjectOfType<LevelHandler>();
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

    public void Resume()
    {
        Debug.Log("Resume is being called");
        pauseMenuUI.SetActive(false);
        
        GameIsPaused = false;

        FindObjectOfType<PlayerLook>().enabled = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = false;
    }

    public void Pause()
    {
        Debug.Log("Pause is being called");
        pauseMenuUI.SetActive(true);
        
        GameIsPaused = true;
        FindObjectOfType<PlayerLook>().enabled = false;
        
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    
    public void Restart()
    {

        Scene loadedLevel = SceneManager.GetActiveScene();
        SceneManager.LoadScene(loadedLevel.buildIndex);

        pauseMenuUI.SetActive(false);

        GameIsPaused = false;

        levelHandler.LevelRestart();
        levelHandler.levelRestarts++;


    }

    public void Menu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void Quit()
    {
        levelHandler.LevelQuit();
        levelHandler.levelQuits++;
        Application.Quit();
    }
}
