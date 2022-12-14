//Marissa Estramonte and Quillan Gee
//2405291, 2404244 
//estramonte@chapman.edu, qgee@chapman.edu 
//245-01
//Final Project: Whack-a-mole

//Controls the Quit State.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateQuit : GameStates
{
    public StateQuit(GameManager instance) : base(instance) { }

    public override void OnStateEnter()
    {
        gameManagerInstance.Quit();
    }
    public override void OnStateExit() { }
    public override void StateUpdate() { }
}
