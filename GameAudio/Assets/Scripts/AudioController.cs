//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class AudioController : MonoBehaviour
//{
//    public AudioClip jumpSound;
//    public AudioClip walkingSound;
//    public AudioClip walkingSound2;
//    public AudioClip walkingSound3;
//    public AudioClip level1Background;
//    public AudioClip level2Background;
//    public AudioClip level3Background;
//    public AudioClip collectableSound;
//    public AudioClip windSound;
//    public AudioClip barrelSound;
//    public AudioClip podSound;
//    public AudioClip breathingSound;

//    public AudioSource player;
//    public AudioSource player2;
//    public AudioSource player3;
//    public AudioSource source1;
//    public AudioSource source2;
//    public AudioSource source3;
//    public AudioSource colletableAudio;
//    public AudioSource barrelAudio;
//    public AudioSource podAudio;
//    public AudioSource windAudio;
//    private float volLowRange = .5f;
//    private float volHighRange = 1.0f;

//    private bool scene1;
//    private bool scene2;
//    private bool scene3;

//    private void Awake()
//    {
//        source1 = GetComponent<AudioSource>();


//        ////breathing
//        //float vol = Random.Range(volLowRange, volHighRange);
//        //player2.PlayOneShot(breathingSound, vol);
//        //player2.Play();
//        //// yield return new WaitForSeconds(audio.clip.length);
//        //player2.clip = breathingSound;
//        //player2.Play();
//    }

//    //audio for diff terrains
//    void OnCollisionEnter(Collision col)
//    {
//        //AudioSource playerAudio = GetComponent<AudioSource>();
//        ////breath quieter when static
//        //player = GetComponent<AudioSource>();
//        //playerAudio.PlayOneShot(breathingSound, 0.3f);
//        //playerAudio.Play();
//        //playerAudio.clip = breathingSound;
//        //playerAudio.Play();

//        if (col.gameObject.name == "SandGround")
//        {
//            //source1 = GetComponent<AudioSource>();
//            //float vol = Random.Range(volLowRange, volHighRange);
//            Debug.Log("collide sandGound");
//            source1.PlayOneShot(level1Background, 1.0f);
//            //scene1 = true;
//            //scene2 = false;
//            //scene3 = false;
//        }
//                else
//                if (col.gameObject.name == "WaterGround")
//                {
//                    //source1.mute = true;
//                    source2 = GetComponent<AudioSource>();
//                    //float vol = Random.Range(volLowRange, volHighRange);
//                    source2.PlayOneShot(level2Background, 1.0f);
//                    //scene1 = false;
//                    //scene2 = true;
//                    //scene3 = false;
//                }
//                else
//                    if (col.gameObject.name == "DirtGround")
//                    {
//                        //source2.mute = true;
//                        //play quieter
//                        //source3.PlayOneShot(level3Background, 1.0f);
//                        //source3.PlayOneShot(windSound, 1.0f);
//                        //barrelAudio.PlayOneShot(barrelSound, 1.0f);
//                        //podAudio.PlayOneShot(podSound, 1.0f);
//                        //scene1 = false;
//                        //scene2 = false;
//                        //scene3 = true;
//                    };
//                        //if (col.gameObject.name == "Collectable" || col.gameObject.name == "Collectable2" || col.gameObject.name == "Collectable3" || col.gameObject.name == "Collectable4")
//                        //{
//                        // colletableAudio = GetComponent<AudioSource>();
//                        // colletableAudio.PlayOneShot(collectableSound, 1.0f);
//                        //}
//    }

//    void Update()
//    {
//        //AudioSource playerAudio = GetComponent<AudioSource>();
//        //if (scene1 == true)
//        //{
//        //    source1.PlayOneShot(level1Background, 1.0f);
//        //}
//        //if (scene2 == true)
//        //{
//        //    //source1.mute = true;
//        //    Debug.Log("scene2 = true");
//        //    source2 = GetComponent<AudioSource>();
//        //    source2.PlayOneShot(level2Background, 1.0f);
//        //    //source2.clip = level2Background;
//        //    //source2.Play();
//        //}
//        //if (scene3 == true)
//        //{
//        //    source2.mute = true;
//        //    //play quieter
//        //    source3.PlayOneShot(level3Background, 0.5f);
//        //    source3.PlayOneShot(windSound, 0.5f);
//        //    barrelAudio.PlayOneShot(barrelSound, 1.0f);
//        //    podAudio.PlayOneShot(podSound, 1.0f);
//        //}
//        //jump audio
//        //if (Input.GetKeyDown(KeyCode.Space))
//        //{
//        //    //player = GetComponent<AudioSource>();
//        //    float vol = Random.Range(volLowRange, volHighRange);
//        //    player.PlayOneShot(jumpSound, vol);
//        //    player.Play();
//        //    // yield return new WaitForSeconds(audio.clip.length);
//        //    player.clip = jumpSound;
//        //    player.Play();
//        //}

//            //if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
//            //{
//            ////player2 = GetComponent<AudioSource>();
//            ////player3 = GetComponent<AudioSource>();
//            //////stop quiter breathing
//            ////player2.mute = true;
//            ////player2.PlayOneShot(breathingSound, 1);
//            //////breath loader when walking
//            ////player = GetComponent<AudioSource>();
//            ////player2.mute = true;
//            ////player2.PlayOneShot(breathingSound, 1);
//            ////playerAudio.mute = false;
//            //////playerAudio.clip = breathingSound;
//            ////playerAudio.Play();
//            //////playerAudio.mute = false;
//            //////float vol = Random.Range(volLowRange, volHighRange);
//            //////source.PlayOneShot(walkingSound, vol);
//            //if (scene1 == true)
//            //    {
//            //        float vol = Random.Range(volLowRange, volHighRange);
//            //        // playerAudio.PlayOneShot(walkingSound, vol);
//            //        //player.Play();
//            //        // yield return new WaitForSeconds(audio.clip.length);
//            //        player.clip = walkingSound;
//            //        player.Play();
//            //    }
//            //    else if (scene2 == true)
//            //    {
//            //        float vol = Random.Range(volLowRange, volHighRange);
//            //        player2.PlayOneShot(walkingSound2, vol);
//            //        player2.Play();
//            //        // yield return new WaitForSeconds(audio.clip.length);
//            //        player2.clip = walkingSound2;
//            //        player2.Play();
//            //    }
//            //    else if (scene3 == true)
//            //    {
//            //        float vol = Random.Range(volLowRange, volHighRange);
//            //        player3.PlayOneShot(walkingSound2, vol);
//            //        player3.Play();
//            //        // yield return new WaitForSeconds(audio.clip.length);
//            //        player3.clip = walkingSound2;
//            //        player3.Play();
//            //    }
//            //}
//        //            if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
//        //{
//        //    //quiter breathing when not moving
//        //    player3.mute = true;
//        //    player2.mute = false;
//        //}


//    }
//}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioClip jumpSound;
    public AudioClip sandSound;
    public AudioClip waterSound;
    public AudioClip dirtSound;
    public AudioClip collectableSound;

    public AudioSource player;
    public AudioSource source1;
    public AudioSource source2;
    public AudioSource source3;
    private float volLowRange = .5f;
    private float volHighRange = 1.0f;

    public AudioSource player2;
    public AudioSource player3;
    public AudioSource colletableAudio;
    public AudioSource barrelAudio;
    public AudioSource podAudio;
    public AudioSource windAudio;

    private bool scene1;
    private bool scene2;
    private bool scene3;
    private bool walking;


    void Awake()
    {
        source1 = GetComponent<AudioSource>();
    }

    //audio for diff terrains
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "SandGround")
        {
            source1.clip = sandSound;
            source1.Play();
            //float vol = Random.Range(volLowRange, volHighRange);
            Debug.Log("collide sandGound");
            //source1.PlayOneShot(sandSound, 1.0f);
        }
        else
        if (col.gameObject.name == "WaterGround")
        {
            scene2 = true;
            source2 = GetComponent<AudioSource>();
            //float vol = Random.Range(volLowRange, volHighRange);
            //source2.PlayOneShot(waterSound, 1.0f);
            source2.clip = waterSound;
            source2.Play();
        }
        else
        if (col.gameObject.name == "DirtGround")
        {
            scene3 = true;
            source3 = GetComponent<AudioSource>();
            // float vol = Random.Range(volLowRange, volHighRange);
            //source3.PlayOneShot(dirtSound, 1.0f);
            source3.clip = dirtSound;
            source3.Play();
        };
    }


    void Update()
    {
        //jump audio
        if (Input.GetKeyDown(KeyCode.Space))
        {
            float vol = Random.Range(volLowRange, volHighRange);
            player.PlayOneShot(jumpSound, vol);
        }

        //if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
        //{
        //    //{
        //    ////player2 = GetComponent<AudioSource>();
        //    ////player3 = GetComponent<AudioSource>();
        //    //////stop quiter breathing
        //    ////player2.mute = true;
        //    ////player2.PlayOneShot(breathingSound, 1);
        //    //////breath loader when walking
        //    ////player = GetComponent<AudioSource>();
        //    ////player2.mute = true;
        //    ////player2.PlayOneShot(breathingSound, 1);
        //    ////playerAudio.mute = false;
        //    //////playerAudio.clip = breathingSound;
        //    ////playerAudio.Play();
        //    //////playerAudio.mute = false;
        //    //////float vol = Random.Range(volLowRange, volHighRange);
        //    //////source.PlayOneShot(walkingSound, vol);

        //    //float vol = Random.Range(volLowRange, volHighRange);
        //    //player.clip = walkingSound;
        //    //player.Play();

        //    //if (Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0)
        //    //{
        //    //    player.clip = walkingSound;
        //    //    player.Play();
        //    //}

        //    //    else
        //    //    {
        //    //        player.clip = walkingSound;
        //    //        player.Pause();
        //    //    }

        //if (scene2 == true && Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
        //{
        //    //float vol = Random.Range(volLowRange, volHighRange);
        //    player2.clip = jumpSound;
        //    player2.Play();
        //}
        //    else if (scene3 == true)
        //    {
        //        //float vol = Random.Range(volLowRange, volHighRange);
        //        player3.clip = walkingSound3;
        //        player3.Play();
        //    }
        //}

        ////walking audio
        //    if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
        //{
        //    float vol = Random.Range(volLowRange, volHighRange);
        //    source.PlayOneShot(walkingSound, vol);
        //}

    }
}
