using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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

    public Smash smash;
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

        if (StartCounting == true && TimerValue < TimerTarget)
        {
            TimerValue += Time.deltaTime;
            Slider.value = TimerValue;

            if (TimerValue == TimerTarget) // not registering as soon as timer is finished
            {
                StartCounting = false;
                SceneManager.LoadScene(0);
                Debug.Log("TimeUp");
            }
        }
        if(TimerValue>TimerTarget)
        {
            SceneManager.LoadScene(0);
        }

        ScoreText.text = "Score: " + smash.Score;
        MultiplierText.text = "Multiplier: " +smash.Multiplier;
    }
}
