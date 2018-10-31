using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpkinBlopper : MonoBehaviour {

    public GameObject pumpkin;
    public bool isActive;

    public float upTimers;
    private float curTimer;
	// Use this for initialization
	void Start () {
        pumpkin = transform.GetChild(0).gameObject;
        pumpkin.SetActive(false);
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(isActive==true)
        {

            curTimer += Time.deltaTime;
            if(curTimer>upTimers)
            {
                curTimer = 0;
                deActivate();
            }
        }

        if(Random.Range(0,100)>20 && isActive==false)
        {
            activate();
        }
	}

    public void activate()
    {
        isActive = true;
        pumpkin.SetActive(true);
    }

    public void deActivate()
    {
        isActive = false;
        pumpkin.SetActive(false);
    }


}
