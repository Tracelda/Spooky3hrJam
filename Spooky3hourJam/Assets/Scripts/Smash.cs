using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Smash : MonoBehaviour
{
    public float Score = 0.0f;
    public int Multiplier = 1;
    public int Streak = 0;

    void Update()
    {
        //click
        if(Input.GetMouseButtonDown(0))
        {
            
           
        }

    }

  public void ScoreGoUp()
    {
        //increment score times multipler
        Score += 1 * Multiplier;
        //increment Streak
        Streak++;
        //5 in a row
        if (Streak == 5)
        {
            //increment multiplier
            Multiplier++;
            Debug.Log("Multiplier Activated");
            Streak = 0;
        }
        Debug.Log(Score);
        Debug.Log(Streak);
        Debug.Log(Multiplier);

    }

    public void NullMulti()
    {
        Multiplier = 1;
    }



}
