using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    LevelHandler levelHandler;
    private void Start()
    {
        levelHandler = FindObjectOfType<LevelHandler>();
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }


    public void QuitGame()
    {
        
        Application.Quit();
        Debug.Log("YOU QUIT!");
    }

   
}
