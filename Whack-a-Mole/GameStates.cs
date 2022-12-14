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
