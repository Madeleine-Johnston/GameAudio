using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VolumeController : MonoBehaviour
{

    public AudioMixer mixer;

    public void musicVol(float musiclevel)
    {
        mixer.SetFloat("MusicVol", musiclevel);
    }

    public void masterVol(float masterlevel)
    {
        mixer.SetFloat("MusicVol2", masterlevel);
    }

    public void SFXVol(float sfxlevel)
    {
        mixer.SetFloat("MusicVol2", sfxlevel);
    }
}
