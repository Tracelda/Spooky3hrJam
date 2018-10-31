using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class STOP : MonoBehaviour {

    public PumpkinBlopper boop;
	// Use this for initialization
	void Start () {

        boop = transform.parent.GetComponent<PumpkinBlopper>();
}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void deActivate()
    {
        boop.deActivate();
    }
}
