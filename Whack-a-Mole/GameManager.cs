using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private GameStates currState;

    public Canvas startScreen;
    public Canvas gameScreen;
    public Canvas countdown;
    public Canvas resultScreen;
    public Text time;
    public Timer timer;
    public UI ui;
    public Sounds sounds;
    public GamePlaying gamePlaying;
    [HideInInspector] public StatePlaying statePlaying;
    [HideInInspector] public StateReset stateReset;
    [HideInInspector] public StateQuit stateQuit;

    private void Awake()
    {
        statePlaying = new StatePlaying(this);
        stateReset = new StateReset(this);
        stateQuit = new StateQuit(this);
    }

    void Start()
    {
        sounds.PlayMenuMusic();
        startScreen.gameObject.SetActive(true);
        gameScreen.gameObject.SetActive(false);
        countdown.gameObject.SetActive(false);
        resultScreen.gameObject.SetActive(false);
    }

    public void StartBeginningOfGame()
    {
        sounds.StopMusic();
        startScreen.gameObject.SetActive(false);
        countdown.gameObject.SetActive(true);
        StartCoroutine(Countdown(3));
    }

    public void StartGame()
    {
        sounds.PlayInGameMusic();
        gameScreen.gameObject.SetActive(true);
        gamePlaying.GoMoles();
        timer.StartTimer();
    }

    IEnumerator Countdown(int seconds)
    {
        int count = seconds;

        while (count > -1)
        {
            if (count == 0)
            {
                time.text = "Go!";
                sounds.PlayCountdown();
            }
            else
            {
                sounds.PlayCountdown();
                time.text = count + "";
            }
            yield return new WaitForSeconds(1);
            count--;
        }
        countdown.gameObject.SetActive(false);
        StartGame();
    }

    public void StartResults()
    {
        sounds.StopMusic();
        sounds.PlayResultMusic();
        gameScreen.gameObject.SetActive(false);
        resultScreen.gameObject.SetActive(true);
        ui.ShowEndScore();
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void NewState(GameStates newState)
    {
        if (null != currState)
            currState.OnStateExit();

        currState = newState;
        currState.OnStateEnter();
    }

    public void Reset()
    {
        sounds.StopMusic();
        sounds.PlayInGameMusic();
        timer.Reset();
        ui.Reset();
        gamePlaying.Reset();
        StartGame();
        resultScreen.gameObject.SetActive(false);
    }
}
