using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{	
	
	void Update ()
	{

		RaycastHit Hit;														// Raycasthit setup

		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);			// ray to follow the mouse position on the scene


		if (Input.GetMouseButton(0))
		{
			if (Physics.Raycast(ray, out Hit))
			{
				Debug.Log("test2");
			}
		}
	}
}
