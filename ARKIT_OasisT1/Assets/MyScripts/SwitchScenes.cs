using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SwitchScenes : MonoBehaviour {

	Scene scene = SceneManager.GetActiveScene();


	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown() {

		if (SceneManager.GetActiveScene().name == "ckeMain1"){
         SceneManager.LoadScene("snapDemo2");
     	}

     	if (SceneManager.GetActiveScene().name == "snapDemo2"){
         SceneManager.LoadScene("ckeMain1");
     	}

	}
}
