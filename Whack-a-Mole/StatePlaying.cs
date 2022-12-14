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
