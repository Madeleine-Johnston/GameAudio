using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{

    public GameObject panel;

    //public AudioClip uiClick;
    //public AudioSource source1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.P)){
            Pause();
            //source1.PlayOneShot(uiClick, 1.0f);
            panel.SetActive(!panel.activeInHierarchy);
            
            //uiAnim.Play("PlayHover");
        }
    }

    //credit to Vincent Quarles for pause piece of code
    //https://www.sitepoint.com/adding-pause-main-menu-and-game-over-screens-in-unity/
    public void Pause(){
        if(Time.timeScale == 1)
		{
			Time.timeScale = 0;
		} else if (Time.timeScale == 0){
			Time.timeScale = 1;	
		}
    }

}
