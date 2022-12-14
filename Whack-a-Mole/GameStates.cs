//Marissa Estramonte and Quillan Gee
//2405291, 2404244 
//estramonte@chapman.edu, qgee@chapman.edu 
//245-01
//Final Project: Whack-a-mole

//Includes all the GameStates used.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStates 
{
    public enum StateType
    {
        Reset,
        Playing,
        Quit
    }

    protected GameManager gameManagerInstance;

    public GameStates(GameManager instance)
    {
        gameManagerInstance = instance;
    }

    public virtual void OnStateEnter() { }
    public virtual void OnStateExit() { }
    public virtual void StateUpdate() { }
}
