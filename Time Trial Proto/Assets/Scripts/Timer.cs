﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{

    public TextMeshProUGUI text;
    private float startTime;
    private bool finished = false;
    float t = 0;

    LevelHandler levelHandler;

    // Start is called before the first frame update
    void Start()
    {
        
        startTime = Time.time;

        levelHandler = FindObjectOfType<LevelHandler>();

    }

    // Update is called once per frame
    void Update()
    {
        if (finished)
            return;

        t += Time.deltaTime;

        string minutes = ((int)t / 60).ToString("0");
        string seconds = (t % 60).ToString("00");
        float miliseconds = ((t * 100) % 100);

        text.text = minutes + ":" + seconds + ":" + miliseconds.ToString("00");
    }

    public void Finish()
    {
        finished = true;

        text.color = Color.yellow;

        levelHandler.timer = t;
    }
}
