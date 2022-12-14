using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateReset : GameStates
{
    public StateReset(GameManager instance) : base(instance) { }

    public override void OnStateEnter()
    {
        gameManagerInstance.StartResults();
    }
    public override void OnStateExit() { }
    public override void StateUpdate() { }
}