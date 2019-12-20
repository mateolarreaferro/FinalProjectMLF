using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayWelcome : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;

    public void Awake()
    {
        source = GetComponent<AudioSource>();
    }
    //Plays if collision is detected
    public void OnTriggerEnter(Collider other)
    {
        source.Play();
    }
}
