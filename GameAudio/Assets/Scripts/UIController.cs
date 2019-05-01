using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{

    //public string nextScene;
    //public Animator uiAnim;
    public GameObject panel;

    public bool isOn;

    void Start()
    {
       //cameraAnim = GetComponent<Animator>();
       //uiAnim = GetComponent<Animator>();

    }
    public void Quit()
    {
        //SceneManager.LoadScene();
        Debug.Log("Quitting");
        Application.Quit();
    }

    public void ChangeScene(string nextScene){
		Debug.Log("Changing to scene: " + nextScene);
        SceneManager.LoadScene(nextScene);
        //Invoke("DelayedAction", 3);
	}	

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.P)){
            Pause();
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

    /*public void HandleLayers(){
        uiAnim.SetLayerWeight(1,1);
    }*/
}
