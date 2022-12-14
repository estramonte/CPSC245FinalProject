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
