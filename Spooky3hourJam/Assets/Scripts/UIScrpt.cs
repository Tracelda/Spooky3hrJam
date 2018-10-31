using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScrpt : MonoBehaviour {
    bool StartCounting;
    public float TimerTarget;
    public float TimerValue;
    public Slider Slider;
    public float score;
    public float multiplier;
    public GameObject Score;
    public GameObject Multiplier;
    public Text ScoreText;
    public Text MultiplierText;
 
    void Start ()
    {
        StartCounting = true;
        Score = GameObject.Find("Score");
        Multiplier = GameObject.Find("Multiplier");

        ScoreText = Score.GetComponent<Text>();
        MultiplierText = Multiplier.GetComponent<Text>();
        score = 0;
        multiplier = 0;
    }
	
	void Update ()
    {
        score++;
        multiplier++;

        if (StartCounting == true && TimerValue < TimerTarget)
        {
            TimerValue += Time.deltaTime;
            Slider.value = TimerValue;

            if (TimerValue == TimerTarget) // not registering as soon as timer is finished
            {
                StartCounting = false;
                Debug.Log("TimeUp");
            }
        }

        ScoreText.text = "Score: " + score;
        MultiplierText.text = "Multiplier: " + multiplier;
    }
}
