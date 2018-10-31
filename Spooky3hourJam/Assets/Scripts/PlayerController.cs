using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public Animator BoneAnim;
	public GameObject Bone;

	private Vector3 Pos;

    public Smash SmashScrpt;


    private void Start()
    {
        SmashScrpt = GetComponent<Smash>();
    }
    void Update ()
	{

		RaycastHit Hit;														// Raycasthit setup

		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);            // ray to follow the mouse position on the scene

		Pos = Input.mousePosition;
		Pos.z = 3;

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
					Hit.collider.transform.parent.gameObject.GetComponent<PumpkinBlopper>().deActivate();
                    SoundScrpt.AudioManager.PlaySFX("Squish");
                    Debug.Log("Play Squish");
                    SmashScrpt.ScoreGoUp();
                }
                else
                {
                    SmashScrpt.NullMulti();
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
