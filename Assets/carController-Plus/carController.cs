using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carController : MonoBehaviour {

	Animator anim;
    AudioSource audio;
 	public static carController instance;

	//Create a cloned object so we can access the functions
	void Awake(){
		if (instance == null) {
			instance = this;
		}
	}

	// Use this for initialization
	void Start () {
 
		//Loop through the child items activating the correct item by name
		for (int i = 0; i < transform.childCount; ++i) {
			
			//Check the current selected item and activate
 			if (transform.GetChild (i).gameObject.name == gameContoller.currentSelectedCar) {
                //Get the animator componant from the active item
                anim = transform.GetChild(i).gameObject.GetComponent<Animator>();
               // anim.StopPlayback();
                transform.GetChild (i).gameObject.SetActive (true);
                anim.enabled = false;

				
			} else {
				//Deactivate all other cars
				transform.GetChild (i).gameObject.SetActive (false);
			}
 		}

		 
	}

	//Called from _Handle
 	public void triggerAnimation(string action){

        anim = GameObject.Find("/UserDefinedTarget-1/activeitems/" + gameContoller.currentSelectedCar).GetComponent<Animator>(); 
        anim.enabled = true;
        anim.SetTrigger (action);
	}

    public void playAudio()
    {
        Debug.Log("audio is about to be played!");
        audio = GameObject.Find("/UserDefinedTarget-1/activeitems/" + gameContoller.currentSelectedCar).GetComponent<AudioSource>();
        audio.Play();
        Debug.Log("audio played!");
    }

    public void stopAudio()
    {
        audio = GameObject.Find("/UserDefinedTarget-1/activeitems/" + gameContoller.currentSelectedCar).GetComponent<AudioSource>();
        audio.Stop();
    }

    //Called from _Handle
    public void showMessage(){
		//TODO
	}

}
