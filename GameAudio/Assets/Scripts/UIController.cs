using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{

    //public GameObject panel, fadePanel;

    public AudioClip uiClick;

    public GameObject fadePanel;

    public string nextScene;

    public AudioSource source1;

    public bool isOn;

    void Start()
    {
       //cameraAnim = GetComponent<Animator>();
       //uiAnim = GetComponent<Animator>();
        //fadeAnim = GetComponent<Animator>();
    }
    public void Quit()
    {
        //SceneManager.LoadScene();
        Debug.Log("Quitting");
        Application.Quit();
    }

    public void ChangeScene(){
		Debug.Log("Changing to scene: " + nextScene);
        SceneManager.LoadScene(nextScene);
        //Invoke("DelayedAction", 3);
	}	

    public void Fade(){
		fadePanel.SetActive(true);
		//fadeAnim.SetTrigger("fade");

		Invoke("ChangeScene", 3);
		//StartCoroutine(ExecuteAfterTime());
		
		//fadeAnim.SetBool("homeFade", true);
	}

    public void ClickSounds(){
        Debug.Log("Button clicked");
        source1.PlayOneShot(uiClick, 1.0f);
    }



 
}
