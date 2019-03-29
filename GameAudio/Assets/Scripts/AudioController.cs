using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioClip jumpSound;
    public AudioClip walkingSound;
    public AudioClip sandSound;
    public AudioClip waterSound;
    public AudioClip dirtSound;

    public AudioSource source1;
    public AudioSource source2;
    public AudioSource source3;
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
            //float vol = Random.Range(volLowRange, volHighRange);
            Debug.Log("collide sandGound");
            source1.PlayOneShot(sandSound, 1.0f);
        }
        else
        if (col.gameObject.name == "WaterGround")
        {
            source2 = GetComponent<AudioSource>();
            //float vol = Random.Range(volLowRange, volHighRange);
            source2.PlayOneShot(waterSound, 1.0f);
        }
        else
        if (col.gameObject.name == "DirtGround")
        {
            source3 = GetComponent<AudioSource>();
            // float vol = Random.Range(volLowRange, volHighRange);
            source3.PlayOneShot(dirtSound, 1.0f);
        };
    }

    void Update()
    {
        //jump audio
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    float vol = Random.Range(volLowRange, volHighRange);
        //    source.PlayOneShot(jumpSound, vol);
        //}

        //walking audio
        //if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
        //{
        //    float vol = Random.Range(volLowRange, volHighRange);
        //    source.PlayOneShot(walkingSound, vol);
        //}

    }
}
