//Marissa Estramonte and Quillan Gee
//2405291, 2404244 
//estramonte@chapman.edu, qgee@chapman.edu 
//245-01
//Final Project: Whack-a-mole

//Manages the UI in the game.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Text ScoreText;
    public Text AllMoles;
    public Text EndScoreText;
    private int score = 0;

    public void UpdateScore()
    {
        AddToScore();
        ScoreText.text = "Score: " + score;
    }

    private void AddToScore()
    {
        score++;
    }

    public void Reset()
    {
        score = 0;
        ScoreText.text = "Score: " + score;
    }

    public void ShowMoleNumber(int number)
    {
        AllMoles.text = number + "";
    }

    public void ShowEndScore()
    {
        EndScoreText.text = score + "";
    }
}
