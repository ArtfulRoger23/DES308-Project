﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{

    public TextMeshProUGUI text;
    private float startTime;
    private bool finished = false;

    // Start is called before the first frame update
    void Start()
    {
        //text = GetComponent<TextMeshProUGUI>();
        startTime = Time.time;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (finished)
            return;

       float t = Time.time - startTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        text.text = minutes + ":" + seconds;
    }

    public void Finish()
    {
        finished = true;

        text.color = Color.yellow;

    }
}