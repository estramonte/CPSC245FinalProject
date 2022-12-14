//Marissa Estramonte and Quillan Gee
//2405291, 2404244 
//estramonte@chapman.edu, qgee@chapman.edu 
//245-01
//Final Project: Whack-a-mole

//Mole takes care of the behavior of each individual Mole.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Mole : MonoBehaviour
{
    public UnityEvent sinkMole;
    public bool isMoleOut = false;

    private bool HasMoleBeenHit = false;
    
    private float showDuration = 0.5f;
    private float duration = 1f;

    public IEnumerator ShowHide(Vector2 start, Vector2 end) {
    transform.localPosition = start;

    // Show the mole.
    float elapsed = 0f;
    while (elapsed < showDuration) {
      transform.localPosition = Vector2.Lerp(start, end, elapsed / showDuration);
      isMoleOut = true;
      elapsed += Time.deltaTime;
      yield return null;
    }
    yield return new WaitForSeconds(duration);

    // Hide the mole.
    if(HasMoleBeenHit)
        {
            HasMoleBeenHit = false;
        }
    else
        {
            elapsed = 0f;
            while (elapsed < showDuration)
            {
                transform.localPosition = Vector2.Lerp(end, start, elapsed / showDuration);
                // Update at max framerate.
                elapsed += Time.deltaTime;
                yield return null;
            }
    }
    isMoleOut = false;
    transform.localPosition = start;
  }
    
    //Controls what happens when you whack-a-mole
    public void OnMouseDown()
    {
        if (isMoleOut)
        {
            sinkMole.Invoke();
            isMoleOut = false;
        }
    }
    
    //Controls the position of the mole once being hit and puts it back into the starting position immediately.
    public void Sink()
    {
        transform.localPosition = Vector2.Lerp(new Vector2(0f, -0.75f), new Vector2(0f, 1f), 0.25f);
        HasMoleBeenHit = true;
    }

}
