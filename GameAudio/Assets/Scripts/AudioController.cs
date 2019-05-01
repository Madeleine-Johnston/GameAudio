using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioClip jumpSound;
    public AudioClip sandSound;
    public AudioClip waterSound;
    public AudioClip dirtSound;
    public AudioClip barrelSound;
    public AudioClip podSound;

    public AudioSource source0;
    public AudioSource source1;
    public AudioSource source2;
    public AudioSource source3;
    public AudioSource barrelAudio;
    public AudioSource podAudio;

    private float volLowRange = .5f;
    private float volHighRange = 1.0f;


    void Awake()
    {
        source1 = GetComponent<AudioSource>();
    }

    //audio for diff terrains
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "SandGround")
        {
            //Debug.Log("collide sandGound");
            source1.PlayOneShot(sandSound, 0.5f);
        }
        else
        if (col.gameObject.name == "WaterGround")
        {
            source1.Pause();
            source2 = GetComponent<AudioSource>();
            source2.clip = waterSound;
            source2.Play();
        }
        else
        if (col.gameObject.name == "DirtGround")
        {
            source2.Pause();
            source3 = GetComponent<AudioSource>();
            source3.clip = dirtSound;
            source3.Play();
            barrelAudio.clip = barrelSound;
            barrelAudio.Play();
            podAudio.clip = podSound;
            podAudio.Play();
        };

            
    }

    void Update()
    {
        //jump audio
        if (Input.GetKeyDown(KeyCode.Space))
        {
            float vol = Random.Range(volLowRange, volHighRange);
            source0.PlayOneShot(jumpSound, vol);
        }

    }
}
