using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Smash : MonoBehaviour
{
    private float Score = 0.0f;
    private int Multiplier = 1;
    private int Streak = 0;

    void Update()
    {
        //click
        if(Input.GetMouseButtonDown(0))
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
            }
            Debug.Log(Score);
            Debug.Log(Streak);
            Debug.Log(Multiplier);
        }

    }



}
