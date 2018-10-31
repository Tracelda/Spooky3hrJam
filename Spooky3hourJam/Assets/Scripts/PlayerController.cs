using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public Animator BoneAnim;
	public GameObject Bone;

	private Vector3 Pos;



	void Update ()
	{

		RaycastHit Hit;														// Raycasthit setup

		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);            // ray to follow the mouse position on the scene

		Pos = Input.mousePosition;
		Pos.z = 5;

		Bone.transform.position = Camera.main.ScreenToWorldPoint(Pos);


		if (Input.GetMouseButton(0))
		{
			BoneAnim.SetBool("Play", true);
			StartCoroutine(Wait());

			if (Physics.Raycast(ray, out Hit))
			{
				if(Hit.collider.gameObject.name == "Pumpkin")
				{
					//add score 'n' stuff
					Hit.collider.gameObject.GetComponent<PumpkinBlopper>().deActivate();
				}
			}
		}
	}

	private IEnumerator Wait()
	{
		yield return new WaitForSeconds(.6f);
		BoneAnim.SetBool("Play", false);
		StopAllCoroutines();
	}
}
