//Marissa Estramonte and Quillan Gee
//2405291, 2404244 
//estramonte@chapman.edu, qgee@chapman.edu 
//245-01
//Final Project: Whack-a-mole

//Button Actions class controls what each button does in the game.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAction : MonoBehaviour
{
    private GameManager gameInstance;

    private void Start()
    {
        gameInstance = GetComponent<GameManager>();
    }

    public void OnClickStart()
    {
        gameInstance.NewState(gameInstance.statePlaying);
    }

    public void OnClickReset()
    {
        gameInstance.NewState(gameInstance.stateReset);
    }

    public void OnClickQuit()
    {
        gameInstance.NewState(gameInstance.stateQuit);
    }
}
