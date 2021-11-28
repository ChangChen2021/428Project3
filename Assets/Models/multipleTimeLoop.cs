using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class multipleTimeLoop : MonoBehaviour
{
	AudioSource myAudio;
    int currentRepeat = 0;
    int repeatAmount = 4;
    void Start ()
    {
        myAudio = GetComponent<AudioSource>();
        Invoke("playAudio", 2.0f);
    }
    void playAudio(){
        myAudio.Play();
    }
    void Update ()
    {
        if (!myAudio.isPlaying) 
        {
            if (currentRepeat < repeatAmount)
            {
                myAudio.Play();
                currentRepeat++;
            }
        }
    }
}