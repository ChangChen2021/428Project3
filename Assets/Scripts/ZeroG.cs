using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeroG : MonoBehaviour
{
    public AudioSource audio;
    public GameObject table;
    public void SetZeroG()
    {
        Physics.gravity = new Vector3(0,0,0);
        table.SetActive(false);
        audio.Play();
    }

    public void SetRealG()
    {
        Physics.gravity = new Vector3(0,-10,0);
    }
}
