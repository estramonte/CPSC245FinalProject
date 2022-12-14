//Marissa Estramonte and Quillan Gee
//2405291, 2404244 
//estramonte@chapman.edu, qgee@chapman.edu 
//245-01
//Final Project: Whack-a-mole

//Controls the in-game Timer.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeOnGame = 10f;
    private float seconds, miliseconds;
    public Text timerText;

    public void StartTimer()
    {
        StartCoroutine(TimerRun());
    }

    private IEnumerator TimerRun()
    {
        while (timeOnGame > 0)
        {
            seconds = (int)timeOnGame;
            miliseconds = (int)((timeOnGame * 60f) % 60f);
            timerText.text = "Time: " + seconds.ToString() + ":" + miliseconds.ToString();
            timeOnGame -= 0.01f;
            yield return new WaitForSeconds(0.01f);
        }
    }

    public void Reset()
    {
        timeOnGame = 10f;
    }
}
