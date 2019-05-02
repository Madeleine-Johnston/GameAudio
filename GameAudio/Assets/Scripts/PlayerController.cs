
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody rb;

    private float xForce;
    private float zForce;
    private Vector3 force;

    private float pitch = 0.0F;
    private float yaw = 0.0F;

    public AudioClip collectableSound;
    public AudioClip sandSound;
    public AudioSource source;
    public AudioSource source2;

    public bool walking;
    private string floortag;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        //takes information about positions from the current scene
        //to be used in movement calculations
        xForce = Input.GetAxis("Horizontal");
        zForce = Input.GetAxis("Vertical");

        pitch -= Input.GetAxis("Mouse Y");
        yaw += Input.GetAxis("Mouse X");

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("walking");
            walking = true;
        }
        else walking = false;

        //stops the player from rolling on a slope when no longer pressing the keys
        if (Input.GetKeyUp(KeyCode.W))
        {
            rb.Sleep();
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            rb.Sleep();
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            rb.Sleep();
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            rb.Sleep();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, 2, 0), ForceMode.Impulse);
        }

        walkingAudio();

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Collectable" || col.gameObject.name == "Collectable1" || col.gameObject.name == "Collectable2" || col.gameObject.name == "Collectable3")
        {
            Destroy(col.gameObject);
            source.PlayOneShot(collectableSound, 1.0f);
        }
    }


    public void walkingAudio()
    {
        if (walking == true)
        {
            RaycastHit hit;

            if (Physics.Raycast(transform.position, Vector3.down, out hit))
            {
                floortag = hit.collider.gameObject.tag;
                if (floortag == "SandGround")
                {
                    Debug.Log("playnig footsteps");
                    source2.clip = sandSound;
                    source2.Play();
                }
                //else if (floortag == "Water")
                //{
                //    //play Water sound code
                //}
            }
        }
    }

    void LateUpdate()
    {
        //applies force
        force = new Vector3((xForce * 2), 0.0F, (zForce * 2));

        // rotate object to face mouse direction
        rb.transform.localEulerAngles = new Vector3(0.0f, yaw, 0.0F);

        // move object in facing direction relative to local (AddRelative) not world (AddForce) coordinates
        rb.AddRelativeForce(force);

    }



}

