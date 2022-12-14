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
