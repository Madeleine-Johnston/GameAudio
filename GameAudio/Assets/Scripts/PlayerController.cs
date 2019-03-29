
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

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Manzana_2")
        {
            Destroy(col.gameObject);
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