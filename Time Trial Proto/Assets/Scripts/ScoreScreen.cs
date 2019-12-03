using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreScreen : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI finalTIme;
    [SerializeField]
    TextMeshProUGUI finalscore;
    [SerializeField]
    TextMeshProUGUI finalTotal;

    LevelHandler levelHandler;

    void Start()
    {
        levelHandler = FindObjectOfType<LevelHandler>();
    }

   
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            SetAll();
        }
    }

    public void SetAll()
    {
        float t = FindObjectOfType<Timer>().t;
        float score = FindObjectOfType<ScoreCount>().score;


       

        string minutes = ((int)t / 60).ToString("0");
        string seconds = (t % 60).ToString("00");
        float miliseconds = ((t * 100) % 100);

        finalTIme.text = minutes + ":" + seconds + ":" + miliseconds.ToString("00");

        finalscore.text = score.ToString();

        finalTotal.text = (score / t).ToString();

        


        GetComponent<CanvasGroup>().alpha = 1;

        
       

    }
}
