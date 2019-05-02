using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadePanelOut : MonoBehaviour

{
	//public Animator fadeAnim;

	public GameObject fadeInPanel;

    //public string nextScene;


	// Use this for initialization
	void Start () {
		//fadeAnim = GetComponent<Animator>();
		//homeAnim = GetComponent<Animator>();
		fadeInPanel.SetActive(true);

		Invoke("PanelOff", 1);
	}

    

	public void PanelOff(){
		fadeInPanel.SetActive(false);
	}

	/*IEnumerator ExecuteAfterTime()
 	{
     yield return new WaitForSeconds(3);
 
     SceneManager.LoadScene(nextScene);
 	}*/	

	

}

