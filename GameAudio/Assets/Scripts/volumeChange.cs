//** help from https://johnleonardfrench.com/articles/10-unity-audio-tips-that-you-wont-find-in-the-tutorials/ **//

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class volumeChange : MonoBehaviour
{

    public AudioMixer mixer;

    //sets volume based on slider 
    public void musicVol(float musiclevel)
    {
        mixer.SetFloat("MusicVol", Mathf.Log10(musiclevel) *20);
    }

    public void masterVol(float masterlevel)
    {
        mixer.SetFloat("MusicVol2", Mathf.Log10(masterlevel) * 20);
    }

    public void SFXVol(float sfxlevel)
    {
        mixer.SetFloat("SFXVol", sfxlevel);
    }
}