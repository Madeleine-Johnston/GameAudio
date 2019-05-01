
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//new
public class PlayerController : MonoBehaviour
{


    public AudioClip collectableSound;
    public AudioClip sandSound;
    public AudioClip jumpSound;
    public AudioClip waterWalking;
    //colleactable
    public AudioSource source;
    //walking
    public AudioSource source2;

    public bool walking;
    public bool sandGround;
    public bool waterGround;
    public bool dirtGround;
    public string floortag;
    public float health;
    public int appleCollection;
    public int waterCollection;

    public Text appleCollectionText;
    public Text waterCollectionText;


    public Slider healthSlider;

    public AudioClip[] footsteps;
    public AudioClip[] waterSteps;

    void Start()
    {
        health = 10;
        appleCollection = 0;
        waterCollection = 0;
    }

    void FixedUpdate()
    {

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("walking");
            walking = true;
            walkingAudio();
        }

        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
        {
            Debug.Log("stop walking");
            walking = false;
        }

        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Collectable" || col.gameObject.name == "Collectable1" || col.gameObject.name == "Collectable2" || col.gameObject.name == "Collectable3")
        {
            Destroy(col.gameObject);
            source.PlayOneShot(collectableSound, 1.0f);
            health = health + 10.0f;
            appleCollection++;
            SetCountText();
        }
        ////water collectables
        //if (col.gameObject.name == "Collectable" || col.gameObject.name == "Collectable1" || col.gameObject.name == "Collectable2" || col.gameObject.name == "Collectable3")
        //{
        //    Destroy(col.gameObject);
        //    source.PlayOneShot(collectableSound, 1.0f);
        //    waterCollection++;
        //    SetCountText();
        //}
        if (col.gameObject.name == "SandGround")
        {
            sandGround = true;
        }
        else
        if (col.gameObject.name == "WaterGround")
        {
            sandGround = false;
            waterGround = true;
        }
        else
        if (col.gameObject.name == "DirtGround")
        {
            waterGround = false;
            dirtGround = true;
        };
    }

    public void SetCountText()
    {
        appleCollectionText.text = " " + appleCollection.ToString();
        waterCollectionText.text = " " + waterCollection.ToString();
    }

    public void walkingAudio()
    {
        if (walking == true)
        {
            //chooses a random component of the array to play
            //Debug.Log("playing walking sound");
            AudioClip nextclip = footsteps[Random.Range(0, footsteps.Length)];
            source2.clip = nextclip;
            source2.Play();
        }
        
        //**waterwalking sounding bad**//
        //else if (walking == true && waterGround == true)
        //{
        //    source2.Pause();
        //    float vol = Random.Range(0.5f, 1.0f);
        //    source2.PlayOneShot(waterWalking, vol);
        //    //source2.clip = waterWalking;
        //    //source2.Play();
        //}

        else
        {
            //stop walking sound
            source2.Pause();
        }
    }


        void LateUpdate()
    {

        //asign health value to slider
        healthSlider.value = health;
    }

}