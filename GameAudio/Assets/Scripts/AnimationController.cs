using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator cameraAnim;
    // Start is called before the first frame update
    void Start()
    {
       cameraAnim = GetComponent<Animator>();
    }

    public void CameraZoom(){
        cameraAnim.SetTrigger("CameraZoom");
    }
}
