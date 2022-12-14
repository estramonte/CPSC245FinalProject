//Marissa Estramonte and Quillan Gee
//2405291, 2404244 
//estramonte@chapman.edu, qgee@chapman.edu 
//245-01
//Final Project: Whack-a-mole

//GamePlaying managed all the overall mole behavior and some game behavior.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlaying : MonoBehaviour
{
    public Mole[] moleList;
    public Timer timer;
    public GameManager game;
    public UI ui;
    private int RandomMoleNumber;
    private int temp = 10;
    private int totalMoles = 0;
    private float timeFromEachMolePop = 1f;
    private float timeWaitForResults = 1f;
    
    //Controls the moles coming up.
    private IEnumerator MolesUpTillTimeIsOut()
    {
        while(timer.timeOnGame>0){
            randomMoleComingUp();
            yield return new WaitForSeconds(timeFromEachMolePop);
        }
        StartCoroutine(WaitForResults());
    }
    
    //Pauses the game for a moment after the timer runs out so it doesn't feel rushed.
    private IEnumerator WaitForResults()
    {
        yield return new WaitForSeconds(timeWaitForResults);
        ui.ShowMoleNumber(totalMoles);
        game.StartResults();
    }
    
    //Randomly generates between the 9 moles
    private int RandomMoleNumberGenerator()
    {
        RandomMoleNumber = Random.Range(0,9);
        while (RandomMoleNumber == temp)
        {
            RandomMoleNumber = Random.Range(0, 9);
        }
        temp = RandomMoleNumber;
        totalMoles++;
        return RandomMoleNumber;
    }

   //if mole not hit and not currently generated
   //start coroutine for a random time for the mole to come up
    private void randomMoleComingUp()
    {
        StartCoroutine(moleList[RandomMoleNumberGenerator()].ShowHide(new Vector2(0f, -0.25f), new Vector2(0f,1f)));
    }

    //Starts the molesuptilltimeisout coroutine.
    public void GoMoles()
    {
        StartCoroutine(MolesUpTillTimeIsOut());
    }
    
    //Reset function
    public void Reset()
    {
        totalMoles = 0;
    }
}
