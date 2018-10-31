using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScrpt : MonoBehaviour {
    public GameObject SFXManager;
    public static SoundScrpt AudioManager;

    public List<string> SFXName = new List<string>();
    public List<AudioClip> SFXAudio = new List<AudioClip>();
    public Dictionary<string, AudioClip> SFX_Libairy = new Dictionary<string, AudioClip>();

    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < SFXName.Count; i++)
        {
            SFX_Libairy.Add(SFXName[i], SFXAudio[i]);
        }

        AudioManager = this;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            AudioManager.PlaySFX("ElectroWin");
            Debug.Log("PlaySound");
        }
    }

    public void PlaySFX(string Name)
    {
        if (SFX_Libairy.ContainsKey(Name))
        {
            GameObject SFX = Instantiate(SFXManager);
            AudioSource SRC = SFX.GetComponent<AudioSource>();
            SRC.clip = SFX_Libairy[Name];
            SRC.Play();

            Destroy(SFX, SRC.clip.length);
        }
    }


}
