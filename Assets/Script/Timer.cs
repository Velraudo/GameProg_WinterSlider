using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timeRemain = 0;
    public bool timeIsRunning = true;
    public Text timeText;
  
    void Start()
    {
        timeIsRunning = true;
    }

    void Update()
    {
        if(timeIsRunning)
        {
            timeRemain += Time.deltaTime;
            DisplayTime(timeRemain);
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
}
