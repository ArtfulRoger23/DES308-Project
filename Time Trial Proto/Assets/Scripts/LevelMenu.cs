using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{
    public void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }



    public void PlayLevel1()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void PlayLevel2()
    {
        SceneManager.LoadScene("Level 2");
    }
}
