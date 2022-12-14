//Marissa Estramonte and Quillan Gee
//2405291, 2404244 
//estramonte@chapman.edu, qgee@chapman.edu 
//245-01
//Final Project: Whack-a-mole

//Controls the Playing State.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatePlaying : GameStates
{
    public StatePlaying(GameManager instance) : base(instance) { }

    public override void OnStateEnter()
    {
        gameManagerInstance.StartBeginningOfGame();
    }
    public override void OnStateExit() { }
    public override void StateUpdate() { }
}
