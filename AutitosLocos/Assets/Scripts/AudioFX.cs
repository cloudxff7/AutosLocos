using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioFX : MonoBehaviour
{
    public AudioClip[] fxs;
    AudioSource audioS;

    private void Start()
    {
        audioS = GetComponent<AudioSource>();
    }
    //o choque
    public void FXSonidoCHoque()
    {
        audioS.clip = fxs[0];
        audioS.Play();
    }
    //1 music game
    public void FXMusic()
    {
        audioS.clip = fxs[1];
        audioS.Play();
    }
}

